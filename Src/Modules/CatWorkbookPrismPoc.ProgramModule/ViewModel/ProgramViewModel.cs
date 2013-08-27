using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Security.AccessControl;
using System.ServiceModel.Channels;
using System.Threading.Tasks;
using CatWorkbookPrismPoc.Business.CatWorkbookPrisimPoc.Business;
using CatWorkbookPrismPoc.Infrastructure;
using CatWorkbookPrismPoc.Infrastructure.Commands;
using CatWorkbookPrismPoc.Infrastructure.Repositories;
using CatWorkbookPrismPoc.Infrastructure.Service;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Windows.Controls;

namespace CatWorkbookPrismPoc.ProgramModule.ViewModel
{
    public class ProgramViewModel : ViewModelBase, IProgramViewModel
    {
        #region Variables

        private IProgramRepository _programRepository;
        private IProgramService _programService;

        #endregion

        #region Constructors

        /// <summary>
        /// Creates an instance of the ProgramViewModel
        /// </summary>
        /// <param name="programRepository"></param>
        public ProgramViewModel(IProgramRepository programRepository, IProgramService programService)
        {
            _programRepository = programRepository;
            _programService = programService;

            SelectProgramCommand = new DelegateCommand(SelectProgram, CanSelectProgram);
            ApplicationCommands.OpenProgram.RegisterCommand(SelectProgramCommand);

            //LoadProgramCommand = new DelegateCommand(LoadProgram, CanLoadProgram);
            LoadEffectiveYears();
            LoadUnderwriters();
        }


       
        #endregion

        #region Events

        #endregion

        #region Commands

        public DelegateCommand SelectProgramCommand { get; set; }
        public DelegateCommand LoadProgramCommand { get; set; }

        private bool CanSelectProgram()
        {
            return true;//(Underwriters != null && Underwriters.Count > 0) && (EffectiveYears != null && EffectiveYears.Count > 0);
        }

        private void SelectProgram()
        {
            WindowState = WindowState.Open;
        }


        private bool CanLoadProgram()
        {
            return SelectedYear > 0;
        }



        #endregion

        #region Properties
        private Program _program;

        /// <summary>
        /// Retruns an instance of the Program.
        /// </summary>
        public Program Program
        {
            get
            {
                return _program;
            }
            set
            {
                _program = value;
                RaisePropertyChanged("Program");
            }
        }

        private bool _isBusy;
        
        /// <summary>
        /// Returns a boolean indicating the IsBusy 
        /// </summary>
        public bool IsBusy
        {
            get
            {
                return _isBusy;
            }
            set
            {
                _isBusy = value;
                RaisePropertyChanged("IsBusy");
            }
        }

        private WindowState _windowState;

        public WindowState WindowState
        {
            get
            {
                return _windowState;
            }
            set
            {
                _windowState = value;
                RaisePropertyChanged("WindowState");
            }
        }

        private Dictionary<int, string> _underwriters; 
        public Dictionary<int, string> Underwriters
        {
            get
            {
                return _underwriters;
            }
            set
            {
                _underwriters = value;
                RaisePropertyChanged("Underwriters");
            }
        }

        private IList<int> _effectiveYears;

        public IList<int> EffectiveYears
        {
            get
            {
                return _effectiveYears;
            }
            set
            {
                _effectiveYears = value;
                RaisePropertyChanged("EffectiveYears");
            }
        }


        private int? _selectedYear;

        public int? SelectedYear
        {
            get
            {
                return _selectedYear;
            }
            set
            {
                _selectedYear = value;
                MessageBox.Show("Selected Year Changed");
                RaisePropertyChanged("SelectedYear");
                LoadProgramList();
            }
        }


        private KeyValuePair<int, string> _selectedUnderwriter;

        public KeyValuePair<int, string> SelectedUnderwriter
        {
            get
            {
                return _selectedUnderwriter;
            }
            set
            {
                _selectedUnderwriter = value;
                RaisePropertyChanged("SelectedUnderwriter");

                LoadProgramList();
            }
        }

        private Program _selectdProgram;

        public Program SelectedProgram
        {
            get
            {
                return _selectdProgram;
            }
            set
            {
                _selectdProgram = value;
                RaisePropertyChanged("SelectedProgram");
                MessageBox.Show("Selected Program: " + _selectdProgram.ProgramName);
            }
        }

        private IList<Program> _programs;

        public IList<Program> Programs
        {
            get
            {
                return _programs;
            }
            set
            {
                _programs = value;
                RaisePropertyChanged("Programs");
            }
        }
        #endregion

        #region Methods

        private void LoadProgramList()
        {
            if (SelectedUnderwriter.Key > 0 && SelectedYear != null)
            {
                LoadProgramList(SelectedUnderwriter.Key, SelectedYear.Value);
            }
        }

        private async void LoadProgramList(int undewriterId, int effectiveYear)
        {
            IsBusy = true;
            var programsTask = Task.Factory.StartNew(() => _programService.GetPrograms(undewriterId, effectiveYear));
            var programs = await programsTask;
            await programs.ContinueWith(e =>
            {
                if (e.IsCompleted)
                {
                    IsBusy = false;
                    Programs = e.Result;
                }
            });
        }

        private async void LoadProgram(int programId)
        {
            IsBusy = true;
            
            _programService.GetProgramByIdAsync(programId, (sender, result) =>
            {
                Program = (Program) result.Object;
                IsBusy = false;
            });
        }

        /// <summary>
        /// Loads a list of underwriters asynchronously.
        /// </summary>
        private async void LoadUnderwriters()
        {
            var uwTask = Task.Factory.StartNew(() => _programService.GetUnderwritersAsync());
            var uwDictionary = await uwTask;
            await uwDictionary.ContinueWith(e =>
            {   
                if (e.IsCompleted)
                {
                    Underwriters = e.Result;
                }
            });
        }

        private async void LoadEffectiveYears()
        {
            var yearsTask = Task.Factory.StartNew(() => _programService.GetEffectiveYearsAsync());
            var years = await yearsTask;
            await years.ContinueWith(e =>
            {
                if (e.IsCompleted)
                {
                    EffectiveYears = e.Result;
                }
            });

        }

        private async void LoadPrograms()
        {
            
        }
        #endregion

    }
}

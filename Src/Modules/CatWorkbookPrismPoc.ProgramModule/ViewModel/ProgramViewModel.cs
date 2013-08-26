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

            LoadProgramCommand = new DelegateCommand(SelectProgram, CanSelectProgram);
            ApplicationCommands.OpenProgram.RegisterCommand(LoadProgramCommand);


            LoadProgram();
        }
       
        #endregion

        #region Commands

        public DelegateCommand LoadProgramCommand { get; set; }

        private bool CanSelectProgram()
        {
            return true;
        }

        private void SelectProgram()
        {
            WindowState = WindowState.Open;
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

        #endregion

        #region Methods

        private void LoadProgram()
        {
            IsBusy = true;
            int programId = 44559;
            _programService.GetProgramByIdAsync(programId, (sender, result) =>
            {
                Program = (Program) result.Object;
                IsBusy = false;
            });
        }


        #endregion

    }
}

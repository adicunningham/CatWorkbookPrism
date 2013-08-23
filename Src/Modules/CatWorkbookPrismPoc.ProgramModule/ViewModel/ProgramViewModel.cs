using CatWorkbookPrismPoc.Infrastructure;
using CatWorkbookPrismPoc.ProgramModule.Views.ViewModel;

namespace CatWorkbookPrismPoc.ProgramModule.ViewModel
{
    public class ProgramViewModel : ViewModelBase, IProgramViewModel
    {
        public ProgramViewModel()
        {
            ProgramName = "Adrian's Program";
        }

        private string _programName;
        public string ProgramName
        {
            get
            {
                return _programName;
            }
            set
            {
                _programName = value;
                RaisePropertyChanged("ProgramName");
            }
        }
    }
}

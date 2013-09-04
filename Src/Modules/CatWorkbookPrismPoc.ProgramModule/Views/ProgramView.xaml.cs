using CatWorkbookPrismPoc.Infrastructure;
using CatWorkbookPrismPoc.ProgramModule.ViewModel;

namespace CatWorkbookPrismPoc.ProgramModule.Views
{
    /// <summary>
    /// Interaction logic for ProgramView.xaml
    /// </summary>
    public partial class ProgramView : IProgramView
    {
        public ProgramView(IProgramViewModel progamViewModel)
        {
            InitializeComponent();

            ViewModel = progamViewModel;

            
        }

        public IViewModel ViewModel
        {
            get
            {
                return (IViewModel) DataContext;
            }
            set
            {
                DataContext = value;
            }
        }
    }
}

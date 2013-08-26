using System.Windows.Controls;
using CatWorkbookPrismPoc.Infrastructure;
using CatWorkbookPrismPoc.ToolbarModule.ViewModels;

namespace CatWorkbookPrismPoc.ToolbarModule.Views
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class ToolbarView : UserControl, IToolbarView
    {
        public ToolbarView(IToolbarViewModel viewModel)
        {
            InitializeComponent();

            ViewModel = viewModel;
        }

        public Infrastructure.IViewModel ViewModel
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

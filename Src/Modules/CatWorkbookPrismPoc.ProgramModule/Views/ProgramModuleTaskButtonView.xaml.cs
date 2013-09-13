using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CatWorkbookPrismPoc.Infrastructure;
using CatWorkbookPrismPoc.ProgramModule.ViewModel;

namespace CatWorkbookPrismPoc.ProgramModule.Views
{
    /// <summary>
    /// Interaction logic for ProgramModuleTaskButton.xaml
    /// </summary>
    public partial class ProgramModuleTaskButtonView : UserControl, IProgramModuleTaskButtonView
    {
        public ProgramModuleTaskButtonView(IProgramModuleTaskButtonViewModel viewModel)
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

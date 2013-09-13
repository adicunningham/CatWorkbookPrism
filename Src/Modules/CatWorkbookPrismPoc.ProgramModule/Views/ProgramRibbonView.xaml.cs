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
using Microsoft.Practices.Prism.Regions;
using Microsoft.Windows.Controls.Ribbon;

namespace CatWorkbookPrismPoc.ProgramModule.Views
{
    /// <summary>
    /// Interaction logic for ProgramRibbonView.xaml
    /// </summary>
    public partial class ProgramRibbonView : RibbonTab, IProgramRibbonView, IRegionMemberLifetime
    {
        public ProgramRibbonView(IProgramViewModel viewModel)
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

        public bool KeepAlive
        {
            get { return false; }
        }
    }
}

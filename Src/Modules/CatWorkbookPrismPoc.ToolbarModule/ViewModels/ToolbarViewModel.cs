using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatWorkbookPrismPoc.Infrastructure;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Windows.Controls;

namespace CatWorkbookPrismPoc.ToolbarModule.ViewModels
{
    public class ToolbarViewModel : ViewModelBase, IToolbarViewModel
    {

        #region Constructors

        public ToolbarViewModel()
        {
            
            OpenCommand = new DelegateCommand(Open, CanOpen);
            SaveCommand = new DelegateCommand(Save, CanSave);
            ExitCommand = new DelegateCommand(Exit, CanExit);
        }

        private bool CanExit()
        {
            return true;
        }

        private void Exit()
        {
            MessageBox.Show("Exit Button Clicked");
        }

        private bool CanSave()
        {
            return true;
        }

        private void Save()
        {
            MessageBox.Show("Save menu item clicked");
        }

        private bool CanOpen()
        {
            return true;
        }

        private void Open()
        {
            MessageBox.Show("Open Command clicked");
        }

        #endregion

        #region Commands

        public DelegateCommand OpenCommand { get; set; }
        public DelegateCommand SaveCommand { get; set; }
        public DelegateCommand ExitCommand { get; set; }

        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CatWorkbookPrismPoc.Infrastructure;

namespace CatWorkbookPrismPoc.ProgramModule.ViewModel
{
    public interface IProgramModuleTaskButtonViewModel : IViewModel
    {

        #region Commands

        ICommand ShowProgramModuleView { get; set; }

        #endregion

        #region Administrative Properties

        bool? IsChecked { get; set; }

        #endregion


        #region Event Handlers

        void OnNavigatedCompleted(string publisher);

        #endregion


        #region Private Methods

        void Initialize();

        #endregion
    }
}

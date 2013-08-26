using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using CatWorkbookPrismPoc.Infrastructure;

namespace CatWorkbookPrismPoc.StatusbarModule.ViewModel
{
    public class StatusbarViewModel : ViewModelBase, IStatusbarViewModel
    {
        #region Constructors

        public StatusbarViewModel()
        {
            Message = "Ready";
        }

        #endregion

        #region Propeties

        private string _message;
        public string Message
        {
            get
            {
                return _message;
            }
            set
            {
                _message = value;
                RaisePropertyChanged("Message");
            }
        }


        #endregion


    }
}

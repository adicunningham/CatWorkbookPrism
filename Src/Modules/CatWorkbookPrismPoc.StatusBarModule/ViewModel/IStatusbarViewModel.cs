using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatWorkbookPrismPoc.Infrastructure;

namespace CatWorkbookPrismPoc.StatusbarModule.ViewModel
{
    public interface IStatusbarViewModel : IViewModel
    {
        string Message { get; set; }
    }
}

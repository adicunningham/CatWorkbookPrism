using CatWorkbookPrismPoc.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatWorkbookPrismPoc.ProgramModule.Views.ViewModel
{
    public interface IProgramViewModel : IViewModel
    {
        string ProgramName { get; set; }

    }
}

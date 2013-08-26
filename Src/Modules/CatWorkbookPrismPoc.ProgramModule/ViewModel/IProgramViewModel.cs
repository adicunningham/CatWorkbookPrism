using System.Collections.Generic;
using CatWorkbookPrismPoc.Business.CatWorkbookPrisimPoc.Business;
using CatWorkbookPrismPoc.Infrastructure;

namespace CatWorkbookPrismPoc.ProgramModule.ViewModel
{
    public interface IProgramViewModel : IViewModel
    {
        Program Program { get; set; }

        bool IsBusy { get; set; }

        Dictionary<int, string> Underwriters { get; set; } 

        IList<int> EffectiveYears { get; set; } 
    }
}

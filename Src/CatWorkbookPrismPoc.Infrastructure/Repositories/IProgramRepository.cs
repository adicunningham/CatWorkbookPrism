using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatWorkbookPrismPoc.Business.CatWorkbookPrisimPoc.Business;

namespace CatWorkbookPrismPoc.Infrastructure.Repositories
{
    public interface IProgramRepository
    {
        Program GetProgram(int programId);
    }
}

using CatWorkbookPrismPoc.Business;
using CatWorkbookPrismPoc.Business.CatWorkbookPrisimPoc.Business;
using CatWorkbookPrismPoc.Infrastructure.Repositories;

namespace CatWorkbookPrismPoc.ServiceModule
{
    public class ProgramRepository : IProgramRepository
    {
        public Program GetProgram(int programId)
        {
            var program = ServiceFacade.CatWorkbookService.GetProgramById(programId);
            return program;
        }
    }
}

using CatWorkbookPrismPoc.Business.CatWorkbookPrisimPoc.Business;
using CatWorkbookPrismPoc.Infrastructure;
using CatWorkbookPrismPoc.Infrastructure.Repositories;
using CatWorkbookPrismPoc.Infrastructure.Service;
using CatWorkbookPrismPoc.ServiceModule;
using NUnit.Framework;

namespace CatWorkbookPrismPoc.Modules.UnitTest
{
    [TestFixture]
    public class ProgramModuleTests
    {
        
        [Test, Description("Test verifies retrieving a program view the repository")]
        public void TestGetProgramFromRepository()
        {
            int programID = 44559;

            IProgramRepository programRepository = new ProgramRepository();
            Program program = programRepository.GetProgram(programID);
            
            Assert.IsNotNull(program) ;
        }

        [Test, Description("Test verifies retrieving a program via IPersonService")]
        public void TestGetProgramFromSerivce()
        {
            int programId = 44559;

            IProgramService programService = new ProgramService();
            Program program = programService.GetProgramById(programId);

            Assert.IsNotNull(program);
        }

    }
}

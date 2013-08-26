using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
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

        [Test, Description("Tests calling GetUnderwriters asynchronously")]
        public async void TestGetUnderwriters()
        {
            IProgramService programService = new ProgramService();

            var task = Task.Factory.StartNew(() => programService.GetUnderwritersAsync());

            Dictionary<int, string> uwDict = new Dictionary<int, string>();
            var uwDictTask = await task;
            await uwDictTask.ContinueWith(e =>
            {
                if (e.IsCompleted)
                {
                    Console.Out.WriteLine("Number of UWs: " + e.Result.Count);
                    Assert.Greater(e.Result.Count, 0);
                }
            });
            Console.Out.WriteLine("Waiting for results");
        }

        [Test, Description("Verifies calling GetEffective Years Asynchronously")]
        public async void TestGetEffectiveYears()
        {
            IProgramService programService = new ProgramService();

            var task = Task.Factory.StartNew(() => programService.GetEffectiveYearsAsync());
            var years = await task;
            await years.ContinueWith(e =>
            {
                if (e.IsCompleted)
                {
                    foreach (var year in e.Result)
                    {
                        Console.Out.WriteLine(year);
                    }
                    Assert.Greater(e.Result.Count, 0);
                }
            });
        }

    }
}

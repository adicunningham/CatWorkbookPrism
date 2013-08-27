using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using CatWorkbookPrismPoc.Services.Behaviours;
using CatWorkbookPrismPoc.Services.Contracts;
using CatWorkbookPrismPoc.Services.Contracts.Data;
using NUnit.Framework;

namespace CatWorkbookPrismPoc.Services.UnitTests
{
    [TestFixture]
    public class CatWorkbookServiceTest
    {
        
        [Test, Description("Test verifies retrieving a program")]
        public void TestGetProgram()
        {
            int programID;
            programID = 44559;

            ICatWorkbookService catWorkbookService = new CatWorkbookService();

            Program program = catWorkbookService.GetProgramById(programID);
            
            Assert.IsNotNull(program) ;
        }

        [Test, Description("Test verifies that a dictionary of underwriters was returned")]
        public void TestGetUnderwriters()
        {
            ICatWorkbookService catWorkbookService = new CatWorkbookService();

            Dictionary<int, string> uwDictionary = catWorkbookService.GetUnderwriters();
          
            Assert.Greater(uwDictionary.Count, 0);
        }

        [Test, Description("Verifies a list of effective years are returned")]
        public void TestGetEffectiveYears()
        {
            ICatWorkbookService catWorkbookService = new CatWorkbookService();

            var years= catWorkbookService.GetEffectiveYears();

            Assert.Greater(years.Count, 0);
        }

        [Test, Description("Tests that a list of programs are returned for Underwriter and Year")]
        public void TestGetProgramList()
        {
            ICatWorkbookService catWorkbookService = new CatWorkbookService();

            var programs = catWorkbookService.GetPrograms(8783, 2013); // thomas brazil, 2013

            Assert.Greater(programs.Count, 0);
            Console.Out.WriteLine("Num Programs: " + programs.Count);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
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

    }
}

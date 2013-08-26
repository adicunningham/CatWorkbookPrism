using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatWorkbookPrismPoc.Business;
using CatWorkbookPrismPoc.Business.CatWorkbookPrisimPoc.Business;
using CatWorkbookPrismPoc.Infrastructure;
using CatWorkbookPrismPoc.Infrastructure.Service;

namespace CatWorkbookPrismPoc.ServiceModule
{
    public class ProgramService : IProgramService
    {
        public string ServiceName
        {
            get { return "ProgramService"; }
        }

        public Program GetProgramById(int programId)
        {
            var program = ServiceFacade.CatWorkbookService.GetProgramById(programId);
            return program;
        }

        public void GetProgramByIdAsync(int programId, EventHandler<ServiceResult<Program>> callback)
        {
            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += (o, e) =>
            {
                e.Result = GetProgramById(programId);
            };
            bw.RunWorkerCompleted += (o, e) => callback.Invoke(this, new ServiceResult<Program>((Program) e.Result));
            bw.RunWorkerAsync();
        }
    }
}

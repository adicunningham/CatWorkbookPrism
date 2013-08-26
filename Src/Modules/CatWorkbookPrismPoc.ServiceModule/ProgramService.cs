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

        /// <summary>
        /// Get Program By Id
        /// </summary>
        /// <param name="programId"></param>
        /// <returns></returns>
        public Program GetProgramById(int programId)
        {
            var program = ServiceFacade.CatWorkbookService.GetProgramById(programId);
            return program;
        }

        /// <summary>
        /// Get Program By Id Asynchronously.
        /// </summary>
        /// <param name="programId"></param>
        /// <param name="callback"></param>
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

        /// <summary>
        /// Get Underwriters Asynchronously.
        /// </summary>
        /// <returns></returns>
        public async Task<Dictionary<int, string>> GetUnderwritersAsync()
        {
            var task = Task.Factory.StartNew(() =>
            {
                var uwDictionary = ServiceFacade.CatWorkbookService.GetUnderwriters();
                return uwDictionary;
            });

            return await task.ConfigureAwait(false);
        }


        /// <summary>
        /// Get Effective Years Asynchronously.
        /// </summary>
        /// <returns></returns>
        public async Task<IList<int>> GetEffectiveYearsAsync()
        {
            var task = Task.Factory.StartNew(() =>
            {
                var years = ServiceFacade.CatWorkbookService.GetEffectiveYears();
                return years;
            });
            return await task.ConfigureAwait(false);
        }
    }
}

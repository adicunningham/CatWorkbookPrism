using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CatWorkbookPrismPoc.Business.CatWorkbookPrisimPoc.Business;

namespace CatWorkbookPrismPoc.Infrastructure.Service
{
    public interface IProgramService : IService
    {
        Program GetProgramById(int programId);
        void GetProgramByIdAsync(int programId, EventHandler<ServiceResult<Program>> callback);

        Task<Dictionary<int, string>> GetUnderwritersAsync();

        Task<IList<int>> GetEffectiveYearsAsync();
    }
}

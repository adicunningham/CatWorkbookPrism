using System;
using CatWorkbookPrismPoc.Business.CatWorkbookPrisimPoc.Business;

namespace CatWorkbookPrismPoc.Infrastructure.Service
{
    public interface IProgramService : IService
    {
        Program GetProgramById(int programId);
        void GetProgramByIdAsync(int programId, EventHandler<ServiceResult<Program>> callback);
    }
}

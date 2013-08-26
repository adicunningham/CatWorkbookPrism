using System.ServiceModel;
using CatWorkbookPrismPoc.Infrastructure;
using CatWorkbookPrismPoc.Services.Contracts.Data;
using CatWorkbookPrismPoc.Services.Contracts.Faults;

namespace CatWorkbookPrismPoc.Services.Contracts
{
    [ServiceContract]
    public interface ICatWorkbookService
    {
        [OperationContract]
        [FaultContract(typeof(ServiceException))]
        Program GetProgramById(int programId);
    }
}

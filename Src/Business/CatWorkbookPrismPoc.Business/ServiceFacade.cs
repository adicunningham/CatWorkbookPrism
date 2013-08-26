using CatWorkbookPrismPoc.Business.CatWorkbookPrisimPoc.Business;

namespace CatWorkbookPrismPoc.Business
{
    public class ServiceFacade
    {
        private static CatWorkbookServiceClient _catWorkbookServiceClient;
        public static CatWorkbookServiceClient CatWorkbookService
        {
            get
            {
                if (_catWorkbookServiceClient == null)
                {
                    _catWorkbookServiceClient = new CatWorkbookServiceClient();
                }
                return _catWorkbookServiceClient;
            }
        }

    }
}
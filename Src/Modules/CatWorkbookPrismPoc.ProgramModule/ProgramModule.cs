using CatWorkbookPrismPoc.Infrastructure;
using CatWorkbookPrismPoc.Infrastructure.Repositories;
using CatWorkbookPrismPoc.ProgramModule.ViewModel;
using CatWorkbookPrismPoc.ProgramModule.Views;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;

namespace CatWorkbookPrismPoc.ProgramModule
{
    public class ProgramModule : IModule
    {
        private IUnityContainer _container;
        private IRegionManager _regionManager;

        public ProgramModule(IUnityContainer container, IRegionManager regionManager)
        {
            _container = container;
            _regionManager = regionManager;
        }


        public void Initialize()
        {
            RegisterTypesAndServices();

            _regionManager.RegisterViewWithRegion(RegionNames.NavigatorRegion, typeof (ProgramView));
        }

        private void RegisterTypesAndServices()
        {
            _container.RegisterType<IProgramView, ProgramView>();
            _container.RegisterType<IProgramViewModel, ProgramViewModel>();
        }
    }
}

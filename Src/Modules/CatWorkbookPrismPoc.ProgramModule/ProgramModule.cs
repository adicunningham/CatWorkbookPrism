using System;
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

            _regionManager.RegisterViewWithRegion(RegionNames.TaskbuttonRegion, typeof (ProgramModuleTaskButtonView));
        }

        private void RegisterTypesAndServices()
        {
            _container.RegisterType<Object, ProgramView>(typeof(ProgramView).FullName);
            _container.RegisterType<Object, ProgramModuleNavigatorView>(typeof(ProgramModuleNavigatorView).FullName);
            _container.RegisterType<Object, ProgramRibbonView>(typeof(ProgramRibbonView).FullName);
            _container.RegisterType<IProgramViewModel, ProgramViewModel>();
            _container.RegisterType<IProgramModuleTaskButtonView, ProgramModuleTaskButtonView>();
            _container.RegisterType<IProgramModuleTaskButtonViewModel, ProgramModuleTaskButtonViewModel>();
        }
    }
}

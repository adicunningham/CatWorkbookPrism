using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatWorkbookPrismPoc.Infrastructure;
using CatWorkbookPrismPoc.StatusbarModule.ViewModel;
using CatWorkbookPrismPoc.StatusbarModule.Views;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;

namespace CatWorkbookPrismPoc.StatusbarModule
{
    public class StatusbarModule : IModule
    {
        private IUnityContainer _container;
        private IRegionManager _regionManager;

        public StatusbarModule(IUnityContainer container, IRegionManager regionManager)
        {
            _container = container;
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            RegisterTypesAndServices();

            _regionManager.RegisterViewWithRegion(RegionNames.StatusbarRegion, typeof (StatusbarView));
        }

        private void RegisterTypesAndServices()
        {
            _container.RegisterType<IStatusbarView, StatusbarView>();
            _container.RegisterType<IStatusbarViewModel, StatusbarViewModel>();
        }
    }
}

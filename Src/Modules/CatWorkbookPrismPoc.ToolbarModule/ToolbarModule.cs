using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using CatWorkbookPrismPoc.Infrastructure;
using CatWorkbookPrismPoc.ToolbarModule.ViewModels;
using CatWorkbookPrismPoc.ToolbarModule.Views;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;

namespace CatWorkbookPrismPoc.ToolbarModule
{
    public class ToolbarModule : IModule
    {
        private IUnityContainer _container;
        private IRegionManager _regionManager;

        public ToolbarModule(IUnityContainer container, IRegionManager regionManager)
        {
            _container = container;
            _regionManager = regionManager;

        }
        public void Initialize()
        {
            RegisterTypesAndServices();

            _regionManager.RegisterViewWithRegion(RegionNames.ToolbarRegion, typeof (ToolbarView));
        }

        private void RegisterTypesAndServices()
        {
            _container.RegisterType<IToolbarView, ToolbarView>();
            _container.RegisterType<IToolbarViewModel, ToolbarViewModel>();
        }
    }
}

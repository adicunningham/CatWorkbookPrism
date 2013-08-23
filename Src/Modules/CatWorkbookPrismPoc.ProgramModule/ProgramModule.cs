using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatWorkbookPrismPoc.ProgramModule.ViewModel;
using CatWorkbookPrismPoc.ProgramModule.Views;
using CatWorkbookPrismPoc.ProgramModule.Views.ViewModel;
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

            _regionManager.RegisterViewWithRegion("ProgramRegion", typeof (ProgramView));
        }

        private void RegisterTypesAndServices()
        {
            _container.RegisterType<IProgramView, ProgramView>();
            _container.RegisterType<IProgramViewModel, ProgramViewModel>();
        }
    }
}

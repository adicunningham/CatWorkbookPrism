using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatWorkbookPrismPoc.Business.CatWorkbookPrisimPoc.Business;
using CatWorkbookPrismPoc.Infrastructure;
using CatWorkbookPrismPoc.Infrastructure.Repositories;
using CatWorkbookPrismPoc.Infrastructure.Service;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;

namespace CatWorkbookPrismPoc.ServiceModule
{
    public class ServiceModule : ModuleBase 
    {
       

        public ServiceModule(IUnityContainer container, IRegionManager regionManger) : base(container, regionManger)
        {
        }

        protected override void InitializeModule()
        {
           
        }

        protected override void RegisterTypes()
        {
            Container.RegisterType<IProgramRepository, ProgramRepository>(new ContainerControlledLifetimeManager());
            Container.RegisterType<IProgramService, ProgramService>(new ContainerControlledLifetimeManager());
        }
    }
}

using LinkGatesTask.Contracts;
using LinkGatesTask.DAL;
using LinkGatesTask.Repos;
using LinkGatesTask.Services;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace LinkGatesTask
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            container.RegisterType<MyContext>(new Unity.Lifetime.HierarchicalLifetimeManager());
            container.RegisterType<IUnitOfWork, UnitOfWork>(new Unity.Lifetime.HierarchicalLifetimeManager());
            container.RegisterType<IPropertyReposetory, PropertyReposetory>(new Unity.Lifetime.HierarchicalLifetimeManager());
            container.RegisterType<ICategoryReposetory, ICategoryReposetory>(new Unity.Lifetime.HierarchicalLifetimeManager());
            container.RegisterType<IDeviceReposetory, DeviceReposetory>(new Unity.Lifetime.HierarchicalLifetimeManager());
            container.RegisterType<ICategoryPropertiesReposetory, CategoryPropertiesReposetory>(new Unity.Lifetime.HierarchicalLifetimeManager());
            container.RegisterType<IPropertyValueReposetory, PropertyValueReposetory>(new Unity.Lifetime.HierarchicalLifetimeManager());
            container.RegisterType<DeviceService>(new Unity.Lifetime.HierarchicalLifetimeManager());
            container.RegisterType<PropertyService>(new Unity.Lifetime.HierarchicalLifetimeManager());
            container.RegisterType<PropertyValueService>(new Unity.Lifetime.HierarchicalLifetimeManager());
            container.RegisterType<CategoryService>(new Unity.Lifetime.HierarchicalLifetimeManager());

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}
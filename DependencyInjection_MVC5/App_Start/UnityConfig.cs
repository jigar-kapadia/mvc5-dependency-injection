using BL.Interfaces;
using BL.Repository;
using DependencyInjection_MVC5.Mapper;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using AutoMapper;
using DependencyInjection_MVC5.Models;
using DL;

namespace DependencyInjection_MVC5
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();gist
            //container.RegisterSingleton(typeof(MappingProfiles));

            //var config = new MapperConfiguration(ctx =>
            //{
            //    ctx.CreateMap<customer, Customer>();
            //    ctx.CreateMap<order, Order>();
            //});
            //IMapper mapper = config.CreateMapper();
            //container.RegisterInstance(mapper);
            container.RegisterInstance(new SampleDbEntities());
            container.RegisterInstance(MappingProfiles.ConfigureMapper());
            container.RegisterType<ICustomerRepository, CustomerRepository>();
            container.RegisterType<IOrderRepository, OrderRepository>();
            container.RegisterType<IOrderItemRepository, OrderItemRepository>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        
    }
}
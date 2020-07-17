using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using DL;
using DependencyInjection_MVC5.Models;

namespace DependencyInjection_MVC5.Mapper
{
    public class MappingProfiles : Profile
    {
        //public MappingProfiles()
        //{
        //    CreateMap<customer, Customer>();
        //}
        public static IMapper ConfigureMapper()
        {
            var config = new MapperConfiguration(ctx =>
           {
               ctx.CreateMap<customer, Customer>();
               ctx.CreateMap<order, Order>();
               ctx.CreateMap<order_items, OrderItems>();
           });

            return config.CreateMapper();
        }
    }
}
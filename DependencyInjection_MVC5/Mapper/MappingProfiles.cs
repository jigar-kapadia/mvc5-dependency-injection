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
               ctx.CreateMap<order, Order>()
                .ForMember(x => x.customer_name, z => z.MapFrom(y => y.customer.first_name + " " + y.customer.last_name))
                .ForMember(x => x.store_name, z => z.MapFrom(y => y.store.store_name))
                .ForMember(x => x.staff_name, z => z.MapFrom(y => y.staff.first_name + " " + y.staff.last_name));
               ctx.CreateMap<order_items, OrderItems>()
                .ForMember(x => x.product_name, z => z.MapFrom(y => y.product.product_name));
           });
            
            return  config.CreateMapper();
        }
    }
}
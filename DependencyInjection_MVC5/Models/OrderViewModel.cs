using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DependencyInjection_MVC5.Models
{
    public class OrderViewModel
    {
        public Order OrderDetails { get; set; }
        public List<OrderItems> Items { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DependencyInjection_MVC5.Models
{
    public class Order
    {
        [Display(Name = "OrderId")]
        public int order_id { get; set; }
        [Display(Name = "CustomerId")]
        public int? customer_id { get; set; }
        [Display(Name = "Customer")]
        public string customer_name { get; set; }
        [Display(Name = "Status")]
        public byte order_status { get; set; }
        [Display(Name = "Order Date")]
        public DateTime order_date { get; set; }
        public DateTime required_date { get; set; }
        [Display(Name = "Shipping Date")]
        public DateTime? shipped_date { get; set; }
        [Display(Name = "Store")]
        public string store_name { get; set; }
        public int store_id { get; set; }
        [Display(Name = "Staff")]
        public string staff_name { get; set; }
        public int staff_id { get; set; }
    }
}
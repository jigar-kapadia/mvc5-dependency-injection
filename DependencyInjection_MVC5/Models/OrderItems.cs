using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DependencyInjection_MVC5.Models
{
    public class OrderItems
    {
        [Display(Name = "Order#")]
        public int order_id { get; set; }
        [Display(Name = "Item")]
        public int item_id { get; set; }
        [Display(Name = "Product")]
        public string product_name { get; set; }
        public int product_id { get; set; }
        [Display(Name = "Quantity")]
        public int quantity { get; set; }
        [Display(Name = "Price")]
        public decimal list_price { get; set; }
        [Display(Name = "Discount")]
        public decimal discount { get; set; }
    }
}
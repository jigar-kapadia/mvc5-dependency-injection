﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DependencyInjection_MVC5.Models
{
    public class OrderItems
    {
        public int order_id { get; set; }
        public int item_id { get; set; }
        public int product_id { get; set; }
        public int quantity { get; set; }
        public decimal list_price { get; set; }
        public decimal discount { get; set; }
    }
}
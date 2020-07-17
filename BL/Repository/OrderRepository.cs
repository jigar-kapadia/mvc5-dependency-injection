using BL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL;

namespace BL.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private SampleDbEntities dbContext;
        public OrderRepository()
        {
            dbContext = new SampleDbEntities();
        }
        public List<order> GetOrdersByCustomerId(int customerId)
        {
            return dbContext.orders.Where(x => x.customer_id == customerId).ToList();
        }

        public order GetOrdersByOrderId(int orderId)
        {
            return dbContext.orders.FirstOrDefault(x => x.order_id == orderId);
        }
    }
}

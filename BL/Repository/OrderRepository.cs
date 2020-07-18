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
        private SampleDbEntities _dbContext;
        public OrderRepository(SampleDbEntities dbContext)
        {
            _dbContext = dbContext;
        }
        public List<order> GetOrdersByCustomerId(int customerId)
        {
            return _dbContext.orders.Where(x => x.customer_id == customerId).ToList();
        }

        public order GetOrdersByOrderId(int orderId)
        {
            return _dbContext.orders.FirstOrDefault(x => x.order_id == orderId);
        }
    }
}

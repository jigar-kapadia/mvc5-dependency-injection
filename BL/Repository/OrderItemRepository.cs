using BL.Interfaces;
using DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Repository
{
    public class OrderItemRepository : IOrderItemRepository
    {
        private SampleDbEntities _dbContext;
        public OrderItemRepository(SampleDbEntities dbContext)
        {
            _dbContext = dbContext;
        }

        public order_items GetOrderItemById(int itemId)
        {
            return _dbContext.order_items.FirstOrDefault(x => x.item_id == itemId);   
        }

        public List<order_items> GetOrderItemsByOrderId(int orderId)
        {
            return _dbContext.order_items.Where(x => x.order_id == orderId).ToList();
        }
    }
}

using DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface IOrderItemRepository
    {
        List<order_items> GetOrderItemsByOrderId(int orderId);
        order_items GetOrderItemById(int itemId);
    }
}

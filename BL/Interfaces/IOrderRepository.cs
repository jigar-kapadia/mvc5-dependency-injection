using DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface IOrderRepository
    {
        List<order> GetOrdersByCustomerId(int customerId);
        order GetOrdersByOrderId(int orderId);

    }
}

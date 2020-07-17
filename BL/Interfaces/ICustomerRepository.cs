using DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface ICustomerRepository
    {
        List<customer> GetCustomers();
        customer GetCustomerById(int id);
    }
}

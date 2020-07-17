using BL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL;

namespace BL.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private SampleDbEntities dbContext;
        public CustomerRepository()
        {
            dbContext = new SampleDbEntities();
        }
        public customer GetCustomerById(int id)
        {
            return dbContext.customers.Where(x => x.customer_id == id).FirstOrDefault();
        }

        public List<customer> GetCustomers()
        {
            return dbContext.customers.ToList();
        }
    }
}

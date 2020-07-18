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
        private readonly SampleDbEntities _dbContext;
        public CustomerRepository(SampleDbEntities dbContext)
        {
            _dbContext = dbContext;
        }
        public customer GetCustomerById(int id)
        {
            return _dbContext.customers.Where(x => x.customer_id == id).FirstOrDefault();
        }

        public List<customer> GetCustomers()
        {
            return _dbContext.customers.ToList();
        }
    }
}

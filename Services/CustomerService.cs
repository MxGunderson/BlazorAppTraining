using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorAppSandBox.Data;

namespace BlazorAppSandBox.Services
{
    public class CustomerService
    {
        protected readonly ApplicationDbContext _dbcontext;
        public CustomerService(ApplicationDbContext _db)
        {
            _dbcontext = _db;
        }

        public List<CustomerClass> GetCustomers()
        {
            return _dbcontext.SaleLT.ToList();
        }

        public bool Addcustomer(CustomerClass ecadd)
        {
            _dbcontext.SaleLT.Add(ecadd);
            _dbcontext.SaveChanges();
            return true;
        }

    }
}

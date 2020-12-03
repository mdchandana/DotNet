using EFCoreBasics.DAL.Entities;
using EFCoreBasics.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreBasics.DAL
{
    public class CustomerRepository : ICustomerRepository
    {
        private AppDbContext _appDbContext;

        public CustomerRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return _appDbContext.Customers;
        }
    }
}

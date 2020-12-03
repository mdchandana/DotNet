using EFCoreBasics.DAL.Entities;
using EFCoreBasics.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreBasics.DAL
{
    public class MockCustomerRepository : ICustomerRepository
    {
        private List<Customer> _customers;

        public MockCustomerRepository()
        {
            _customers = new List<Customer>()
            {
                new Customer(){Id=2001,Name="Sidath Abeysiriwardana"},
                new Customer(){Id=2016,Name="Chandana Priyantha"}
            };
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return _customers;
        }
    }
}

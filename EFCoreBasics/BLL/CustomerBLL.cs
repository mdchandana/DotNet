using EFCoreBasics.BLL.Interface;
using EFCoreBasics.DAL.Entities;
using EFCoreBasics.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreBasics.BLL
{
    public class CustomerBLL : ICustomerBLL
    {
        private ICustomerRepository _customerRepository;

        public CustomerBLL(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public IEnumerable<Customer> GetCustomers()
        {
            return _customerRepository.GetCustomers();
        }
    }
}

using EFCoreBasics.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreBasics.DAL.Interface
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetCustomers();
    }
}

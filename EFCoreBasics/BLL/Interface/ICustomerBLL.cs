using EFCoreBasics.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreBasics.BLL.Interface
{
    public interface ICustomerBLL
    {
        IEnumerable<Customer> GetCustomers();
    }
}

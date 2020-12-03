using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCoreBasics.DAL.Entities
{
    [Table("Customer")]
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public List<Order> Orders { get; set; }     //Customer can have many orders , But a Order belongs to a specific Customer..

    }
}

using ShoppingCartBasicsMVC.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ShoppingCartBasicsMVC.Models.Entities
{
    [Table("Customer")]
    public class Customer
    {
        public int Id { get; set; }

        [Display(Name ="Customer Name")]
        public string Name { get; set; }
        [Display(Name ="Customer Address")]
        public string Address { get; set; }

        public List<Order> Orders { get; set; }


    }
}
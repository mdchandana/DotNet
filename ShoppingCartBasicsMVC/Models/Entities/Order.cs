using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ShoppingCartBasicsMVC.Models.Entities
{
    [Table("Order")]
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }

        public int CustomerId { get; set; }       //this is FK... from Customer       
        public Customer Customer { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }


    }
}
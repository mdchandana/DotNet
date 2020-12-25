using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ShoppingCartBasicsMVC.Models.Entities
{
    [Table("OrderDetail")]
    public class OrderDetail
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Qty { get; set; }

        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCoreBasics.DAL.Entities
{

    public class OrderDetail
    {
       
        public int OrderId { get; set; }
       
        public int ProductId { get; set; }


        public int Qty { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }



        [ForeignKey("OrderId")]
        public Order Order { get; set; }       //A OrderDetail belongs to a specific Order 

        [ForeignKey("ProductId")]
        public Product Product { get; set; }   //A OrderDetail belongs to a specfic
    }
}

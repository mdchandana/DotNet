using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCoreBasics.DAL.Entities
{
    [Table("Order")]
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderedDate { get; set; }    
        
        public int CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }          //A Order belongs to a specific Customer


        public List<OrderDetail> OrderDetails { get; set; }   //Order can have many OrderDetails

    }
}

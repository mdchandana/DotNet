using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCoreBasics.DAL.Entities
{

    [Table("Product")]
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }  //A product can associate with Many OrderDetails..
    }
}

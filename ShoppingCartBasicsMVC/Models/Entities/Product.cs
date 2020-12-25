using ShoppingCartBasicsMVC.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ShoppingCartBasicsMVC.Models.Entities
{
    [Table("Product")]
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Column(TypeName = "decimal(18,2)")]       
        public decimal Price { get; set; }

        public DateTime DateCreation { get; set; }
        public string Photo { get; set; }
        public int CategoryId { get; set; }


        public List<OrderDetail> OrderDetails { get; set; }

    }
}
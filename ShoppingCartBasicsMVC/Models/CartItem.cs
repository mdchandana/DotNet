using ShoppingCartBasicsMVC.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCartBasicsMVC.Models
{
    public class CartItem
    {
        public Product Product { get; set; }
        public int Qty { get; set; }


        public CartItem()
        {
        }
        
        public CartItem(Product product,int qty)
        {
            this.Product = product;
            this.Qty = qty;
        }

    }
}
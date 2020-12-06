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

        //--------------------MANY TO MANY-------------------------       
        //--Automatic many many relationships mapping not supported with ef core...
        //--We have create Bridge table manually like this and define Composite key manually..
        //--And Composite key define using [Key] attribute not working with ef core.. we have to define it in DbContext..


        /* Eg :  
         * ------------Composite Key Not working with ef core
         * [Key]                                    [Key]
         * public int OrderId { get; set; }         public int ProductId { get; set; }
         * 
         * we have to define it in DbContext...
         */


        [ForeignKey("OrderId")]
        public Order Order { get; set; }       //A OrderDetail belongs to a specific Order 

        [ForeignKey("ProductId")]
        public Product Product { get; set; }   //A OrderDetail belongs to a specfic
    }
}

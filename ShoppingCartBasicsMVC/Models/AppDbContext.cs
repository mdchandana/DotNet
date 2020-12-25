
using Microsoft.EntityFrameworkCore;
using ShoppingCartBasicsMVC.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCartBasicsMVC.Models
{
    public class AppDbContext : DbContext
    {

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //WORKED..Access with hard coded connstring
            optionsBuilder.UseSqlServer("Server=CHANDANA\\SQLEXPRESS2012;Database=ShoppingCartBasicsMvcDB;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //In EfCore , we can't define Composite key..
            //So solution is below lines.. easily we can define OrderId,ProductId

            modelBuilder.Entity<OrderDetail>().HasKey(table => new
            {
                table.OrderId,
                table.ProductId
            });
        }
    }
}
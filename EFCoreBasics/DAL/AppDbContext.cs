using EFCoreBasics.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreBasics.DAL
{
    public class AppDbContext : DbContext
    {


        
        //public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        //{

        //}


        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //WORKED..Access with hard coded connstring
            //optionsBuilder.UseSqlServer("Server=CHANDANA\\SQLEXPRESS2012;Database=EFCoreBasicsDB;Integrated Security=True;");

            //Below code is Used appsetting.json file to read connection string
            //Need package Microsoft.Extensions.Configuration.Json

            IConfigurationBuilder configurationBuilder = new ConfigurationBuilder().AddJsonFile("appsettings.json");
            IConfiguration configuration = configurationBuilder.Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("EFCoreBasicsDbConnString"));

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //In EfCore , we can't define 2 keys as primary key..
            //So solution is below lines.. easily we can define OrderId,ProductId

            modelBuilder.Entity<OrderDetail>().HasKey(table => new
            {
                table.OrderId,
                table.ProductId
            });
        }

    }
}

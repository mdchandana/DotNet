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
        /*
         * IF WE NEED TO RUN THIS CLASS LIBRY PROJECT STAND ALONE WITH DbCOntext....
         *    1. Comment or,Remove 'AppDbContext(DbContextOptions<AppDbContext> options) : base(options)' method..
         *       [this is only need when we run our project through WebApp..  ]
         *       
         *    2. override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         *       [have to set Database provider and connectionString]
         */


        /*We Only need this DbContextOption method when we run through WebApp Project..
        *This method call By 'void ConfigureServices(IServiceCollection services)' -
        method inside Startup.cs in WebApp Project..*/
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }


        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }





        /* WORKED.......IF WE NEED THIS OnConfiguring Method Only If We RUN EfCoreBasics ClassLibry STAND ALONE.....
         * We Don't need this OnConfiguring method to configure, when our WebApp project set as statup project..Eg:EFCoreTestingWebApp ...
         * This method is configuring DatabaseProvider using UseSqlServer() method and 
         * Read ConnString by appsettings.json file Withing EfCoreBasics ClassLibry ...(appsettings.json File inside ClassLib Project)..
         * appsettings.json" properties should be configured to  'Copy To Output Derectory'  'copyIfNewer' or 'Always'
         */

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

using JqueryAjax.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JqueryAjax.Context
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions options) : base(options)
        {

        }


        
        public DbSet<Customer> Customers { get; set; }  



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>()
                .ToTable("Customer");


            //====Worked
            //====Excluding from migrations
            //====The ability to exclude tables from migrations was introduced in EF Core 5.0.
            //modelBuilder.Entity<Customer>()
            //    .ToTable("Customer", t => t.ExcludeFromMigrations());
        }






        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=CHANDANA\\SQLEXPRESS2012;Database=AjaxJqueryDB;Integrated Security=True;");
        //}


    }

}

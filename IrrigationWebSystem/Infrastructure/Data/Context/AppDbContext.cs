using IrrigationWebSystem.ApplicationCore.DomainEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IrrigationWebSystem.Infrastructure.Data.Context
{
    public class AppDbContext : DbContext
    {

        public AppDbContext()
        {

        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeePosition> EmployeePositions { get; set; }        
        public DbSet<EmployeeContact> EmployeeContacts { get; set; }
        public DbSet<EmployeeLeave> EmployeeLeaves { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=CHANDANA\\SQLEXPRESS2012;Database=IrrigationSystemDB;Integrated Security=True;");
        }


    }
}

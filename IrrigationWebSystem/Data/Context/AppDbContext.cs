using IrrigationWebSystem.Models.DomainEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IrrigationWebSystem.Data.Context
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
        public DbSet<WmScheme> WmSchemes { get; set; }
        public DbSet<WmWaterLevelCapacityMuruthawelaTank> WmWaterLevelCapacityMuruthawelaTanks { get; set; }
        public DbSet<WmRainFall> wmRainFalls { get; set; }
        public DbSet<WmCultivationSeasonInformation> wmCultivationSeasonInformations { get; set; }
        public DbSet<WmDailyWaterLevelAndissue> dailyWaterLevelAndissues { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Employee>()
                .ToTable("Employee");
            modelBuilder.Entity<EmployeePosition>()
                .ToTable("EmployeePosition");
            modelBuilder.Entity<EmployeeContact>()
                .ToTable("EmployeeContact");
            modelBuilder.Entity<EmployeeLeave>()
                .ToTable("EmployeeLeave");
            modelBuilder.Entity<WmScheme>()
                .ToTable("WmScheme");
            modelBuilder.Entity<WmWaterLevelCapacityMuruthawelaTank>()
                .ToTable("WmWaterLevelCapacityMuruthawelaTank");
            modelBuilder.Entity<WmRainFall>()
                .ToTable("WmRainFall");
            modelBuilder.Entity<WmCultivationSeasonInformation>()
                .ToTable("WmCultivationSeasonInformation");
            modelBuilder.Entity<WmDailyWaterLevelAndissue>()
                .ToTable("WmDailyWaterLevelAndissue");
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=CHANDANA\\SQLEXPRESS2012;Database=IrrigationSystemDB;Integrated Security=True;");
        }


    }
}

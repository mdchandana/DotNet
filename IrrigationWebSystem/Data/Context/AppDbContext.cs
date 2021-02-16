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

        //public AppDbContext()
        //{

        //}

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeePosition> EmployeePositions { get; set; }        
        //public DbSet<EmployeeContact> EmployeeContacts { get; set; }
        public DbSet<EmployeeLeave> EmployeeLeaves { get; set; }
        public DbSet<WmScheme> WmSchemes { get; set; }
        public DbSet<WmWaterLevelCapacityMuruthawelaTank> WmWaterLevelCapacityMuruthawelaTanks { get; set; }
        public DbSet<WmRainFall> WmRainFalls { get; set; }
        public DbSet<WmCultivationSeasonInformation> WmCultivationSeasonInformations { get; set; }
        public DbSet<WmDailyWaterLevelAndissue> WmDailyWaterLevelAndissues { get; set; }
        public DbSet<WmCannel> WmCannels  { get; set; }
        public DbSet<WmCannelsWaterIssue> WmCannelsWaterIssues { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Employee>()
                .ToTable("Employee");
            modelBuilder.Entity<EmployeePosition>()
                .ToTable("EmployeePosition");
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
            modelBuilder.Entity<WmCannel>()
                .ToTable("WmCannel");
            modelBuilder.Entity<WmCannelsWaterIssue>()
                .ToTable("WmCannelsWaterIssue");
            modelBuilder.Entity<WmCultivationSeasonInformation>()
                .ToTable("WmCultivationSeasonInformation");

            // //-----------set primary key fluent api -------------------------
            // modelBuilder.Entity<WmCannel>()
            // .HasKey(c => c.CannelName);

            // ////-----------set Identity  -- auto increment OFF -- fluent api -------------------------
            // modelBuilder.Entity<WmCannel>()
            //.Property(c => c.CannelName)
            //.ValueGeneratedNever();



        }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=CHANDANA\\SQLEXPRESS2012;Database=IrrigationSystemDB;Integrated Security=True;");
        //}


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=tcp:mdchandana.database.windows.net,1433;Initial Catalog=IrrigationSystemDB;Persist Security Info=False;User ID=mdchandana;Password=myApple5s;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        //}

    }
}

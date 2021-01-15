using Microsoft.EntityFrameworkCore;
using StudyMash.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyMash.Infrastructure.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Make> Makes { get; set; }
        public DbSet<Model> Models { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            /*
              If you want to seed on application start, in your applications starting method you can 
              do a check for the data you want using conditional checks and if no returns, add those
             classes to the context and save the changes.

              The seeding in EF Core is designed for migration, its initialised data for the database, 
              not for an applications runtime. If you want a set of data to be unchanged then consider 
              utilising an alternative method? Like keeping it in xml/json format with in memory caching 
              via properties with field checks.
            */

            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Make>()
                .ToTable("Make");
            modelBuilder.Entity<Model>()
                .ToTable("Model");

            //we are using the HasData method to inform EF Core about the data it has to seed
            modelBuilder.Entity<Make>()
                .HasData(
                    new Make()
                    {
                        Id = 1,
                        Name = "Hero Honda"
                    },
                    new Make()
                    {
                        Id = 2,
                        Name = "Toyota"
                    },
                    new Make()
                    {
                        Id = 3,
                        Name = "Nissan"
                    }
                );



            modelBuilder.Entity<Model>()
                .HasData(
                    new Model()
                    {
                       Id=1,
                       Name="Fit",
                       MakeId=1      
                    },
                    new Model()
                    {
                        Id=2,
                        Name="Aqua",
                        MakeId=2
                    },
                    new Model()
                    {
                        Id=3,
                        Name="Vits",
                        MakeId=2
                    }
               );
        }
    }
}


/*
 public void Configure(EntityTypeBuilder<Student> builder)
{
    builder.ToTable("Student");
    builder.Property(s => s.Age)
        .IsRequired(false);
    builder.Property(s => s.IsRegularStudent)
        .HasDefaultValue(true);
    builder.HasData
    (
        new Student
        {
            Id = Guid.NewGuid(),
            Name = "John Doe",
            Age = 30
        },
        new Student
        {
            Id = Guid.NewGuid(),
            Name = "Jane Doe",
            Age = 25
        },
        new Student
        {
            Id = Guid.NewGuid(),
            Name = "Mike Miles",
            Age = 28
        }
    );
}
 */
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
                        Name = "Harly Devidson"
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
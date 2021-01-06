using Microsoft.EntityFrameworkCore;
using StudyMash.ApplicationCore.DomainEntities;
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

    }
}

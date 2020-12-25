using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Shawn.Data.Entities;

namespace Shawn.Data
{
  public class DutchContext : DbContext
  {
    public DutchContext(DbContextOptions<DutchContext> options): base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }

  }
}

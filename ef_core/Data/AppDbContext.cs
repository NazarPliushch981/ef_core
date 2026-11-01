using System.Collections.Generic;
using ef_core.Models;
using Microsoft.EntityFrameworkCore;

namespace ef_core.Data
{
    public class AppDbContext : DbContext
    {
      public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
    }
}
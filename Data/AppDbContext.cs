using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WellmanFinal1.Models;

namespace WellmanFinal1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Game> Games { get; set; }
    }
}
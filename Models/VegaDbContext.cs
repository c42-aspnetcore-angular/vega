using Microsoft.EntityFrameworkCore;

namespace asp.net_core_angular.Models
{
    public class VegaDbContext : DbContext
    {
        public VegaDbContext(DbContextOptions<VegaDbContext> options) : base(options)
        {            
        }

        public DbSet<Make> Makes { get; set; }
        public DbSet<Feature> Features { get; set; }
    }
}
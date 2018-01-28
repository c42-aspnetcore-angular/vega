using Microsoft.EntityFrameworkCore;

namespace asp.net_core_angular.DomainModels
{
    public class VegaDbContext : DbContext
    {
        public VegaDbContext(DbContextOptions<VegaDbContext> options) : base(options)
        {            
        }

        public DbSet<MakeDomain> Makes { get; set; }
        public DbSet<FeatureDomain> Features { get; set; }
    }
}
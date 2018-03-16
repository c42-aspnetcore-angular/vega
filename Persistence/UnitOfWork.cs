using System.Threading.Tasks;

using asp.net_core_angular.Core;

namespace asp.net_core_angular.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly VegaDbContext dbContext;
        public UnitOfWork(VegaDbContext dbContext)
        {
            this.dbContext = dbContext;

        }
        public Task Complete()
        {
            return dbContext.SaveChangesAsync();
        }
    }
}
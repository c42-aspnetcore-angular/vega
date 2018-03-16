using System.Threading.Tasks;

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
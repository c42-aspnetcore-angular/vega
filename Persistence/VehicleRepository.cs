using System.Threading.Tasks;
using asp.net_core_angular.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace asp.net_core_angular.Persistence
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly VegaDbContext _dbContext;

        public VehicleRepository(VegaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Vehicle> GetVehicle(int id) =>
            await _dbContext.Vehicles
                        .Include(v => v.Features)
                            .ThenInclude(vf => vf.Feature)
                        .Include(v => v.Model)
                            .ThenInclude(vm => vm.Make)
                        .SingleOrDefaultAsync(v => v.Id == id);
    }
}
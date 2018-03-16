using System.Collections.Generic;
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

        public void Add(Vehicle vehicle)
        {
            _dbContext.Vehicles.Add(vehicle);
        }

        public async Task<Vehicle> GetVehicle(int id, bool includeRelated = true)
        {
            if (!includeRelated)
                return await _dbContext.Vehicles.SingleOrDefaultAsync(v => v.Id == id);

            return    
                await _dbContext.Vehicles
                    .Include(v => v.Features)
                        .ThenInclude(vf => vf.Feature)
                    .Include(v => v.Model)
                        .ThenInclude(vm => vm.Make)
                    .SingleOrDefaultAsync(v => v.Id == id);
        }

        public async Task<IEnumerable<Vehicle>> GetAllVehicles()
        {
            return await _dbContext.Vehicles
                    .Include(v => v.Features)
                        .ThenInclude(vf => vf.Feature)
                    .Include(v => v.Model)
                        .ThenInclude(vm => vm.Make)
                    .ToListAsync();
        }

        public void Remove(Vehicle vehicle)
        {
            _dbContext.Remove(vehicle);
        }
    }
}
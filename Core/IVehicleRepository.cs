using System.Collections.Generic;
using System.Threading.Tasks;

using asp.net_core_angular.Core.Models;

namespace asp.net_core_angular.Core
{
    public interface IVehicleRepository
    {
        Task<Vehicle> GetVehicle(int id, bool includeRelated = true);
        void Add(Vehicle vehicle);
        void Remove(Vehicle vehicle);
        Task<IEnumerable<Vehicle>> GetAllVehicles();
    }
}
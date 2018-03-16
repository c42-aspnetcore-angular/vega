using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;

using asp.net_core_angular.Controllers.Resources;
using asp.net_core_angular.Persistence;
using asp.net_core_angular.DomainModels;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace asp.net_core_angular.Controllers
{
    [Route("api/[controller]")]
    public class VehiclesController : Controller
    {
        private readonly VegaDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly IVehicleRepository _repository;

        public VehiclesController(VegaDbContext dbContext, IVehicleRepository repository, IMapper _mapper)
        {
            this._repository = repository;
            this._dbContext = dbContext;
            this._mapper = _mapper;

        }

        [HttpPost]
        public async Task<IActionResult> CreateVehicle([FromBody] SaveVehicleResource vehicleResource)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var vehicle = _mapper.Map<SaveVehicleResource, Vehicle>(vehicleResource);
            vehicle.LastUpdate = DateTime.Now;

            _dbContext.Vehicles.Add(vehicle);
            await _dbContext.SaveChangesAsync();

            vehicle = await _repository.GetVehicle(vehicle.Id);

            var result = _mapper.Map<Vehicle, VehicleResource>(vehicle);

            return Ok(value: result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateVehicle(int id, [FromBody] SaveVehicleResource vehicleResource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var vehicle = await _repository.GetVehicle(id);

            if (vehicle == null)
                return NotFound();

            _mapper.Map<SaveVehicleResource, Vehicle>(vehicleResource, vehicle);
            vehicle.LastUpdate = DateTime.Now;

            await _dbContext.SaveChangesAsync();

            var result = _mapper.Map<Vehicle, VehicleResource>(vehicle);

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVehicle(int id)
        {
            var vehicle = await _dbContext.Vehicles.FindAsync(id);

            if (vehicle == null)
                return NotFound();

            _dbContext.Remove(vehicle);
            await _dbContext.SaveChangesAsync();

            return Ok(id);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetVehicle(int id)
        {
            var vehicle = await _repository.GetVehicle(id);

            if (vehicle == null)
                return NotFound();

            var vehicleResource = _mapper.Map<Vehicle, VehicleResource>(vehicle);

            return Ok(vehicleResource);
        }


        [HttpGet]
        public async Task<IActionResult> GetVehiclesAsync()
        {
            var vehicles = await _dbContext.Vehicles.Include(v => v.Features).ToListAsync();

            if (vehicles == null)
                return NotFound();

            var vehicleResources = vehicles.Select(v => _mapper.Map<Vehicle, SaveVehicleResource>(v));

            return Ok(vehicleResources);
        }
    }
}
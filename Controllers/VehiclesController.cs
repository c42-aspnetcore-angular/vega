using Microsoft.AspNetCore.Mvc;
using AutoMapper;

using asp.net_core_angular.ResourceModels;
using asp.net_core_angular.Persistence;
using asp.net_core_angular.DomainModels;

namespace asp.net_core_angular.Controllers
{
    [Route("api/[controller]")]
    public class VehiclesController : Controller
    {
        private readonly VegaDbContext _dbContext;
        private readonly IMapper _mapper;

        public VehiclesController(VegaDbContext dbContext, IMapper mapper)
        {
            this._dbContext = dbContext;
            this._mapper = mapper;

        }
        public IActionResult Create([FromBody] VehicleResource vehicle)
        {
            try {
                var vehicleDomain = _mapper.Map<VehicleResource, Vehicle>(vehicle);

                _dbContext.Vehicles.Add(vehicleDomain);
                _dbContext.SaveChanges();

                return Ok(value: vehicle);

            } catch {
                return BadRequest();
            }
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

using asp.net_core_angular.ResourceModels;
using asp.net_core_angular.DomainModels;
using asp.net_core_angular.Persistence;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace asp.net_core_angular.Controllers
{
    [Route("api/[controller]")]
    public class MakesController : Controller
    {
        private VegaDbContext _dbContext;
        private readonly IMapper _mapper;

        public MakesController(VegaDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<Make> GetAll()
        {
            var makes = _dbContext.Makes.Include(m => m.Models).ToList();

            return _mapper.Map<IEnumerable<MakeDomain>, IEnumerable<Make>>(makes);
        }
    }
}
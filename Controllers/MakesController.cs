using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

using asp.net_core_angular.Controllers.Resources;
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
        public IEnumerable<MakeResource> GetAll()
        {
            var makes = _dbContext.Makes.Include(m => m.Models).ToList();

            return _mapper.Map<IEnumerable<Make>, IEnumerable<MakeResource>>(makes);
        }
    }
}
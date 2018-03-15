using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

using AutoMapper;

using asp.net_core_angular.ResourceModels;
using asp.net_core_angular.DomainModels;
using asp.net_core_angular.Persistence;

namespace asp.net_core_angular.Controllers
{
    [Route("api/[controller]")]
    public class FeaturesController
    {
        private  VegaDbContext _dbContext;
        private IMapper _mapper;

        public FeaturesController(VegaDbContext dbContext, IMapper mapper) {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<KeyValuePairResource> GetAll()
        {
            var features = _dbContext.Features.ToList();

            var mappedResources = _mapper.Map<IEnumerable<Feature>, IEnumerable<KeyValuePairResource>>(features);
            return mappedResources;
        }
    }
}
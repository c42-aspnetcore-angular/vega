using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

using AutoMapper;

using asp.net_core_angular.ResourceModels;
using asp.net_core_angular.DomainModels;

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
        public IEnumerable<Feature> GetAll()
        {
            var dummyFeatures = new List<FeatureDomain>(
                new [] {
                    new FeatureDomain() {Id = 1, Name = "CarPlay"},
                    new FeatureDomain() {Id = 2, Name = "Android Auto"}
                }
            );

            var mappedResources = _mapper.Map<IEnumerable<FeatureDomain>, IEnumerable<Feature>>(dummyFeatures);
            return mappedResources;
        }
    }
}
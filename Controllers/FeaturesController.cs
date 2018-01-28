using System.Collections.Generic;
using asp.net_core_angular.Models;
using Microsoft.AspNetCore.Mvc;

namespace asp.net_core_angular.Controllers
{
    [Route("api/[controller]")]
    public class FeaturesController
    {
        private  VegaDbContext _dbContext;
        
        public FeaturesController(VegaDbContext dbContext) => _dbContext = dbContext;

        [HttpGet]
        public IEnumerable<Feature> GetAll()
        {
            var dummyFeatures = new List<Feature>(
                new [] {
                    new Feature() {Id = 1, Name = "CarPlay"},
                    new Feature() {Id = 2, Name = "Android Auto"}
                }
            );

            return dummyFeatures;
        }
    }
}
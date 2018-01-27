using System.Collections.Generic;
using System.Linq;
using asp.net_core_angular.Models;
using Microsoft.AspNetCore.Mvc;

namespace asp.net_core_angular.Controllers
{
    [Route("api/[controller]")]
    public class MakesController : Controller
    {
        [HttpGet]
        public IEnumerable<Make> GetAll()
        {
            var dummyMakes = new List<Make>();
            dummyMakes.AddRange(
                new [] { new Make() { 
                            Id = 0, 
                            Name = "Ford", 
                            Models = new [] {new Model() {Id = 0, Name = "Focus"}, new Model() {Id = 1, Name = "Mondeo"}}},
                        new Make() { 
                            Id = 1, 
                            Name = "Skoda", 
                            Models = new [] {new Model() {Id = 0, Name = "Yeti"}, new Model() {Id = 1, Name = "Kodiaq"}}}}
            );
            return dummyMakes;
        }
    }
}
using System.Collections.Generic;

namespace asp.net_core_angular.DomainModels
{
    public class MakeDomain
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<ModelDomain> Models { get; set; }
    }
}
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace asp.net_core_angular.Controllers.Resources
{
    public class MakeResource : KeyValuePairResource
    {
        public IEnumerable<KeyValuePairResource> Models { get; set; }
    }
}
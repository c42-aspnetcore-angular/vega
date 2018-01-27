using System.Collections.Generic;

namespace asp.net_core_angular.Models
{
    public class Make
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Model> Models { get; set; }
    }
}
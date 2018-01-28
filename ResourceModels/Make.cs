using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace asp.net_core_angular.ResourceModels
{
    public class Make
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public IEnumerable<Model> Models { get; set; }
    }
}
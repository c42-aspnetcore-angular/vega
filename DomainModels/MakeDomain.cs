using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace asp.net_core_angular.DomainModels
{
    [Table("Makes")]
    public class MakeDomain
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public IEnumerable<ModelDomain> Models { get; set; }

        public MakeDomain()
        {
            Models = new List<ModelDomain>();
        }
    }
}
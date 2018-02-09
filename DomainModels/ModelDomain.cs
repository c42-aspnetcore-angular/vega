using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace asp.net_core_angular.DomainModels
{
    [Table("Models")]
    public class Model
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]        
        public string Name { get; set; }

        public Make Make { get; set; }

        public int MakeId { get; set; }
    }
}
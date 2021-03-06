using System.ComponentModel.DataAnnotations;

namespace asp.net_core_angular.Controllers.Resources
{
    public class ContactResource
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [StringLength(255)]
        public string Email { get; set; }
        
        [Required]
        [StringLength(255)]
        public string Phone { get; set; }
    }
}
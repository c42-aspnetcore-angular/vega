using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace asp.net_core_angular.DomainModels
{
    [Table("Vehicles")]
    public class Vehicle
    {
        public int Id { get; set; }

        public Model Model {get; set;}

        public int ModelId { get; set; }

        [Required]
        [StringLength(255)]
        public string ContactName { get; set; }

        [StringLength(255)]
        public string ContactEmail { get; set; }

        [Required]
        [StringLength(255)]
        public string ContactPhone { get; set; }

        public DateTime LastUpdate { get; set; }
    }
}
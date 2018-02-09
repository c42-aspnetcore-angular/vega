using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace asp.net_core_angular.ResourceModels
{
    public class VehicleResource
    {
        public int Id { get; set; }

        public ModelResource Model { get; set; }

        public int ModelId { get; set; }

        public bool IsRegistered { get; set; }
        
        [Required]
        public ContactResource Contact { get; set; }

        public ICollection<int> Features { get; set; }

        public VehicleResource()
        {
            this.Features = new Collection<int>();
        }
    }
}
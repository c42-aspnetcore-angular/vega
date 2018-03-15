using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using asp.net_core_angular.ResourceModels;

namespace asp.net_core_angular.ResourceModels
{
    public class VehicleResource
    {
        public int Id { get; set; }

        public KeyValuePairResource Model { get; set; }

        public KeyValuePairResource Make { get; set; }

        public bool IsRegistered { get; set; }

        public ContactResource Contact { get; set; }

        public DateTime LastUpdate { get; set; }

        public ICollection<KeyValuePairResource> Features { get; set; }

        public VehicleResource()
        {
            this.Features = new Collection<KeyValuePairResource>();
        }
    }
}
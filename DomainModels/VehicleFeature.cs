using System.ComponentModel.DataAnnotations.Schema;

namespace asp.net_core_angular.DomainModels
{
    [Table("VehicleFeature")]
    public class VehicleFeature
    {
        public VehicleDomain Vehicle { get; set; }
        public FeatureDomain Feature { get; set; }
        public int VehicleId { get; set; }
        public int FeatureId { get; set; }
    }
}
namespace asp.net_core_angular.ResourceModels
{
    public class VehicleResource
    {
        public int Id { get; set; }

        public ModelResource Model {get; set;}

        public int ModelId { get; set; }

        public string ContactName { get; set; }

        public string ContactPhone { get; set; }
    }
}
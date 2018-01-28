namespace asp.net_core_angular.DomainModels
{
    public class ModelDomain
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public MakeDomain Make { get; set; }

        public int MakeId { get; set; }
    }
}
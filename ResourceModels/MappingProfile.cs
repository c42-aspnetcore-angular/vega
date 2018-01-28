using System.Collections.Generic;

using AutoMapper;

using asp.net_core_angular.DomainModels;

namespace asp.net_core_angular.ResourceModels
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap();
        }

        private void CreateMap()
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<FeatureDomain, Feature>();
                cfg.CreateMap<IEnumerable<FeatureDomain>, IEnumerable<Feature>>();
                cfg.CreateMap<MakeDomain, Make>();
                cfg.CreateMap<ModelDomain, Model>();
            });
        }
    }
}
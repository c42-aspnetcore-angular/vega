using System.Collections.Generic;

using AutoMapper;

using asp.net_core_angular.DomainModels;

namespace asp.net_core_angular.ResourceModels
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Make, Make>();
            CreateMap<Model, ModelResource>();
            CreateMap<Feature, Feature>();
            CreateMap<Vehicle, VehicleResource>();
            CreateMap<VehicleResource, Vehicle>();
        }
    }
}
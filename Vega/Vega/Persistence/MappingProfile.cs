using AutoMapper;
using Vega.Models;
using Vega.Models.ModelResources;

namespace Vega.Persistence{
    public class MappingProfile : Profile{
        public MappingProfile(){
            CreateMap<Brand, BrandResource>();
            CreateMap<Model, ModelResource>();
            CreateMap<Feature, FeatureResource>();
/*

            CreateMap<BrandResource, Brand>()
                .ForMember(b => b.Id, opt => opt.Ignore());
            
            CreateMap<ModelResource, Model>()
                .ForMember(b => b.Id, opt => opt.Ignore());
            
            CreateMap<FeatureResource, Feature>()
                .ForMember(b => b.Id, opt => opt.Ignore());*/
        }
    }
}
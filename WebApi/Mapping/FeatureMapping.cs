using AutoMapper;
using Dto.FeatureDto;
using Entities.Concrete;

namespace WebApi.Mapping;

public class FeatureMapping : Profile
{
    public FeatureMapping()
    {
        CreateMap<Feature, CreateFeatureDto>().ReverseMap();
        CreateMap<Feature, ResultFeatureDto>().ReverseMap();
        CreateMap<Feature, UpdateFeatureDto>().ReverseMap();
        CreateMap<Feature, GetFeatureDto>().ReverseMap();
    }
}
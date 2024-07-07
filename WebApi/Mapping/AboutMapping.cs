using AutoMapper;
using Dto.AboutDto;
using Entities.Concrete;

namespace WebApi.Mapping;

public class AboutMapping : Profile
{
    public AboutMapping()
    {
        CreateMap<About, CreateAboutDto>().ReverseMap();
        CreateMap<About, ResultAboutDto>().ReverseMap();
        CreateMap<About, UpdateAboutDto>().ReverseMap();
        CreateMap<About, GetAboutDto>().ReverseMap();
    }
}
using AutoMapper;
using Dto.FooterDto;
using Entities.Concrete;

namespace WebApi.Mapping;

public class FooterMapping : Profile
{
    public FooterMapping()
    {
        CreateMap<Footer, CreateFooterDto>().ReverseMap();
        CreateMap<Footer, ResultFooterDto>().ReverseMap();
        CreateMap<Footer, UpdateFooterDto>().ReverseMap();
        CreateMap<Footer, GetFooterDto>().ReverseMap();
    }
}
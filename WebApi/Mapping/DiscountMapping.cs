using AutoMapper;
using Dto.DiscountDto;
using Entities.Concrete;

namespace WebApi.Mapping;

public class DiscountMapping : Profile
{
    public DiscountMapping()
    {
        CreateMap<Discount, CreateDiscountDto>().ReverseMap();
        CreateMap<Discount, ResultDiscountDto>().ReverseMap();
        CreateMap<Discount, UpdateDiscountDto>().ReverseMap();
        CreateMap<Discount, GetDiscountDto>().ReverseMap();
    }
}
using AutoMapper;
using Dto.CategoryDto;
using Entities.Concrete;

namespace WebApi.Mapping;

public class CategoryMapping : Profile
{
    public CategoryMapping()
    {
        CreateMap<Category, CreateCategoryDto>().ReverseMap();
        CreateMap<Category, ResultCategoryDto>().ReverseMap();
        CreateMap<Category, UpdateCategoryDto>().ReverseMap();
        CreateMap<Category, GetCategoryDto>().ReverseMap();
    }
}
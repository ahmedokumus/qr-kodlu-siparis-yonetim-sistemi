using AutoMapper;
using Dto.ProductDto;
using Entities.Concrete;

namespace WebApi.Mapping;

public class ProductMapping : Profile
{
    public ProductMapping()
    {
        CreateMap<Product, CreateProductDto>().ReverseMap();
        CreateMap<Product, ResultProductDto>().ReverseMap();
        CreateMap<Product, UpdateProductDto>().ReverseMap();
        CreateMap<Product, GetProductDto>().ReverseMap();
        CreateMap<Product, ProductsWithCategoriesDto>().ReverseMap();
    }
}
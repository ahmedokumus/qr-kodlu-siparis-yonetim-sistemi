using AutoMapper;
using Business.Abstract;
using Dto.CategoryDto;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using WebApi.Controllers.Common;

namespace WebApi.Controllers;

public class CategoryController : BaseController<ICategoryService, Category, ResultCategoryDto, CreateCategoryDto, UpdateCategoryDto>
{
    public CategoryController(ICategoryService categoryService, IMapper mapper) : base(categoryService, mapper)
    {
    }
}
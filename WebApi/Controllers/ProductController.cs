using AutoMapper;
using Business.Abstract;
using Core.Entities;
using Dto.ProductDto;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using WebApi.Controllers.Common;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]

public class ProductController : BaseController<IProductService, Product, ResultProductDto, CreateProductDto, UpdateProductDto>
{
    private new readonly IProductService _service;
    private new readonly IMapper _mapper;
    public ProductController(IProductService service, IMapper mapper) : base(service, mapper)
    {
        _service = service;
        _mapper = mapper;
    }

    [HttpGet("WithCategories")]
    public IActionResult GetProductsWithCategories()
    {
        var result = _service.GetProductsWithCategories();
        return result.Success ? Ok(result) : BadRequest(result);
    }
}
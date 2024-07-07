using AutoMapper;
using Core.Entities;
using Core.Utilities.Business;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers.Common;

[Route("api/[controller]")]
[ApiController]

public class BaseController<TIService, TEntity, TGetDto, TCreateDto, TUpdateDto> : Controller
    where TIService : IServiceBase<TEntity>
    where TEntity : class, IEntity, new()
    where TGetDto : class
    where TCreateDto : class
    where TUpdateDto : class
{
    protected readonly TIService _service;
    protected readonly IMapper _mapper;

    public BaseController(TIService service, IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult Create(TCreateDto createDto)
    {
        TEntity entity = _mapper.Map<TEntity>(createDto);
        var result = _service.Add(entity);
        return result.Success ? Ok(result) : BadRequest(result);
    }

    [HttpPut]
    public IActionResult Update(TUpdateDto updateDto)
    {
        TEntity entity = _mapper.Map<TEntity>(updateDto);
        var result = _service.Update(entity);
        return result.Success ? Ok(result) : BadRequest(result);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        var data = _service.GetById(id);
        var result = _service.Delete(data.Data!);
        return result.Success ? Ok(result) : BadRequest(result);
    }

    [HttpGet]
    public IActionResult Get()
    {
        var result = _service.GetAll();
        return result.Success ? Ok(result) : BadRequest(result);
    }

    [HttpGet("{id}")]
    public virtual IActionResult GetById(Guid id)
    {
        var result = _service.GetById(id);
        return result.Success ? Ok(result) : BadRequest(result);
    }
}
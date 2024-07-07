using AutoMapper;
using Business.Abstract;
using Dto.AboutDto;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using WebApi.Controllers.Common;

namespace WebApi.Controllers;

public class AboutController : BaseController<IAboutService, About, ResultAboutDto, CreateAboutDto, UpdateAboutDto>
{
    public AboutController(IAboutService service, IMapper mapper) : base(service, mapper)
    {
    }
}
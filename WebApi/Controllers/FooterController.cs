using AutoMapper;
using Business.Abstract;
using Dto.FooterDto;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using WebApi.Controllers.Common;

namespace WebApi.Controllers;

public class FooterController : BaseController<IFooterService, Footer, ResultFooterDto, CreateFooterDto, UpdateFooterDto>
{
    public FooterController(IFooterService service, IMapper mapper) : base(service, mapper)
    {
    }
}
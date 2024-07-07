using AutoMapper;
using Business.Abstract;
using Dto.DiscountDto;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using WebApi.Controllers.Common;

namespace WebApi.Controllers;

public class DiscountController : BaseController<IDiscountService, Discount, ResultDiscountDto, CreateDiscountDto, UpdateDiscountDto>
{
    public DiscountController(IDiscountService service, IMapper mapper) : base(service, mapper)
    {
    }
}
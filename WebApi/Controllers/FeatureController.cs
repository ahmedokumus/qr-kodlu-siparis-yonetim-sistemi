using AutoMapper;
using Business.Abstract;
using Dto.FeatureDto;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using WebApi.Controllers.Common;

namespace WebApi.Controllers;

public class FeatureController : BaseController<IFeatureService, Feature, ResultFeatureDto, CreateFeatureDto, UpdateFeatureDto>
{
    public FeatureController(IFeatureService service, IMapper mapper) : base(service, mapper)
    {
    }
}
using AutoMapper;
using Business.Abstract;
using Dto.TestimonialDto;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using WebApi.Controllers.Common;

namespace WebApi.Controllers;

public class TestimonialController : BaseController<ITestimonialService, Testimonial, ResultTestimonialDto, CreateTestimonialDto, UpdateTestimonialDto>
{
    public TestimonialController(ITestimonialService service, IMapper mapper) : base(service, mapper)
    {
    }
}
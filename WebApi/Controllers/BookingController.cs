using AutoMapper;
using Business.Abstract;
using Dto.BookingDto;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using WebApi.Controllers.Common;

namespace WebApi.Controllers;

public class BookingController : BaseController<IBookingService, Booking, ResultBookingDto, CreateBookingDto, UpdateBookingDto>
{
    public BookingController(IBookingService service, IMapper mapper) : base(service, mapper)
    {
    }
}
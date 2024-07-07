using AutoMapper;
using Dto.BookingDto;
using Entities.Concrete;

namespace WebApi.Mapping;

public class BookingMapping : Profile
{
    public BookingMapping()
    {
        CreateMap<Booking, CreateBookingDto>().ReverseMap();
        CreateMap<Booking, ResultBookingDto>().ReverseMap();
        CreateMap<Booking, UpdateBookingDto>().ReverseMap();
        CreateMap<Booking, GetBookingDto>().ReverseMap();
    }
}
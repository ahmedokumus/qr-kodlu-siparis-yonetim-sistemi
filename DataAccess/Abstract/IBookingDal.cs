using Core.DataAccess;
using Dto.BookingDto;
using Entities.Concrete;

namespace DataAccess.Abstract;

public interface IBookingDal : IEntityRepository<Booking>
{
    
}
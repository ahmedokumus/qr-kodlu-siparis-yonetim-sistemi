using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Dto.BookingDto;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework;

public class EfBookingDal : EfEntityRepositoryBase<Booking, EfContext>, IBookingDal
{
    public EfBookingDal(EfContext context) : base(context)
    {
    }
}
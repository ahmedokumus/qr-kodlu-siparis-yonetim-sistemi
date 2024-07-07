using Business.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class BookingManager : IBookingService
{
    private readonly IBookingDal _bookingDal;

    public BookingManager(IBookingDal bookingDal)
    {
        _bookingDal = bookingDal;
    }

    public IDataResult<List<Booking>> GetAll()
    {
        var data = _bookingDal.GetAll();
        return new SuccessDataResult<List<Booking>>(data);
    }

    public IDataResult<Booking?> GetById(Guid entityId)
    {
        var data = _bookingDal.Get(x => x.Id == entityId);
        return new SuccessDataResult<Booking?>(data);
    }

    public IResult Add(Booking entity)
    {
        _bookingDal.Add(entity);
        return new SuccessResult();
    }

    public IResult Update(Booking entity)
    {
        _bookingDal.Update(entity);
        return new SuccessResult();
    }

    public IResult Delete(Booking entity)
    {
        _bookingDal.Delete(entity);
        return new SuccessResult();
    }
}
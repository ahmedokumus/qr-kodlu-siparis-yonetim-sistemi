using Business.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class DiscountManager : IDiscountService
{
    private readonly IDiscountDal _discountDal;

    public DiscountManager(IDiscountDal discountDal)
    {
        _discountDal = discountDal;
    }

    public IDataResult<List<Discount>> GetAll()
    {
        var data = _discountDal.GetAll();
        return new SuccessDataResult<List<Discount>>(data);
    }

    public IDataResult<Discount?> GetById(Guid entityId)
    {
        var data = _discountDal.Get(x => x.Id == entityId);
        return new SuccessDataResult<Discount?>(data);
    }

    public IResult Add(Discount entity)
    {
        _discountDal.Add(entity);
        return new SuccessResult();
    }

    public IResult Update(Discount entity)
    {
        _discountDal.Update(entity);
        return new SuccessResult();
    }

    public IResult Delete(Discount entity)
    {
        _discountDal.Delete(entity);
        return new SuccessResult();
    }
}
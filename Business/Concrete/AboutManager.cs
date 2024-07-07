using Business.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class AboutManager : IAboutService
{
    private readonly IAboutDal _aboutDal;

    public AboutManager(IAboutDal aboutDal)
    {
        _aboutDal = aboutDal;
    }

    public IDataResult<List<About>> GetAll()
    {
        List<About> data = _aboutDal.GetAll();
        return new SuccessDataResult<List<About>>(data);
    }

    public IDataResult<About?> GetById(Guid entityId)
    {
        About? data = _aboutDal.Get(x => x.Id == entityId);
        return new SuccessDataResult<About?>(data);
    }

    public IResult Add(About entity)
    {
        _aboutDal.Add(entity);
        return new SuccessResult();
    }

    public IResult Update(About entity)
    {
        _aboutDal.Update(entity);
        return new SuccessResult();
    }

    public IResult Delete(About entity)
    {
        _aboutDal.Delete(entity);
        return new SuccessResult();
    }
}
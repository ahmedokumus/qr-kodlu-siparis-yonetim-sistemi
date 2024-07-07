using Business.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class FooterManager : IFooterService
{
    private readonly IFooterDal _footerDal;

    public FooterManager(IFooterDal footerDal)
    {
        _footerDal = footerDal;
    }

    public IDataResult<List<Footer>> GetAll()
    {
        var data = _footerDal.GetAll();
        return new SuccessDataResult<List<Footer>>(data);
    }

    public IDataResult<Footer?> GetById(Guid entityId)
    {
        var data = _footerDal.Get(x => x.Id == entityId);
        return new SuccessDataResult<Footer?>(data);
    }

    public IResult Add(Footer entity)
    {
        _footerDal.Add(entity);
        return new SuccessResult();
    }

    public IResult Update(Footer entity)
    {
        _footerDal.Update(entity);
        return new SuccessResult();
    }

    public IResult Delete(Footer entity)
    {
        _footerDal.Delete(entity);
        return new SuccessResult();
    }
}
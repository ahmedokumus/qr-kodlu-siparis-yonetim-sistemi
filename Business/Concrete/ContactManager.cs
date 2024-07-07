using Business.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class ContactManager : IContactService
{
    private readonly IContactDal _contactDal;

    public ContactManager(IContactDal contactDal)
    {
        _contactDal = contactDal;
    }

    public IDataResult<List<Contact>> GetAll()
    {
        var data = _contactDal.GetAll();
        return new SuccessDataResult<List<Contact>>(data);
    }

    public IDataResult<Contact?> GetById(Guid entityId)
    {
        var data = _contactDal.Get(x => x.Id == entityId);
        return new SuccessDataResult<Contact?>(data);
    }

    public IResult Add(Contact entity)
    {
        _contactDal.Add(entity);
        return new SuccessResult();
    }

    public IResult Update(Contact entity)
    {
        _contactDal.Update(entity);
        return new SuccessResult();
    }

    public IResult Delete(Contact entity)
    {
        _contactDal.Delete(entity);
        return new SuccessResult();
    }
}
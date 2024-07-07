using Business.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class CategoryManager : ICategoryService
{
    private readonly ICategoryDal _categoryDal;

    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }

    public IDataResult<List<Category>> GetAll()
    {
        var data = _categoryDal.GetAll();
        return new SuccessDataResult<List<Category>>(data);
    }

    public IDataResult<Category?> GetById(Guid entityId)
    {
        var data = _categoryDal.Get(x => x.Id == entityId);
        return new SuccessDataResult<Category?>(data);
    }

    public IResult Add(Category entity)
    {
        _categoryDal.Add(entity);
        return new SuccessResult();
    }

    public IResult Update(Category entity)
    {
        _categoryDal.Update(entity);
        return new SuccessResult();
    }

    public IResult Delete(Category entity)
    {
        _categoryDal.Delete(entity);
        return new SuccessResult();
    }
}
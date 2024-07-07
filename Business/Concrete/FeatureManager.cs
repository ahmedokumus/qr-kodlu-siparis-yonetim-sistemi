using Business.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class FeatureManager : IFeatureService
{
    private readonly IFeatureDal _featureDal;

    public FeatureManager(IFeatureDal featureDal)
    {
        _featureDal = featureDal;
    }

    public IDataResult<List<Feature>> GetAll()
    {
        var data = _featureDal.GetAll();
        return new SuccessDataResult<List<Feature>>(data);
    }

    public IDataResult<Feature?> GetById(Guid entityId)
    {
        var data = _featureDal.Get(x => x.Id == entityId);
        return new SuccessDataResult<Feature?>(data);
    }

    public IResult Add(Feature entity)
    {
        _featureDal.Add(entity);
        return new SuccessResult();
    }

    public IResult Update(Feature entity)
    {
        _featureDal.Update(entity);
        return new SuccessResult();
    }

    public IResult Delete(Feature entity)
    {
        _featureDal.Delete(entity);
        return new SuccessResult();
    }
}
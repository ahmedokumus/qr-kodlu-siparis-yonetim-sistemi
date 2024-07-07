using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Dto.FeatureDto;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework;

public class EfFeatureDal : EfEntityRepositoryBase<Feature, EfContext>, IFeatureDal
{
    public EfFeatureDal(EfContext context) : base(context)
    {
    }
}
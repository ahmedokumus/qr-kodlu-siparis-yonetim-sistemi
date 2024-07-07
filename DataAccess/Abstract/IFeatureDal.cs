using Core.DataAccess;
using Dto.FeatureDto;
using Entities.Concrete;

namespace DataAccess.Abstract;

public interface IFeatureDal : IEntityRepository<Feature>
{
    
}
using Core.DataAccess;
using Dto.CategoryDto;
using Entities.Concrete;

namespace DataAccess.Abstract;

public interface ICategoryDal : IEntityRepository<Category>
{
    
}
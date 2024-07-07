using Core.DataAccess;
using Dto.AboutDto;
using Entities.Concrete;

namespace DataAccess.Abstract;

public interface IAboutDal : IEntityRepository<About>
{
    
}
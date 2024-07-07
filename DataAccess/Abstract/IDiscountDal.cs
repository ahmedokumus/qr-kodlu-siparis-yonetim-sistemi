using Core.DataAccess;
using Dto.DiscountDto;
using Entities.Concrete;

namespace DataAccess.Abstract;

public interface IDiscountDal : IEntityRepository<Discount>
{
    
}
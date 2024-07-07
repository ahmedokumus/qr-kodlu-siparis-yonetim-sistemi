using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Dto.DiscountDto;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework;

public class EfDiscountDal : EfEntityRepositoryBase<Discount, EfContext>, IDiscountDal
{
    public EfDiscountDal(EfContext context) : base(context)
    {
    }
}
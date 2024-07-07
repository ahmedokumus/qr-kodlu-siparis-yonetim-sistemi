using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Dto.AboutDto;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework;

public class EfAboutDal : EfEntityRepositoryBase<About, EfContext>, IAboutDal
{
    public EfAboutDal(EfContext context) : base(context)
    {
    }
}
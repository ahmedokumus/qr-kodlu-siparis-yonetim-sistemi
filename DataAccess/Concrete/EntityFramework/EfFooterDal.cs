using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Dto.FeatureDto;
using Dto.FooterDto;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework;

public class EfFooterDal : EfEntityRepositoryBase<Footer, EfContext>, IFooterDal
{
    public EfFooterDal(EfContext context) : base(context)
    {
    }
}
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Dto.CategoryDto;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework;

public class EfCategoryDal : EfEntityRepositoryBase<Category, EfContext>, ICategoryDal
{
    public EfCategoryDal(EfContext context) : base(context)
    {
    }
}
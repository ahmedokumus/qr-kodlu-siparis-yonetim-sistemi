using Core.DataAccess;
using Dto.ProductDto;
using Entities.Concrete;
using System.Linq.Expressions;

namespace DataAccess.Abstract;

public interface IProductDal : IEntityRepository<Product>
{
    List<ProductsWithCategoriesDto> GetProductsWithCategories(Expression<Func<Product, bool>>? filter = null, bool tracking = true);
}
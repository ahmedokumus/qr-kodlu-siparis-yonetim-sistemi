using Core.Utilities.Business;
using Core.Utilities.Results.Abstract;
using Dto.ProductDto;
using Entities.Concrete;

namespace Business.Abstract;

public interface IProductService : IServiceBase<Product>
{
    IDataResult<List<ProductsWithCategoriesDto>> GetProductsWithCategories();
}
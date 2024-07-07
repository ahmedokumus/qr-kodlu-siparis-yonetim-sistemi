using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Dto.ProductDto;
using Entities.Concrete;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework;

public class EfProductDal : EfEntityRepositoryBase<Product, EfContext>, IProductDal
{
    private readonly EfContext _context;
    public EfProductDal(EfContext context) : base(context)
    {
        _context = context;
    }

    public List<ProductsWithCategoriesDto> GetProductsWithCategories(Expression<Func<Product, bool>>? filter = null, bool tracking = true)
    {
        var result =
            from product in _context.Products
            join category in _context.Categories
                on product.CategoryId equals category.Id
            select new ProductsWithCategoriesDto()
            {
                Id = product.Id,
                ProductName = product.ProductName,
                CategoryName = category.Name,
                ProductDescription = product.ProductDescription,
                ProductPrice = product.ProductPrice,
                ProductImageUrl = product.ProductImageUrl,
                Status = product.Status,
                CreatedDate = product.CreatedDate,
                UpdatedDate = product.UpdatedDate
            };

        return result.ToList();
    }
}
using Business.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Dto.ProductDto;
using Entities.Concrete;

namespace Business.Concrete;

public class ProductManager : IProductService
{
    private readonly IProductDal _productDal;

    public ProductManager(IProductDal productDal)
    {
        _productDal = productDal;
    }

    public IDataResult<List<Product>> GetAll()
    {
        var data = _productDal.GetAll();
        return new SuccessDataResult<List<Product>>(data);
    }

    public IDataResult<Product?> GetById(Guid entityId)
    {
        var data = _productDal.Get(x => x.Id == entityId);
        return new SuccessDataResult<Product?>(data);
    }

    public IResult Add(Product entity)
    {
        _productDal.Add(entity);
        return new SuccessResult();
    }

    public IResult Update(Product entity)
    {
        _productDal.Update(entity);
        return new SuccessResult();
    }

    public IResult Delete(Product entity)
    {
        _productDal.Delete(entity);
        return new SuccessResult();
    }

    public IDataResult<List<ProductsWithCategoriesDto>> GetProductsWithCategories()
    {
        var datas = _productDal.GetProductsWithCategories();
        return new SuccessDataResult<List<ProductsWithCategoriesDto>>(datas);
    }
}
using Core.Entities;
using Dto.Common;

namespace Dto.ProductDto;

public class ProductsWithCategoriesDto : BaseDto<Guid>, IDto
{
    public string ProductName { get; set; }
    public string CategoryName { get; set; }
    public string ProductDescription { get; set; }
    public decimal ProductPrice { get; set; }
    public string ProductImageUrl { get; set; }
    public bool Status { get; set; }
}
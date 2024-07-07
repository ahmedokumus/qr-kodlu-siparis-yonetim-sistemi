using Core.Entities;
using Dto.Common;

namespace Dto.ProductDto;

public class ResultProductDto : BaseDto<Guid>, IDto
{
    public string ProductName { get; set; }
    public string ProductDescription { get; set; }
    public decimal ProductPrice { get; set; }
    public string ProductImageUrl { get; set; }
    public bool Status { get; set; }
}
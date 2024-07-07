using Core.Entities;
using Dto.Common;

namespace Dto.DiscountDto;

public class GetDiscountDto : BaseDto<Guid>, IDto
{
    public string Title { get; set; }
    public string Amount { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
}
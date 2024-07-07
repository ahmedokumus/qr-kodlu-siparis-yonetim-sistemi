using Core.Entities;

namespace Dto.DiscountDto;

public class CreateDiscountDto : IDto
{
    public string Title { get; set; }
    public string Amount { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
}
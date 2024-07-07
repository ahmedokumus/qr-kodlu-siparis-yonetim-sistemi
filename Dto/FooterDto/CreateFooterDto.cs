using Core.Entities;

namespace Dto.FooterDto;

public class CreateFooterDto : IDto
{
    public string Title { get; set; }
    public string Url { get; set; }
    public string Icon { get; set; }
}
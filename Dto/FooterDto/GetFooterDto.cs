using Core.Entities;
using Dto.Common;

namespace Dto.FooterDto;

public class GetFooterDto : BaseDto<Guid>, IDto
{
    public string Title { get; set; }
    public string Url { get; set; }
    public string Icon { get; set; }
}
using Core.Entities;
using Dto.Common;

namespace Dto.FooterDto;

public class ResultFooterDto : BaseDto<Guid>, IDto
{
    public string Title { get; set; }
    public string Url { get; set; }
    public string Icon { get; set; }
}
using Core.Entities;
using Dto.Common;

namespace Dto.AboutDto;

public class GetAboutDto : BaseDto<Guid>, IDto
{
    public string AboutImageUrl { get; set; }
    public string AboutTitle { get; set; }
    public string AboutDescription { get; set; }
}
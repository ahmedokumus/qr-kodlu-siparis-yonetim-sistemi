using Core.Entities;
using Dto.Common;

namespace Dto.AboutDto;

public class ResultAboutDto : BaseDto<Guid>, IDto
{
    public string AboutImageUrl { get; set; }
    public string AboutTitle { get; set; }
    public string AboutDescription { get; set; }
}
using Core.Entities;

namespace Dto.AboutDto;

public class CreateAboutDto : IDto
{
    public string AboutImageUrl { get; set; }
    public string AboutTitle { get; set; }
    public string AboutDescription { get; set; }
}
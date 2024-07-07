using Core.Entities;

namespace Dto.AboutDto;

public class UpdateAboutDto : IDto
{
    public Guid Id { get; set; }
    public string AboutImageUrl { get; set; }
    public string AboutTitle { get; set; }
    public string AboutDescription { get; set; }
}
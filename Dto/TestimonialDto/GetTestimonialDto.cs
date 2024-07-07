using Core.Entities;
using Dto.Common;

namespace Dto.TestimonialDto;

public class GetTestimonialDto : BaseDto<Guid>, IDto
{
    public string Name { get; set; }
    public string Title { get; set; }
    public string Comment { get; set; }
    public string ImageUrl { get; set; }
    public bool Status { get; set; }
}
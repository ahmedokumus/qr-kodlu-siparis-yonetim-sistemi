using Core.Entities;
using Dto.Common;

namespace Dto.CategoryDto;

public class GetCategoryDto : BaseDto<Guid>, IDto
{
    public string Name { get; set; }
    public bool Status { get; set; }
}

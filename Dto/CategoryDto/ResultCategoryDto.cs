using Core.Entities;
using Dto.Common;

namespace Dto.CategoryDto;

public class ResultCategoryDto : BaseDto<Guid>, IDto
{
    public string Name { get; set; }
    public bool Status { get; set; }
}
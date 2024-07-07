using Core.Entities;
using Dto.Common;

namespace Dto.CategoryDto;

public class UpdateCategoryDto : IDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public bool Status { get; set; }
}
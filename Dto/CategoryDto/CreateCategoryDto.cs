using Core.Entities;

namespace Dto.CategoryDto;

public class CreateCategoryDto : IDto
{
    public string Name { get; set; }
    public bool Status { get; set; }
}
using Core.Entities;
using Dto.Common;

namespace Dto.FooterDto;

public class UpdateFooterDto : IDto
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Url { get; set; }
    public string Icon { get; set; }
}
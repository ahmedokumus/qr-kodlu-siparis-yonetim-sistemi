using Core.Entities;
using Dto.Common;

namespace Dto.FeatureDto;

public class UpdateFeatureDto : IDto
{
    public Guid Id { get; set; }

    public string TitelOne { get; set; }
    public string DescriptionOne { get; set; }

    public string TitelTwo { get; set; }
    public string DescriptionTwo { get; set; }

    public string TitelThree { get; set; }
    public string DescriptionThree { get; set; }
}
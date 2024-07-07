using Core.Entities;

namespace Dto.FeatureDto;

public class CreateFeatureDto : IDto
{
    public string TitelOne { get; set; }
    public string DescriptionOne { get; set; }

    public string TitelTwo { get; set; }
    public string DescriptionTwo { get; set; }

    public string TitelThree { get; set; }
    public string DescriptionThree { get; set; }
}
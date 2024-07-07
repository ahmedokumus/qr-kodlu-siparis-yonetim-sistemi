using Core.Entities;
using Entities.Concrete.Common;

namespace Entities.Concrete;

public class Feature : BaseEntity<Guid>, IEntity
{
    public string TitelOne { get; set; }
    public string DescriptionOne { get; set; }

    public string TitelTwo { get; set; }
    public string DescriptionTwo { get; set; }
    
    public string TitelThree { get; set; }
    public string DescriptionThree { get; set; }
}
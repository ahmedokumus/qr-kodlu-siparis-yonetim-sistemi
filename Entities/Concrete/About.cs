using Core.Entities;
using Entities.Concrete.Common;

namespace Entities.Concrete;

public class About : BaseEntity<Guid>, IEntity
{
    public string AboutImageUrl { get; set; }
    public string AboutTitle { get; set; }
    public string AboutDescription { get; set; }
}
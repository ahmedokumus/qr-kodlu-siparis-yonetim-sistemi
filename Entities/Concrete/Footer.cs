using Core.Entities;
using Entities.Concrete.Common;

namespace Entities.Concrete;

public class Footer : BaseEntity<Guid>, IEntity
{
    public string Title { get; set; }
    public string Url { get; set; }
    public string Icon { get; set; }
}
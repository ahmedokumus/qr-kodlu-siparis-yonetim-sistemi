using Core.Entities;
using Entities.Concrete.Common;

namespace Entities.Concrete;

public class Discount : BaseEntity<Guid>, IEntity
{
    public string Title { get; set; }
    public string Amount { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
}
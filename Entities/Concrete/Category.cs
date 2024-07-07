using Core.Entities;
using Entities.Concrete.Common;

namespace Entities.Concrete;

public class Category : BaseEntity<Guid>, IEntity
{
    public string Name { get; set; }
    public bool Status { get; set; }

    public List<Product> Products { get; set; }
}
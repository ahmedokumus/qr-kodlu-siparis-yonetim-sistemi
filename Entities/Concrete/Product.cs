using System.Reflection.PortableExecutable;
using Core.Entities;
using Entities.Concrete.Common;

namespace Entities.Concrete;

public class Product : BaseEntity<Guid>, IEntity
{
    public string ProductName { get; set; }
    public string ProductDescription { get; set; }
    public decimal ProductPrice { get; set; }
    public string ProductImageUrl { get; set; }
    public bool Status { get; set; }

    public Guid CategoryId { get; set; }
    public virtual Category? Category { get; set; }
}
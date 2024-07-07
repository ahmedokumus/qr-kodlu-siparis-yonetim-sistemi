using Core.Entities;

namespace Entities.Concrete.Common;

public class BaseEntity<TId> : IEntity
{
    public TId Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public DateTime? DeletedDate { get; set; }
}
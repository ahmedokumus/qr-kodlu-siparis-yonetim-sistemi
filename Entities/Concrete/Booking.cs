using Core.Entities;
using Entities.Concrete.Common;

namespace Entities.Concrete;

public class Booking : BaseEntity<Guid>, IEntity
{
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Mail { get; set; }
    public int PersonCount { get; set; }
    public DateTime Date { get; set; }
}
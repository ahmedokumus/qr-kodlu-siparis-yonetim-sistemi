using Core.Entities;
using Entities.Concrete.Common;

namespace Entities.Concrete;

public class Testimonial : BaseEntity<Guid>, IEntity
{
    public string Name { get; set; }
    public string Title { get; set; }
    public string Comment { get; set; }
    public string ImageUrl { get; set; }
    public bool Status { get; set; }
}
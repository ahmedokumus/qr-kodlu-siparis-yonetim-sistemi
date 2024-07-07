using Core.Entities;
using Entities.Concrete.Common;

namespace Entities.Concrete;

public class Contact : BaseEntity<Guid>, IEntity
{
    public string Location { get; set; }
    public string PhoneNumber { get; set; }
    public string MailAddress { get; set; }
}
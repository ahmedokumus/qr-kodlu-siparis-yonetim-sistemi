using Core.Entities;

namespace Dto.ContactDto;

public class UpdateContactDto : IDto
{
    public Guid Id { get; set; }
    public string Location { get; set; }
    public string PhoneNumber { get; set; }
    public string MailAddress { get; set; }
}
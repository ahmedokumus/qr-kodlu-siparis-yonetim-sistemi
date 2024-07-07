using Core.Entities;

namespace Dto.ContactDto;

public class CreateContactDto : IDto
{
    public string Location { get; set; }
    public string PhoneNumber { get; set; }
    public string MailAddress { get; set; }
}
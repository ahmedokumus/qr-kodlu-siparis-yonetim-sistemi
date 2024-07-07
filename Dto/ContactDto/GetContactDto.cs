using Core.Entities;
using Dto.Common;

namespace Dto.ContactDto;

public class GetContactDto : BaseDto<Guid>, IDto
{
    public string Location { get; set; }
    public string PhoneNumber { get; set; }
    public string MailAddress { get; set; }
}

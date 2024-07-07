using Core.Entities;
using Dto.Common;

namespace Dto.BookingDto;

public class GetBookingDto : BaseDto<Guid>, IDto
{
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Mail { get; set; }
    public int PersonCount { get; set; }
    public DateTime Date { get; set; }
}
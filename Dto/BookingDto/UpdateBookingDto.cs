using Core.Entities;
using Dto.Common;

namespace Dto.BookingDto;

public class UpdateBookingDto : IDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Mail { get; set; }
    public int PersonCount { get; set; }
    public DateTime Date { get; set; }
}
using Core.Entities;

namespace Dto.Common;

public class BaseDto<TId> : IDto
{
    public TId Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }
    //public DateTime? DeletedDate { get; set; }
}
using Core.DataAccess;
using Dto.ContactDto;
using Entities.Concrete;

namespace DataAccess.Abstract;

public interface IContactDal : IEntityRepository<Contact>
{
    
}
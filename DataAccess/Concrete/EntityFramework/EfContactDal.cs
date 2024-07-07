using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Dto.ContactDto;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework;

public class EfContactDal : EfEntityRepositoryBase<Contact, EfContext>, IContactDal
{
    public EfContactDal(EfContext context) : base(context)
    {
    }
}
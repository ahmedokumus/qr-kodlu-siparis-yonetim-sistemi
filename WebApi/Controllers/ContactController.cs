using AutoMapper;
using Business.Abstract;
using Dto.ContactDto;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using WebApi.Controllers.Common;

namespace WebApi.Controllers;

public class ContactController : BaseController<IContactService, Contact, ResultContactDto, CreateContactDto, UpdateContactDto>
{
    public ContactController(IContactService service, IMapper mapper) : base(service, mapper)
    {
    }
}
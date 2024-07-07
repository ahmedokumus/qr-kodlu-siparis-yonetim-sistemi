using AutoMapper;
using Dto.ContactDto;
using Entities.Concrete;

namespace WebApi.Mapping;

public class ContactMapping : Profile
{
    public ContactMapping()
    {
        CreateMap<Contact, CreateContactDto>().ReverseMap();
        CreateMap<Contact, ResultContactDto>().ReverseMap();
        CreateMap<Contact, UpdateContactDto>().ReverseMap();
        CreateMap<Contact, GetContactDto>().ReverseMap();
    }
}
using Core.DataAccess;
using Dto.TestimonialDto;
using Entities.Concrete;

namespace DataAccess.Abstract;

public interface ITestimonialDal : IEntityRepository<Testimonial>
{
    
}
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Dto.TestimonialDto;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework;

public class EfTestimonialDal : EfEntityRepositoryBase<Testimonial, EfContext>, ITestimonialDal
{
    public EfTestimonialDal(EfContext context) : base(context)
    {
    }
}
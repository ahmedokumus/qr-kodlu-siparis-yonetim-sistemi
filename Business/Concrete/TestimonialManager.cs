using Business.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class TestimonialManager : ITestimonialService
{
    private readonly ITestimonialDal _testimonialDal;

    public TestimonialManager(ITestimonialDal testimonialDal)
    {
        _testimonialDal = testimonialDal;
    }

    public IDataResult<List<Testimonial>> GetAll()
    {
        var data = _testimonialDal.GetAll();
        return new SuccessDataResult<List<Testimonial>>(data);
    }

    public IDataResult<Testimonial?> GetById(Guid entityId)
    {
        var data = _testimonialDal.Get(x => x.Id == entityId);
        return new SuccessDataResult<Testimonial?>(data);
    }

    public IResult Add(Testimonial entity)
    {
        _testimonialDal.Add(entity);
        return new SuccessResult();
    }

    public IResult Update(Testimonial entity)
    {
        _testimonialDal.Update(entity);
        return new SuccessResult();
    }

    public IResult Delete(Testimonial entity)
    {
        _testimonialDal.Delete(entity);
        return new SuccessResult();
    }
}
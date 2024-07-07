using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.Extensions.DependencyInjection;

namespace Business.DependencyResolvers;

public static class ServiceRegistration
{
    public static void AddBusinessServices(this IServiceCollection services)
    {
        services.AddDbContext<EfContext>();
        services.AddScoped<IAboutService, AboutManager>();
        services.AddScoped<IAboutDal, EfAboutDal>();
        services.AddScoped<IBookingService, BookingManager>();
        services.AddScoped<IBookingDal, EfBookingDal>();
        services.AddScoped<ICategoryService, CategoryManager>();
        services.AddScoped<ICategoryDal, EfCategoryDal>();
        services.AddScoped<IContactService, ContactManager>();
        services.AddScoped<IContactDal, EfContactDal>();
        services.AddScoped<IDiscountService, DiscountManager>();
        services.AddScoped<IDiscountDal, EfDiscountDal>();
        services.AddScoped<IFeatureService, FeatureManager>();
        services.AddScoped<IFeatureDal, EfFeatureDal>();
        services.AddScoped<IFooterService, FooterManager>();
        services.AddScoped<IFooterDal, EfFooterDal>();
        services.AddScoped<IProductService, ProductManager>();
        services.AddScoped<IProductDal, EfProductDal>();
        services.AddScoped<ITestimonialService, TestimonialManager>();
        services.AddScoped<ITestimonialDal, EfTestimonialDal>();
    }
}
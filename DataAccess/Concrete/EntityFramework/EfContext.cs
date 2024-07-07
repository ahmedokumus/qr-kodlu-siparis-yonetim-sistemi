using Entities.Concrete;
using Entities.Concrete.Common;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework;

public class EfContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(Configuration.ConnectionString!);
    }

    public DbSet<About>? Abouts { get; set; }
    public DbSet<Booking>? Bookings { get; set; }
    public DbSet<Category>? Categories { get; set; }
    public DbSet<Contact>? Contacts { get; set; }
    public DbSet<Discount>? Discounts { get; set; }
    public DbSet<Feature>? Features { get; set; }
    public DbSet<Footer>? Footers { get; set; }
    public DbSet<Product>? Products { get; set; }
    public DbSet<Testimonial>? Testimonials { get; set; }

    public override int SaveChanges()
    {
        var datas = ChangeTracker.Entries<BaseEntity<Guid>>();
        foreach (var data in datas)
        {
            _ = data.State switch
            {
                EntityState.Added => data.Entity.CreatedDate = DateTime.ParseExact(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), "yyyy-MM-dd HH:mm:ss", null),
                EntityState.Modified => data.Entity.UpdatedDate = DateTime.ParseExact(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), "yyyy-MM-dd HH:mm:ss", null),
                _ => DateTime.ParseExact(DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss"), "yyyy-MM-dd HH:mm:ss", null)
            };

            if (data.State == EntityState.Modified)
            {
                data.Property("CreatedDate").IsModified = false;
            }
        }

        return base.SaveChanges();
    }
}
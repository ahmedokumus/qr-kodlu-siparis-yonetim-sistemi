using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Core.DataAccess.EntityFramework;

public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
    where TEntity : class, IEntity, new()
    where TContext : DbContext, new()
{
    private readonly TContext _context;

    public EfEntityRepositoryBase(TContext context)
    {
        _context = context;
    }

    public DbSet<TEntity> Table
        => _context.Set<TEntity>();

    public List<TEntity> GetAll(Expression<Func<TEntity, bool>>? filter = null, bool tracking = true)
    {
        if (filter == null)
        {
            IQueryable<TEntity> query = Table.AsQueryable();
            if (!tracking) query = query.AsNoTracking();

            return query.ToList();
        }
        else
        {
            IQueryable<TEntity> query = Table.Where(filter);
            if (!tracking)
                query = query.AsNoTracking();

            return query.ToList();
        }
    }

    public TEntity? Get(Expression<Func<TEntity, bool>> filter, bool tracking = true)
    {
        var query = Table.AsQueryable();
        if (!tracking)
        {
            query = Table.AsNoTracking();
        }
        return query.SingleOrDefault(filter);
    }

    public void Add(TEntity entity)
    {
        var addedEntity = Table.Add(entity);
        Save();
    }

    public void Update(TEntity entity)
    {
        var updatedEntity = Table.Update(entity);
        Save();
    }

    public void Delete(TEntity entity)
    {
        var deletedEntity = Table.Remove(entity);
        Save();
    }

    public int Save()
    {
        return _context.SaveChanges();
    }
}
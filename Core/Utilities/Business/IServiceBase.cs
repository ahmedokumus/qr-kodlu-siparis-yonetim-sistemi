using Core.Entities;
using Core.Utilities.Results.Abstract;

namespace Core.Utilities.Business;

public interface IServiceBase<T> where T : class, IEntity, new()
{
    IDataResult<List<T>> GetAll();
    IDataResult<T?> GetById(Guid entityId);
    IResult Add(T entity);
    IResult Update(T entity);
    IResult Delete(T entity);
}
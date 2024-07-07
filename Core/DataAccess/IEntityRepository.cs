﻿using System.Linq.Expressions;
using Core.Entities;

namespace Core.DataAccess;
// Generic constraint
// class : referans tip olmalı.
// IEntity : IEntity olabilir veya IEntity implamente eden bir nesne olabilir.
// new() : new'lenebilir olmalı.
public interface IEntityRepository<T> where T : class, IEntity, new()
{
    List<T> GetAll(Expression<Func<T, bool>>? filter = null, bool tracking = true);
    T? Get(Expression<Func<T, bool>> filter, bool tracking = true);
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
}
using System;
using System.Linq.Expressions;
using Entities.Abstracts;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
    //generic constraint
    //class : referans tip olabilir demek 
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}


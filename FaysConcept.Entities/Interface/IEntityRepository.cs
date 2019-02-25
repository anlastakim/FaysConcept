using System;
using System.Linq.Expressions;
using System.Data.Entity;

namespace FaysConcept.Entities.Interface
{
    public interface IEntityRepository<TContext,TEntity> 
        where TContext:DbContext,new()
        where TEntity:class,IEntity,new()

    {
        bool AddOrUpdate(TContext context, TEntity entity);

        void Delete(TContext context, Expression<Func<TEntity, bool>> filter);

        void Save(TContext context);
    }
}

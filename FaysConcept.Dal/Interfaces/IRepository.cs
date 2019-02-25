using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace FaysConcept.Dal.Interfaces
{
    public interface IRepository<T> : IDisposable where T : class
    {
        void Insert(T entity);
        // birden çok entity gönderildiğinde kayıt etmesi
        void Insert(IEnumerable<T> entities);
        void Update(T entity);
        // değişen alanlarını update etme
        void Update(T entity, IEnumerable<string> fields);
        void Update(IEnumerable<T> entities);
        void Delete(T entity);
        void Delete(IEnumerable<T> entities);
        //t türünde sorgu gönderilecek bu sorgu sonucunda true değer dönüyor ise hangi tipte veri olacağını find ile ilgili sorguda vereceğiz.
        TResult Find<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector);
        //
        IQueryable<TResult> Select<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector);
    }
}

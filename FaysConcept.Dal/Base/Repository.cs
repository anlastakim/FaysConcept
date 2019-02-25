using FaysConcept.Dal.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace FaysConcept.Dal.Base
{
    public class Repository<T> : IRepository<T> where T : class
    {
        #region Variables

        //yerel değişkenler _ile başlayacak 
        private readonly DbContext _context;
        private readonly DbSet<T> _dbset;

        #endregion

        public Repository(DbContext context)
        {
            if (context == null) return;
            _context = context;
            _dbset = _context.Set<T>();
        }


        public void Insert(T entity)
        {
            _context.Entry(entity).State = EntityState.Added;
        }

        public void Insert(IEnumerable<T> entities)
        {
            foreach (var entity in entities)
                _context.Entry(entity).State = EntityState.Added;

        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Update(T entity, IEnumerable<string> fields)
        {
            _dbset.Attach(entity);
            var entry = _context.Entry(entity);
            foreach (var field in fields)
                entry.Property(field).IsModified = true;

        }

        public void Update(IEnumerable<T> entities)
        {
            foreach (var entity in entities)
            {
                _context.Entry(entity).State = EntityState.Modified;
            }
        }


        public void Delete(T entity)
        {
            _context.Entry(entity).State = EntityState.Deleted;
        }

        public void Delete(IEnumerable<T> entities)
        {
            foreach (var entity in entities)
            {
                _context.Entry(entity).State = EntityState.Deleted;
            }
        }

        public TResult Find<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector)
        {
            return filter == null ? _dbset.Select(selector).FirstOrDefault() : _dbset.Where(filter).Select(selector).FirstOrDefault();
        }

        //IQueryable<TResult> henüz çalıştırılmamış sql kodu döndürüyor.
        public IQueryable<TResult> Select<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector)
        {
            return filter == null ? _dbset.Select(selector) : _dbset.Where(filter).Select(selector);
        }

        #region Dispose
        private bool _disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                    _context.Dispose();


                _disposedValue = true;
            }
        }


        public void Dispose()
        {

            Dispose(true);
            //işlem tamamlandığında hafızadan silme için
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}

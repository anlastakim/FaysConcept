using FaysConcept.Dal.Interfaces;
using FaysConcept.WMS.Common.Message;
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;

namespace FaysConcept.Dal.Base
{
    //kaydetme işlemlerini UnitOfWork üzerinden yapacağız.

    public class UnitOfWork<T> : IUnitOfWork<T> where T : class
    {

        #region Variables (Değişkenler)

        private readonly DbContext _context; 

        #endregion

        public UnitOfWork(DbContext context)
        {
            if (context == null) return;
            {
                _context = context;
            }
        }

        // => return anlamına geliyor.
        public IRepository<T> Rep => new Repository<T>(_context);

        public bool Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {

                var sqlEx = (SqlException)ex.InnerException?.InnerException;
                if (sqlEx == null)
                {
                    //kayıt null ise genel hata veriyoruz.
                    Messages.HataMesaji(ex.Message);
                    return false;
                }

                switch (sqlEx.Number)
                {
                    case 208:
                        Messages.HataMesaji("İşlem yapmak istediğiniz tablo veritanında bulunamadı.");
                        break;
                    case 547:
                        Messages.HataMesaji("Seçilen kartın işlem görmüş hareketleri var.Kart silinemez.");
                        break;
                    case 2601:
                    case 2627:
                        Messages.HataMesaji("Girmiş olduğumuz Id daha önce kullanılmıştır.");
                        break;
                    case 4060:
                        Messages.HataMesaji("İşlem yapmak istediğiniz veritabanı sunucuda bulunamadı.");
                        break;
                    case 18456:
                        Messages.HataMesaji("Sunucuda bağlanılmak istenilen kullanıcı adı veya parola hatalıdır.");
                        break;
                    default:
                        Messages.HataMesaji(sqlEx.Message);
                        break;
                }

                return false;
            }

            catch (Exception ex)
            {
                Messages.HataMesaji(ex.Message);
                return false;
            }

            return true;
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
            GC.SuppressFinalize(this);

        }
        #endregion
    }
}

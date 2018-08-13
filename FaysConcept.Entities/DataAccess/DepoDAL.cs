using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FaysConcept.Entities.Context;
using FaysConcept.Entities.Repositories;
using FaysConcept.Entities.Tables;
using FaysConcept.Entities.Validations;

namespace FaysConcept.Entities.DataAccess
{
    public class DepoDAL : EntityRepositoryBase<FaysConceptContext, Depo, DepoValidator>
    {
        public object DepoBazindaStokListele(FaysConceptContext context, string stokKodu)
        {
            var result = context.Depolar.GroupJoin(context.StokHareketleri.Where(c => c.StokKodu == stokKodu),
               c => c.DepoKodu, c => c.DepoKodu, (depolar, stokhareketleri) => new
               {
                   depolar.Id,
                   depolar.DepoKodu,
                   depolar.DepoAdi,
                   depolar.YetkiliKodu,
                   depolar.YetkiliAdi,
                   depolar.Il,
                   depolar.Ilce,
                   depolar.Semt,
                   depolar.Adress,
                   depolar.Aciklama,
                   depolar.Telefon,
                   StokGiris = stokhareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktar) ?? 0,
                   StokCikis = stokhareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0,
                   MevcutStok = stokhareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktar) -
                                stokhareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0
               }).ToList();
            return result;
        }
    }
}

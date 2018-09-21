using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using FaysConcept.Entities.Context;
using FaysConcept.Entities.Repositories;
using FaysConcept.Entities.Tables;
using FaysConcept.Entities.Validations;

namespace FaysConcept.Entities.DataAccess
{
  public  class StokDAL : EntityRepositoryBase<FaysConceptContext, Stok,StokValidator>
    {
      // StokDAL stokDal = new StokDAL();
        public  object StokListele(FaysConceptContext context)
        {
            var tablo = context.Stoklar.GroupJoin(context.StokHareketleri, c => c.StokKodu, c => c.StokKodu,
                (Stoklar, StokHareketleri) =>
                    new
                    {
                        Stoklar.RefNo,
                        Stoklar.Durumu,
                        Stoklar.StokKodu,
                        Stoklar.StokAdi,
                        Stoklar.BarkodNo,
                        Stoklar.BarkodTuru,
                        Stoklar.Birimi,
                        Stoklar.StokGrubu,
                        Stoklar.StokAltGrubu,
                        Stoklar.Marka,
                        Stoklar.Model,
                        Stoklar.OzelKod1,
                        Stoklar.OzelKod2,
                        Stoklar.OzelKod3,
                        Stoklar.OzelKod4,
                        Stoklar.GarantiSuresi,
                        Stoklar.UreticiKodu,
                        Stoklar.AlisKdv,
                        Stoklar.SatisKdv,
                        Stoklar.AlisFiyat1,
                        Stoklar.AlisFiyat2,
                        Stoklar.AlisFiyat3,
                        Stoklar.SatisFiyat1,
                        Stoklar.SatisFiyat2,
                        Stoklar.SatisFiyat3,
                        Stoklar.MinStokMiktar,
                        Stoklar.MaxStokMiktar,
                        Stoklar.Aciklama,
                        StokGiris = StokHareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktar) ?? 0,
                        // null ise 0 olarak göster
                        StokCikis = StokHareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0,
                        MevcutStok = StokHareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktar) -
                                     StokHareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0


                    }).ToList();
            return tablo;
        }

        
    }
}

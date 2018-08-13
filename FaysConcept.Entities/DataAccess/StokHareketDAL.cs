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
    public class StokHareketDAL : EntityRepositoryBase<FaysConceptContext, StokHareket, StokHareketValidator>
    {
        public object GetGenelStok(FaysConceptContext context, string stokkodu)
        {
            var result = (from c in context.StokHareketleri.Where(c => c.StokKodu == stokkodu)
                          group c by new { c.Hareket }
                into g
                          select new
                          {
                              Bilgi = g.Key.Hareket,
                              KayitSayisi = g.Count(),
                              GenelToplam = g.Sum(c => c.Miktar)
                          }).ToList();
            return result;
        }

        public object GetDepoStok(FaysConceptContext context, string stokkodu)
        {
            var result = context.Depolar.GroupJoin(context.StokHareketleri.Where(c => c.StokKodu == stokkodu),
                c => c.DepoKodu, c => c.DepoKodu, (depolar, stokhareketleri) => new
                {
                    depolar.DepoKodu,
                    depolar.DepoAdi,
                    StokGiris = stokhareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktar) ?? 0,
                    StokCikis = stokhareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0,
                    MevcutStok = stokhareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktar) -
                                 stokhareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0
                }).ToList();
            return result;
        }


        public object DepoStokListele(FaysConceptContext context, string depoKodu)
        {
            var tablo = context.Stoklar.GroupJoin(context.StokHareketleri.Where(c => c.DepoKodu == depoKodu), c => c.StokKodu, c => c.StokKodu,
                (Stoklar, StokHareketleri) =>
                    new
                    {
                        Stoklar.StokKodu,
                        Stoklar.StokAdi,

                        StokGiris = StokHareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktar) ?? 0,
                        StokCikis = StokHareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0,
                        MevcutStok = StokHareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktar) -
                                     StokHareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0


                    }).ToList();
            return tablo;
        }

        public object DepoIstatistikListele(FaysConceptContext context, string depoKodu)
        {

            List<GenelToplam> genelToplamlar = new List<GenelToplam>()
            {
                new GenelToplam
                {
                    Bilgi = "Stok Giriş",
                    KayitSayisi = context.StokHareketleri.Where(c=>c.DepoKodu==depoKodu && c.Hareket=="Stok Giriş").Count(),
                    Tutar = context.StokHareketleri.Where(c=>c.DepoKodu==depoKodu && c.Hareket=="Stok Giriş").Sum(c=>c.Miktar) ?? 0
                },
                new GenelToplam
                {
               Bilgi = "Stok Çıkış",
                    KayitSayisi = context.StokHareketleri.Where(c=>c.DepoKodu==depoKodu && c.Hareket=="Stok Çıkış").Count(),
                    Tutar = context.StokHareketleri.Where(c=>c.DepoKodu==depoKodu && c.Hareket=="Stok Çıkış").Sum(c=>c.Miktar) ?? 0
                },
            };
            return genelToplamlar;

        }


    }
}

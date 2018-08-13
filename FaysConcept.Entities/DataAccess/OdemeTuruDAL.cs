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
  public  class OdemeTuruDAL : EntityRepositoryBase<FaysConceptContext, OdemeTuru,OdemeTuruValidator>
    {
        public object OdemeTuruListele(FaysConceptContext context)
        {
            var result = context.OdemeTurleri.GroupJoin(context.KasaHareketleri, c => c.OdemeTuruKodu,
                c => c.OdemeTuruKodu,
                (odemeturu, kasahareket) => new
                {
                    odemeturu.Id,
                    odemeturu.OdemeTuruKodu,
                    odemeturu.OdemeTuruAdi,
                    odemeturu.Aciklama,
                    KasaGiris = (kasahareket.Where(c =>
                                         c.OdemeTuruKodu == odemeturu.OdemeTuruKodu && c.Hareket == "Kasa Giriş")
                                     .Sum(c => c.Tutar) ?? 0),
                    KasaCikis = (kasahareket.Where(c =>
                                         c.OdemeTuruKodu == odemeturu.OdemeTuruKodu && c.Hareket == "Kasa Çıkış")
                                     .Sum(c => c.Tutar) ?? 0),
                    Bakiye = (kasahareket.Where(c =>
                                      c.OdemeTuruKodu == odemeturu.OdemeTuruKodu && c.Hareket == "Kasa Giriş")
                                  .Sum(c => c.Tutar) ?? 0) -
                             (kasahareket.Where(c =>
                                      c.OdemeTuruKodu == odemeturu.OdemeTuruKodu && c.Hareket == "Kasa Çıkış")
                                  .Sum(c => c.Tutar) ?? 0),
                }).ToList();
            return result;
        }
    }
}

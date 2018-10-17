using FaysConcept.Entities.Context;
using FaysConcept.Entities.Repositories;
using FaysConcept.Entities.Tables;
using FaysConcept.Entities.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaysConcept.Entities.DataAccess
{
    public class PersonelDAL : EntityRepositoryBase<FaysConceptContext, Personel, PersonelValidator>
    {
        public object PersonelListele(FaysConceptContext context)
        {
            var result = context.Personeller.GroupJoin(context.Fisler, c => c.PersonelKodu, c => c.PlasiyerKodu, (personel, fis) => new
            {
                personel.Id,
                personel.Calisiyor,
                personel.PersonelKodu,
                personel.PersonelAdi,
                personel.Unvani,
                personel.TcKimlikNo,
                personel.IseGirisTarihi,
                personel.IstenCikisTarihi,
                personel.VergiDairesi,
                personel.VergiNo,
                personel.CepTelefonu,
                personel.Telefon,
                personel.Fax,
                personel.Web,
                personel.PrimOrani,
                personel.AylikMaas,
                personel.Aciklama,
                ToplamSatis = fis.Where(c => c.FisTuru == "Perakende Satış Faturası").Sum(c => c.ToplamTutar) ?? 0,
                PrimTutari = (fis.Where(c => c.FisTuru == "Perakende Satış Faturası").Sum(c => c.ToplamTutar) ?? 0) / 100 * personel.PrimOrani
            }).ToList();
            return result;
        }

        public object PersonelFisToplam(FaysConceptContext context, string personelKodu)
        {
            var result = (from c in context.Fisler.Where(c => c.PlasiyerKodu == personelKodu)
                          group c by new { c.FisTuru } into grp
                          select new
                          {
                              Bilgi = grp.Key.FisTuru,
                              KayitSayisi = grp.Count(),
                              ToplamTutar = grp.Sum(c => c.ToplamTutar)
                          }).ToList();
            return result;
        }

    }

}

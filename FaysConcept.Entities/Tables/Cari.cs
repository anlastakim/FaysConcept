using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FaysConcept.Entities.Interface;

namespace FaysConcept.Entities.Tables
{
    public class Cari:IEntity
    {
        public int Id { get; set; }
        public bool Durumu { get; set; }
        public string CariTuru { get; set; }
        public string CariKodu { get; set; }
        public string CariAdi { get; set; }
        public string Yetkili { get; set; }
        public string FaturaUnvani { get; set; }
        public string CepTelefon { get; set; }
        public string Telefon { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Web { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Semt { get; set; }
        public string Adres { get; set; }
        public string CariGrubu { get; set; }
        public string CariAltGrubu { get; set; }
        public string OzelKod1 { get; set; }
        public string OzelKod2 { get; set; }
        public string OzelKod3 { get; set; }
        public string OzelKod4 { get; set; }
        public string VergiDairesi { get; set; }
        public string VergiNo { get; set; }
        public Nullable<decimal> IskontoOrani { get; set; }
        public Nullable<decimal> RiskLimiti { get; set; }
        public string AlisOzelFiyat { get; set; }
        public string SatisOzelFiyat { get; set; }
        public string Aciklama { get; set; }




    }
}

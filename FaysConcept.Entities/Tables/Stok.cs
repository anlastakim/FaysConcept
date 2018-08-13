using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FaysConcept.Entities.Interface;

namespace FaysConcept.Entities.Tables
{
    public class Stok:IEntity
    {
        public int RefNo { get; set; }
        public bool Durumu { get; set; }
        public string StokKodu { get; set; }
        public string StokAdi { get; set; }
        public string BarkodNo { get; set; }
        public string BarkodTuru { get; set; }
        public string Birimi { get; set; }
        public string StokGrubu { get; set; }
        public string StokAltGrubu { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string OzelKod1 { get; set; }
        public string OzelKod2 { get; set; }
        public string OzelKod3 { get; set; }
        public string OzelKod4 { get; set; }
        public string GarantiSuresi { get; set; }
        public string UreticiKodu { get; set; }
        public Nullable<int> AlisKdv { get; set; }
        public Nullable<int> SatisKdv { get; set; }
        public Nullable<decimal> AlisFiyat1 { get; set; }
        public Nullable<decimal> AlisFiyat2 { get; set; }
        public Nullable<decimal> AlisFiyat3 { get; set; }
        public Nullable<decimal> SatisFiyat1 { get; set; }
        public Nullable<decimal> SatisFiyat2 { get; set; }
        public Nullable<decimal> SatisFiyat3 { get; set; }
        public Nullable<decimal> MinStokMiktar { get; set; }
        public Nullable<decimal> MaxStokMiktar { get; set; }
        public string Aciklama { get; set; }





    }       
}

using FaysConcept.WMS.Model.Entities;
using FaysConcept.WMS.Model.Entities.Base;

namespace FaysConcept.WMS.Model.Dto
{   //Attribute gelecek.
    /// <summary>
    /// data transfer id üzerinden isimleri ulaşma
    /// </summary>
    // CariS Sonundaki S select ifade ediyor single
    public class CariS:CariKartlar
    {
        public string IlAdi { get; set; }
        public string IlceAdi { get; set; }
    }
    public class CariL : BaseEntity
    {
        public string CariAdi { get; set; }
        public string IlAdi { get; set; }
        public string IlceAdi { get; set; }
        public string Aciklama { get; set; }
    }
}

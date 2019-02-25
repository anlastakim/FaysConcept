using FaysConcept.WMS.Model.Entities.Base;


namespace FaysConcept.WMS.Model.Entities
{
  public  class CariKartlar: BaseEntityDurum
    {
        public string CariKodu { get; set; }
        public string CariAdi { get; set; }
        public long IlId { get; set; }
        public long IlceId { get; set; }
        public string Aciklama { get; set; }

        public Il Il { get; set; }
        public Ilce Ilce { get; set; }
    }
}

using FaysConcept.WMS.Model.Entities.Base;

namespace FaysConcept.WMS.Model.Entities
{
    public class Ilce : BaseEntityDurum
    {
        public string IlceAdi { get; set; }
        public long IlId { get; set; }
        public string Aciklama { get; set; }
        public Il Il { get; set; }
    }
}

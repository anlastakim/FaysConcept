using FaysConcept.WMS.Model.Entities.Base.Interfaces;

namespace FaysConcept.WMS.Model.Entities.Base
{
   public class BaseEntity:IBaseEntity
    {
        // yeni 
        public long Id { get; set; }   // kendimiz ıd oluşturacağımız için long kullanıldı.
        public string Kod { get; set; }
        
    }
}

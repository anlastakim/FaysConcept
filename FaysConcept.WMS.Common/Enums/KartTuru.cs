using System.ComponentModel;

namespace FaysConcept.WMS.Common.Enums
{
    public enum KartTuru : byte
    {
        [Description("Cari Kartı")]
        Cari = 1,
        [Description("İl Kartı")]
        Il = 2,
        [Description("İlçe Kartı")]
        Ilce = 3
    }
}

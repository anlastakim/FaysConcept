using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FaysConcept.Entities.Tables;

namespace FaysConcept.Entities.Mapping
{
    public class StokHareketMap:EntityTypeConfiguration<StokHareket>
    {
        public StokHareketMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.FisKodu).HasMaxLength(12).HasColumnName("FisKodu");
            this.Property(p => p.Hareket).HasMaxLength(10).HasColumnName("Hareket");
            this.Property(p => p.StokKodu).HasMaxLength(12).HasColumnName("StokKodu");
            this.Property(p => p.StokAdi).HasMaxLength(50).HasColumnName("StokAdi");
            this.Property(p => p.BarkodTuru).HasMaxLength(15).HasColumnName("BarkodTuru");
            this.Property(p => p.Barkod).HasMaxLength(20).HasColumnName("Barkod");
            this.Property(p => p.Birimi).HasMaxLength(15).HasColumnName("Birimi");
            this.Property(p => p.Miktar).HasPrecision(12,3).HasColumnName("Miktar");
            this.Property(p => p.BirimFiyat).HasPrecision(12,2).HasColumnName("BirimFiyat");
            this.Property(p => p.IndirimOrani).HasPrecision(5,2).HasColumnName("IndirimOrani");
            this.Property(p => p.IndirimTutari).HasPrecision(12,2).HasColumnName("IndirimTutari");
            this.Property(p => p.ToplamTutar).HasPrecision(12,2).HasColumnName("ToplamTutar");
            this.Property(p => p.DepoKodu).HasMaxLength(12).HasColumnName("DepoKodu");
            this.Property(p => p.DepoAdi).HasMaxLength(30).HasColumnName("DepoAdi");
            this.Property(p => p.SeriNo).HasMaxLength(200).HasColumnName("SeriNo");
            this.Property(p => p.Aciklama).HasMaxLength(200).HasColumnName("Aciklama");

            this.ToTable("StokHareketleri");

            this.Property(p => p.Kdv).HasColumnName("Kdv");
            this.Property(p => p.Tarih).HasColumnName("Tarih");

        }
    }
}

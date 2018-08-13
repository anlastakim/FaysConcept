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
    public class StokMap:EntityTypeConfiguration<Stok>

    {
        public StokMap()
        {
            this.HasKey(p => p.RefNo);
            this.Property(p => p.RefNo).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.StokKodu).HasMaxLength(12);
            this.Property(p => p.StokAdi).HasMaxLength(50);
            this.Property(p => p.BarkodNo).HasMaxLength(20);
            this.Property(p => p.BarkodTuru).HasMaxLength(15);
            this.Property(p => p.Birimi).HasMaxLength(15);
            this.Property(p => p.StokGrubu).HasMaxLength(30);
            this.Property(p => p.StokAltGrubu).HasMaxLength(30);
            this.Property(p => p.Marka).HasMaxLength(30);
            this.Property(p => p.Model).HasMaxLength(30);
            this.Property(p => p.OzelKod1).HasMaxLength(30);
            this.Property(p => p.OzelKod2).HasMaxLength(30);
            this.Property(p => p.OzelKod3).HasMaxLength(30);
            this.Property(p => p.OzelKod4).HasMaxLength(30);
            this.Property(p => p.GarantiSuresi).HasMaxLength(15);
            this.Property(p => p.UreticiKodu).HasMaxLength(20);
            this.Property(p => p.AlisFiyat1).HasPrecision(12, 2);
            this.Property(p => p.AlisFiyat2).HasPrecision(12, 2);
            this.Property(p => p.AlisFiyat3).HasPrecision(12, 2);
            this.Property(p => p.SatisFiyat1).HasPrecision(12, 2);
            this.Property(p => p.SatisFiyat2).HasPrecision(12, 2);
            this.Property(p => p.SatisFiyat3).HasPrecision(12, 2);
            this.Property(p => p.MinStokMiktar).HasPrecision(12, 3);
            this.Property(p => p.MaxStokMiktar).HasPrecision(12, 3);
            this.Property(p => p.Aciklama).HasMaxLength(200);

            this.ToTable("Stoklar");
            this.Property(p => p.RefNo).HasColumnName("RefNo");
            this.Property(p => p.Durumu).HasColumnName("Durumu");
            this.Property(p => p.StokKodu).HasColumnName("StokKodu");
            this.Property(p => p.StokAdi).HasColumnName("StokAdi");
            this.Property(p => p.BarkodNo).HasColumnName("BarkodNo");
            this.Property(p => p.BarkodTuru).HasColumnName("BarkodTuru");
            this.Property(p => p.Birimi).HasColumnName("Birimi");
            this.Property(p => p.StokGrubu).HasColumnName("StokGrubu1");
            this.Property(p => p.StokAltGrubu).HasColumnName("StokAltGrubu");
            this.Property(p => p.Marka).HasColumnName("Marka");
            this.Property(p => p.Model).HasColumnName("Model");
            this.Property(p => p.OzelKod1).HasColumnName("OzelKod1");
            this.Property(p => p.OzelKod2).HasColumnName("OzelKod2");
            this.Property(p => p.OzelKod3).HasColumnName("OzelKod3");
            this.Property(p => p.OzelKod4).HasColumnName("OzelKod4");
            this.Property(p => p.GarantiSuresi).HasColumnName("GarantiSuresi");
            this.Property(p => p.UreticiKodu).HasColumnName("UreticiKodu");
            this.Property(p => p.AlisKdv).HasColumnName("AlisKdv");
            this.Property(p => p.SatisKdv).HasColumnName("SatisKdv");
            this.Property(p => p.AlisFiyat1).HasColumnName("AlisFiyat1");
            this.Property(p => p.AlisFiyat2).HasColumnName("AlisFiyat2");
            this.Property(p => p.AlisFiyat3).HasColumnName("AlisFiyat3");
            this.Property(p => p.SatisFiyat1).HasColumnName("SatisFiyat1");
            this.Property(p => p.SatisFiyat2).HasColumnName("SatisFiyat2");
            this.Property(p => p.SatisFiyat3).HasColumnName("SatisFiyat3");
            this.Property(p => p.MinStokMiktar).HasColumnName("MinStokMiktar");
            this.Property(p => p.MaxStokMiktar).HasColumnName("MaxStokMiktar");
            this.Property(p => p.Aciklama).HasColumnName("Aciklama");
        }

    }
}

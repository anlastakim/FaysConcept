using FaysConcept.Entities.Tables;
using System.Data.Entity.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace FaysConcept.Entities.Mapping
{
  public  class KodUretMap:EntityTypeConfiguration<KodUret>
    {
        public KodUretMap()
        {

            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.OnEki).HasMaxLength(6);
            this.Property(p => p.Tablo).HasMaxLength(15);


            this.ToTable("Kodlar"); // context alanı ile aynı olacak.

            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.OnEki).HasColumnName("OnEki");
            this.Property(p => p.Tablo).HasColumnName("Tablo");
            this.Property(p => p.SonDeger).HasColumnName("SonDeger");
        }

    }

}

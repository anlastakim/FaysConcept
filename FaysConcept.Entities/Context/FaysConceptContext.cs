using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FaysConcept.Entities.Tables;
using FaysConcept.Entities.Mapping;
using FaysConcept.Entities.Tools;

namespace FaysConcept.Entities.Context
{
    public class FaysConceptContext : DbContext
    {
        //public FaysConceptContext():base(SettingsTool.AyarOku(SettingsTool.Ayarlar.DatabaseAyarlari_BaglantiCumlesi)?? "Bağlantı Yok")
        //{

        //}
        

        public DbSet<Stok> Stoklar { get; set; }
        public DbSet<Cari> Cariler { get; set; }
        public DbSet<Fis> Fisler { get; set; }
        public DbSet<StokHareket> StokHareketleri { get; set; }
        public DbSet<KasaHareket> KasaHareketleri { get; set; }
        public DbSet<Depo> Depolar { get; set; }
        public DbSet<Kasa> Kasalar { get; set; }
        public DbSet<OdemeTuru> OdemeTurleri { get; set; }
        public DbSet<Tanim> Tanimlar { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<KullaniciRol> KullaniciRolleri { get; set; }
        public DbSet<KodUret> Kodlar  { get; set; }
        public DbSet<Personel> Personeller { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<FaysConceptContext>(null);
            //Veritabanı sutun adı değiştiğinde kullanıldı.
            modelBuilder.Configurations.Add(new CariMap());
            modelBuilder.Configurations.Add(new DepoMap());
            modelBuilder.Configurations.Add(new FisMap());
            modelBuilder.Configurations.Add(new KasaHareketMap());
            modelBuilder.Configurations.Add(new KasaMap());
            modelBuilder.Configurations.Add(new OdemeTuruMap());
            modelBuilder.Configurations.Add(new StokHareketMap());
            modelBuilder.Configurations.Add(new StokMap());
            modelBuilder.Configurations.Add(new TanimMap());
            modelBuilder.Configurations.Add(new KullaniciMap());
            modelBuilder.Configurations.Add(new KullaniciRolMap());
            modelBuilder.Configurations.Add(new KodUretMap());
            modelBuilder.Configurations.Add(new PersonelMap());


        }


    }
}

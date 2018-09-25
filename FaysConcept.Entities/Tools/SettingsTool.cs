using IniParser;
using IniParser.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaysConcept.Entities.Tools
{
    public static class SettingsTool
    {
        static FileIniDataParser parser = new FileIniDataParser();
        static IniData data;
        //ayarların tutulacağı dosya adı
        static string dosyaAdi = "Settings.ini";

        static SettingsTool()
        {
            if (System.IO.File.Exists(Application.StartupPath + "\\" + dosyaAdi) == true)
            {
                data = parser.ReadFile(dosyaAdi);
            }
            // settings.ini dosyası yok ise oluşturup sonra okuyacak.

            else
            {
                // using bloğu : önce ilgili dosya oluşturuluyor sonra dispose edip okuma işlemine geçiliyor.
                using (System.IO.File.Create(Application.StartupPath + "\\" + dosyaAdi))
                {

                }
                ;
                data = parser.ReadFile(dosyaAdi);
            }
        }

        public enum Ayarlar
        {
            SmsAyarları_KullanıcıAdı,
            SmsAyarları_Parola,
            FrmFisIslem_VarsayılanDepo,
            FrmKullaniciGiris_VarsayılanKullanici,
            FrmBackup_YedeklemeKonumu,
            DatabaseAyarlari_BaglantiCumlesi
        }

        public static void AyarDegistir(Ayarlar ayar, string value)
        {
            // _ ye göre parçalama
            string[] gelenAyar = ayar.ToString().Split(Convert.ToChar("_"));
            // data null değil ise
            if (data != null)
            {
                if (data.Sections.Count(c => c.SectionName == gelenAyar[0]) == 0)
                {
                    data.Sections.AddSection(gelenAyar[0]);
                    data[gelenAyar[0]].AddKey(gelenAyar[1]);
                }
                else
                {
                    data[gelenAyar[0]].AddKey(gelenAyar[1]);
                }
                data[gelenAyar[0]][gelenAyar[1]] = value;
            }
        }

        public static string AyarOku(Ayarlar ayar)
        {
            string[] gelenAyar = ayar.ToString().Split(Convert.ToChar("_"));
            return data[gelenAyar[0]][gelenAyar[1]];
        }

        public static void Save()
        {
            parser.WriteFile(dosyaAdi, data);
        }
    }
}

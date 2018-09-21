using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using FaysConcept.Entities.Context;
using FaysConcept.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaysConcept.Entities.Tools
{
  public static  class RoleTool
    {
        public static Kullanici KullaniciEntity;
        public static void RolleriYukle(XtraForm form)
        {
            FaysConceptContext context = new FaysConceptContext();
            // yetkisi false olanları getir koşulu (formadi form name eşit ise çalışacak.)
            foreach (var item in context.KullaniciRolleri.Where(c=>c.FormAdi==form.Name && c.Yetki==false).ToList()) 
            {
                var bulunan = form.Controls.Find(item.KontrolAdi, true).SingleOrDefault();
                if (bulunan!=null)
                {
                    bulunan.Enabled = false;
                }
            }
        }
        //public static bool RolleriYukle(XtraForm form, String kontrolAdi)
        //{
        //    FaysConceptContext context = new FaysConceptContext();
        //    // yetkisi false olanları getir koşulu (formadi form name eşit ise çalışacak.)
        //    foreach (var item in context.KullaniciRolleri.Where(c => c.FormAdi == form.Name && c.Yetki == false).ToList())
        //    {
        //        var bulunan = form.Controls.Find(kontrolAdi, true).SingleOrDefault();
        //        if (bulunan != null)
        //        {
        //            return  false;
        //        }
        //    }
        //    return true;
        //}
        //Ana Menüdeki butonların yetkisini kontrol etme üst menü
        public static void RolleriYukle(RibbonControl form)
        {
            FaysConceptContext context = new FaysConceptContext();
            // yetkisi false olanları getir koşulu (formadi form name eşit ise çalışacak.)
            foreach (var item in context.KullaniciRolleri.Where(c => c.FormAdi == "FrmAnaMenu" && c.Yetki == false).ToList())
            {
                form.Items.SingleOrDefault(c => c.Name == item.KontrolAdi).Enabled = false;
            }
        }
    }
}

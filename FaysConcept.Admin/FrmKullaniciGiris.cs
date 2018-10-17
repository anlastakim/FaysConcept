using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using FaysConcept.Entities.Context;
using FaysConcept.Entities.Tools;
using System.Security.AccessControl;
using System.IO;
using System.Security.Principal;

namespace FaysConcept.Admin
{
    public partial class FrmKullaniciGiris : DevExpress.XtraEditors.XtraForm
    {   
        private FaysConceptContext context;
        public bool girisBasarili = false;
        
        public FrmKullaniciGiris()
        {
            InitializeComponent();
            
            KlasoreIzinVer();
            //Kullanıcı giriş formu oluşturulurken bağlantı kontrolü ve kayıt
            if (!ConnectionTool.CheckConnection(SettingsTool.AyarOku(SettingsTool.Ayarlar.DatabaseAyarlari_BaglantiCumlesi)))
            {
                FrmBaglantiAyarlari form = new FrmBaglantiAyarlari();
                form.ShowDialog();
            }
            context = new FaysConceptContext();
            txtKullaniciAdi.Text = SettingsTool.AyarOku(SettingsTool.Ayarlar.FrmKullaniciGiris_VarsayılanKullanici);
        }

        // program setup sonrası kurulumlarda yetkiler
        private void KlasoreIzinVer()
        {     // programın çalışacağı klasöre izin ver.
            DirectorySecurity izin = Directory.GetAccessControl(Application.StartupPath);
            //everyone a denk gelen tüm windows dillerinde yetki vermek için SecurityIdentifier  domain sid null değeri verildi.
            SecurityIdentifier everyone = new SecurityIdentifier(WellKnownSidType.WorldSid, null);
            izin.AddAccessRule(new FileSystemAccessRule(everyone, FileSystemRights.FullControl, AccessControlType.Allow));
            // izin verme tamamlandı.
            Directory.SetAccessControl(Application.StartupPath, izin);
        }


        private void btnGiris_Click(object sender, EventArgs e)
        {

            if (context.Kullanicilar.Any(c=>c.KullaniciAdi==txtKullaniciAdi.Text && c.Parola==txtParola.Text))
            {
                girisBasarili = true;
                // Giriş başarılı ise kullanıcı adını kullanicientity e gönderdik.
                RoleTool.KullaniciEntity = context.Kullanicilar.SingleOrDefault(c => c.KullaniciAdi == txtKullaniciAdi.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Girmiş olduğunuz kullanıcı adı veya şifre yanlış");
               // txtKullaniciAdi.Text = null;
                txtParola.Text = null;
            }
        }

        private void FrmKullaniciGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!girisBasarili)
           
            {
                //FormCollection frm = Application.OpenForms;

                //foreach (Form f in frm)
                //{
                //    if (f.Name == "RibbonForm1")
                //    {
                //        this.Close();
                //        this.Dispose();
                //        break;
                //    }
                //}
                    Environment.Exit(0);
           
            }
        }


        private void btnParolaSıfırla_Click(object sender, EventArgs e)
        {
            if (context.Kullanicilar.Any(c=>c.KullaniciAdi==txtKullaniciAdi.Text))
            {
                FrmParolaHatirlat form = new FrmParolaHatirlat(txtKullaniciAdi.Text);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Girmiş olduğunuz kullanıcı adı kayıtlı değildir.");
                txtKullaniciAdi.Text = null;
            }
        }



        private void txtParola_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (context.Kullanicilar.Any(c => c.KullaniciAdi == txtKullaniciAdi.Text && c.Parola == txtParola.Text))
                {
                    girisBasarili = true;
                    // Giriş başarılı ise kullanıcı adını kullanicientity e gönderdik.
                    RoleTool.KullaniciEntity = context.Kullanicilar.SingleOrDefault(c => c.KullaniciAdi == txtKullaniciAdi.Text);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Girmiş olduğunuz kullanıcı adı veya şifre yanlış");
                    // txtKullaniciAdi.Text = null;
                    txtParola.Text = null;
                }
            }
        }

        private void FrmKullaniciGiris_Shown(object sender, EventArgs e)
        {
            txtParola.Focus();
        }


        private void btnkapat_Click(object sender, EventArgs e)
        {
            if (!girisBasarili)
            {
                //FormCollection frm = Application.OpenForms;

                //foreach (Form f in frm)
                //{
                //    if (f.Name == "RibbonForm1")
                //    {
                        
                //        this.Close();
                //        this.Dispose();
                //        break;
                //    }
                //}
                Environment.Exit(0);
            }

        }
    }
}
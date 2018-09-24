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

namespace FaysConcept.Admin
{
    public partial class FrmKullaniciGiris : DevExpress.XtraEditors.XtraForm
    {
        FaysConceptContext context = new FaysConceptContext();
        private bool girisBasarili = false;
   
        public FrmKullaniciGiris()
        {
            InitializeComponent();
            txtKullaniciAdi.Text = SettingsTool.AyarOku(SettingsTool.Ayarlar.FrmKullaniciGiris_VarsayılanKullanici);
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
                Application.Exit();
            }
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void FrmKullaniciGiris_Load(object sender, EventArgs e)
        {
         
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
    }
}
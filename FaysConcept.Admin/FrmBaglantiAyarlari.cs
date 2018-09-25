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
using System.Data.SqlClient;
using FaysConcept.Entities.Tools;
using FaysConcept.Entities.Context;
using FaysConcept.Entities.Tables;

namespace FaysConcept.Admin
{
    public partial class FrmBaglantiAyarlari : DevExpress.XtraEditors.XtraForm
    {
        SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder();
        private bool kaydedildi = false;

        public FrmBaglantiAyarlari()
        {
            InitializeComponent();
        }

        private void BaglantiCumleOlustur()
        {
            connectionStringBuilder.DataSource = txtServer.Text;
            connectionStringBuilder.InitialCatalog = txtDbAdi.Text;
            //windows oturumu işaretli ise
            if (chkWindows.Checked)
            {
                connectionStringBuilder.IntegratedSecurity = true;
            }
            else
            {
                connectionStringBuilder.UserID = txtKullanici.Text;
                connectionStringBuilder.Password = txtParola.Text;
                connectionStringBuilder.IntegratedSecurity = false;
            }
        }

        private void FrmBaglantiAyarlari_Load(object sender, EventArgs e)
        {

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            BaglantiCumleOlustur();
            //connectionStringBuilder.InitialCatalog = "master";
            // MessageBox.Show(connectionStringBuilder.ConnectionString);
            if (ConnectionTool.CheckConnection(connectionStringBuilder.ConnectionString))
            {
                connectionStringBuilder.InitialCatalog = txtDbAdi.Text;
                MessageBox.Show("Bağlantı Başarılı.");
            }
            else
            {
                MessageBox.Show("Bağlantı Başarısız.");
            }
        }
        private void chkSql_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSql.Checked)
            {
                txtParola.Enabled = true;
                txtKullanici.Enabled = true;

            }
            else
            {
                txtParola.Enabled = false;
                txtKullanici.Enabled = false;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            BaglantiCumleOlustur();
            connectionStringBuilder.InitialCatalog = "master";
            if (ConnectionTool.CheckConnection(connectionStringBuilder.ConnectionString))
            {
                connectionStringBuilder.InitialCatalog = txtDbAdi.Text;
                MessageBox.Show("Seçtiğiniz server da belirttiğiniz database yok ise bu mesajdan sonra oluşturulacak.Bu işlem uzun sürebilir.");
                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.DatabaseAyarlari_BaglantiCumlesi, connectionStringBuilder.ConnectionString);
                SettingsTool.Save();
                using (var context = new FaysConceptContext())
                {
                    context.Database.CreateIfNotExists();
                    if (!context.Kullanicilar.Any(c => c.KullaniciAdi == "Yönetici"))
                    {
                        context.Kullanicilar.Add(new Kullanici
                        {
                            KullaniciAdi = "Yönetici",
                            Parola = "953199"
                        });
                        context.SaveChanges();
                    }
                }
                //MessageBox.Show("Bağlantı Başarılı.");

                kaydedildi = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Bağlantı Başarısız.");
            }

        }

        private void FrmBaglantiAyarlari_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!kaydedildi)
            {
                MessageBox.Show("Uygulamada bağlantı cümlesi olmadığından kapatılacak.");
                Application.Exit();
            }
        }

        private void FrmBaglantiAyarlari_Shown(object sender, EventArgs e)
        {
            txtParola.Focus();
        }
    }
}
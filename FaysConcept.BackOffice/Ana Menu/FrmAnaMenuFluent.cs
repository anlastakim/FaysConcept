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
using FaysConcept.BackOffice.Stok;
using FaysConcept.Entities.Tools;
using FaysConcept.Admin;
using System.Net;
using System.Reflection;
using System.Diagnostics;
using System.Data.SqlClient;
using FaysConcept.Entities.Context;

namespace FaysConcept.BackOffice.Ana_Menu
{
    public partial class FrmAnaMenuFluent : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public FrmAnaMenuFluent()
        {
            InitializeComponent();

            this.OptionsAdaptiveLayout.AdaptiveLayout = false;

            if (Convert.ToBoolean(SettingsTool.AyarOku(SettingsTool.Ayarlar.GenelAyarlar_GuncellemeKontrolu)))
            {
                if (CheckForInternetConnection())
                {
                    WebClient indir = new WebClient();
                    string programVersiyon = Assembly.Load("FaysConcept.BackOffice").GetName().Version.ToString();
                    string guncelVersiyon = indir.DownloadString("http://www.fayscrm.com/Download/versiyon.txt");
                    if (programVersiyon != guncelVersiyon)
                    {

                        if (MessageBox.Show("Yeni bir sürüm yayınlandı.Yüklemek ister misiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            Process.Start($"{Application.StartupPath}\\FaysConcept.Update.exe");
                        }

                    }

                }
                else
                {
                    MessageBox.Show("İnternet bağlantınız olmadığı için yeni versiyon kontrol edilemedi.");
                }

            }

            //
            FrmKullaniciGiris girisForm = new FrmKullaniciGiris();
            girisForm.ShowDialog();


            using (var context = new FaysConceptContext())
            {

                try
                {
                    context.Database.CreateIfNotExists();
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.Message);
                }




            }
        }

        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                {
                    using (client.OpenRead("http://www.fayscrm.com/Download/versiyon.txt"))
                    {
                        return true;
                    }
                }
            }
            catch
            {

                return false;
            }
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement5_Click(object sender, EventArgs e)
        {

            FrmStok form = new FrmStok();
            form.MdiParent = this;
            form.Show();

            //fluentDesignFormContainer1.Controls.Add(new FrmStok()
            //{
            //    Dock = DockStyle.Fill
            //});
        }

        private void fluentDesignFormControl1_Click(object sender, EventArgs e)
        {

        }

        private void FrmAnaMenuFluent_Load(object sender, EventArgs e)
        {

            //fluentDesignFormContainer1.Controls.Add(new FrmAnaMenuBilgi()
            //{
            //    Dock=DockStyle.Fill
            //});


            //RoleTool.RolleriYukle(ribbon);
            //barKullaniciAdi.Caption = $"Giriş Yapan Kullanıcı :  {RoleTool.KullaniciEntity.KullaniciAdi}";
        }
    }
}
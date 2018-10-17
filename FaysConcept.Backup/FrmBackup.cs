using FaysConcept.Entities.Context;
using FaysConcept.Entities.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FaysConcept.Backup
{
    public partial class FrmBackup : DevExpress.XtraEditors.XtraForm
    {
        FaysConceptContext context = new FaysConceptContext();

        public FrmBackup()
        {
            InitializeComponent();
            txtYedekKonumu.Text = SettingsTool.AyarOku(SettingsTool.Ayarlar.FrmBackup_YedeklemeKonumu);
        }

        private void FrmBackup_Load(object sender, EventArgs e)
        {

        }

        private void btnYedekleme_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(SettingsTool.AyarOku(SettingsTool.Ayarlar.DatabaseAyarlari_BaglantiCumlesi));
                //MessageBox.Show(string.Format("{0}{1}", builder.InitialCatalog,""));

               // string sqlCumle = string.Format("USE {0} ;BACKUP DATABASE FaysYeni TO DISK='{{1}\\{0}{2}.BAK}' WITH NOFORMAT,  INIT",builder.InitialCatalog, txtYedekKonumu.Text, DateTime.Now.ToString("yyyyMMddHHmmss"));

                string sqlCumle = $"USE " + builder.InitialCatalog + " ;BACKUP DATABASE " + builder.InitialCatalog + " TO DISK='" + txtYedekKonumu.Text + "\\" + builder.InitialCatalog + "" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".BAK' WITH NOFORMAT,  INIT";
                context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, sqlCumle);
                MessageBox.Show("Veritabanı yedekleme işlemi tamamlandı.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void txtYedekKonumu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FolderBrowserDialog form = new FolderBrowserDialog();
            if (form.ShowDialog() == DialogResult.OK)
            {
                txtYedekKonumu.Text = form.SelectedPath;
                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.FrmBackup_YedeklemeKonumu, txtYedekKonumu.Text);
                SettingsTool.Save();
            }
        }

        private void btnGeriYukleme_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Fays Concept Yedekleme Dosyası *.BAK | *.BAK";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                     SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(SettingsTool.AyarOku(SettingsTool.Ayarlar.DatabaseAyarlari_BaglantiCumlesi));
                    string sqlCumle = $"USE master;ALTER DATABASE " + builder.InitialCatalog + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE;" +
                                    $"ALTER DATABASE " + builder.InitialCatalog + " SET READ_ONLY;RESTORE DATABASE " + builder.InitialCatalog + " FROM DISK='" + dialog.FileName + "';" +
                                    $"ALTER DATABASE " + builder.InitialCatalog + " SET MULTI_USER;";
                    context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, sqlCumle);
                    MessageBox.Show("Veritabanı geri yükleme işlemi tamamlandı.");
                }
                catch (Exception ef)
                {

                    MessageBox.Show(ef.Message);
                }

            }
        }
    }
}

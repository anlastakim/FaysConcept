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

namespace FaysConcept.BackOffice.Fisler
{
    public partial class FrmSeriNo : DevExpress.XtraEditors.XtraForm
    {
        public string veriSeriNo;
        public bool kilitli = false;

        public FrmSeriNo(string veri)
        {
            InitializeComponent();
            if (veri != null)  // veri null değil ise bu işlemleri yap.
            {
                string[] veriListesi =
                    veri.Split(new[] { System.Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in veriListesi)   // veri listesi olarak atama
                {
                    listboxSeriNo.Items.Add(item);
                }

                // Erhan,Toprak,Ali,Veli   split ayırıcı yöntem belirleme
            }

            if (kilitli)
            {
                grpMenu.Enabled = true;
            }
        }

        void KayitAc()
        {
            btnYeni.Enabled = false;
            btnSil.Enabled = false;
            btnKaydet.Enabled = true;
            btnVazgec.Enabled = true;
            grupbilgi.Enabled = true;
            txtSeriNo.Focus();
        }

        void KayitKapat()
        {
            btnYeni.Enabled = true;
            btnSil.Enabled = true;
            btnKaydet.Enabled = false;
            btnVazgec.Enabled = false;
            grupbilgi.Enabled = false;
            txtSeriNo.Text = null;
        }

        private void FrmSeriNo_Load(object sender, EventArgs e)
        {

        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            KayitAc();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            listboxSeriNo.Items.Remove(listboxSeriNo.SelectedItem);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            listboxSeriNo.Items.Add(txtSeriNo.Text);
            KayitKapat();
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            KayitKapat();
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSeriNo_FormClosing(object sender, FormClosingEventArgs e)
        {   
            // form kapatıldığında listedeki serinolar veri değişkenine eklenecek
            if (listboxSeriNo.Items.Count != 0)
            {
                foreach (var item in listboxSeriNo.Items)
                {
                    veriSeriNo += item + System.Environment.NewLine;
                }
            }

        }
    }
}
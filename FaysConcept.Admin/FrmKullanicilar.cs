using FaysConcept.Entities.Context;
using FaysConcept.Entities.DataAccess;
using FaysConcept.Entities.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace FaysConcept.Admin
{
    public partial class FrmKullanicilar : DevExpress.XtraEditors.XtraForm
    {
        FaysConceptContext context = new FaysConceptContext();
        KullaniciDAL kullaniciDAL = new KullaniciDAL();
        private string secilen = null;

        public FrmKullanicilar()
        {
            InitializeComponent();
            Guncelle();
        }

        private void Guncelle() // guncelle method olarak oluşturuldu.
        {
            gridControlKullanici.DataSource = kullaniciDAL.GetAll(context);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmKullaniciIslem form=new FrmKullaniciIslem(new Kullanici());
            form.ShowDialog();
            if (form.saved)
            {
                Guncelle();
                
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmKullanicilar_Load(object sender, EventArgs e)
        {
            FrmKullaniciGiris form = new FrmKullaniciGiris();
            form.ShowDialog();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            secilen = gridViewKullanici.GetFocusedRowCellValue(colKullaniciAdi).ToString();
            FrmKullaniciIslem form = new FrmKullaniciIslem(kullaniciDAL.GetByFilter(context,c=>c.KullaniciAdi==secilen));
            form.ShowDialog();
            if (form.saved)
            {
                Guncelle();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string secilen = gridViewKullanici.GetFocusedRowCellValue(colKullaniciAdi).ToString();
                Kullanici kullaniciEntity = new Kullanici();
                kullaniciDAL.Delete(context, c => c.KullaniciAdi == secilen);
                kullaniciEntity.Id = -1;
                kullaniciDAL.Save(context);
                Guncelle();
            }
        }
    }
}

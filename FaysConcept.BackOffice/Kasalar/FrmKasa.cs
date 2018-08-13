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
using FaysConcept.BackOffice.Cari;
using FaysConcept.Entities.Context;
using FaysConcept.Entities.DataAccess;

namespace FaysConcept.BackOffice.Kasalar
{
    public partial class FrmKasa : DevExpress.XtraEditors.XtraForm
    {
        KasaDAL kasaDal=new KasaDAL();
        FaysConceptContext context=new FaysConceptContext();
        private string secilen = null;

        public FrmKasa()
        {
            InitializeComponent();
        }

        public void Guncelle()
        {
         gridControlKasa.DataSource= kasaDal.KasaListele(context);
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            FrmKasaIslem form = new FrmKasaIslem(new Entities.Tables.Kasa());
            form.ShowDialog();
            if (form.Kaydedildi)
            {
                Guncelle();

            }
        }

        private void btnduzenle_Click(object sender, EventArgs e)
        {
            secilen = layoutView1Kasa.GetFocusedRowCellValue(colKasaKodu).ToString();
            FrmKasaIslem form = new FrmKasaIslem(kasaDal.GetByFilter(context, c => c.KasaKodu == secilen));
            form.ShowDialog();
            if (form.Kaydedildi) // kapat butununa basıldığında gereksiz yere güncelleme işlemi yapmamak için ; form kaydedildi metodu (addorrupdate) true ise listeyi güncelle
            {
                Guncelle();

            }
        }

        private void FrmKasa_Load(object sender, EventArgs e)
        {

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string secilen = layoutView1Kasa.GetFocusedRowCellValue(colKasaKodu).ToString();
                kasaDal.Delete(context, c => c.KasaKodu == secilen);
                kasaDal.Save(context);
                Guncelle();
            }
        }
    }
}
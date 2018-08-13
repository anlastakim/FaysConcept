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
using FaysConcept.Entities.DataAccess;
using FaysConcept.Entities.Tables;

namespace FaysConcept.BackOffice.Ödeme_Türü
{

    public partial class FrmOdemeTuru : DevExpress.XtraEditors.XtraForm
    {
        FaysConceptContext context=new FaysConceptContext();
        OdemeTuruDAL odemeTuruDal=new OdemeTuruDAL();
        
        public FrmOdemeTuru()
        {
            InitializeComponent();
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmOdemeTuru_Load(object sender, EventArgs e)
        {
            OdemeListele();
        }

        public void OdemeListele()
        {
            gridControl1Odeme.DataSource = odemeTuruDal.OdemeTuruListele(context);
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            OdemeListele();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz ?", "Uyarı", 
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string secilen = gridView1Odeme.GetFocusedRowCellValue(colOdemeTuruKodu).ToString();
                odemeTuruDal.Delete(context, c => c.OdemeTuruKodu == secilen);
                odemeTuruDal.Save(context);
                OdemeListele();
            }
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            FrmOdemeIslem form=new FrmOdemeIslem(new OdemeTuru());
            form.ShowDialog();

        }

        private void btnduzenle_Click(object sender, EventArgs e)
        {
            string secilen = gridView1Odeme.GetFocusedRowCellValue(colOdemeTuruKodu).ToString();
            FrmOdemeIslem form = new FrmOdemeIslem(odemeTuruDal.GetByFilter(context,c=>c.OdemeTuruKodu==secilen));
            form.ShowDialog();
        }
    }
}
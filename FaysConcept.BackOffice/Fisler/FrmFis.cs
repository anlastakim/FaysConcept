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

namespace FaysConcept.BackOffice.Fisler
{
    public partial class FrmFis : DevExpress.XtraEditors.XtraForm
    {
        FaysConceptContext context=new FaysConceptContext();
        FisDAL fisDal=new FisDAL();
        KasaHareketDAL kasaHareketDal=new KasaHareketDAL();
        StokHareketDAL stokHareketDal=new StokHareketDAL();

        public FrmFis()
        {
            InitializeComponent();
        }

        private void FrmFis_Load(object sender, EventArgs e)
        {

        }

        private void Listele()
        {
            gridControlFisler.DataSource = fisDal.GetAll(context);
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string secilen = gridViewFisler.GetFocusedRowCellValue(colFisKodu).ToString();
                fisDal.Delete(context, c => c.FisKodu == secilen);
                kasaHareketDal.Delete(context,c=>c.FisKodu==secilen);
                //bağlı olan hareketleri silme
                stokHareketDal.Delete(context,c=>c.FisKodu==secilen);
                // bağlı olan hareketleri silme
                fisDal.Save(context);
                Listele();
            }
        }
    }
}
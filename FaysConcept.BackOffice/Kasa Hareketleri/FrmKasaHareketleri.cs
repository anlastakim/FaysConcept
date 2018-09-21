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
using FaysConcept.BackOffice.Fisler;

namespace FaysConcept.BackOffice.Kasa_Hareketleri
{
      public partial class FrmKasaHareketleri : DevExpress.XtraEditors.XtraForm
    {
        FaysConceptContext context = new FaysConceptContext();
        KasaHareketDAL kasaHareketDAL = new KasaHareketDAL();

        public FrmKasaHareketleri()
        {
            InitializeComponent();
        }

        private void Listele()
        {
            gridcontKasaHareketleri.DataSource = kasaHareketDAL.GetAll(context);
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            if (gridKasaHareketleri.OptionsView.ShowAutoFilterRow == true)
            {
                gridKasaHareketleri.OptionsView.ShowAutoFilterRow = false;
                //MessageBox.Show(gridstokhareket.RowCount.ToString());
            }
            else
            {
                gridKasaHareketleri.OptionsView.ShowAutoFilterRow = true;
                //MessageBox.Show(gridstokhareket.RowCount.ToString());
            }
        }

        private void FrmKasaHareketleri_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void txtDetayGor_Click(object sender, EventArgs e)
        {
            FrmFisIslem form=new FrmFisIslem(gridKasaHareketleri.GetFocusedRowCellValue(colFisKodu).ToString());
            form.ShowDialog();
        }
    }
}
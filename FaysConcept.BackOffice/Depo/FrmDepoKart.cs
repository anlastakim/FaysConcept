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

namespace FaysConcept.BackOffice.Depo
{
    public partial class FrmDepoKart : DevExpress.XtraEditors.XtraForm
    {
        FaysConceptContext context =new FaysConceptContext();
        DepoDAL depoDal=new DepoDAL();
        private string secilen = null;


        public FrmDepoKart()
        {
            InitializeComponent();
            
        }

        private void FrmDepoKart_Load(object sender, EventArgs e)
        {
            Listele();
           
        }

        public void Listele()
        {
            gridContDepoKart.DataSource = depoDal.GetAll(context);
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
                string secilen = gridViewDepoKart.GetFocusedRowCellValue(colDepoKodu).ToString();
                depoDal.Delete(context, c => c.DepoKodu == secilen);
                depoDal.Save(context);
                Listele();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (gridViewDepoKart.OptionsView.ShowAutoFilterRow == false)
            {
                gridViewDepoKart.OptionsView.ShowAutoFilterRow = true;
            }
            else { gridViewDepoKart.OptionsView.ShowAutoFilterRow = false; }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (gridViewDepoKart.IsFindPanelVisible)
            {
                gridViewDepoKart.HideFindPanel();
            }
            else { gridViewDepoKart.ShowFindPanel(); }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            gridViewDepoKart.ColumnsCustomization();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            FrmDepoIslem form = new FrmDepoIslem(new Entities.Tables.Depo());
            form.ShowDialog();
            if (form.kaydedildi)
            {
                Listele();
            }
        }

        private void btnduzenle_Click(object sender, EventArgs e)
        {
            secilen = gridViewDepoKart.GetFocusedRowCellValue(colDepoKodu).ToString();
            FrmDepoIslem form = new FrmDepoIslem
                (depoDal.GetByFilter(context, c => c.DepoKodu == secilen));
            form.ShowDialog();
            if (form.kaydedildi) // frmdepoislem kaydedildi metodu
            {
                Listele();

            }
        }

        private void btnDepoHareket_Click(object sender, EventArgs e)
        {

        }

        private void btnkopyala_Click(object sender, EventArgs e)
        {

        }
    }
}

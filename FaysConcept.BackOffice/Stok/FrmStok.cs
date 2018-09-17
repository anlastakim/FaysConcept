using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using FaysConcept.Entities.Context;
using FaysConcept.Entities.DataAccess;
using FaysConcept.Entities.Tables;

namespace FaysConcept.BackOffice.Stok
{
    public partial class FrmStok : DevExpress.XtraEditors.XtraForm
    {
        StokDAL stokDal = new StokDAL();
        FaysConceptContext context = new FaysConceptContext();
        private string secilen = null;


        public FrmStok()
        {

            InitializeComponent();
        }

        private void FrmStok_Load(object sender, EventArgs e)
        {
            listele();

        }

        public void listele()
        {
            gridControl1.DataSource = stokDal.GetStoklar(context);
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void btnfiltrele_Click(object sender, EventArgs e)
        //{
        //    filterControl1.ApplyFilter();
        //}

        //private void btnfiltreiptal_Click(object sender, EventArgs e)
        //{
        //    filterControl1.FilterString = null;
        //    filterControl1.ApplyFilter();
        //}

        //private void btnfiltrekapat_Click(object sender, EventArgs e)
        //{
        //    splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
        //}

        //private void btnara_Click(object sender, EventArgs e)
        //{
        //    splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
        //}

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string secilen = gridView1.GetFocusedRowCellValue(colStokKodu).ToString();
                Entities.Tables.Stok stokEntity = new Entities.Tables.Stok();
                stokDal.Delete(context, c => c.StokKodu == secilen);
                stokEntity.RefNo = -1;
                stokDal.Save(context);
                listele();
            }

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            FrmStokIslem form = new FrmStokIslem(new Entities.Tables.Stok());
            form.ShowDialog();
            if (form.saved)
            {
                listele();

            }

        }

        private void btnduzenle_Click(object sender, EventArgs e)
        {
            secilen = gridView1.GetFocusedRowCellValue(colStokKodu).ToString();
            FrmStokIslem form = new FrmStokIslem(stokDal.GetByFilter(context, c => c.StokKodu == secilen));
            form.ShowDialog();
            if (form.saved)
            {
                listele();

            }
        }

        private void btnkopyala_Click(object sender, EventArgs e)
        {
            secilen = gridView1.GetFocusedRowCellValue(colStokKodu).ToString();
            Entities.Tables.Stok stokEntity = new Entities.Tables.Stok();
            stokEntity = stokDal.GetByFilter(context, c => c.StokKodu == secilen);
            stokEntity.RefNo = -1;
            stokEntity.StokKodu = null;
            //stokkodunun benzersiz olması için null olarak gönderiliyor.
            FrmStokIslem form = new FrmStokIslem(stokEntity);
            form.ShowDialog();
            if (form.saved)
            {
                listele();

            }
        }

        private void btnstokhareket_Click(object sender, EventArgs e)
        {
            secilen = gridView1.GetFocusedRowCellValue(colStokKodu).ToString();
            // odaklanan seçilen verinin stok kodunu alma
            string secilenad = gridView1.GetFocusedRowCellValue(colStokAdi).ToString();

            FrmStokHareket form = new FrmStokHareket(secilen, secilenad);
            form.ShowDialog();

        }


    }
}
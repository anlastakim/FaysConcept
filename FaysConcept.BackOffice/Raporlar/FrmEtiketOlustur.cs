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
using DevExpress.XtraReports.UI;
using FaysConcept.Entities.Context;
using DevExpress.XtraPrinting;
using FaysConcept.BackOffice.Stok;
using DevExpress.XtraWizard;

namespace FaysConcept.BackOffice.Raporlar
{
    public partial class FrmEtiketOlustur : DevExpress.XtraEditors.XtraForm
    {
        private XtraReport rapor = new XtraReport();
        FaysConceptContext context = new FaysConceptContext();
        List<Entities.Tables.Stok> stokEntity = new List<Entities.Tables.Stok>();

        public FrmEtiketOlustur()
        {

            InitializeComponent();
            gridControl1.DataSource = stokEntity;

        }

        private int mmToPixel(int mm)
        {
            return Convert.ToInt32(mm * 3.779527559);
        }

        private void wizardControl1_FinishClick(object sender, CancelEventArgs e)
        {
            rapor.DataSource = stokEntity;
            rapor.ReportUnit = ReportUnit.TenthsOfAMillimeter;
            rapor.Height = mmToPixel(Convert.ToInt32(txtDikeyUzunluk.Value));
            rapor.Width = mmToPixel(Convert.ToInt32(txtYatayUzunluk.Value));
            rapor.Margins.Top = mmToPixel(Convert.ToInt32(txtMarginUst.Value));
            rapor.Margins.Bottom = mmToPixel(Convert.ToInt32(txtMarginAlt.Value));
            rapor.Margins.Left = mmToPixel(Convert.ToInt32(txtMarginSol.Value));
            rapor.Margins.Right = mmToPixel(Convert.ToInt32(txtMarginSağ.Value));
            rapor.RollPaper = chkRulo.Checked;


            DetailBand detail = new DetailBand();
            detail.MultiColumn.Layout = ColumnLayout.AcrossThenDown;
            detail.MultiColumn.Mode = MultiColumnMode.UseColumnWidth;
            detail.MultiColumn.ColumnWidth = mmToPixel(Convert.ToInt32(txtUzunluk.Value));
            detail.Height = mmToPixel(Convert.ToInt32(txtGenislik.Value));
            detail.MultiColumn.ColumnSpacing = mmToPixel(Convert.ToInt32(txtAraBosluk.Value));

            rapor.Bands.Add(detail);
            FrmRaporDuzenle form = new FrmRaporDuzenle(rapor);
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmStokSec form = new FrmStokSec(true);
            form.ShowDialog();
            if (form.secildi)
            {
                foreach (var itemStok in form.secilen)
                {
                    stokEntity.Add(itemStok);
                }
            }
            gridView1.RefreshData();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            gridView1.DeleteSelectedRows();
            gridView1.RefreshData();
        }

        private void wizardControl1_SelectedPageChanging(object sender, DevExpress.XtraWizard.WizardPageChangingEventArgs e)
        {
            if(e.Page==completionWizardPage1 && e.Direction==Direction.Forward && gridView1.RowCount == 0)
            {
                MessageBox.Show("Listeye ürün eklenmedi.");
                e.Cancel = true;
            }
        }
    }
}
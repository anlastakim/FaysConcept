namespace FaysConcept.Reports.Stok
{
    partial class rptStokHareket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.colStokKodu = new DevExpress.XtraReports.UI.XRTableCell();
            this.colBarkodNo = new DevExpress.XtraReports.UI.XRTableCell();
            this.colStokAdi = new DevExpress.XtraReports.UI.XRTableCell();
            this.colBirimi = new DevExpress.XtraReports.UI.XRTableCell();
            this.colStokGrubu = new DevExpress.XtraReports.UI.XRTableCell();
            this.colStokAltGrubu = new DevExpress.XtraReports.UI.XRTableCell();
            this.colStokGiris = new DevExpress.XtraReports.UI.XRTableCell();
            this.colStokCikis = new DevExpress.XtraReports.UI.XRTableCell();
            this.colMevcutStok = new DevExpress.XtraReports.UI.XRTableCell();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.Detail.HeightF = 100F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 100F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 100F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTable1
            // 
            this.xrTable1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrTable1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(2F, 1.5F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(1095.276F, 25F);
            this.xrTable1.StylePriority.UseBorderDashStyle = false;
            this.xrTable1.StylePriority.UseBorders = false;
            this.xrTable1.StylePriority.UseTextAlignment = false;
            this.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.colStokKodu,
            this.colBarkodNo,
            this.colStokAdi,
            this.colBirimi,
            this.colStokGrubu,
            this.colStokAltGrubu,
            this.colStokGiris,
            this.colStokCikis,
            this.colMevcutStok});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // colStokKodu
            // 
            this.colStokKodu.Name = "colStokKodu";
            this.colStokKodu.Text = "colStokKodu";
            this.colStokKodu.Weight = 1D;
            // 
            // colBarkodNo
            // 
            this.colBarkodNo.Name = "colBarkodNo";
            this.colBarkodNo.Text = "colBarkodNo";
            this.colBarkodNo.Weight = 0.69185847399647837D;
            // 
            // colStokAdi
            // 
            this.colStokAdi.Name = "colStokAdi";
            this.colStokAdi.Text = "colStokAdi";
            this.colStokAdi.Weight = 2.882009740701946D;
            // 
            // colBirimi
            // 
            this.colBirimi.Name = "colBirimi";
            this.colBirimi.Text = "colBirimi";
            this.colBirimi.Weight = 0.62445940446887926D;
            // 
            // colStokGrubu
            // 
            this.colStokGrubu.Name = "colStokGrubu";
            this.colStokGrubu.Text = "colStokGrubu";
            this.colStokGrubu.Weight = 0.751776809747231D;
            // 
            // colStokAltGrubu
            // 
            this.colStokAltGrubu.Name = "colStokAltGrubu";
            this.colStokAltGrubu.Text = "colStokAltGrubu";
            this.colStokAltGrubu.Weight = 0.80313058794187508D;
            // 
            // colStokGiris
            // 
            this.colStokGiris.Name = "colStokGiris";
            this.colStokGiris.Text = "colStokGiris";
            this.colStokGiris.Weight = 0.78601371496380179D;
            // 
            // colStokCikis
            // 
            this.colStokCikis.Name = "colStokCikis";
            this.colStokCikis.Text = "colStokCikis";
            this.colStokCikis.Weight = 0.75177365048680689D;
            // 
            // colMevcutStok
            // 
            this.colMevcutStok.Name = "colMevcutStok";
            this.colMevcutStok.Text = "colMevcutStok";
            this.colMevcutStok.Weight = 0.70897761769298162D;
            // 
            // PageHeader
            // 
            this.PageHeader.HeightF = 100F;
            this.PageHeader.Name = "PageHeader";
            // 
            // rptStokHareket
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PageHeader});
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(33, 35, 100, 100);
            this.PageHeight = 827;
            this.PageWidth = 1169;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Version = "17.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell colStokKodu;
        private DevExpress.XtraReports.UI.XRTableCell colBarkodNo;
        private DevExpress.XtraReports.UI.XRTableCell colStokAdi;
        private DevExpress.XtraReports.UI.XRTableCell colBirimi;
        private DevExpress.XtraReports.UI.XRTableCell colStokGrubu;
        private DevExpress.XtraReports.UI.XRTableCell colStokAltGrubu;
        private DevExpress.XtraReports.UI.XRTableCell colStokGiris;
        private DevExpress.XtraReports.UI.XRTableCell colStokCikis;
        private DevExpress.XtraReports.UI.XRTableCell colMevcutStok;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
    }
}

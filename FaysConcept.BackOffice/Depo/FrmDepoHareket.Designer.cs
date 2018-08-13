namespace FaysConcept.BackOffice.Depo
{
    partial class FrmDepoHareket
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDepoHareket));
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnkapat = new DevExpress.XtraEditors.SimpleButton();
            this.imgmenu = new System.Windows.Forms.ImageList(this.components);
            this.btnara = new DevExpress.XtraEditors.SimpleButton();
            this.btnguncelle = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            this.gridcontDepoHareket = new DevExpress.XtraGrid.GridControl();
            this.gridDepoHareket = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colfiskodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhareket = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbirimi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsaat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colaciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkdv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbirimfiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colindirimorani = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colindirimtutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltoplamtutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridcontDepoStok = new DevExpress.XtraGrid.GridControl();
            this.gridDepoStok = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBarkod1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrunAdi1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokGiris = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokCikis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmevcutstok = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridcontIstatistik = new DevExpress.XtraGrid.GridControl();
            this.gridIstatistik = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colgenelbilgi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkayitsayisi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgeneltoplam = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridcontDepoHareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDepoHareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridcontDepoStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDepoStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridcontIstatistik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridIstatistik)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("lblBaslik.Appearance.Image")));
            this.lblBaslik.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBaslik.Appearance.Options.UseFont = true;
            this.lblBaslik.Appearance.Options.UseImage = true;
            this.lblBaslik.Appearance.Options.UseImageAlign = true;
            this.lblBaslik.Appearance.Options.UseTextOptions = true;
            this.lblBaslik.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblBaslik.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBaslik.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lblBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBaslik.Location = new System.Drawing.Point(0, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(1365, 71);
            this.lblBaslik.TabIndex = 2;
            this.lblBaslik.Text = "Depo Hareketleri";
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.btnkapat);
            this.grpMenu.Controls.Add(this.btnara);
            this.grpMenu.Controls.Add(this.btnguncelle);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(0, 659);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(1365, 94);
            this.grpMenu.TabIndex = 3;
            this.grpMenu.Text = "Menü";
            // 
            // btnkapat
            // 
            this.btnkapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnkapat.ImageOptions.ImageIndex = 0;
            this.btnkapat.ImageOptions.ImageList = this.imgmenu;
            this.btnkapat.Location = new System.Drawing.Point(1266, 24);
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.Size = new System.Drawing.Size(87, 65);
            this.btnkapat.TabIndex = 4;
            this.btnkapat.Text = "Kapat";
            this.btnkapat.Click += new System.EventHandler(this.btnkapat_Click);
            // 
            // imgmenu
            // 
            this.imgmenu.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgmenu.ImageSize = new System.Drawing.Size(16, 16);
            this.imgmenu.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnara
            // 
            this.btnara.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnara.ImageOptions.ImageIndex = 2;
            this.btnara.ImageOptions.ImageList = this.imgmenu;
            this.btnara.Location = new System.Drawing.Point(105, 24);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(87, 65);
            this.btnara.TabIndex = 3;
            this.btnara.Text = "Ara";
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnguncelle.ImageOptions.ImageIndex = 1;
            this.btnguncelle.ImageOptions.ImageList = this.imgmenu;
            this.btnguncelle.Location = new System.Drawing.Point(12, 24);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(87, 65);
            this.btnguncelle.TabIndex = 2;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 71);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gridSplitContainer1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1365, 588);
            this.splitContainerControl1.SplitterPosition = 303;
            this.splitContainerControl1.TabIndex = 4;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gridSplitContainer1
            // 
            this.gridSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSplitContainer1.Grid = this.gridcontDepoHareket;
            this.gridSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.gridSplitContainer1.Name = "gridSplitContainer1";
            this.gridSplitContainer1.Panel1.Controls.Add(this.gridcontDepoHareket);
            this.gridSplitContainer1.Size = new System.Drawing.Size(1365, 303);
            this.gridSplitContainer1.TabIndex = 0;
            // 
            // gridcontDepoHareket
            // 
            this.gridcontDepoHareket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridcontDepoHareket.Location = new System.Drawing.Point(0, 0);
            this.gridcontDepoHareket.MainView = this.gridDepoHareket;
            this.gridcontDepoHareket.Name = "gridcontDepoHareket";
            this.gridcontDepoHareket.Size = new System.Drawing.Size(1365, 303);
            this.gridcontDepoHareket.TabIndex = 2;
            this.gridcontDepoHareket.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridDepoHareket});
            // 
            // gridDepoHareket
            // 
            this.gridDepoHareket.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colfiskodu,
            this.colhareket,
            this.colbirimi,
            this.coltarih,
            this.colsaat,
            this.colaciklama,
            this.colkdv,
            this.colmiktar,
            this.colbirimfiyat,
            this.colindirimorani,
            this.colindirimtutar,
            this.coltoplamtutar});
            this.gridDepoHareket.GridControl = this.gridcontDepoHareket;
            this.gridDepoHareket.Name = "gridDepoHareket";
            // 
            // colfiskodu
            // 
            this.colfiskodu.Caption = "Fiş Kodu";
            this.colfiskodu.FieldName = "FisKodu";
            this.colfiskodu.Name = "colfiskodu";
            this.colfiskodu.Visible = true;
            this.colfiskodu.VisibleIndex = 0;
            // 
            // colhareket
            // 
            this.colhareket.Caption = "Hareket";
            this.colhareket.FieldName = "Hareket";
            this.colhareket.Name = "colhareket";
            this.colhareket.Visible = true;
            this.colhareket.VisibleIndex = 1;
            // 
            // colbirimi
            // 
            this.colbirimi.Caption = "Birimi";
            this.colbirimi.FieldName = "Birimi";
            this.colbirimi.Name = "colbirimi";
            this.colbirimi.Visible = true;
            this.colbirimi.VisibleIndex = 2;
            // 
            // coltarih
            // 
            this.coltarih.Caption = "Tarih";
            this.coltarih.FieldName = "Tarih";
            this.coltarih.Name = "coltarih";
            this.coltarih.Visible = true;
            this.coltarih.VisibleIndex = 3;
            // 
            // colsaat
            // 
            this.colsaat.Caption = "Saat";
            this.colsaat.FieldName = "Saat";
            this.colsaat.Name = "colsaat";
            this.colsaat.Visible = true;
            this.colsaat.VisibleIndex = 4;
            // 
            // colaciklama
            // 
            this.colaciklama.Caption = "Açıklama";
            this.colaciklama.FieldName = "Aciklama";
            this.colaciklama.Name = "colaciklama";
            this.colaciklama.Visible = true;
            this.colaciklama.VisibleIndex = 5;
            // 
            // colkdv
            // 
            this.colkdv.Caption = "Kdv(%)";
            this.colkdv.FieldName = "Kdv";
            this.colkdv.Name = "colkdv";
            this.colkdv.Visible = true;
            this.colkdv.VisibleIndex = 6;
            // 
            // colmiktar
            // 
            this.colmiktar.Caption = "Miktar";
            this.colmiktar.FieldName = "Miktar";
            this.colmiktar.Name = "colmiktar";
            this.colmiktar.Visible = true;
            this.colmiktar.VisibleIndex = 7;
            // 
            // colbirimfiyat
            // 
            this.colbirimfiyat.Caption = "Birim Fiyatı";
            this.colbirimfiyat.FieldName = "BirimFiyat";
            this.colbirimfiyat.Name = "colbirimfiyat";
            this.colbirimfiyat.Visible = true;
            this.colbirimfiyat.VisibleIndex = 8;
            // 
            // colindirimorani
            // 
            this.colindirimorani.Caption = "İndirim Oranı";
            this.colindirimorani.FieldName = "IndirimOrani";
            this.colindirimorani.Name = "colindirimorani";
            this.colindirimorani.Visible = true;
            this.colindirimorani.VisibleIndex = 9;
            // 
            // colindirimtutar
            // 
            this.colindirimtutar.Caption = "İndirim Tutarı";
            this.colindirimtutar.FieldName = "IndirimTutar";
            this.colindirimtutar.Name = "colindirimtutar";
            this.colindirimtutar.Visible = true;
            this.colindirimtutar.VisibleIndex = 10;
            // 
            // coltoplamtutar
            // 
            this.coltoplamtutar.Caption = "Toplam Tutar";
            this.coltoplamtutar.FieldName = "ToplamTutar";
            this.coltoplamtutar.Name = "coltoplamtutar";
            this.coltoplamtutar.Visible = true;
            this.coltoplamtutar.VisibleIndex = 11;
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.groupControl2);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(1365, 280);
            this.splitContainerControl2.SplitterPosition = 732;
            this.splitContainerControl2.TabIndex = 0;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridcontDepoStok);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(732, 280);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Depodaki Stok Miktarları";
            // 
            // gridcontDepoStok
            // 
            this.gridcontDepoStok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridcontDepoStok.Location = new System.Drawing.Point(2, 20);
            this.gridcontDepoStok.MainView = this.gridDepoStok;
            this.gridcontDepoStok.Name = "gridcontDepoStok";
            this.gridcontDepoStok.Size = new System.Drawing.Size(728, 258);
            this.gridcontDepoStok.TabIndex = 2;
            this.gridcontDepoStok.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridDepoStok});
            // 
            // gridDepoStok
            // 
            this.gridDepoStok.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBarkod1,
            this.colUrunAdi1,
            this.colStokGiris,
            this.colStokCikis,
            this.colmevcutstok});
            this.gridDepoStok.GridControl = this.gridcontDepoStok;
            this.gridDepoStok.Name = "gridDepoStok";
            this.gridDepoStok.OptionsView.ShowGroupPanel = false;
            // 
            // colBarkod1
            // 
            this.colBarkod1.Caption = "Barkod";
            this.colBarkod1.FieldName = "Barkod";
            this.colBarkod1.Name = "colBarkod1";
            this.colBarkod1.OptionsColumn.AllowEdit = false;
            this.colBarkod1.Visible = true;
            this.colBarkod1.VisibleIndex = 0;
            this.colBarkod1.Width = 210;
            // 
            // colUrunAdi1
            // 
            this.colUrunAdi1.Caption = "Urun Adı";
            this.colUrunAdi1.FieldName = "StokAdi";
            this.colUrunAdi1.Name = "colUrunAdi1";
            this.colUrunAdi1.OptionsColumn.AllowEdit = false;
            this.colUrunAdi1.Visible = true;
            this.colUrunAdi1.VisibleIndex = 1;
            this.colUrunAdi1.Width = 156;
            // 
            // colStokGiris
            // 
            this.colStokGiris.Caption = "Stok Giriş";
            this.colStokGiris.FieldName = "StokGiris";
            this.colStokGiris.Name = "colStokGiris";
            this.colStokGiris.OptionsColumn.AllowEdit = false;
            this.colStokGiris.Visible = true;
            this.colStokGiris.VisibleIndex = 2;
            this.colStokGiris.Width = 159;
            // 
            // colStokCikis
            // 
            this.colStokCikis.Caption = "Stok Çıkış";
            this.colStokCikis.FieldName = "StokCikis";
            this.colStokCikis.Name = "colStokCikis";
            this.colStokCikis.Visible = true;
            this.colStokCikis.VisibleIndex = 3;
            this.colStokCikis.Width = 187;
            // 
            // colmevcutstok
            // 
            this.colmevcutstok.Caption = "Mevcut Stok";
            this.colmevcutstok.FieldName = "MevcutStok";
            this.colmevcutstok.Name = "colmevcutstok";
            this.colmevcutstok.Visible = true;
            this.colmevcutstok.VisibleIndex = 4;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridcontIstatistik);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(628, 280);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Depo İstatistikleri";
            // 
            // gridcontIstatistik
            // 
            this.gridcontIstatistik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridcontIstatistik.Location = new System.Drawing.Point(2, 20);
            this.gridcontIstatistik.MainView = this.gridIstatistik;
            this.gridcontIstatistik.Name = "gridcontIstatistik";
            this.gridcontIstatistik.Size = new System.Drawing.Size(624, 258);
            this.gridcontIstatistik.TabIndex = 2;
            this.gridcontIstatistik.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridIstatistik});
            // 
            // gridIstatistik
            // 
            this.gridIstatistik.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colgenelbilgi,
            this.colkayitsayisi,
            this.colgeneltoplam});
            this.gridIstatistik.GridControl = this.gridcontIstatistik;
            this.gridIstatistik.Name = "gridIstatistik";
            this.gridIstatistik.OptionsView.ShowGroupPanel = false;
            // 
            // colgenelbilgi
            // 
            this.colgenelbilgi.Caption = "Bilgi";
            this.colgenelbilgi.FieldName = "Bilgi";
            this.colgenelbilgi.Name = "colgenelbilgi";
            this.colgenelbilgi.OptionsColumn.AllowEdit = false;
            this.colgenelbilgi.Visible = true;
            this.colgenelbilgi.VisibleIndex = 1;
            this.colgenelbilgi.Width = 181;
            // 
            // colkayitsayisi
            // 
            this.colkayitsayisi.Caption = "Kayıt Sayısı";
            this.colkayitsayisi.FieldName = "KayitSayisi";
            this.colkayitsayisi.Name = "colkayitsayisi";
            this.colkayitsayisi.Visible = true;
            this.colkayitsayisi.VisibleIndex = 0;
            this.colkayitsayisi.Width = 169;
            // 
            // colgeneltoplam
            // 
            this.colgeneltoplam.Caption = "Toplam";
            this.colgeneltoplam.DisplayFormat.FormatString = "C2";
            this.colgeneltoplam.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colgeneltoplam.FieldName = "Tutar";
            this.colgeneltoplam.Name = "colgeneltoplam";
            this.colgeneltoplam.OptionsColumn.AllowEdit = false;
            this.colgeneltoplam.Visible = true;
            this.colgeneltoplam.VisibleIndex = 2;
            this.colgeneltoplam.Width = 258;
            // 
            // FrmDepoHareket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 753);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.lblBaslik);
            this.Name = "FrmDepoHareket";
            this.Text = "Depo Hareketleri";
            this.Load += new System.EventHandler(this.FrmDepoHareket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridcontDepoHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDepoHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridcontDepoStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDepoStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridcontIstatistik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridIstatistik)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraEditors.SimpleButton btnkapat;
        private DevExpress.XtraEditors.SimpleButton btnara;
        private DevExpress.XtraEditors.SimpleButton btnguncelle;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridcontDepoHareket;
        private DevExpress.XtraGrid.Views.Grid.GridView gridDepoHareket;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        public System.Windows.Forms.ImageList imgmenu;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridcontDepoStok;
        private DevExpress.XtraGrid.Views.Grid.GridView gridDepoStok;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkod1;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunAdi1;
        private DevExpress.XtraGrid.Columns.GridColumn colStokGiris;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridcontIstatistik;
        private DevExpress.XtraGrid.Views.Grid.GridView gridIstatistik;
        private DevExpress.XtraGrid.Columns.GridColumn colgenelbilgi;
        private DevExpress.XtraGrid.Columns.GridColumn colgeneltoplam;
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
        private DevExpress.XtraGrid.Columns.GridColumn colStokCikis;
        private DevExpress.XtraGrid.Columns.GridColumn colfiskodu;
        private DevExpress.XtraGrid.Columns.GridColumn colhareket;
        private DevExpress.XtraGrid.Columns.GridColumn colbirimi;
        private DevExpress.XtraGrid.Columns.GridColumn colkayitsayisi;
        private DevExpress.XtraGrid.Columns.GridColumn coltarih;
        private DevExpress.XtraGrid.Columns.GridColumn colsaat;
        private DevExpress.XtraGrid.Columns.GridColumn colaciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colkdv;
        private DevExpress.XtraGrid.Columns.GridColumn colmiktar;
        private DevExpress.XtraGrid.Columns.GridColumn colbirimfiyat;
        private DevExpress.XtraGrid.Columns.GridColumn colindirimorani;
        private DevExpress.XtraGrid.Columns.GridColumn colindirimtutar;
        private DevExpress.XtraGrid.Columns.GridColumn coltoplamtutar;
        private DevExpress.XtraGrid.Columns.GridColumn colmevcutstok;
    }
}
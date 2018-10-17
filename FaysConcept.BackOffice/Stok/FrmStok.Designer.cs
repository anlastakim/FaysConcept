using System;

namespace FaysConcept.BackOffice.Stok
{
    partial class FrmStok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStok));
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnkapat = new DevExpress.XtraEditors.SimpleButton();
            this.imgmenu = new System.Windows.Forms.ImageList(this.components);
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnHareket = new DevExpress.XtraEditors.SimpleButton();
            this.btnKopyala = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRefNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDurumu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarkodNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarkodTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirimi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokGrubu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokAltGrubu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarka = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOzelKod1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOzelKod2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOzelKod3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOzelKod4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGarantiSuresi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUreticiKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlisKdv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSatisKdv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlisFiyat1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlisFiyat2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlisFiyat3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSatisFiyat1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSatisFiyat2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSatisFiyat3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMinStokMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaxStokMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StokGiris = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StokCikis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MevcutStok = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
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
            this.lblBaslik.Size = new System.Drawing.Size(1370, 50);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Stok Kartları";
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.btnkapat);
            this.grpMenu.Controls.Add(this.btnGuncelle);
            this.grpMenu.Controls.Add(this.btnHareket);
            this.grpMenu.Controls.Add(this.btnKopyala);
            this.grpMenu.Controls.Add(this.btnSil);
            this.grpMenu.Controls.Add(this.btnDuzenle);
            this.grpMenu.Controls.Add(this.btnEkle);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(0, 660);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(1370, 69);
            this.grpMenu.TabIndex = 1;
            this.grpMenu.Text = "Menü";
            // 
            // btnkapat
            // 
            this.btnkapat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnkapat.ImageOptions.ImageIndex = 6;
            this.btnkapat.ImageOptions.ImageList = this.imgmenu;
            this.btnkapat.Location = new System.Drawing.Point(1271, 22);
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.Size = new System.Drawing.Size(87, 42);
            this.btnkapat.TabIndex = 4;
            this.btnkapat.Text = "Kapat";
            this.btnkapat.Click += new System.EventHandler(this.btnkapat_Click);
            // 
            // imgmenu
            // 
            this.imgmenu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgmenu.ImageStream")));
            this.imgmenu.TransparentColor = System.Drawing.Color.Transparent;
            this.imgmenu.Images.SetKeyName(0, "refresh.png");
            this.imgmenu.Images.SetKeyName(1, "Stok Düzenle.png");
            this.imgmenu.Images.SetKeyName(2, "Stok Ekle.png");
            this.imgmenu.Images.SetKeyName(3, "Stok Kopyala.png");
            this.imgmenu.Images.SetKeyName(4, "Stok Sil.png");
            this.imgmenu.Images.SetKeyName(5, "view.png");
            this.imgmenu.Images.SetKeyName(6, "folder_out.png");
            this.imgmenu.Images.SetKeyName(7, "funnel.png");
            this.imgmenu.Images.SetKeyName(8, "funnel_delete.png");
            this.imgmenu.Images.SetKeyName(9, "StokHareket.png");
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuncelle.ImageOptions.ImageIndex = 0;
            this.btnGuncelle.ImageOptions.ImageList = this.imgmenu;
            this.btnGuncelle.Location = new System.Drawing.Point(492, 23);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(87, 42);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnHareket
            // 
            this.btnHareket.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHareket.ImageOptions.ImageIndex = 9;
            this.btnHareket.ImageOptions.ImageList = this.imgmenu;
            this.btnHareket.Location = new System.Drawing.Point(384, 23);
            this.btnHareket.Name = "btnHareket";
            this.btnHareket.Size = new System.Drawing.Size(102, 42);
            this.btnHareket.TabIndex = 4;
            this.btnHareket.Text = "Stok Durum";
            this.btnHareket.Click += new System.EventHandler(this.btnstokhareket_Click);
            // 
            // btnKopyala
            // 
            this.btnKopyala.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnKopyala.ImageOptions.ImageIndex = 3;
            this.btnKopyala.ImageOptions.ImageList = this.imgmenu;
            this.btnKopyala.Location = new System.Drawing.Point(291, 23);
            this.btnKopyala.Name = "btnKopyala";
            this.btnKopyala.Size = new System.Drawing.Size(87, 42);
            this.btnKopyala.TabIndex = 4;
            this.btnKopyala.Text = "Kopyala";
            this.btnKopyala.Click += new System.EventHandler(this.btnkopyala_Click);
            // 
            // btnSil
            // 
            this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSil.ImageOptions.ImageIndex = 4;
            this.btnSil.ImageOptions.ImageList = this.imgmenu;
            this.btnSil.Location = new System.Drawing.Point(198, 23);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(87, 42);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDuzenle.ImageOptions.ImageIndex = 1;
            this.btnDuzenle.ImageOptions.ImageList = this.imgmenu;
            this.btnDuzenle.Location = new System.Drawing.Point(105, 23);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(87, 42);
            this.btnDuzenle.TabIndex = 3;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.Click += new System.EventHandler(this.btnduzenle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEkle.ImageOptions.ImageIndex = 2;
            this.btnEkle.ImageOptions.ImageList = this.imgmenu;
            this.btnEkle.Location = new System.Drawing.Point(12, 23);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(87, 42);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 50);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1370, 610);
            this.splitContainerControl1.SplitterPosition = 0;
            this.splitContainerControl1.TabIndex = 2;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1370, 605);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRefNo,
            this.colDurumu,
            this.colStokKodu,
            this.colStokAdi,
            this.colBarkodNo,
            this.colBarkodTuru,
            this.colBirimi,
            this.colStokGrubu,
            this.colStokAltGrubu,
            this.colMarka,
            this.colModel,
            this.colOzelKod1,
            this.colOzelKod2,
            this.colOzelKod3,
            this.colOzelKod4,
            this.colGarantiSuresi,
            this.colUreticiKodu,
            this.colAlisKdv,
            this.colSatisKdv,
            this.colAlisFiyat1,
            this.colAlisFiyat2,
            this.colAlisFiyat3,
            this.colSatisFiyat1,
            this.colSatisFiyat2,
            this.colSatisFiyat3,
            this.colMinStokMiktar,
            this.colMaxStokMiktar,
            this.colAciklama,
            this.StokGiris,
            this.StokCikis,
            this.MevcutStok});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colRefNo
            // 
            this.colRefNo.Caption = "RefNo";
            this.colRefNo.FieldName = "RefNo";
            this.colRefNo.Name = "colRefNo";
            this.colRefNo.OptionsColumn.AllowEdit = false;
            this.colRefNo.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colDurumu
            // 
            this.colDurumu.Caption = "Durumu";
            this.colDurumu.FieldName = "Durumu";
            this.colDurumu.Name = "colDurumu";
            this.colDurumu.OptionsColumn.AllowEdit = false;
            this.colDurumu.Visible = true;
            this.colDurumu.VisibleIndex = 0;
            this.colDurumu.Width = 52;
            // 
            // colStokKodu
            // 
            this.colStokKodu.Caption = "Stok Kodu";
            this.colStokKodu.FieldName = "StokKodu";
            this.colStokKodu.Name = "colStokKodu";
            this.colStokKodu.OptionsColumn.AllowEdit = false;
            this.colStokKodu.Visible = true;
            this.colStokKodu.VisibleIndex = 1;
            this.colStokKodu.Width = 112;
            // 
            // colStokAdi
            // 
            this.colStokAdi.Caption = "Stok Adı";
            this.colStokAdi.FieldName = "StokAdi";
            this.colStokAdi.Name = "colStokAdi";
            this.colStokAdi.OptionsColumn.AllowEdit = false;
            this.colStokAdi.Visible = true;
            this.colStokAdi.VisibleIndex = 3;
            this.colStokAdi.Width = 207;
            // 
            // colBarkodNo
            // 
            this.colBarkodNo.Caption = "Barkod No";
            this.colBarkodNo.FieldName = "BarkodNo";
            this.colBarkodNo.Name = "colBarkodNo";
            this.colBarkodNo.OptionsColumn.AllowEdit = false;
            this.colBarkodNo.Visible = true;
            this.colBarkodNo.VisibleIndex = 2;
            this.colBarkodNo.Width = 97;
            // 
            // colBarkodTuru
            // 
            this.colBarkodTuru.Caption = "Barkod Türü";
            this.colBarkodTuru.FieldName = "BarkodTuru";
            this.colBarkodTuru.Name = "colBarkodTuru";
            this.colBarkodTuru.OptionsColumn.AllowEdit = false;
            this.colBarkodTuru.Visible = true;
            this.colBarkodTuru.VisibleIndex = 4;
            this.colBarkodTuru.Width = 79;
            // 
            // colBirimi
            // 
            this.colBirimi.Caption = "Birimi";
            this.colBirimi.FieldName = "Birimi";
            this.colBirimi.Name = "colBirimi";
            this.colBirimi.OptionsColumn.AllowEdit = false;
            this.colBirimi.Visible = true;
            this.colBirimi.VisibleIndex = 5;
            this.colBirimi.Width = 44;
            // 
            // colStokGrubu
            // 
            this.colStokGrubu.Caption = "Stok Grubu";
            this.colStokGrubu.FieldName = "StokGrubu";
            this.colStokGrubu.Name = "colStokGrubu";
            this.colStokGrubu.OptionsColumn.AllowEdit = false;
            this.colStokGrubu.Visible = true;
            this.colStokGrubu.VisibleIndex = 6;
            this.colStokGrubu.Width = 63;
            // 
            // colStokAltGrubu
            // 
            this.colStokAltGrubu.Caption = "Stok Alt Grubu";
            this.colStokAltGrubu.FieldName = "StokAltGrubu";
            this.colStokAltGrubu.Name = "colStokAltGrubu";
            this.colStokAltGrubu.OptionsColumn.AllowEdit = false;
            this.colStokAltGrubu.Visible = true;
            this.colStokAltGrubu.VisibleIndex = 7;
            this.colStokAltGrubu.Width = 85;
            // 
            // colMarka
            // 
            this.colMarka.Caption = "Marka";
            this.colMarka.FieldName = "Marka";
            this.colMarka.Name = "colMarka";
            this.colMarka.OptionsColumn.AllowEdit = false;
            // 
            // colModel
            // 
            this.colModel.Caption = "Model";
            this.colModel.FieldName = "Model";
            this.colModel.Name = "colModel";
            this.colModel.OptionsColumn.AllowEdit = false;
            // 
            // colOzelKod1
            // 
            this.colOzelKod1.Caption = "Özel Kod 1";
            this.colOzelKod1.FieldName = "OzelKod1";
            this.colOzelKod1.Name = "colOzelKod1";
            this.colOzelKod1.OptionsColumn.AllowEdit = false;
            // 
            // colOzelKod2
            // 
            this.colOzelKod2.Caption = "Özel Kod 2";
            this.colOzelKod2.FieldName = "OzelKod2";
            this.colOzelKod2.Name = "colOzelKod2";
            this.colOzelKod2.OptionsColumn.AllowEdit = false;
            // 
            // colOzelKod3
            // 
            this.colOzelKod3.Caption = "Özel Kod 3";
            this.colOzelKod3.FieldName = "OzelKod3";
            this.colOzelKod3.Name = "colOzelKod3";
            this.colOzelKod3.OptionsColumn.AllowEdit = false;
            // 
            // colOzelKod4
            // 
            this.colOzelKod4.Caption = "Özel Kod 4";
            this.colOzelKod4.FieldName = "OzelKod4";
            this.colOzelKod4.Name = "colOzelKod4";
            this.colOzelKod4.OptionsColumn.AllowEdit = false;
            // 
            // colGarantiSuresi
            // 
            this.colGarantiSuresi.Caption = "Garanti Süresi";
            this.colGarantiSuresi.FieldName = "GarantiSuresi";
            this.colGarantiSuresi.Name = "colGarantiSuresi";
            this.colGarantiSuresi.OptionsColumn.AllowEdit = false;
            // 
            // colUreticiKodu
            // 
            this.colUreticiKodu.Caption = "Üretici Kodu";
            this.colUreticiKodu.FieldName = "UreticiKodu";
            this.colUreticiKodu.Name = "colUreticiKodu";
            this.colUreticiKodu.OptionsColumn.AllowEdit = false;
            // 
            // colAlisKdv
            // 
            this.colAlisKdv.Caption = "Alış Kdv";
            this.colAlisKdv.DisplayFormat.FormatString = "\'%\'0";
            this.colAlisKdv.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAlisKdv.FieldName = "AlisKdv";
            this.colAlisKdv.Name = "colAlisKdv";
            this.colAlisKdv.OptionsColumn.AllowEdit = false;
            // 
            // colSatisKdv
            // 
            this.colSatisKdv.Caption = "Satış Kdv";
            this.colSatisKdv.DisplayFormat.FormatString = "\'%\'0";
            this.colSatisKdv.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSatisKdv.FieldName = "SatisKdv";
            this.colSatisKdv.Name = "colSatisKdv";
            this.colSatisKdv.OptionsColumn.AllowEdit = false;
            // 
            // colAlisFiyat1
            // 
            this.colAlisFiyat1.Caption = "Alış Fiyatı 1";
            this.colAlisFiyat1.DisplayFormat.FormatString = "C2";
            this.colAlisFiyat1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAlisFiyat1.FieldName = "AlisFiyat1";
            this.colAlisFiyat1.Name = "colAlisFiyat1";
            this.colAlisFiyat1.OptionsColumn.AllowEdit = false;
            // 
            // colAlisFiyat2
            // 
            this.colAlisFiyat2.Caption = "Alış Fiyatı 2";
            this.colAlisFiyat2.DisplayFormat.FormatString = "C2";
            this.colAlisFiyat2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAlisFiyat2.FieldName = "AlisFiyat2";
            this.colAlisFiyat2.Name = "colAlisFiyat2";
            this.colAlisFiyat2.OptionsColumn.AllowEdit = false;
            // 
            // colAlisFiyat3
            // 
            this.colAlisFiyat3.Caption = "Alış Fiyatı 3";
            this.colAlisFiyat3.DisplayFormat.FormatString = "C2";
            this.colAlisFiyat3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAlisFiyat3.FieldName = "AlisFiyat3";
            this.colAlisFiyat3.Name = "colAlisFiyat3";
            this.colAlisFiyat3.OptionsColumn.AllowEdit = false;
            // 
            // colSatisFiyat1
            // 
            this.colSatisFiyat1.Caption = "Satış Fiyatı 1";
            this.colSatisFiyat1.DisplayFormat.FormatString = "C2";
            this.colSatisFiyat1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSatisFiyat1.FieldName = "SatisFiyat1";
            this.colSatisFiyat1.Name = "colSatisFiyat1";
            this.colSatisFiyat1.OptionsColumn.AllowEdit = false;
            // 
            // colSatisFiyat2
            // 
            this.colSatisFiyat2.Caption = "Satış Fiyatı 2";
            this.colSatisFiyat2.DisplayFormat.FormatString = "C2";
            this.colSatisFiyat2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSatisFiyat2.FieldName = "SatisFiyat2";
            this.colSatisFiyat2.Name = "colSatisFiyat2";
            this.colSatisFiyat2.OptionsColumn.AllowEdit = false;
            // 
            // colSatisFiyat3
            // 
            this.colSatisFiyat3.Caption = "Satış Fiyatı 3";
            this.colSatisFiyat3.DisplayFormat.FormatString = "C2";
            this.colSatisFiyat3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSatisFiyat3.FieldName = "SatisFiyat3";
            this.colSatisFiyat3.Name = "colSatisFiyat3";
            this.colSatisFiyat3.OptionsColumn.AllowEdit = false;
            // 
            // colMinStokMiktar
            // 
            this.colMinStokMiktar.Caption = "Min.Stok Miktarı";
            this.colMinStokMiktar.FieldName = "MinStokMiktar";
            this.colMinStokMiktar.Name = "colMinStokMiktar";
            this.colMinStokMiktar.OptionsColumn.AllowEdit = false;
            this.colMinStokMiktar.Visible = true;
            this.colMinStokMiktar.VisibleIndex = 8;
            this.colMinStokMiktar.Width = 84;
            // 
            // colMaxStokMiktar
            // 
            this.colMaxStokMiktar.Caption = "Max.Stok Miktarı";
            this.colMaxStokMiktar.FieldName = "MaxStokMiktar";
            this.colMaxStokMiktar.Name = "colMaxStokMiktar";
            this.colMaxStokMiktar.OptionsColumn.AllowEdit = false;
            this.colMaxStokMiktar.Visible = true;
            this.colMaxStokMiktar.VisibleIndex = 9;
            this.colMaxStokMiktar.Width = 94;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 10;
            this.colAciklama.Width = 184;
            // 
            // StokGiris
            // 
            this.StokGiris.Caption = "Stok Giriş";
            this.StokGiris.FieldName = "StokGiris";
            this.StokGiris.Name = "StokGiris";
            this.StokGiris.OptionsColumn.AllowEdit = false;
            this.StokGiris.Visible = true;
            this.StokGiris.VisibleIndex = 11;
            this.StokGiris.Width = 67;
            // 
            // StokCikis
            // 
            this.StokCikis.Caption = "Stok Çıkış";
            this.StokCikis.FieldName = "StokCikis";
            this.StokCikis.Name = "StokCikis";
            this.StokCikis.OptionsColumn.AllowEdit = false;
            this.StokCikis.Visible = true;
            this.StokCikis.VisibleIndex = 12;
            this.StokCikis.Width = 83;
            // 
            // MevcutStok
            // 
            this.MevcutStok.Caption = "Mevcut Stok";
            this.MevcutStok.FieldName = "MevcutStok";
            this.MevcutStok.Name = "MevcutStok";
            this.MevcutStok.OptionsColumn.AllowEdit = false;
            this.MevcutStok.Visible = true;
            this.MevcutStok.VisibleIndex = 13;
            this.MevcutStok.Width = 101;
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2});
            this.barManager1.MaxItemId = 2;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1370, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 729);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1370, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 729);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1370, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 729);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // FrmStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 729);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "FrmStok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Kartları Bölümü";
            this.Load += new System.EventHandler(this.FrmStok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

   

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnKopyala;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnDuzenle;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        public System.Windows.Forms.ImageList imgmenu;
        private DevExpress.XtraEditors.SimpleButton btnkapat;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colRefNo;
        private DevExpress.XtraGrid.Columns.GridColumn colDurumu;
        private DevExpress.XtraGrid.Columns.GridColumn colStokKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colStokAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkodNo;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkodTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimi;
        private DevExpress.XtraGrid.Columns.GridColumn colStokGrubu;
        private DevExpress.XtraGrid.Columns.GridColumn colStokAltGrubu;
        private DevExpress.XtraGrid.Columns.GridColumn colMarka;
        private DevExpress.XtraGrid.Columns.GridColumn colModel;
        private DevExpress.XtraGrid.Columns.GridColumn colOzelKod1;
        private DevExpress.XtraGrid.Columns.GridColumn colOzelKod2;
        private DevExpress.XtraGrid.Columns.GridColumn colOzelKod3;
        private DevExpress.XtraGrid.Columns.GridColumn colOzelKod4;
        private DevExpress.XtraGrid.Columns.GridColumn colGarantiSuresi;
        private DevExpress.XtraGrid.Columns.GridColumn colUreticiKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colAlisKdv;
        private DevExpress.XtraGrid.Columns.GridColumn colSatisKdv;
        private DevExpress.XtraGrid.Columns.GridColumn colAlisFiyat1;
        private DevExpress.XtraGrid.Columns.GridColumn colAlisFiyat2;
        private DevExpress.XtraGrid.Columns.GridColumn colAlisFiyat3;
        private DevExpress.XtraGrid.Columns.GridColumn colSatisFiyat1;
        private DevExpress.XtraGrid.Columns.GridColumn colSatisFiyat2;
        private DevExpress.XtraGrid.Columns.GridColumn colSatisFiyat3;
        private DevExpress.XtraGrid.Columns.GridColumn colMinStokMiktar;
        private DevExpress.XtraGrid.Columns.GridColumn colMaxStokMiktar;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn StokGiris;
        private DevExpress.XtraGrid.Columns.GridColumn StokCikis;
        private DevExpress.XtraGrid.Columns.GridColumn MevcutStok;
        private DevExpress.XtraEditors.SimpleButton btnHareket;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
    }
}
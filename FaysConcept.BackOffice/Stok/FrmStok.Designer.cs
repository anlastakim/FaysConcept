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
            this.btnguncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnstokhareket = new DevExpress.XtraEditors.SimpleButton();
            this.btnkopyala = new DevExpress.XtraEditors.SimpleButton();
            this.btnsil = new DevExpress.XtraEditors.SimpleButton();
            this.btnduzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnekle = new DevExpress.XtraEditors.SimpleButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.grpMenu.Controls.Add(this.btnguncelle);
            this.grpMenu.Controls.Add(this.btnstokhareket);
            this.grpMenu.Controls.Add(this.btnkopyala);
            this.grpMenu.Controls.Add(this.btnsil);
            this.grpMenu.Controls.Add(this.btnduzenle);
            this.grpMenu.Controls.Add(this.btnekle);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(0, 615);
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
            // btnguncelle
            // 
            this.btnguncelle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnguncelle.ImageOptions.ImageIndex = 0;
            this.btnguncelle.ImageOptions.ImageList = this.imgmenu;
            this.btnguncelle.Location = new System.Drawing.Point(492, 23);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(87, 42);
            this.btnguncelle.TabIndex = 4;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnstokhareket
            // 
            this.btnstokhareket.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnstokhareket.ImageOptions.ImageIndex = 9;
            this.btnstokhareket.ImageOptions.ImageList = this.imgmenu;
            this.btnstokhareket.Location = new System.Drawing.Point(384, 23);
            this.btnstokhareket.Name = "btnstokhareket";
            this.btnstokhareket.Size = new System.Drawing.Size(102, 42);
            this.btnstokhareket.TabIndex = 4;
            this.btnstokhareket.Text = "Stok Durum";
            this.btnstokhareket.Click += new System.EventHandler(this.btnstokhareket_Click);
            // 
            // btnkopyala
            // 
            this.btnkopyala.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnkopyala.ImageOptions.ImageIndex = 3;
            this.btnkopyala.ImageOptions.ImageList = this.imgmenu;
            this.btnkopyala.Location = new System.Drawing.Point(291, 23);
            this.btnkopyala.Name = "btnkopyala";
            this.btnkopyala.Size = new System.Drawing.Size(87, 42);
            this.btnkopyala.TabIndex = 4;
            this.btnkopyala.Text = "Kopyala";
            this.btnkopyala.Click += new System.EventHandler(this.btnkopyala_Click);
            // 
            // btnsil
            // 
            this.btnsil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnsil.ImageOptions.ImageIndex = 4;
            this.btnsil.ImageOptions.ImageList = this.imgmenu;
            this.btnsil.Location = new System.Drawing.Point(198, 23);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(87, 42);
            this.btnsil.TabIndex = 4;
            this.btnsil.Text = "Sil";
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnduzenle
            // 
            this.btnduzenle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnduzenle.ImageOptions.ImageIndex = 1;
            this.btnduzenle.ImageOptions.ImageList = this.imgmenu;
            this.btnduzenle.Location = new System.Drawing.Point(105, 23);
            this.btnduzenle.Name = "btnduzenle";
            this.btnduzenle.Size = new System.Drawing.Size(87, 42);
            this.btnduzenle.TabIndex = 3;
            this.btnduzenle.Text = "Düzenle";
            this.btnduzenle.Click += new System.EventHandler(this.btnduzenle_Click);
            // 
            // btnekle
            // 
            this.btnekle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnekle.ImageOptions.ImageIndex = 2;
            this.btnekle.ImageOptions.ImageList = this.imgmenu;
            this.btnekle.Location = new System.Drawing.Point(12, 23);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(87, 42);
            this.btnekle.TabIndex = 2;
            this.btnekle.Text = "Ekle";
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
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
            this.splitContainerControl1.Size = new System.Drawing.Size(1370, 565);
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
            this.gridControl1.Size = new System.Drawing.Size(1370, 560);
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
            this.colDurumu.Width = 60;
            // 
            // colStokKodu
            // 
            this.colStokKodu.Caption = "Stok Kodu";
            this.colStokKodu.FieldName = "StokKodu";
            this.colStokKodu.Name = "colStokKodu";
            this.colStokKodu.OptionsColumn.AllowEdit = false;
            this.colStokKodu.Visible = true;
            this.colStokKodu.VisibleIndex = 1;
            this.colStokKodu.Width = 129;
            // 
            // colStokAdi
            // 
            this.colStokAdi.Caption = "Stok Adı";
            this.colStokAdi.FieldName = "StokAdi";
            this.colStokAdi.Name = "colStokAdi";
            this.colStokAdi.OptionsColumn.AllowEdit = false;
            this.colStokAdi.Visible = true;
            this.colStokAdi.VisibleIndex = 3;
            this.colStokAdi.Width = 238;
            // 
            // colBarkodNo
            // 
            this.colBarkodNo.Caption = "Barkod No";
            this.colBarkodNo.FieldName = "BarkodNo";
            this.colBarkodNo.Name = "colBarkodNo";
            this.colBarkodNo.OptionsColumn.AllowEdit = false;
            this.colBarkodNo.Visible = true;
            this.colBarkodNo.VisibleIndex = 2;
            this.colBarkodNo.Width = 112;
            // 
            // colBarkodTuru
            // 
            this.colBarkodTuru.Caption = "Barkod Türü";
            this.colBarkodTuru.FieldName = "BarkodTuru";
            this.colBarkodTuru.Name = "colBarkodTuru";
            this.colBarkodTuru.OptionsColumn.AllowEdit = false;
            this.colBarkodTuru.Visible = true;
            this.colBarkodTuru.VisibleIndex = 4;
            this.colBarkodTuru.Width = 91;
            // 
            // colBirimi
            // 
            this.colBirimi.Caption = "Birimi";
            this.colBirimi.FieldName = "Birimi";
            this.colBirimi.Name = "colBirimi";
            this.colBirimi.OptionsColumn.AllowEdit = false;
            this.colBirimi.Visible = true;
            this.colBirimi.VisibleIndex = 5;
            this.colBirimi.Width = 37;
            // 
            // colStokGrubu
            // 
            this.colStokGrubu.Caption = "Stok Grubu";
            this.colStokGrubu.FieldName = "StokGrubu";
            this.colStokGrubu.Name = "colStokGrubu";
            this.colStokGrubu.OptionsColumn.AllowEdit = false;
            this.colStokGrubu.Visible = true;
            this.colStokGrubu.VisibleIndex = 6;
            this.colStokGrubu.Width = 74;
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
            this.colMinStokMiktar.Width = 104;
            // 
            // colMaxStokMiktar
            // 
            this.colMaxStokMiktar.Caption = "Max.Stok Miktarı";
            this.colMaxStokMiktar.FieldName = "MaxStokMiktar";
            this.colMaxStokMiktar.Name = "colMaxStokMiktar";
            this.colMaxStokMiktar.OptionsColumn.AllowEdit = false;
            this.colMaxStokMiktar.Visible = true;
            this.colMaxStokMiktar.VisibleIndex = 9;
            this.colMaxStokMiktar.Width = 88;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 10;
            this.colAciklama.Width = 257;
            // 
            // StokGiris
            // 
            this.StokGiris.Caption = "Stok Giriş";
            this.StokGiris.FieldName = "StokGiris";
            this.StokGiris.Name = "StokGiris";
            this.StokGiris.OptionsColumn.AllowEdit = false;
            this.StokGiris.Visible = true;
            this.StokGiris.VisibleIndex = 11;
            this.StokGiris.Width = 60;
            // 
            // StokCikis
            // 
            this.StokCikis.Caption = "Stok Çıkış";
            this.StokCikis.FieldName = "StokCikis";
            this.StokCikis.Name = "StokCikis";
            this.StokCikis.OptionsColumn.AllowEdit = false;
            this.StokCikis.Visible = true;
            this.StokCikis.VisibleIndex = 12;
            this.StokCikis.Width = 59;
            // 
            // MevcutStok
            // 
            this.MevcutStok.Caption = "Mevcut Stok";
            this.MevcutStok.FieldName = "MevcutStok";
            this.MevcutStok.Name = "MevcutStok";
            this.MevcutStok.OptionsColumn.AllowEdit = false;
            this.MevcutStok.Visible = true;
            this.MevcutStok.VisibleIndex = 13;
            this.MevcutStok.Width = 156;
            // 
            // FrmStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 684);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.lblBaslik);
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
            this.ResumeLayout(false);

        }

   

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraEditors.SimpleButton btnguncelle;
        private DevExpress.XtraEditors.SimpleButton btnkopyala;
        private DevExpress.XtraEditors.SimpleButton btnsil;
        private DevExpress.XtraEditors.SimpleButton btnduzenle;
        private DevExpress.XtraEditors.SimpleButton btnekle;
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
        private DevExpress.XtraEditors.SimpleButton btnstokhareket;
    }
}
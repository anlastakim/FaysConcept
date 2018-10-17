namespace FaysConcept.BackOffice.Fisler
{
    partial class FrmSeriNo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSeriNo));
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.grupbilgi = new DevExpress.XtraEditors.GroupControl();
            this.txtSeriNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnkapat = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnYeni = new DevExpress.XtraEditors.SimpleButton();
            this.btnVazgec = new DevExpress.XtraEditors.SimpleButton();
            this.listboxSeriNo = new DevExpress.XtraEditors.ListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.grupbilgi)).BeginInit();
            this.grupbilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeriNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listboxSeriNo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.lblBaslik.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("lblBaslik.Appearance.Image")));
            this.lblBaslik.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBaslik.Appearance.Options.UseFont = true;
            this.lblBaslik.Appearance.Options.UseForeColor = true;
            this.lblBaslik.Appearance.Options.UseImage = true;
            this.lblBaslik.Appearance.Options.UseImageAlign = true;
            this.lblBaslik.Appearance.Options.UseTextOptions = true;
            this.lblBaslik.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblBaslik.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBaslik.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.lblBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBaslik.Location = new System.Drawing.Point(0, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(470, 60);
            this.lblBaslik.TabIndex = 10;
            this.lblBaslik.Text = "Seri No Bilgileri";
            // 
            // grupbilgi
            // 
            this.grupbilgi.Controls.Add(this.txtSeriNo);
            this.grupbilgi.Controls.Add(this.labelControl2);
            this.grupbilgi.Dock = System.Windows.Forms.DockStyle.Top;
            this.grupbilgi.Enabled = false;
            this.grupbilgi.Location = new System.Drawing.Point(0, 60);
            this.grupbilgi.Name = "grupbilgi";
            this.grupbilgi.Size = new System.Drawing.Size(470, 53);
            this.grupbilgi.TabIndex = 11;
            this.grupbilgi.Text = "Seri No Bilgileri";
            // 
            // txtSeriNo
            // 
            this.txtSeriNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSeriNo.Location = new System.Drawing.Point(104, 26);
            this.txtSeriNo.Name = "txtSeriNo";
            this.txtSeriNo.Size = new System.Drawing.Size(361, 20);
            this.txtSeriNo.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl2.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.labelControl2.Appearance.Options.UseBackColor = true;
            this.labelControl2.Appearance.Options.UseBorderColor = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl2.Location = new System.Drawing.Point(5, 25);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(93, 21);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Seri No :";
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.btnkapat);
            this.grpMenu.Controls.Add(this.btnKaydet);
            this.grpMenu.Controls.Add(this.btnSil);
            this.grpMenu.Controls.Add(this.btnYeni);
            this.grpMenu.Controls.Add(this.btnVazgec);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(0, 471);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(470, 86);
            this.grpMenu.TabIndex = 14;
            this.grpMenu.Text = "İşlemler";
            // 
            // btnkapat
            // 
            this.btnkapat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnkapat.ImageOptions.ImageIndex = 4;
            this.btnkapat.ImageOptions.ImageList = this.ımageList1;
            this.btnkapat.Location = new System.Drawing.Point(377, 25);
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.Size = new System.Drawing.Size(87, 56);
            this.btnkapat.TabIndex = 4;
            this.btnkapat.Text = "Kapat";
            this.btnkapat.Click += new System.EventHandler(this.btnkapat_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "add.png");
            this.ımageList1.Images.SetKeyName(1, "delete.png");
            this.ımageList1.Images.SetKeyName(2, "floppy_disk.png");
            this.ımageList1.Images.SetKeyName(3, "floppy_disk_delete.png");
            this.ımageList1.Images.SetKeyName(4, "folder_out.png");
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnKaydet.Enabled = false;
            this.btnKaydet.ImageOptions.ImageIndex = 2;
            this.btnKaydet.ImageOptions.ImageList = this.ımageList1;
            this.btnKaydet.Location = new System.Drawing.Point(191, 25);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(87, 56);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSil.ImageOptions.ImageIndex = 1;
            this.btnSil.ImageOptions.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(98, 25);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(87, 56);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnYeni.ImageOptions.ImageIndex = 0;
            this.btnYeni.ImageOptions.ImageList = this.ımageList1;
            this.btnYeni.Location = new System.Drawing.Point(5, 25);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(87, 56);
            this.btnYeni.TabIndex = 4;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnVazgec
            // 
            this.btnVazgec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVazgec.Enabled = false;
            this.btnVazgec.ImageOptions.ImageIndex = 3;
            this.btnVazgec.ImageOptions.ImageList = this.ımageList1;
            this.btnVazgec.Location = new System.Drawing.Point(284, 25);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(87, 56);
            this.btnVazgec.TabIndex = 4;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // listboxSeriNo
            // 
            this.listboxSeriNo.Appearance.Font = new System.Drawing.Font("Tahoma", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listboxSeriNo.Appearance.Options.UseFont = true;
            this.listboxSeriNo.Cursor = System.Windows.Forms.Cursors.Default;
            this.listboxSeriNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listboxSeriNo.Location = new System.Drawing.Point(0, 113);
            this.listboxSeriNo.Name = "listboxSeriNo";
            this.listboxSeriNo.Size = new System.Drawing.Size(470, 358);
            this.listboxSeriNo.TabIndex = 15;
            // 
            // FrmSeriNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 557);
            this.Controls.Add(this.listboxSeriNo);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.grupbilgi);
            this.Controls.Add(this.lblBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(486, 596);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(486, 596);
            this.Name = "FrmSeriNo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSeriNo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSeriNo_FormClosing);
            this.Load += new System.EventHandler(this.FrmSeriNo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grupbilgi)).EndInit();
            this.grupbilgi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSeriNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listboxSeriNo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.GroupControl grupbilgi;
        private DevExpress.XtraEditors.TextEdit txtSeriNo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraEditors.SimpleButton btnkapat;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnYeni;
        private DevExpress.XtraEditors.SimpleButton btnVazgec;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.ListBoxControl listboxSeriNo;
    }
}
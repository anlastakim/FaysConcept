namespace FaysConcept.Backup
{
    partial class FrmBackup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBackup));
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.btnYedekleme = new DevExpress.XtraEditors.SimpleButton();
            this.btnGeriYukleme = new DevExpress.XtraEditors.SimpleButton();
            this.lblfisno = new DevExpress.XtraEditors.LabelControl();
            this.txtYedekKonumu = new DevExpress.XtraEditors.ButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYedekKonumu.Properties)).BeginInit();
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
            this.lblBaslik.Size = new System.Drawing.Size(547, 59);
            this.lblBaslik.TabIndex = 3;
            this.lblBaslik.Text = "Yedekleme İşlemleri";
            // 
            // btnYedekleme
            // 
            this.btnYedekleme.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYedekleme.Appearance.Options.UseFont = true;
            this.btnYedekleme.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnYedekleme.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnYedekleme.Location = new System.Drawing.Point(12, 65);
            this.btnYedekleme.Name = "btnYedekleme";
            this.btnYedekleme.Size = new System.Drawing.Size(253, 244);
            this.btnYedekleme.TabIndex = 4;
            this.btnYedekleme.Text = "Yedekleme";
            this.btnYedekleme.Click += new System.EventHandler(this.btnYedekleme_Click);
            // 
            // btnGeriYukleme
            // 
            this.btnGeriYukleme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGeriYukleme.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeriYukleme.Appearance.Options.UseFont = true;
            this.btnGeriYukleme.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGeriYukleme.ImageOptions.Image")));
            this.btnGeriYukleme.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnGeriYukleme.Location = new System.Drawing.Point(282, 65);
            this.btnGeriYukleme.Name = "btnGeriYukleme";
            this.btnGeriYukleme.Size = new System.Drawing.Size(253, 244);
            this.btnGeriYukleme.TabIndex = 4;
            this.btnGeriYukleme.Text = "Geri Yükleme";
            this.btnGeriYukleme.Click += new System.EventHandler(this.btnGeriYukleme_Click);
            // 
            // lblfisno
            // 
            this.lblfisno.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblfisno.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.lblfisno.Appearance.Options.UseBackColor = true;
            this.lblfisno.Appearance.Options.UseBorderColor = true;
            this.lblfisno.Appearance.Options.UseTextOptions = true;
            this.lblfisno.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblfisno.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblfisno.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lblfisno.Location = new System.Drawing.Point(12, 317);
            this.lblfisno.Name = "lblfisno";
            this.lblfisno.Size = new System.Drawing.Size(111, 22);
            this.lblfisno.TabIndex = 28;
            this.lblfisno.Text = "Yedekleme Konumu :";
            // 
            // txtYedekKonumu
            // 
            this.txtYedekKonumu.Location = new System.Drawing.Point(130, 319);
            this.txtYedekKonumu.Name = "txtYedekKonumu";
            this.txtYedekKonumu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtYedekKonumu.Size = new System.Drawing.Size(405, 20);
            this.txtYedekKonumu.TabIndex = 29;
            this.txtYedekKonumu.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtYedekKonumu_ButtonClick);
            // 
            // FrmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 351);
            this.Controls.Add(this.txtYedekKonumu);
            this.Controls.Add(this.lblfisno);
            this.Controls.Add(this.btnGeriYukleme);
            this.Controls.Add(this.btnYedekleme);
            this.Controls.Add(this.lblBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yedekleme ve Geri Yükleme";
            this.Load += new System.EventHandler(this.FrmBackup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtYedekKonumu.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.SimpleButton btnYedekleme;
        private DevExpress.XtraEditors.SimpleButton btnGeriYukleme;
        private DevExpress.XtraEditors.LabelControl lblfisno;
        private DevExpress.XtraEditors.ButtonEdit txtYedekKonumu;
    }
}


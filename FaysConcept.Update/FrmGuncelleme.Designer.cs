namespace FaysConcept.Update
{
    partial class FrmGuncelleme
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
            this.btnIndir = new DevExpress.XtraEditors.SimpleButton();
            this.progressBar = new DevExpress.XtraEditors.ProgressBarControl();
            this.lblIndirmeBoyutu = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.progressBar.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIndir
            // 
            this.btnIndir.Location = new System.Drawing.Point(214, 12);
            this.btnIndir.Name = "btnIndir";
            this.btnIndir.Size = new System.Drawing.Size(203, 80);
            this.btnIndir.TabIndex = 0;
            this.btnIndir.Text = "Güncelleme İndir";
            this.btnIndir.Click += new System.EventHandler(this.btnIndir_Click);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(12, 124);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(586, 53);
            this.progressBar.TabIndex = 1;
            // 
            // lblIndirmeBoyutu
            // 
            this.lblIndirmeBoyutu.Location = new System.Drawing.Point(13, 104);
            this.lblIndirmeBoyutu.Name = "lblIndirmeBoyutu";
            this.lblIndirmeBoyutu.Size = new System.Drawing.Size(0, 13);
            this.lblIndirmeBoyutu.TabIndex = 2;
            // 
            // FrmGuncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 189);
            this.Controls.Add(this.lblIndirmeBoyutu);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnIndir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGuncelleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Versiyon Güncelleme";
            this.Load += new System.EventHandler(this.FrmGuncelleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.progressBar.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnIndir;
        private DevExpress.XtraEditors.ProgressBarControl progressBar;
        private DevExpress.XtraEditors.LabelControl lblIndirmeBoyutu;
    }
}


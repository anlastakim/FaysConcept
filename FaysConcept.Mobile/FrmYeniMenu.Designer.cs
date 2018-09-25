namespace FaysConcept.Mobile
{
    partial class FrmYeniMenu
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
            DevExpress.XtraEditors.TileItemElement tileItemElement7 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement8 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement9 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement10 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement11 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement12 = new DevExpress.XtraEditors.TileItemElement();
            this.Girişler = new DevExpress.XtraEditors.TileControl();
            this.tileGroup1 = new DevExpress.XtraEditors.TileGroup();
            this.tileItem1 = new DevExpress.XtraEditors.TileItem();
            this.tileItem2 = new DevExpress.XtraEditors.TileItem();
            this.tileGroup3 = new DevExpress.XtraEditors.TileGroup();
            this.tileItem3 = new DevExpress.XtraEditors.TileItem();
            this.tileItem4 = new DevExpress.XtraEditors.TileItem();
            this.tileGroup4 = new DevExpress.XtraEditors.TileGroup();
            this.tileItem5 = new DevExpress.XtraEditors.TileItem();
            this.tileItem6 = new DevExpress.XtraEditors.TileItem();
            this.SuspendLayout();
            // 
            // Girişler
            // 
            this.Girişler.AllowItemHover = true;
            this.Girişler.AllowSelectedItem = true;
            this.Girişler.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Girişler.AppearanceItem.Normal.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.Girişler.AppearanceItem.Normal.Options.UseFont = true;
            this.Girişler.AppearanceText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Girişler.AppearanceText.Options.UseFont = true;
            this.Girişler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Girişler.Groups.Add(this.tileGroup1);
            this.Girişler.Groups.Add(this.tileGroup3);
            this.Girişler.Groups.Add(this.tileGroup4);
            this.Girişler.Location = new System.Drawing.Point(0, 0);
            this.Girişler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Girişler.MaxId = 11;
            this.Girişler.Name = "Girişler";
            this.Girişler.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Girişler.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.Girişler.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollBar;
            this.Girişler.SelectionColor = System.Drawing.Color.Silver;
            this.Girişler.Size = new System.Drawing.Size(268, 360);
            this.Girişler.TabIndex = 0;
            this.Girişler.Text = "Fays Mobil";
            this.Girişler.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Top;
            this.Girişler.Click += new System.EventHandler(this.Girişler_Click);
            // 
            // tileGroup1
            // 
            this.tileGroup1.Items.Add(this.tileItem1);
            this.tileGroup1.Items.Add(this.tileItem2);
            this.tileGroup1.Name = "tileGroup1";
            this.tileGroup1.Text = "Girişler";
            // 
            // tileItem1
            // 
            tileItemElement7.Text = "Manuel Giriş";
            this.tileItem1.Elements.Add(tileItemElement7);
            this.tileItem1.Id = 0;
            this.tileItem1.ItemSize = DevExpress.XtraEditors.TileItemSize.Small;
            this.tileItem1.Name = "tileItem1";
            this.tileItem1.TextShowMode = DevExpress.XtraEditors.TileItemContentShowMode.Always;
            // 
            // tileItem2
            // 
            tileItemElement8.Text = "Siparişten Giriş";
            tileItemElement8.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileItem2.Elements.Add(tileItemElement8);
            this.tileItem2.Id = 1;
            this.tileItem2.ItemSize = DevExpress.XtraEditors.TileItemSize.Small;
            this.tileItem2.Name = "tileItem2";
            // 
            // tileGroup3
            // 
            this.tileGroup3.Items.Add(this.tileItem3);
            this.tileGroup3.Items.Add(this.tileItem4);
            this.tileGroup3.Name = "tileGroup3";
            this.tileGroup3.Text = "Çıkışlar";
            // 
            // tileItem3
            // 
            tileItemElement9.Text = "Manuel Çıkış";
            tileItemElement9.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileItem3.Elements.Add(tileItemElement9);
            this.tileItem3.Id = 6;
            this.tileItem3.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItem3.Name = "tileItem3";
            // 
            // tileItem4
            // 
            tileItemElement10.Text = "Siparişten Çıkış";
            tileItemElement10.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileItem4.Elements.Add(tileItemElement10);
            this.tileItem4.Id = 7;
            this.tileItem4.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItem4.Name = "tileItem4";
            // 
            // tileGroup4
            // 
            this.tileGroup4.Items.Add(this.tileItem5);
            this.tileGroup4.Items.Add(this.tileItem6);
            this.tileGroup4.Name = "tileGroup4";
            this.tileGroup4.Text = "Transferler";
            // 
            // tileItem5
            // 
            tileItemElement11.Text = "Raf Transferi";
            tileItemElement11.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileItem5.Elements.Add(tileItemElement11);
            this.tileItem5.Id = 8;
            this.tileItem5.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItem5.Name = "tileItem5";
            // 
            // tileItem6
            // 
            tileItemElement12.Text = "Depo Transferi";
            tileItemElement12.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileItem6.Elements.Add(tileItemElement12);
            this.tileItem6.Id = 9;
            this.tileItem6.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItem6.Name = "tileItem6";
            // 
            // FrmYeniMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 360);
            this.Controls.Add(this.Girişler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmYeniMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmYeniMenu";
            this.Load += new System.EventHandler(this.FrmYeniMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TileControl Girişler;
        private DevExpress.XtraEditors.TileGroup tileGroup1;
        private DevExpress.XtraEditors.TileItem tileItem1;
        private DevExpress.XtraEditors.TileItem tileItem2;
        private DevExpress.XtraEditors.TileGroup tileGroup3;
        private DevExpress.XtraEditors.TileItem tileItem3;
        private DevExpress.XtraEditors.TileItem tileItem4;
        private DevExpress.XtraEditors.TileGroup tileGroup4;
        private DevExpress.XtraEditors.TileItem tileItem5;
        private DevExpress.XtraEditors.TileItem tileItem6;
    }
}
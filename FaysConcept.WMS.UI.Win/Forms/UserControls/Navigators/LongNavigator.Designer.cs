using DevExpress.Utils;
using DevExpress.XtraEditors;

namespace AnlasYazilim.OgrenciTakip.UI.Win.Forms.UserControls.Navigators
{
    partial class LongNavigator
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LongNavigator));
            this.imageCollection = new DevExpress.Utils.ImageCollection();
            this.controlNavigator1 = new DevExpress.XtraEditors.ControlNavigator();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.Images.SetKeyName(0, "first_16x16.png");
            this.imageCollection.Images.SetKeyName(1, "doubleprev_16x16.png");
            this.imageCollection.Images.SetKeyName(2, "prev_16x16.png");
            this.imageCollection.Images.SetKeyName(3, "next_16x16.png");
            this.imageCollection.Images.SetKeyName(4, "doublenext_16x16.png");
            this.imageCollection.Images.SetKeyName(5, "last_16x16.png");
            this.imageCollection.Images.SetKeyName(6, "addfile_16x16.png");
            this.imageCollection.Images.SetKeyName(7, "deletelist_16x16.png");
            // 
            // controlNavigator1
            // 
            this.controlNavigator1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.controlNavigator1.Appearance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.controlNavigator1.Appearance.Options.UseFont = true;
            this.controlNavigator1.Appearance.Options.UseForeColor = true;
            this.controlNavigator1.Buttons.Append.ImageIndex = 6;
            this.controlNavigator1.Buttons.Append.Visible = false;
            this.controlNavigator1.Buttons.CancelEdit.Visible = false;
            this.controlNavigator1.Buttons.Edit.Visible = false;
            this.controlNavigator1.Buttons.EndEdit.Visible = false;
            this.controlNavigator1.Buttons.First.ImageIndex = 0;
            this.controlNavigator1.Buttons.ImageList = this.imageCollection;
            this.controlNavigator1.Buttons.Last.ImageIndex = 5;
            this.controlNavigator1.Buttons.Next.ImageIndex = 3;
            this.controlNavigator1.Buttons.NextPage.ImageIndex = 4;
            this.controlNavigator1.Buttons.Prev.ImageIndex = 2;
            this.controlNavigator1.Buttons.PrevPage.ImageIndex = 1;
            this.controlNavigator1.Buttons.Remove.ImageIndex = 7;
            this.controlNavigator1.Buttons.Remove.Visible = false;
            this.controlNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlNavigator1.Location = new System.Drawing.Point(0, 0);
            this.controlNavigator1.Name = "controlNavigator1";
            this.controlNavigator1.Size = new System.Drawing.Size(535, 24);
            this.controlNavigator1.TabIndex = 0;
            this.controlNavigator1.Text = "Navigator";
            this.controlNavigator1.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Begin;
            this.controlNavigator1.TextStringFormat = "Kartlar ( {0} / {1} )";
            // 
            // LongNavigator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.controlNavigator1);
            this.Name = "LongNavigator";
            this.Size = new System.Drawing.Size(535, 24);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ImageCollection imageCollection;
        private ControlNavigator controlNavigator1;
    }
}

using DevExpress.Utils;
using DevExpress.XtraEditors;

namespace AnlasYazilim.OgrenciTakip.UI.Win.Forms.UserControls.Navigators
{
    partial class Navigator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Navigator));
            this.dataNavigator1 = new DevExpress.XtraEditors.DataNavigator();
            this.imageCollection = new DevExpress.Utils.ImageCollection();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // dataNavigator1
            // 
            this.dataNavigator1.Buttons.Append.ImageIndex = 6;
            this.dataNavigator1.Buttons.CancelEdit.Visible = false;
            this.dataNavigator1.Buttons.EndEdit.Visible = false;
            this.dataNavigator1.Buttons.First.ImageIndex = 0;
            this.dataNavigator1.Buttons.ImageList = this.imageCollection;
            this.dataNavigator1.Buttons.Last.ImageIndex = 4;
            this.dataNavigator1.Buttons.Next.ImageIndex = 3;
            this.dataNavigator1.Buttons.NextPage.Visible = false;
            this.dataNavigator1.Buttons.Prev.ImageIndex = 2;
            this.dataNavigator1.Buttons.PrevPage.Visible = false;
            this.dataNavigator1.Buttons.Remove.ImageIndex = 7;
            this.dataNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataNavigator1.Location = new System.Drawing.Point(0, 0);
            this.dataNavigator1.Name = "dataNavigator1";
            this.dataNavigator1.Size = new System.Drawing.Size(535, 24);
            this.dataNavigator1.TabIndex = 1;
            this.dataNavigator1.Text = "dataNavigator1";
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
            // Navigator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataNavigator1);
            this.Name = "Navigator";
            this.Size = new System.Drawing.Size(535, 24);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataNavigator dataNavigator1;
        private ImageCollection imageCollection;
    }
}

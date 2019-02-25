using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraEditors.Controls;
using AnlasYazilim.Software.UI.Win.Forms.Interfaces;

namespace AnlasYazilim.Software.UI.Win.Forms.UserControls.Controls
{
    [ToolboxItem(true)]

    public class MyPictureBoxEdit : PictureEdit, IStatusBarKisaYol,Language
    {
        public string Language { get; set; }
        public MyPictureBoxEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.Appearance.ForeColor = Color.Maroon;

            if (Language == "TR")
            {
                Properties.NullText = "Resim Yok";
            }
            else if(Language=="EN")
            {
                Properties.NullText = "No picture";
            }

            Properties.SizeMode = PictureSizeMode.Stretch;
            Properties.ShowMenu = false;
        }

        public override bool EnterMoveNextControl { get; set; } = true;

        public string StatusBarKisayol { get; set; }
        public string StatusBarKisayolAciklama { get; set; }
        public string StatusBarAciklama { get; set; }

    }
}

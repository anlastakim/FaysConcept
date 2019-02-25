using AnlasYazilim.Software.UI.Win.Forms.Interfaces;
using DevExpress.XtraEditors;
using System.ComponentModel;
using DevExpress.Utils;
using System.Drawing;

namespace AnlasYazilim.OgrenciTakip.UI.Win.Forms.UserControls.Controls
{
    [ToolboxItem(true)]

    public class MyToggleSwitch : ToggleSwitch, IStatusBarAciklama, Language
    {
        public string StatusBarAciklama { get; set; }
        public string Language { get; set; }

        public MyToggleSwitch()
        {
            Name = "tglDurum";

            if (Language == "TR")
            {
                Properties.OffText = "[TR] - Pasif";
                Properties.OnText = "[TR] - Aktif";
            }
            else if (Language == "EN")
            {
                Properties.OffText = "[EN] - Passive";
                Properties.OnText = "[EN] - Active";
            }
            else
            {
                Properties.OffText = "Passive";
                Properties.OnText = "Active";
            }

            Properties.AutoHeight = false;
            Properties.AutoWidth = true;
            Properties.GlyphAlignment = HorzAlignment.Far;
            Properties.Appearance.ForeColor = Color.Maroon;

            if (Language == "TR")
            {
                StatusBarAciklama = "[TR] - Kartın Kullanım Durumunu Seçiniz.";
            }
            else if (Language == "EN")
            {
                StatusBarAciklama = "[EN] - Please Select the Card Usage Status.";
            }
            else
            {
                StatusBarAciklama = "[UnknownLanguage] - Please Select the Card Usage Status.";
            }

        }

        public override bool EnterMoveNextControl { get; set; } = true;

    }
}

using System.ComponentModel;
using AnlasYazilim.Software.UI.Win.Forms.Interfaces;
using DevExpress.Utils;
using DevExpress.XtraEditors.Mask;
using System.Configuration;

namespace AnlasYazilim.Software.UI.Win.Forms.UserControls.Controls
{
    [ToolboxItem(true)]

    public class MyTCNoEdit : MyTextEdit,Language
    {
        public string Language { get; set; } 

        public MyTCNoEdit()
        {
            Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            Properties.Mask.MaskType = MaskType.Regular;
            Properties.Mask.EditMask = @"\d?\d?\d? \d?\d? \d?\d? \d?\d? \d?\d?";
            Properties.Mask.AutoComplete = AutoCompleteType.None;

            if (Language == "TR")
            {
                StatusBarAciklama = "TC Kimlik Numarası Giriniz.";
            }
            else if (Language == "EN")
            {
                StatusBarAciklama = "Please Enter Phone Number !";
            }
            else
            {
                StatusBarAciklama = "Language not found, Please Set The Language Settings!";
            }

        }

        
    }
}

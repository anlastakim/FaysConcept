using AnlasYazilim.Software.UI.Win.Forms.Interfaces;
using DevExpress.Utils;
using DevExpress.XtraEditors.Mask;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnlasYazilim.Software.UI.Win.Forms.UserControls.Controls
{
    [ToolboxItem(true)]

    public class MyPhoneNumberEdit : MyTextEdit,Language
    {
        public string Language { get; set; }

        public MyPhoneNumberEdit()
        {
            Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            Properties.Mask.MaskType = MaskType.Regular;
            Properties.Mask.EditMask = @"0 (\d?\d?\d?) \d?\d?\d? \d?\d? \d?\d?";
            Properties.Mask.AutoComplete = AutoCompleteType.None;

            if (Language == "TR")
            {
                StatusBarAciklama = "[TR] - Telefon Numarası Giriniz.";
            }
            else if (Language == "EN")
            {
                StatusBarAciklama = "[EN] - Please Enter Phone Number !";
            }
            else
            {
                StatusBarAciklama = "[UnknownLanguage] - Please Enter Phone Number !";
            }
        }
    }
}

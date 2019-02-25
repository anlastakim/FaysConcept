using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnlasYazilim.Software.UI.Win.Forms.Interfaces;
using DevExpress.XtraEditors.Mask;

namespace AnlasYazilim.Software.UI.Win.Forms.UserControls.Controls
{
    public class MyEmailTextEdit : MyTextEdit,IStatusBarAciklama,Language
    {
        [ToolboxItem(true)]

        public string Language { get; set; } 

        public MyEmailTextEdit()
        {
            Properties.Mask.MaskType = MaskType.RegEx;
            Properties.Mask.EditMask = @"((([0-9a-zA-Z_%-])+[.])+|([0-9a-zA-Z_%-])+)+@((([0-9a-zA-Z_-])+[.])+|([0-9a-zA-Z_-])+)+";
            Properties.Mask.AutoComplete = AutoCompleteType.Strong;

            if (Language == "TR")
            {
                StatusBarAciklama = "[TR] - E-Mail Adresi Giriniz !";
            }
            else if (Language == "EN")
            {
                StatusBarAciklama = "[EN] - Please Enter E-Mail !";
            }
            else
            {
                StatusBarAciklama = "[UnknownLanguage] - Please Enter E-Mail !";
            }

        }

       
    }
}

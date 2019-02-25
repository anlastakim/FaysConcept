using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Utils;
using DevExpress.XtraEditors.Mask;
using AnlasYazilim.Software.UI.Win.Forms.Interfaces;

namespace AnlasYazilim.Software.UI.Win.Forms.UserControls.Controls
{
    [ToolboxItem(true)]

    public class MyCardEdit : MyTextEdit, Language
    {
        public string Language { get; set; }

        public MyCardEdit()
        {
            Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            Properties.Mask.MaskType = MaskType.Regular;
            Properties.Mask.EditMask = @"\d?\d?\d?\d?-\d?\d?\d?\d?-\d?\d?\d?\d?-\d?\d?\d?\d?";
            Properties.Mask.AutoComplete = AutoCompleteType.None;

            if (Language == "TR")
            {
                StatusBarAciklama = "Kart No Giriniz !";
            }
            else if(Language=="EN"){
                StatusBarAciklama = "Please Enter Card Number !";
            }
            else { }

            // Sola yatık [ \ ] tanıması için başına @ işareti koyuyoruz. -- d? = [d] Bu alana bir değer girilebilir. [?] Bu alan boş girilebilir.
        }

        
    }
}

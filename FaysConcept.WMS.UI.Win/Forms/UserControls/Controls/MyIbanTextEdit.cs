using System.ComponentModel;
using AnlasYazilim.Software.UI.Win.Forms.Interfaces;
using DevExpress.XtraEditors.Mask;

namespace AnlasYazilim.Software.UI.Win.Forms.UserControls.Controls
{
    [ToolboxItem(true)]

    public class MyIbanTextEdit : MyTextEdit, Language
    {
        public string Language { get; set; }
        public MyIbanTextEdit()
        {
            Properties.Mask.MaskType = MaskType.Regular;
            Properties.Mask.EditMask = @"TR\d?\d? \d?\d?\d?\d? \d?\d?\d?\d? \d?\d?\d?\d? \d?\d?\d?\d? \d?\d?";
            Properties.Mask.AutoComplete = AutoCompleteType.None;

            if (Language == "TR")
            {
                StatusBarAciklama = "Iban Numarası Giriniz.";
            }
            else if (Language == "EN")
            {
                StatusBarAciklama = "Please Enter Iban Number !";
            }
         
        }

        public override bool EnterMoveNextControl { get; set; } = true;
      
    }
}

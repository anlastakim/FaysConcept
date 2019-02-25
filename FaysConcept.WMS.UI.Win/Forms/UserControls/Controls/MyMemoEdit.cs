using AnlasYazilim.Software.UI.Win.Forms.Interfaces;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnlasYazilim.Software.UI.Win.Forms.UserControls.Controls
{
    [ToolboxItem(true)]

    public class MyMemoEdit : MemoEdit, IStatusBarAciklama, Language
    {
        public string Language { get; set; }
        public string StatusBarAciklama { get; set; }

        public MyMemoEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan; //Rengi değiştirin lütfen!
            Properties.MaxLength = 500;

            if (Language == "TR")
            {
                StatusBarAciklama = "Açıklama Giriniz.";
            }
            else if (Language == "EN")
            {
                StatusBarAciklama = "Please Enter Explication !";
            }

        }
        public override bool EnterMoveNextControl { get; set; } = true;
        
        
     
    }
}

using DevExpress.XtraEditors;
using System.Drawing;
using DevExpress.Utils;
using AnlasYazilim.Software.UI.Win.Forms.Interfaces;
using System.ComponentModel;

namespace AnlasYazilim.Software.UI.Win.Forms.UserControls.Controls
{
    [ToolboxItem(true)] // ToolBox içerisinde gözükmesini sağlar.

    public class MyCalcEdit : CalcEdit,IStatusBarKisaYol //  :'dan sonrası [,] arasında nereden türeyeceğini belirtiyoruz.
    {

        public MyCalcEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.FromArgb(235, 236, 239); // Yazının arkaplan rengi
            Properties.AllowNullInput = DefaultBoolean.False; // Bu alanın hiç bir şekilde null olarak geçilmesine izin vermez.
            Properties.EditMask = "n2";
        }

        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarKisayol { get; set; }
        public string StatusBarKisayolAciklama { get; set; }
        public string StatusBarAciklama { get; set; }
    }
}

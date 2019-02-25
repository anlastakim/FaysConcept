using AnlasYazilim.Software.UI.Win.Forms.Interfaces;
using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Drawing;

namespace AnlasYazilim.Software.UI.Win.Forms.UserControls.Controls
{
    [ToolboxItem(true)]

    public class MyCheckEdit : CheckEdit, IStatusBarAciklama
    {
        public MyCheckEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.Transparent; // Bu formun rengini alması !
        }

        public override bool EnterMoveNextControl { get; set; } = true;

        public string StatusBarAciklama { get; set; }
    }
}

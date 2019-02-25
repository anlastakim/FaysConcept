using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Utils;
using AnlasYazilim.Software.UI.Win.Forms.Interfaces;

namespace AnlasYazilim.Software.UI.Win.Forms.UserControls.Controls
{
    [ToolboxItem(true)]

   public class MySpinEdit : SpinEdit,IStatusBarAciklama,Language
    {
        public string Language { get; set; }

        public MySpinEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.AllowNullInput = DefaultBoolean.False;
            Properties.EditMask = "d";
        }
        public override bool EnterMoveNextControl { get; set; } = true;

        public string StatusBarAciklama { get; set; }
        
    }
}

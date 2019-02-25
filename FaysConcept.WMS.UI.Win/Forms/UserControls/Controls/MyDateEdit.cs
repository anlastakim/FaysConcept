using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnlasYazilim.Software.UI.Win.Forms.Interfaces;
using System.ComponentModel;
using DevExpress.XtraEditors;
using System.Drawing;
using DevExpress.Utils;
using DevExpress.XtraEditors.Mask;

namespace AnlasYazilim.Software.UI.Win.Forms.UserControls.Controls
{
    [ToolboxItem(true)]

    public class MyDateEdit : DateEdit,IStatusBarKisaYol
    {
        public MyDateEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.FromArgb(235, 236, 239); // Yazının arkaplan rengi
            Properties.AllowNullInput = DefaultBoolean.False;
            Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            Properties.Mask.MaskType = MaskType.DateTimeAdvancingCaret;
        }

        public override bool EnterMoveNextControl { get; set; } = true;

        public string StatusBarKisayol { get; set; }
        public string StatusBarKisayolAciklama { get; set; } = "Tarih Seç";
        public string StatusBarAciklama { get; set; }
    }
}

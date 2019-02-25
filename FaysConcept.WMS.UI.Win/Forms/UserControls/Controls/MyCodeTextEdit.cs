using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Utils;

namespace AnlasYazilim.Software.UI.Win.Forms.UserControls.Controls
{
    [ToolboxItem(true)]

    public class MyCodeTextEdit : MyTextEdit
    {
        public MyCodeTextEdit()
        {
            Properties.Appearance.BackColor = Color.PaleGoldenrod; // Yazının Arkaplan Rengi
            Properties.AppearanceFocused.BackColor = Color.FromArgb(235, 236, 239); // Yazının Arkaplan Rengi
            Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            Properties.MaxLength = 20;
            StatusBarAciklama = "Kod Giriniz.";
        }
    }
}

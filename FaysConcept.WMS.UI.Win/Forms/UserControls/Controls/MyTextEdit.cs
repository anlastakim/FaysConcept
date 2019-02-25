using AnlasYazilim.Software.UI.Win.Forms.Interfaces;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnlasYazilim.Software.UI.Win.Forms.UserControls.Controls
{
    [ToolboxItem(true)] // ToolBox içerisinde gözükmesini sağlar.

    public class MyTextEdit : TextEdit,IStatusBarAciklama // IStatusBarAciklama
    {
        public MyTextEdit()
        {
            Properties.MaxLength = 50; //Yazının uzunluğu
            Properties.AppearanceFocused.BackColor = Color.FromArgb(235, 236, 239); // Yazının Arkaplan Rengi
        }

        public override bool EnterMoveNextControl { get; set; } = true; // EnterMoveNextControl True olarak gözükür.
        public string StatusBarAciklama { get; set; }
    }
}

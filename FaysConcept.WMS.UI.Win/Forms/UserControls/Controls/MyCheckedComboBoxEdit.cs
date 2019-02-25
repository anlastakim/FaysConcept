using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors.Controls;
using AnlasYazilim.Software.UI.Win.Forms.Interfaces;

namespace AnlasYazilim.Software.UI.Win.Forms.UserControls.Controls
{
    [ToolboxItem(true)]

    public class MyCheckedComboBoxEdit : CheckedComboBoxEdit,IStatusBarKisaYol
    {
        public MyCheckedComboBoxEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.FromArgb(235, 236, 239); // Yazının arkaplan rengi
            Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
        }

        public override bool EnterMoveNextControl { get; set; } = true;

        public string StatusBarKisayol { get; set; }
        public string StatusBarKisayolAciklama { get; set; }
        public string StatusBarAciklama { get; set; }
    }
}

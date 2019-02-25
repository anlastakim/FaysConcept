using DevExpress.XtraEditors;
using FaysConcept.BackOffice.Stok;

namespace FaysConcept.BackOffice.Ana_Menu
{
    public partial class FrmAnaMenuBilgi : DevExpress.XtraEditors.XtraForm
    {
        public FrmAnaMenuBilgi()
        {
            InitializeComponent();
        }

        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            FrmStok form = new FrmStok();
            form.Show();

        }
    }
}
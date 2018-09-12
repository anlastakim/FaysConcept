using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using FaysConcept.BackOffice.Fisler;
using FaysConcept.Entities.Context;
using FaysConcept.Entities.DataAccess;

namespace FaysConcept.BackOffice.Stok_Hareketleri
{
    public partial class FrmStokHareketleri : DevExpress.XtraEditors.XtraForm
    {
        FaysConceptContext context=new FaysConceptContext();
        StokHareketDAL stokHareketDal=new StokHareketDAL();

        public FrmStokHareketleri()
        {
            InitializeComponent();

        }

        private void Listele()
        {
            stokHareketDal.GetAll(context);
        }

        private void FrmStokHareketleri_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void repoSeriNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string veri = Convert.ToString(gridstokhareket.GetFocusedRowCellValue(colSeriNo));
            FrmSeriNo form = new FrmSeriNo(veri);
            form.ShowDialog();
            gridstokhareket.SetFocusedRowCellValue(colSeriNo, form.veriSeriNo);
        }
    }
}
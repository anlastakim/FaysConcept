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
using FaysConcept.Entities.Context;
using FaysConcept.Entities.DataAccess;

namespace FaysConcept.BackOffice.Stok
{
    public partial class FrmStokSec : DevExpress.XtraEditors.XtraForm
    {
        StokDAL stokDal=new StokDAL();
        FaysConceptContext context=new FaysConceptContext();
        public List<Entities.Tables.Stok> secilen=new List<Entities.Tables.Stok>();
        public bool secildi = false;

        public FrmStokSec(bool cokluSecim=false)
        {
            InitializeComponent();
            if (cokluSecim)
            {
                lbluyarı.Visible = true;
                gridViewStokSec.OptionsSelection.MultiSelect = true;

                }

        }

        private void FrmStokSec_Load(object sender, EventArgs e)
        {
           gridControlStokSec.DataSource = stokDal.StokListele(context);
          

        }


        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
        private void btnsec_Click(object sender, EventArgs e)
        {
            if (gridViewStokSec.GetSelectedRows().Length!=0) // secilen değer 0 değil ise bu işlemi yap
            {
                foreach (var row in gridViewStokSec.GetSelectedRows())
                {
                    string stokkodu = gridViewStokSec.GetRowCellValue(row, colStokKodu).ToString();
                    secilen.Add(context.Stoklar.SingleOrDefault(c => c.StokKodu == stokkodu));
                    // secilen değişkenine atama yaptık.
                }

                secildi = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Seçilen bir ürün bulunamadı.");
            }
          }
    }
}
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

        public FrmStokSec(bool cokluSecim=false)
        {
            InitializeComponent();
            if (cokluSecim)
            {
                lbluyarı.Visible = true;
                gridstoklar.OptionsSelection.MultiSelect = true;

                }

        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmStokSec_Load(object sender, EventArgs e)
        {
            gridanastoklar.DataSource = stokDal.GetStoklar(context);

        }

        private void btnsec_Click(object sender, EventArgs e)
        {
            foreach (var row in gridstoklar.GetSelectedRows())
            {
                string stokkodu = gridstoklar.GetRowCellValue(row, colStokKodu).ToString();
                secilen.Add(context.Stoklar.SingleOrDefault(c=>c.StokKodu==stokkodu));
            }

            this.Close();
            
        }
    }
}
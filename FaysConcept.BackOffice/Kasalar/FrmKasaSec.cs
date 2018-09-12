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
using FaysConcept.Entities.Tables;

namespace FaysConcept.BackOffice.Kasalar
{
    public partial class FrmKasaSec : DevExpress.XtraEditors.XtraForm
    {
        KasaDAL kasaDal = new KasaDAL();
        FaysConceptContext context = new FaysConceptContext();
        public Kasa entity = new Kasa();
        public bool secildi = false;

        public FrmKasaSec()
        {
            InitializeComponent();
        }

        private void FrmKasaSec_Load(object sender, EventArgs e)
        {
            gridControlKasaSecim.DataSource = kasaDal.KasaListele(context);
        }

        private void btnCariSec_Click(object sender, EventArgs e)
        {
            if (gridView1KasaSecim.GetSelectedRows().Length != 0) // gridview boş değil ise bu işlemi yap
        
            {
                string kasakodu = gridView1KasaSecim.GetFocusedRowCellValue(colKasaKodu).ToString();
                entity = context.Kasalar.SingleOrDefault(c => c.KasaKodu == kasakodu);
                secildi = true;
                this.Close();
            }

        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
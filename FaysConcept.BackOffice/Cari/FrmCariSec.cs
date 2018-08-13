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

namespace FaysConcept.BackOffice.Cari
{
    public partial class FrmCariSec : DevExpress.XtraEditors.XtraForm
    {
        CariDAL cariDal = new CariDAL();
        FaysConceptContext context = new FaysConceptContext();
        public List<Entities.Tables.Cari> secilen = new List<Entities.Tables.Cari>();
        // liste tipinde veri döndürme 

        public FrmCariSec(bool cokluSecim = false)
        {
            InitializeComponent();
            if (cokluSecim)
            {
                lbluyarı.Visible = true;
                gridView1.OptionsSelection.MultiSelect = true;

            }

        }

        private void FrmCariSec_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = cariDal.GetCariler(context);
        }

        private void btnCariSec_Click(object sender, EventArgs e)
        {
            foreach (var row in gridView1.GetSelectedRows())
                // gridview1 de seçili olan satırları getselectedrows ile dolaşıyoruz.row index değerini tutuyor int tipi
            {
                string carikodu = gridView1.GetRowCellValue(row, colCariKodu).ToString();
                secilen.Add(context.Cariler.SingleOrDefault(c => c.CariKodu == carikodu));
            }

            this.Close();
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
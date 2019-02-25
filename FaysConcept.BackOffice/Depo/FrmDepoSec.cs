using FaysConcept.Entities.Context;
using FaysConcept.Entities.DataAccess;
using System;
using System.Linq;

namespace FaysConcept.BackOffice.Depo
{
    public partial class FrmDepoSec : DevExpress.XtraEditors.XtraForm
    {
        FaysConceptContext context = new FaysConceptContext();
        DepoDAL depoDAL = new DepoDAL();
        public Entities.Tables.Depo entity = new Entities.Tables.Depo();
        private string _stokKodu;
        public bool secildi = false;

        
        public FrmDepoSec(string stokKodu)
        {
            InitializeComponent();
            _stokKodu = stokKodu;
        }

        private void FrmDepoSec_Load(object sender, EventArgs e)
        {
            gridcontDepolar.DataSource = depoDAL.DepoBazindaStokListele(context, _stokKodu);
        }

        private void btnDepoSec_Click(object sender, EventArgs e)
        {
            if (gridDepolar.SelectedRowsCount != 0)
            {
                string depoKodu = gridDepolar.GetFocusedRowCellValue(colDepoKodu).ToString();
                entity = context.Depolar.SingleOrDefault(c => c.DepoKodu == depoKodu);
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

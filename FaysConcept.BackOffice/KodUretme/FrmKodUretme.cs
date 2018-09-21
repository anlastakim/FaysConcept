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
using System.Data.Entity;
using DevExpress.XtraGrid;

namespace FaysConcept.BackOffice.KodUretme
{
    public partial class FrmKodUretme : DevExpress.XtraEditors.XtraForm
    {
        FaysConceptContext context = new FaysConceptContext();
        KodDAL kodDAL = new KodDAL();
        //private Entities.Tables.KodUret _entity;
        private string _tablo;

        public FrmKodUretme(string tablo)
        {
            InitializeComponent();
            _tablo = tablo;
            context.Kodlar.Where(c => c.Tablo == _tablo).Load();
            gridControlKodUretme.DataSource = context.Kodlar.Local.ToBindingList();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmKodUretme_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
            this.Close();
        }

        private void gridViewKodUretme_ShowingEditor(object sender, CancelEventArgs e)
        {
            if (gridViewKodUretme.FocusedRowHandle!=GridControl.NewItemRowHandle)
            {
                e.Cancel = true;
            }
        }

        private void gridViewKodUretme_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            KodUret row = (KodUret)e.Row;
            if (context.Kodlar.Local.Any(c=>c.OnEki==row.OnEki))
            {
                MessageBox.Show("Aynı Ön Eki olan kayıt yapılamaz.");
                gridViewKodUretme.CancelUpdateCurrentRow();
            }
        }
    }
}
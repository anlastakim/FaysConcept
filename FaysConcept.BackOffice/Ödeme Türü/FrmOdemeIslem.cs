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

namespace FaysConcept.BackOffice.Ödeme_Türü
{
    public partial class FrmOdemeIslem : DevExpress.XtraEditors.XtraForm
    {
        FaysConceptContext context=new FaysConceptContext();
        OdemeTuruDAL odemeTuruDal=new OdemeTuruDAL();
        private OdemeTuru _entity;

        public FrmOdemeIslem(OdemeTuru entity)
        {
            InitializeComponent();
            _entity = entity;
            txtOdemeKodu.DataBindings.Add("Text", _entity, "OdemeTuruKodu");
            txtOdemeAdi.DataBindings.Add("Text", _entity, "OdemeTuruAdi");
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama");
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmOdemeIslem_Load(object sender, EventArgs e)
        {

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (odemeTuruDal.AddOrUpdate(context, _entity))
            {
                odemeTuruDal.Save(context);
                this.Close();
            }
        }
    }
}
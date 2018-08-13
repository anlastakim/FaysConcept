using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using FaysConcept.Entities.Context;
using FaysConcept.Entities.DataAccess;
using FaysConcept.Entities.Tables;

namespace FaysConcept.BackOffice.Kasalar
{
    public partial class FrmKasaIslem : DevExpress.XtraEditors.XtraForm
    {
        KasaDAL kasaDal = new KasaDAL();
        FaysConceptContext context=new FaysConceptContext();

        public bool Kaydedildi = false;
        private Entities.Tables.Kasa _entity;

        public FrmKasaIslem(Entities.Tables.Kasa entity)
        {
            InitializeComponent();
            _entity = entity;
            txtKasaKodu.DataBindings.Add("Text", _entity, "KasaKodu");
            txtKasaAdi.DataBindings.Add("Text", _entity, "KasaAdi");
            txtYetkiliKodu.DataBindings.Add("Text", _entity, "YetkiliKodu");
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama");
        }

        private void FrmKasaIslem_Load(object sender, EventArgs e)
        {
            //kasa karti işlemi
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (kasaDal.AddOrUpdate(context,_entity))
            {
                kasaDal.Save(context);
                Kaydedildi = true;
                this.Close();
            }
        }
    }
}
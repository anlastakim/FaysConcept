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
    public partial class FrmCariIslem : DevExpress.XtraEditors.XtraForm
    {
        private Entities.Tables.Cari _entity;
        private CariDAL cariDal = new CariDAL();
        private FaysConceptContext context = new FaysConceptContext();
        public bool saved = false;


        public FrmCariIslem(Entities.Tables.Cari entity)
        {

            InitializeComponent();
            // initialize altına yazılmalı ??
            _entity = entity;
            toggleDurumu.DataBindings.Add("EditValue", _entity, "Durumu", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtcarikodu.DataBindings.Add("Text", _entity, "CariKodu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtcariadi.DataBindings.Add("Text", _entity, "CariAdi", false, DataSourceUpdateMode.OnPropertyChanged);
            cmbCariTuru.DataBindings.Add("Text", _entity, "CariTuru");
            txtyetkili.DataBindings.Add("Text", _entity, "Yetkili", false, DataSourceUpdateMode.OnPropertyChanged);
            txtFaturaUnvani.DataBindings.Add("Text", _entity, "FaturaUnvani", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtvergidairesi.DataBindings.Add("Text", _entity, "VergiDairesi", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtverginumarasi.DataBindings.Add("Text", _entity, "VergiNo", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtaciklama.DataBindings.Add("Text", _entity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);
            txtCepTelefonu.DataBindings.Add("Text", _entity, "CepTelefon", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtSabitTelefon.DataBindings.Add("Text", _entity, "Telefon", false, DataSourceUpdateMode.OnPropertyChanged);
            txtFax.DataBindings.Add("Text", _entity, "Fax", false, DataSourceUpdateMode.OnPropertyChanged);
            txtEmail.DataBindings.Add("Text", _entity, "Email", false, DataSourceUpdateMode.OnPropertyChanged);
            txtWeb.DataBindings.Add("Text", _entity, "Web", false, DataSourceUpdateMode.OnPropertyChanged);
            txtIl.DataBindings.Add("Text", _entity, "Il", false, DataSourceUpdateMode.OnPropertyChanged);
            txtIlce.DataBindings.Add("Text", _entity, "Ilce", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSemt.DataBindings.Add("Text", _entity, "Semt", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAdres.DataBindings.Add("Text", _entity, "Adres", false, DataSourceUpdateMode.OnPropertyChanged);
            btnCariGrubu.DataBindings.Add("Text", _entity, "CariGrubu", false, DataSourceUpdateMode.OnPropertyChanged);
            btncarialtgrubu.DataBindings.Add("Text", _entity, "CariAltGrubu", false,
                DataSourceUpdateMode.OnPropertyChanged);
            btnozelkod1.DataBindings.Add("Text", _entity, "OzelKod1", false, DataSourceUpdateMode.OnPropertyChanged);
            btnozelkod2.DataBindings.Add("Text", _entity, "OzelKod2", false, DataSourceUpdateMode.OnPropertyChanged);
            btnozelkod3.DataBindings.Add("Text", _entity, "OzelKod3", false, DataSourceUpdateMode.OnPropertyChanged);
            btnozelkod4.DataBindings.Add("Text", _entity, "OzelKod4", false, DataSourceUpdateMode.OnPropertyChanged);
            calcalisozelfiyat.DataBindings.Add("Text", _entity, "AlisOzelFiyat", false,
                DataSourceUpdateMode.OnPropertyChanged);
            calcsatisozelfiyat.DataBindings.Add("Text", _entity, "SatisOzelFiyat", false,
                DataSourceUpdateMode.OnPropertyChanged);
            calciskontoorani.DataBindings.Add("EditValue", _entity, "IskontoOrani", true,
                DataSourceUpdateMode.OnPropertyChanged, 0, "'%'0");
            calcrisklimiti.DataBindings.Add("EditValue", _entity, "RiskLimiti", true,
                DataSourceUpdateMode.OnPropertyChanged, 0, "C2");
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (cariDal.AddOrUpdate(context, _entity))
            {
                cariDal.Save(context);
                saved = true;
                this.Close();
            }
        }

        private void FrmCariIslem_Load(object sender, EventArgs e)
        {

        }
    }
}
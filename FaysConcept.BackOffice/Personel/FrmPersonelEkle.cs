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
using FaysConcept.Entities.DataAccess;
using FaysConcept.Entities.Context;
using FaysConcept.BackOffice.Tanım;

namespace FaysConcept.BackOffice.Personel
{
    public partial class FrmPersonelEkle : DevExpress.XtraEditors.XtraForm
    {
        private Entities.Tables.Personel _entity;
        private PersonelDAL personelDAL = new PersonelDAL();
        private FaysConceptContext context = new FaysConceptContext();
        public bool saved = false;

        public FrmPersonelEkle(Entities.Tables.Personel entity)
        {
            InitializeComponent();
            _entity = entity;
            //Entities Tables da bulun isimler ile aynı olmalıdır.
            toggleCalisiyor.DataBindings.Add("EditValue", _entity, "Calisiyor", false, DataSourceUpdateMode.OnPropertyChanged);
            txtPersonelKodu.DataBindings.Add("Text", _entity, "PersonelKodu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtPersonelAdi.DataBindings.Add("Text", _entity, "PersonelAdi", false, DataSourceUpdateMode.OnPropertyChanged);
            cmbUnvani.DataBindings.Add("Text", _entity, "Unvani", false, DataSourceUpdateMode.OnPropertyChanged);
            txtTcKimlikNo.DataBindings.Add("Text", _entity, "TcKimlikNo", false, DataSourceUpdateMode.OnPropertyChanged);
            cmbGirisTarihi.DataBindings.Add("EditValue", _entity, "IseGirisTarihi", true, DataSourceUpdateMode.OnPropertyChanged,null,"F");
            cmbCikisTarihi.DataBindings.Add("EditValue", _entity, "IstenCikisTarihi", true, DataSourceUpdateMode.OnPropertyChanged,null,"F");
            txtVergiDairesi.DataBindings.Add("Text", _entity, "VergiDairesi", false,
               DataSourceUpdateMode.OnPropertyChanged);
            txtVergiNumarasi.DataBindings.Add("Text", _entity, "VergiNo", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);
            txtCepTelefonu.DataBindings.Add("Text", _entity, "CepTelefonu", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtSabitTelefon.DataBindings.Add("Text", _entity, "Telefon", false, DataSourceUpdateMode.OnPropertyChanged);
            txtFax.DataBindings.Add("Text", _entity, "Fax", false, DataSourceUpdateMode.OnPropertyChanged);
            txtEmail.DataBindings.Add("Text", _entity, "Email", false, DataSourceUpdateMode.OnPropertyChanged);
            txtWeb.DataBindings.Add("Text", _entity, "Web", false, DataSourceUpdateMode.OnPropertyChanged);
            txtIl.DataBindings.Add("Text", _entity, "Il", false, DataSourceUpdateMode.OnPropertyChanged);
            txtIlce.DataBindings.Add("Text", _entity, "Ilce", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSemt.DataBindings.Add("Text", _entity, "Semt", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAdres.DataBindings.Add("Text", _entity, "Adres", false, DataSourceUpdateMode.OnPropertyChanged);
            calcAylikMaas.DataBindings.Add("EditValue", _entity, "AylikMaas", true, DataSourceUpdateMode.OnPropertyChanged,0,"C2");
            //Formatlı veri için true yapılıyor.
            calcPrimOrani.DataBindings.Add("EditValue", _entity, "PrimOrani", true, DataSourceUpdateMode.OnPropertyChanged,0,"'%'0");

        }

        private void FrmPersonelEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (personelDAL.AddOrUpdate(context,_entity))
            {
                personelDAL.Save(context);
                saved = true;
                this.Close();
            }
        }

        private void cmbUnvani_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FrmTanim form = new FrmTanim(FrmTanim.TanimTuru.PersonelUnvan);
            form.ShowDialog();
            if (form.secildi)
            {
                cmbUnvani.Text = form._entity.Tanimi;
            }
        }


    }
}
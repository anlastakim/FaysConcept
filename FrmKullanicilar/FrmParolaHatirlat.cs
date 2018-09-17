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
using FaysConcept.Entities.Tables;
using FaysConcept.Entities.DataAccess;

namespace FrmKullanicilar
{
    public partial class FrmParolaHatirlat : DevExpress.XtraEditors.XtraForm
    {
        FaysConceptContext context = new FaysConceptContext();
        KullaniciDAL kullaniciDAL = new KullaniciDAL();
       private Kullanici _entity;
        public FrmParolaHatirlat(string kullaniciAdi)
        {
            InitializeComponent();
            _entity = context.Kullanicilar.SingleOrDefault(c => c.KullaniciAdi == kullaniciAdi);
            txtHatirlatmaSorusu.Text = _entity.HatirlatmaSorusu;

        }

        private void FrmParolaHatirlat_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (_entity.Cevap==txtCevap.Text && txtParola.Text==txtParolaTekrar.Text)
            {
                _entity.Parola = txtParola.Text;
                kullaniciDAL.AddOrUpdate(context, _entity);
                context.SaveChanges();
                MessageBox.Show("Şifreniz başarılı bir şekilde değiştirildi.");
                this.Close();
            }
        }
    }
}
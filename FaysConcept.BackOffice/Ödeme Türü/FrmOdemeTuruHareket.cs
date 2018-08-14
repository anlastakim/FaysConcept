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

namespace FaysConcept.BackOffice.Ödeme_Türü
{
    public partial class FrmOdemeTuruHareket : DevExpress.XtraEditors.XtraForm
    {
        FaysConceptContext context = new FaysConceptContext();
        OdemeTuruDAL odemeTuruDal = new OdemeTuruDAL();
        private string _odemeTuruKodu;
      

        public FrmOdemeTuruHareket(string odemeTuruKodu, string odemeTuruAdi)
        {
            InitializeComponent();
            _odemeTuruKodu = odemeTuruKodu;
            lblBaslik.Text = odemeTuruKodu + " - " + odemeTuruAdi + " Hareketleri"; // seçilen kaydı başlığa getirme
        }

        private void FrmOdemeTuruHareket_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            gridcontKasaHareket.DataSource = odemeTuruDal.GetAll(context, c => c.OdemeTuruKodu == _odemeTuruKodu);
            gridcontKasaBakiye.DataSource = odemeTuruDal.KasaToplamListele(context, _odemeTuruKodu);
            gridcontGenelToplam.DataSource = odemeTuruDal.GenelToplamListele(context, _odemeTuruKodu);
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            gridKasaHareket.OptionsView.ShowAutoFilterRow = false ? true : false; // kısayol single line if diye geçiyor
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
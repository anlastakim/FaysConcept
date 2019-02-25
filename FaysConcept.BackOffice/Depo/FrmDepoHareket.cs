using System;
using FaysConcept.Entities.Context;
using FaysConcept.Entities.DataAccess;

namespace FaysConcept.BackOffice.Depo
{
    public partial class FrmDepoHareket : DevExpress.XtraEditors.XtraForm
    {
        FaysConceptContext context = new FaysConceptContext();
        StokHareketDAL stokHareketDAL = new StokHareketDAL();
        private string _depoKodu; 

        public FrmDepoHareket(string depoKodu, string depoAdi)
        {
            InitializeComponent();
            _depoKodu = depoKodu;
            lblBaslik.Text = depoKodu + " " + depoAdi + "Depo Hareketleri";

        }

        private void FrmDepoHareket_Load(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void Guncelle()
        {

            gridcontDepoHareket.DataSource = stokHareketDAL.GetAll(context, c => c.DepoKodu == _depoKodu);
            gridcontDepoStok.DataSource = stokHareketDAL.DepoStokListele(context, _depoKodu);
            gridcontIstatistik.DataSource = stokHareketDAL.DepoIstatistikListele(context, _depoKodu);

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            if (gridDepoHareket.OptionsView.ShowAutoFilterRow == true)
            {
                gridDepoHareket.OptionsView.ShowAutoFilterRow = false;
            }
            else
            {
                gridDepoHareket.OptionsView.ShowAutoFilterRow = true;
            }
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
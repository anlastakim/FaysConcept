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

namespace FaysConcept.BackOffice.Kasalar
{
    public partial class FrmKasaHareket : DevExpress.XtraEditors.XtraForm
    {
        KasaDAL kasaDal=new KasaDAL();
        FaysConceptContext context=new FaysConceptContext();
        private string _kasaKodu;

        public FrmKasaHareket(string kasaKodu,string kasaAdi)
        {
            InitializeComponent();
            _kasaKodu = kasaKodu;
        }

        private void FrmKasaHareket_Load(object sender, EventArgs e)
        {
            //FaysConcept.Admin
        }

        public void Guncelle()
        {
            gridcontKasaHareket.DataSource = kasaDal.GetAll(context, c => c.KasaKodu == _kasaKodu);
            gridcontOdemeTuruToplam.DataSource = kasaDal.OdemeTuruToplamListele(context, _kasaKodu);
            gridcontGenelToplam.DataSource = kasaDal.GenelToplamListele(context, _kasaKodu);
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            if (gridKasaHareket.OptionsView.ShowAutoFilterRow == true)
            {
                gridKasaHareket.OptionsView.ShowAutoFilterRow = false;
                //MessageBox.Show(gridstokhareket.RowCount.ToString());
            }
            else
            {
                gridKasaHareket.OptionsView.ShowAutoFilterRow = true;
                //MessageBox.Show(gridstokhareket.RowCount.ToString());
            }
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
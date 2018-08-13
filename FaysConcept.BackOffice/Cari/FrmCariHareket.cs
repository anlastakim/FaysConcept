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
    public partial class FrmCariHareket : DevExpress.XtraEditors.XtraForm
    {
        CariDAL cariDal=new CariDAL();
        FaysConceptContext context=new FaysConceptContext();
        private string _cariKodu = null; // 

        public FrmCariHareket(string cariKodu,string cariAdi)
        {
            InitializeComponent();
            _cariKodu = cariKodu;
            lblBaslik.Text = _cariKodu + " - " + cariAdi + " Hareketleri";
        }

        private void FrmCariHareket_Load(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void Guncelle()
        {
          gridcontFisToplam.DataSource=  cariDal.CariFisGenelToplam(context, _cariKodu);
            gridcontBakiye.DataSource= cariDal.CariGenelToplam(context, _cariKodu);
            gridcontCariHareket.DataSource= cariDal.CariFisAyrinti(context, _cariKodu);
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            if (gridCariHareket.OptionsView.ShowAutoFilterRow == true)
            {
                gridCariHareket.OptionsView.ShowAutoFilterRow = false;
                //MessageBox.Show(gridstokhareket.RowCount.ToString());
            }
            else
            {
                gridCariHareket.OptionsView.ShowAutoFilterRow = true;
                //MessageBox.Show(gridstokhareket.RowCount.ToString());
            }
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
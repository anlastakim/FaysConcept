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

namespace FaysConcept.BackOffice.Stok
{
    public partial class FrmStokHareket : DevExpress.XtraEditors.XtraForm
    {
       
        StokHareketDAL stokHareketDal=new StokHareketDAL();
        FaysConceptContext context=new FaysConceptContext();
        private string _stokkodu;

        public FrmStokHareket(string stokkodu,string stokadi)
        {
            InitializeComponent();
            _stokkodu = stokkodu;
            lblBaslik.Text = _stokkodu + " - " + stokadi + " Hareketleri" ;

        }

        private void FrmStokHareket_Load(object sender, EventArgs e)
        {
           Guncelle();
        }

        private void Guncelle()
        {
            gridcontstokhareket.DataSource = stokHareketDal.GetAll(context, c => c.StokKodu == _stokkodu);
            gridcontgenelstok.DataSource = stokHareketDal.GetGenelStok(context, _stokkodu);
            gridcontdepostok.DataSource = stokHareketDal.GetDepoStok(context, _stokkodu);
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            if (gridstokhareket.OptionsView.ShowAutoFilterRow == true)
            {
                gridstokhareket.OptionsView.ShowAutoFilterRow = false;
                //MessageBox.Show(gridstokhareket.RowCount.ToString());
            }
            else
            {
                gridstokhareket.OptionsView.ShowAutoFilterRow = true;
                //MessageBox.Show(gridstokhareket.RowCount.ToString());
            }

        }
    }
}
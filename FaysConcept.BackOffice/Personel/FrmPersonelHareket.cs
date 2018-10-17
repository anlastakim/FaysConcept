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

namespace FaysConcept.BackOffice.Personel
{
    public partial class FrmPersonelHareket : DevExpress.XtraEditors.XtraForm
    {
        FaysConceptContext context = new FaysConceptContext();
        PersonelDAL personelDAL = new PersonelDAL();
        FisDAL fisDAL = new FisDAL();
        private string _personelKodu;

        public FrmPersonelHareket(string personelKodu,string personelAdi)
        {
            InitializeComponent();
            _personelKodu = personelKodu;
            lblBaslik.Text = personelKodu + " - " + personelAdi;
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPersonelHareket_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            gridcontPersonelHareket.DataSource = fisDAL.GetAll(context, c => c.PlasiyerKodu == _personelKodu);
            gridcontFisToplam.DataSource = personelDAL.PersonelFisToplam(context, _personelKodu);
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            if (gridViewPersonelHareket.OptionsView.ShowAutoFilterRow == true)
            {
                gridViewPersonelHareket.OptionsView.ShowAutoFilterRow = false;
                //MessageBox.Show(gridstokhareket.RowCount.ToString());
            }
            else
            {
                gridViewPersonelHareket.OptionsView.ShowAutoFilterRow = true;
                //MessageBox.Show(gridstokhareket.RowCount.ToString());
            }
        }
    }
}
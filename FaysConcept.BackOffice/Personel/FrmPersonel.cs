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
    public partial class FrmPersonel : DevExpress.XtraEditors.XtraForm
    {
        FaysConceptContext context = new FaysConceptContext();
        PersonelDAL personelDAL = new PersonelDAL();
        string _secilen = null;

        public FrmPersonel()
        {
            InitializeComponent();
        }

        private void Listele()
        {
            gridContPersonel.DataSource = personelDAL.PersonelListele(context);
        }

        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            _secilen = gridViewPersonel.GetFocusedRowCellValue(colPersonelKodu).ToString();
            if (MessageBox.Show("Seçili olan kaydı silmek istediğinize emin misiniz ?","Uyarı",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                personelDAL.Delete(context, c => c.PersonelKodu ==_secilen);
                personelDAL.Save(context);
                Listele();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmPersonelEkle form = new FrmPersonelEkle(new Entities.Tables.Personel());
            form.ShowDialog();
            if (form.saved)
            {
                Listele();

            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {

            _secilen = gridViewPersonel.GetFocusedRowCellValue(colPersonelKodu).ToString();
            FrmPersonelEkle form = new FrmPersonelEkle(personelDAL.GetByFilter(context, c => c.PersonelKodu == _secilen));
            form.ShowDialog();
            if (form.saved) // kapat butununa basıldığında gereksiz yere güncelleme işlemi yapmamak için ; form saved metodu (frmpersonelekle kaydet butonu altında) (addorrupdate) true ise listeyi güncelle
            {
                Listele();

            }
        }

        private void btnPersonelHareket_Click(object sender, EventArgs e)
        {
            _secilen = gridViewPersonel.GetFocusedRowCellValue(colPersonelKodu).ToString();
            FrmPersonelHareket form = new FrmPersonelHareket(_secilen, gridViewPersonel.GetFocusedRowCellValue(colPersonelAdi).ToString());
            form.ShowDialog();
        }
    }
}
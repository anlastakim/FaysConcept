using System;
using System.Windows.Forms;
using FaysConcept.Entities.Context;
using FaysConcept.Entities.DataAccess;

namespace FaysConcept.BackOffice.Cari
{
    public partial class FrmCariKart : DevExpress.XtraEditors.XtraForm
    {
        CariDAL cariDal = new CariDAL();
        FaysConceptContext context=new FaysConceptContext();
        private string secilen=null;

        public FrmCariKart()
        {
            InitializeComponent();
        }


        private void FrmCariKart_Load(object sender, EventArgs e)
        {
            GetAll();
        }

        public void GetAll()
        {
            gridControl1.DataSource = cariDal.GetCariler(context);
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            GetAll();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string secilen = gridView1.GetFocusedRowCellValue(colCariKodu).ToString();
                cariDal.Delete(context, c => c.CariKodu == secilen);
                cariDal.Save(context);
                GetAll();
            }
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            FrmCariIslem form = new FrmCariIslem(new Entities.Tables.Cari());
            form.ShowDialog();
            if (form.saved)
            {
                GetAll();

            }
            
        }

        private void btnduzenle_Click(object sender, EventArgs e)
        {
            secilen = gridView1.GetFocusedRowCellValue(colCariKodu).ToString();
            FrmCariIslem form = new FrmCariIslem(cariDal.GetByFilter(context, c => c.CariKodu == secilen));
            form.ShowDialog();
            if (form.saved) // kapat butununa basıldığında gereksiz yere güncelleme işlemi yapmamak için ; form saved metodu (cariislem kaydet butonu altında) (addorrupdate) true ise listeyi güncelle
            {
                GetAll();

            }
       
        }

        private void btnkopyala_Click(object sender, EventArgs e)
        {
            secilen = gridView1.GetFocusedRowCellValue(colCariKodu).ToString();
            Entities.Tables.Cari cariEntity = new Entities.Tables.Cari();
            cariEntity = cariDal.GetByFilter(context, c => c.CariKodu == secilen);
            cariEntity.Id = -1;
            cariEntity.CariKodu = null;
            //stokkodunun benzersiz olması için null olarak gönderiliyor.
            FrmCariIslem form = new FrmCariIslem(cariEntity);
            form.ShowDialog();
            if (form.saved)
            {
                GetAll();

            }
           
        }

        private void btncarihareket_Click(object sender, EventArgs e)
        {
            secilen = gridView1.GetFocusedRowCellValue(colCariKodu).ToString();
            string secilenad = gridView1.GetFocusedRowCellValue(colCariAdi).ToString();
            // odaklanan seçilen verinin stok kodunu alma
            FrmCariHareket form = new FrmCariHareket(secilen, secilenad);
            form.ShowDialog();
            //GetAll();
        }
    }
}
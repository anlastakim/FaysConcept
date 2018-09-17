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
    public partial class FrmKullaniciIslem : DevExpress.XtraEditors.XtraForm
    {
        FaysConceptContext context = new FaysConceptContext();
        KullaniciDAL kullaniciDAL = new KullaniciDAL();
        private Kullanici _entity;
        public bool saved = false;
        private string parola, cevap;

        public FrmKullaniciIslem(Kullanici entity)
        {
            InitializeComponent();
            treeList1.ExpandAll();
            if (entity != null) // düzenle işleminde boş değil ise 
            {
                parola = entity.Parola;
                cevap = entity.Cevap;
                entity.Cevap = null;
                entity.Parola = null;
            }
            _entity = entity;  // parolayı düzenle formunda gösterme

            txtKullaniciAdi.DataBindings.Add("Text", _entity, "KullaniciAdi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtParola.DataBindings.Add("Text", _entity, "Parola", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAdi.DataBindings.Add("Text", _entity, "Adi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSoyadi.DataBindings.Add("Text", _entity, "Soyadi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtGorevi.DataBindings.Add("Text", _entity, "Gorevi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtHatirlatmaSorusu.DataBindings.Add("Text", _entity, "HatirlatmaSorusu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtCevap.DataBindings.Add("Text", _entity, "Cevap", false, DataSourceUpdateMode.OnPropertyChanged);
            AyarYukle();

        }


        private void AyarYukle()
        {
            if (!string.IsNullOrEmpty(_entity.KullaniciAdi))
            {
                foreach (var item in context.KullaniciRolleri.Where(c => c.KullaniciAdi == _entity.KullaniciAdi).ToList())
                {
                    treeList1.SetNodeCheckState(treeList1.Nodes[item.RootId].Nodes[item.ParentId], item.Yetki == true ? CheckState.Checked : CheckState.Unchecked, true);
                }
            }
        }

        private void Kaydet()
        {
            for (int i = 0; i < treeList1.Nodes.Count; i++) // ana nodları dolaşıyor
            {
                for (int j = 0; j < treeList1.Nodes[i].Nodes.Count; j++) //i nin içindeki nodeları dolaşıyor
                {
                    // böyle bir kayıt yok ise yeni kullanıcı yetkisi oluştur
                    if (context.KullaniciRolleri.Count(c => c.KullaniciAdi == txtKullaniciAdi.Text && c.RootId == i && c.ParentId == j) == 0)
                    {
                        context.KullaniciRolleri.Add(new KullaniciRol
                        {
                            KullaniciAdi = txtKullaniciAdi.Text,
                            FormAdi = treeList1.Nodes[i].GetDisplayText(treeListColumn2),
                            KontrolAdi = treeList1.Nodes[i].Nodes[j].GetDisplayText(treeListColumn2),
                            RootId = i,
                            ParentId = j,
                            Yetki = treeList1.Nodes[i].Nodes[j].Checked

                        });
                    }
                    else
                    {     // var ise yetkileri güncelle
                        context.KullaniciRolleri.SingleOrDefault
                            (c => c.KullaniciAdi == txtKullaniciAdi.Text && c.RootId == i && c.ParentId == j).Yetki =
                            treeList1.Nodes[i].Nodes[j].Checked;
                    }
                }
            }
            context.SaveChanges();
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmKullaniciIslem_Load(object sender, EventArgs e)
        {

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_entity.Parola))
            {
                txtParola.Text = parola;
                txtParolaTekrar.Text = parola;
            }

            if (string.IsNullOrEmpty(_entity.Cevap))
            {
                txtCevap.Text = cevap;
            }

            if (txtParola.Text != txtParolaTekrar.Text)
            {
                MessageBox.Show("Girilen Parola Aynı Değil");
            }
            else
            {
                if (_entity.KayitTarihi == null)
                {
                    _entity.KayitTarihi = DateTime.Now;
                }

                if (kullaniciDAL.AddOrUpdate(context, _entity))
                {
                    Kaydet();
                    saved = true;
                    this.Close();

                }

            }

        }
    }
}
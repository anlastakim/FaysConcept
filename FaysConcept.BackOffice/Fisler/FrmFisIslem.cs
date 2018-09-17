using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using DevExpress.XtraEditors;
using FaysConcept.BackOffice.Cari;
using FaysConcept.BackOffice.Depo;
using FaysConcept.BackOffice.Kasalar;
using FaysConcept.BackOffice.Stok;
using FaysConcept.Entities.Context;
using FaysConcept.Entities.DataAccess;
using FaysConcept.Entities.Tables;


namespace FaysConcept.BackOffice.Fisler
{
    public partial class FrmFisIslem : DevExpress.XtraEditors.XtraForm
    {
        FaysConceptContext context = new FaysConceptContext();
        FisDAL fisDal = new FisDAL();
        StokHareketDAL stokHareketDal = new StokHareketDAL();
        KasaHareketDAL kasaHareketDal = new KasaHareketDAL();
        CariDAL cariDal = new CariDAL();

        Fis _fisentity = new Fis();
        CariBakiye entityCariBakiye = new CariBakiye();


        public FrmFisIslem(string fisKodu = null)
        {
            InitializeComponent();
            // Mevcut fişler üzerinde değişiklik yapma (load yapma)
            if (fisKodu != null)
            {
                _fisentity = context.Fisler.Where(c => c.FisKodu == fisKodu).SingleOrDefault();
                context.StokHareketleri.Where(c => c.FisKodu == fisKodu).Load();
                context.KasaHareketleri.Where(c => c.FisKodu == fisKodu).Load();
                entityCariBakiye = this.cariDal.CariBakiyesi(context, _fisentity.CariKodu);

                lblAlacak.Text = entityCariBakiye.Alacak.ToString("C2");
                lblBorc.Text = entityCariBakiye.Borc.ToString("C2");
                lblBakiye.Text = entityCariBakiye.Bakiye.ToString("C2");
            }

            // bindings işlemi sıkıntılı olduğunda onproperty  kullanılıyor
            textFisNo.DataBindings.Add("Text", _fisentity, "FisKodu", false, DataSourceUpdateMode.OnPropertyChanged);
            textFisTuru.DataBindings.Add("Text", _fisentity, "FisTuru", false, DataSourceUpdateMode.OnPropertyChanged);
            CmbTarih.DataBindings.Add("EditValue", _fisentity, "Tarih", false, DataSourceUpdateMode.OnPropertyChanged);
            textBelgeNo.DataBindings.Add("Text", _fisentity, "BelgeNo", false, DataSourceUpdateMode.OnPropertyChanged);
            textAciklama.DataBindings.Add("Text", _fisentity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);
            // Fiş Bilgileri binding edildi.

            lblCariKodu.DataBindings.Add("Text", _fisentity, "CariKodu", false, DataSourceUpdateMode.OnPropertyChanged);
            lblCariAdi.DataBindings.Add("Text", _fisentity, "CariAdi", false, DataSourceUpdateMode.OnPropertyChanged);
            textFaturaUnvani.DataBindings.Add("Text", _fisentity, "FaturaUnvani", false, DataSourceUpdateMode.OnPropertyChanged);
            textGsmNo.DataBindings.Add("Text", _fisentity, "CepTelefon", false, DataSourceUpdateMode.OnPropertyChanged);
            textIl.DataBindings.Add("Text", _fisentity, "Il", false, DataSourceUpdateMode.OnPropertyChanged);
            textIlce.DataBindings.Add("Text", _fisentity, "Ilce", false, DataSourceUpdateMode.OnPropertyChanged);
            textSemt.DataBindings.Add("Text", _fisentity, "Semt", false, DataSourceUpdateMode.OnPropertyChanged);
            textAdres.DataBindings.Add("Text", _fisentity, "Adres", false, DataSourceUpdateMode.OnPropertyChanged);
            textVergiDairesi.DataBindings.Add("Text", _fisentity, "VergiDairesi", false, DataSourceUpdateMode.OnPropertyChanged);
            textVergiNo.DataBindings.Add("Text", _fisentity, "VergiNo", false, DataSourceUpdateMode.OnPropertyChanged);

            gridControlSatisEkrani.DataSource = context.StokHareketleri.Local.ToBindingList();
            // grid control satis ekranini stokhareketlerinde tablo ile lokalime bağlama (veri değiştirme)
            // listeleme yapmadık sadece verikaynağını bağladık.
            gridControlOdemeEkrani.DataSource = context.KasaHareketleri.Local.ToBindingList();

            Toplamlar();
            OdenenTutarGuncelle();

            // Ödeme türlerini dolaş ve buton olarak getirme 
            foreach (var item in context.OdemeTurleri.ToList())
            {
                var buton = new SimpleButton
                {
                    Name = item.OdemeTuruKodu,
                    Text = item.OdemeTuruAdi,
                    Height = 35,
                    Width = 150
                };

                buton.Click += OdemeEkle_Click;
                flowOdemeTurleri.Controls.Add(buton);
            }

        }

        private void OdemeEkle_Click(object sender, EventArgs e)
        {
            var buton = (sender as SimpleButton);
            KasaHareket entityKasaHareket = new KasaHareket
            {
                OdemeTuruKodu = buton.Name,
                OdemeTuruAdi = buton.Text,
                Tutar = calcOdenmesiGereken.Value
            };

            if (calcOdenmesiGereken.Value <= 0)
            {
                MessageBox.Show("Ödenmesi Gereken Tutar zaten ödenmiş durumdadır.");
            }

            else
            {
                kasaHareketDal.AddOrUpdate(context, entityKasaHareket);
                OdenenTutarGuncelle();
            }

        }

        private void OdenenTutarGuncelle()
        {
            gridViewOdemeEkrani.UpdateSummary();
            calcOdenenTutar.Value = Convert.ToDecimal(colTutar.SummaryItem.SummaryValue);
            calcOdenmesiGereken.Value = calcGenelToplam.Value - calcOdenenTutar.Value;
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmFisIslem_Load(object sender, EventArgs e)
        {

        }

        private StokHareket StokSec(Entities.Tables.Stok entity)  // stoğu alıp stok harekete gönderiyoruz.
        {
            StokHareket stokHareket = new StokHareket();
            stokHareket.StokKodu = entity.StokKodu;
            stokHareket.StokAdi = entity.StokAdi;
            stokHareket.Barkod = entity.BarkodNo;
            stokHareket.BarkodTuru = entity.BarkodTuru;
            stokHareket.BirimFiyat = textFisTuru.Text == "Alış Faturası" ? entity.AlisFiyat1 : entity.SatisFiyat1;
            stokHareket.Birimi = entity.Birimi;
            stokHareket.Miktar = textMiktar.Value;
            stokHareket.Kdv = entity.SatisKdv;
            stokHareket.IndirimOrani = 0;
            return stokHareket;
        }

        private void btnUrunBul_Click(object sender, EventArgs e)
        {
            FrmStokSec form = new FrmStokSec();
            form.ShowDialog();
            if (form.secildi) // if koşulu true ise çalışıyor o yüzden true ise demeye gerek yok .
            {
                stokHareketDal.AddOrUpdate(context, StokSec(form.secilen.First()));
                Toplamlar();
            }

        }

        private void textBarkodNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Entities.Tables.Stok entityStok;

                entityStok = context.Stoklar.Where(c => c.BarkodNo == textBarkodNo.Text).SingleOrDefault();
                if (entityStok != null) // boş değil ise
                {
                    stokHareketDal.AddOrUpdate(context,
                        StokSec(entityStok));
                    Toplamlar();
                }
                else
                {
                    MessageBox.Show("Aradığınız Barkod numarası ürünler arasında bulunamadı.");
                }

                textBarkodNo.Text = null;  //ekledikten sonra barkodno alanını temizleme

            }
        }

        private void btnCariSec_Click(object sender, EventArgs e)
        {
            FrmCariSec form = new FrmCariSec();
            form.ShowDialog();
            if (form.secildi)
            {
                Entities.Tables.Cari entityCari = form.secilen.FirstOrDefault();
                entityCariBakiye = this.cariDal.CariBakiyesi(context, entityCari.CariKodu);

                lblCariKodu.Text = entityCari.CariKodu;
                lblCariAdi.Text = entityCari.CariAdi;
                textFaturaUnvani.Text = entityCari.FaturaUnvani;
                textVergiDairesi.Text = entityCari.VergiDairesi;
                textVergiNo.Text = entityCari.VergiNo;
                textGsmNo.Text = entityCari.CepTelefon;
                textIl.Text = entityCari.Il;
                textIlce.Text = entityCari.Ilce;
                textSemt.Text = entityCari.Semt;
                textAdres.Text = entityCari.Adres;
                lblAlacak.Text = entityCariBakiye.Alacak.ToString("C2");
                lblBorc.Text = entityCariBakiye.Borc.ToString("C2");
                lblBakiye.Text = entityCariBakiye.Bakiye.ToString("C2");

            }
        }

        private void btnCariTemizle_Click(object sender, EventArgs e)
        {
            lblCariKodu.Text = null;
            lblCariAdi.Text = null;
            textFaturaUnvani.Text = null;
            textVergiDairesi.Text = null;
            textVergiNo.Text = null;
            textGsmNo.Text = null;
            textIl.Text = null;
            textIlce.Text = null;
            textSemt.Text = null;
            textAdres.Text = null;
            lblAlacak.Text = "Görüntülenemiyor";
            lblBorc.Text = "Görüntülenemiyor";
            lblBakiye.Text = "Görüntülenemiyor";
        }

        private void gridViewSatisEkrani_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

            Toplamlar();

        }

        private void Toplamlar()
        {

            gridViewSatisEkrani.UpdateSummary(); // gridview de alanların özelliği summaryitem update etmek gerekiyor doğru çalışması için
            calcIskontoTutari.Value = Convert.ToDecimal(colToplamTutar.SummaryItem.SummaryValue) / 100 *
                                      calcIskontoOrani.Value;
            calcGenelToplam.Value = Convert.ToDecimal(colToplamTutar.SummaryItem.SummaryValue) - calcIskontoTutari.Value;
            calcKdvToplami.Value = Convert.ToDecimal(colKdvToplam.SummaryItem.SummaryValue);
            calcIndirimToplami.Value = Convert.ToDecimal(colIndirimTutar.SummaryItem.SummaryValue);
            calcOdenmesiGereken.Value = calcGenelToplam.Value - calcOdenenTutar.Value;
        }


        private void calcIskontoOrani_EditValueChanged(object sender, EventArgs e)
        {
            Toplamlar();
        }

        private void repoDepoAdi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            FrmDepoSec form = new FrmDepoSec(gridViewSatisEkrani.GetFocusedRowCellValue(colStokKodu).ToString());
            form.ShowDialog();
            if (form.secildi)
            {
                gridViewSatisEkrani.SetFocusedRowCellValue(colDepoKodu, form.entity.DepoKodu);
                gridViewSatisEkrani.SetFocusedRowCellValue(colDepoAdi, form.entity.DepoAdi);

            }
        }

        private void repoBirimFiyat_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string fiyatSecilen = gridViewSatisEkrani.GetFocusedRowCellValue(colStokKodu).ToString();
            Entities.Tables.Stok fiyatEntity = context.Stoklar.Where(c => c.StokKodu == fiyatSecilen).SingleOrDefault();

            // Fiş türü alış faturası ise aliş fiyatları gelsin değil ise satış fiyatları gelsin..
            barFiyat1.Tag = textFisTuru.Text == "Alış Faturası" ? fiyatEntity.AlisFiyat1 ?? 0 : fiyatEntity.SatisFiyat1 ?? 0;
            barFiyat2.Tag = textFisTuru.Text == "Alış Faturası" ? fiyatEntity.AlisFiyat2 ?? 0 : fiyatEntity.SatisFiyat2 ?? 0;
            barFiyat3.Tag = textFisTuru.Text == "Alış Faturası" ? fiyatEntity.AlisFiyat3 ?? 0 : fiyatEntity.SatisFiyat3 ?? 0;

            barFiyat1.Caption = string.Format("{0:C2}", barFiyat1.Tag);
            barFiyat2.Caption = string.Format("{0:C2}", barFiyat2.Tag);
            barFiyat3.Caption = string.Format("{0:C2}", barFiyat3.Tag); // tag kullanarak sonu TL olacak şekilde gönder.
            radialFiyat.ShowPopup(MousePosition);
        }

        private void FiyatSec(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewSatisEkrani.SetFocusedRowCellValue(colBirimFiyat, Convert.ToDecimal(e.Item.Tag));
        }

        private void repoSeriNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string veri = Convert.ToString(gridViewSatisEkrani.GetFocusedRowCellValue(colSeriNo));
            FrmSeriNo form = new FrmSeriNo(veri);
            form.ShowDialog();
            gridViewSatisEkrani.SetFocusedRowCellValue(colSeriNo, form.veriSeriNo);  // değişikliği yapıp yeni veriyi alma
        }

        private void repoSil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gridViewSatisEkrani.DeleteSelectedRows();
                Toplamlar();
            }
        }

        private void repoKasa_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FrmKasaSec form = new FrmKasaSec();
            form.ShowDialog();
            if (form.secildi)
            {
                gridViewOdemeEkrani.SetFocusedRowCellValue(colKasaKodu, form.entity.KasaKodu);
                gridViewOdemeEkrani.SetFocusedRowCellValue(colKasaAdi, form.entity.KasaAdi);
            }
        }

        private void repoKHSil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gridViewOdemeEkrani.DeleteSelectedRows();
                OdenenTutarGuncelle();
            }
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {      // boş geçilmemesi için kontrol
            int StokHata = context.StokHareketleri.Local.Where(c => c.DepoKodu == null).Count();
            int KasaHata = context.KasaHareketleri.Local.Where(c => c.KasaKodu == null).Count();

            if (StokHata == 0 && KasaHata == 0)
            {
                foreach (var stokVeri in context.StokHareketleri.Local.ToList())  // local önemli
                {
                    stokVeri.Tarih = stokVeri.Tarih == null
                        ? Convert.ToDateTime(CmbTarih.DateTime)
                        : Convert.ToDateTime(stokVeri.Tarih);
                    stokVeri.FisKodu = textFisNo.Text;
                    stokVeri.Hareket = _fisentity.FisTuru == "Alış Faturası" ? "Stok Giriş" : "Stok Çıkış";

                }
                foreach (var kasaVeri in context.KasaHareketleri.Local.ToList())  // local önemli
                {
                    kasaVeri.Tarih = kasaVeri.Tarih == null ? Convert.ToDateTime(CmbTarih.DateTime) : Convert.ToDateTime(kasaVeri.Tarih);
                    kasaVeri.FisKodu = textFisNo.Text;
                    kasaVeri.Hareket = _fisentity.FisTuru == "Alış Faturası" ? "Kasa Çıkış" : "Kasa Giriş";
                    kasaVeri.CariKodu = lblCariKodu.Text;
                    kasaVeri.CariAdi = lblCariAdi.Text;
                }

                _fisentity.ToplamTutar = calcGenelToplam.Value;
                _fisentity.IskontoOrani = calcIskontoOrani.Value;
                _fisentity.IskontoTutar = calcIskontoTutari.Value;
                fisDal.AddOrUpdate(context, _fisentity);
                context.SaveChanges();
            }



        }

        private void CmbTarih_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                CmbTarih.DateTime = DateTime.Now;
            }
        }

        private void CmbTarih_EditValueChanged(object sender, EventArgs e)
        {
            CmbTarih.DateTime = DateTime.Now;
        }
    }
}

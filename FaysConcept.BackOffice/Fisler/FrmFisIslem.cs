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
using FaysConcept.Entities.Tools;
using FaysConcept.Entities.Tables.OtherTables;

namespace FaysConcept.BackOffice.Fisler
{
    public partial class FrmFisIslem : DevExpress.XtraEditors.XtraForm
    {
        FaysConceptContext context = new FaysConceptContext();
        FisDAL fisDal = new FisDAL();
        StokHareketDAL stokHareketDal = new StokHareketDAL();
        KasaHareketDAL kasaHareketDal = new KasaHareketDAL();
        CariDAL cariDal = new CariDAL();

        FisAyarlari ayarlar = new FisAyarlari();

        Fis _fisentity = new Fis();
        CariBakiye entityCariBakiye = new CariBakiye();


        #region ToBinding ve ödeme türleri buton olarak eklenmesi
        public FrmFisIslem(string fisKodu = null, string fisTuru = null)
        {
            InitializeComponent();
            // Mevcut fişler üzerinde değişiklik yapma (load yapma)
            if (fisKodu != null)
            {
                _fisentity = context.Fisler.Where(c => c.FisKodu == fisKodu).SingleOrDefault();
                context.StokHareketleri.Where(c => c.FisKodu == fisKodu).Load();
                context.KasaHareketleri.Where(c => c.FisKodu == fisKodu).Load();

                if (_fisentity.CariKodu != null)
                {
                    entityCariBakiye = this.cariDal.CariBakiyesi(context, _fisentity.CariKodu);

                    lblAlacak.Text = entityCariBakiye.Alacak.ToString("C2");
                    lblBorc.Text = entityCariBakiye.Borc.ToString("C2");
                    lblBakiye.Text = entityCariBakiye.Bakiye.ToString("C2");
                }

            }

            else
            {
                _fisentity.FisTuru = fisTuru;
                _fisentity.Tarih = DateTime.Now;
            }

            // bindings işlemi sıkıntılı olduğunda onproperty  kullanılıyor
            textFisNo.DataBindings.Add("Text", _fisentity, "FisKodu", false, DataSourceUpdateMode.OnPropertyChanged);
            textFisTuru.DataBindings.Add("Text", _fisentity, "FisTuru", false, DataSourceUpdateMode.OnPropertyChanged);
            CmbTarih.DataBindings.Add("EditValue", _fisentity, "Tarih", true, DataSourceUpdateMode.OnPropertyChanged, null, "F");
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

            FisAyar();
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
        #endregion



        #region Ödeme yapma bölümü
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

        #endregion


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
            stokHareket.DepoKodu = SettingsTool.AyarOku(SettingsTool.Ayarlar.FrmFisIslem_VarsayılanDepo);
            // settings üzerinden okunan depo kodunun depo adını getirme
            stokHareket.DepoAdi = context.Depolar.SingleOrDefault(c => c.DepoKodu == stokHareket.DepoKodu).DepoAdi;
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

        #region  Fiş Cari Seçme ve Temizle Bölümü
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
        #endregion

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

        #region SeriNoBilgisi
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
                OdenenTutarGuncelle();
                Toplamlar();
            }
        }
        #endregion

        #region KasaBilgisi
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
                Toplamlar();
                OdenenTutarGuncelle();

            }
        }
        #endregion

        #region Fiş Kaydetmeden önce doldurulması zorunlu olan alanlar
        private void FisAyar()
        {

            //fiş türünü yakaladığımız yer ve ayaları
            switch (_fisentity.FisTuru)
            {
                case "Alış Faturası":
                    ayarlar.StokHareketi = "Stok Giriş";
                    ayarlar.KasaHareketi = "Kasa Çıkış";
                    lblBaslik.Appearance.ImageIndex = 0;
                    ayarlar.OdemeEkrani = true;

                    break;
                case "Perakende Satış Faturası":
                    ayarlar.StokHareketi = "Stok Çıkış";
                    ayarlar.KasaHareketi = "Kasa Giriş";
                    lblBaslik.Appearance.ImageIndex = 1;
                    ayarlar.OdemeEkrani = true;
                    break;
                case "Toptan Satış Faturası":
                    ayarlar.StokHareketi = "Stok Çıkış";
                    ayarlar.KasaHareketi = "Kasa Giriş";
                    lblBaslik.Appearance.ImageIndex = 2;
                    ayarlar.OdemeEkrani = true;
                    break;
                case "Alış İade Faturası":
                    ayarlar.StokHareketi = "Stok Çıkış";
                    ayarlar.KasaHareketi = "Kasa Giriş";
                    lblBaslik.Appearance.ImageIndex = 3;
                    ayarlar.OdemeEkrani = true;
                    break;
                case "Satış İade Faturası":
                    ayarlar.StokHareketi = "Stok Giriş";
                    ayarlar.KasaHareketi = "Kasa Çıkış";
                    lblBaslik.Appearance.ImageIndex = 4;
                    ayarlar.OdemeEkrani = true;
                    break;
                case "Sayım Fazlası Fişi":
                    ayarlar.StokHareketi = "Stok Giriş";
                    navOdemeEkrani.Dispose();
                    lblBaslik.Appearance.ImageIndex = 5;
                    panelOdemeBilgi.Visible = false;
                    ayarlar.OdemeEkrani = false;
                    navCariBilgi.Dispose();
                    break;
                case "Sayım Eksiği Fişi":
                    ayarlar.StokHareketi = "Stok Çıkış";
                    navOdemeEkrani.Dispose();
                    lblBaslik.Appearance.ImageIndex = 6;
                    panelOdemeBilgi.Visible = false;
                    ayarlar.OdemeEkrani = false;
                    navCariBilgi.Dispose();
                    break;
                case "Stok Devir Fişi":
                    ayarlar.StokHareketi = "Stok Giriş";
                    navOdemeEkrani.Dispose();
                    lblBaslik.Appearance.ImageIndex = 7;
                    panelOdemeBilgi.Visible = false;
                    ayarlar.OdemeEkrani = false;
                    navCariBilgi.Dispose();
                    break;
                case "Tahsilat Fişi":
                    ayarlar.KasaHareketi = "Kasa Giriş";
                    ayarlar.OdemeEkrani = true;
                    ayarlar.SatisEkrani = false;
                    panelOdemeBilgi.Visible = false;
                    panelIskonto.Visible = false;
                    panelKDV.Visible = false;
                    panelGenelToplam.Top = 25;
                    grpToplamlar.Height = 65;
                    navigationPane2.SelectedPage = navOdemeEkrani;
                    navSatisEkrani.Dispose();
                    lblBaslik.Appearance.ImageIndex = 8;
                    break;
                case "Ödeme Fişi":
                    ayarlar.KasaHareketi = "Kasa Çıkış";
                    ayarlar.OdemeEkrani = true;
                    ayarlar.SatisEkrani = false;
                    panelOdemeBilgi.Visible = false;
                    panelIskonto.Visible = false;
                    panelKDV.Visible = false;
                    panelGenelToplam.Top = 25;
                    grpToplamlar.Height = 65;
                    navigationPane2.SelectedPage = navOdemeEkrani;
                    navSatisEkrani.Dispose();
                    lblBaslik.Appearance.ImageIndex = 9;
                    break;

                    // Bu kısma daha sonra bakılacak.
                case "Cari Devir Fişi":
                    ayarlar.KasaHareketi = "Kasa Giriş";
                    ayarlar.OdemeEkrani = true;
                    ayarlar.SatisEkrani = false;
                    panelOdemeBilgi.Visible = false;
                    panelIskonto.Visible = false;
                    panelKDV.Visible = false;
                    panelGenelToplam.Top = 25;
                    grpToplamlar.Height = 65;
                    navigationPane2.SelectedPage = navOdemeEkrani;
                    navSatisEkrani.Dispose();
                    lblBaslik.Appearance.ImageIndex = 10;
                    break;
            }
        }
        #endregion

        #region Stok Fiş Kaydet
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            int StokHata = context.StokHareketleri.Local.Where(c => c.DepoKodu == null).Count();
            int KasaHata = context.KasaHareketleri.Local.Where(c => c.KasaKodu == null).Count();

            //validator yerine manuel olarak kontrol
            string message = null;
            int hata = 0;
            if (gridViewSatisEkrani.RowCount == 0)
            {
                message += "Satış ekranında eklenmiş bir ürün bulunamadı" + System.Environment.NewLine;
                hata++;
            }

            if (textFisNo.Text == "")
            {
                message += "Fiş Numarası alanı boş geçilemez." + System.Environment.NewLine;
                // hatayı 1 artır
                hata++;
            }
            //ödenmesi gereken tutar sıfır değil ise ve odeme ekrani açık ise mesaj ver.
            if (calcOdenmesiGereken.Value != 0 && ayarlar.OdemeEkrani == true)
            {
                message += "Ödenmesi gereken tutar ödenmemiş görünüyor." + System.Environment.NewLine;
                hata++;
            }
            if (StokHata != 0)
            {
                message += "Satış ekranındaki eklenen ürünlerde depo seçimi yapılmayanlar var." + System.Environment.NewLine;
                // hatayı 1 artır
                hata++;
            }
            if (KasaHata != 0)
            {
                message += "Ödeme ekranında kasa seçilmemiş." + System.Environment.NewLine;
                hata++;
            }
            if (hata != 0)
            {
                MessageBox.Show(message);
                //bundan sonrasına devam etmemek için
                return;
            }

            foreach (var stokVeri in context.StokHareketleri.Local.ToList())  // local önemli
            {
                //stokVeri.Tarih = stokVeri.Tarih == null
                //    ? Convert.ToDateTime(CmbTarih.DateTime)
                //    : Convert.ToDateTime(stokVeri.Tarih);
                stokVeri.FisKodu = textFisNo.Text;
                stokVeri.Hareket = ayarlar.StokHareketi;

            }


            if (ayarlar.OdemeEkrani)
            {
                foreach (var kasaVeri in context.KasaHareketleri.Local.ToList())  // local önemli
                {
                    kasaVeri.Tarih = kasaVeri.Tarih == null ? Convert.ToDateTime(CmbTarih.DateTime) : Convert.ToDateTime(kasaVeri.Tarih);
                    kasaVeri.FisKodu = textFisNo.Text;
                    kasaVeri.Hareket = ayarlar.KasaHareketi;
                    kasaVeri.CariKodu = lblCariKodu.Text;
                    kasaVeri.CariAdi = lblCariAdi.Text;
                }
            }


            _fisentity.ToplamTutar = calcGenelToplam.Value;
            _fisentity.IskontoOrani = calcIskontoOrani.Value;
            _fisentity.IskontoTutar = calcIskontoTutari.Value;
            fisDal.AddOrUpdate(context, _fisentity);
            context.SaveChanges();
            this.Close();



        }
        #endregion

        private void CmbTarih_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            CmbTarih.DateTime = DateTime.Now;
        }

        #region Kapat Butonu
        private void btnkapat_Click(object sender, EventArgs e)
        {
            if (gridViewSatisEkrani.RowCount != 0)
            {
                if (MessageBox.Show("Fişte eklenmiş ürünler var.Çıkmak istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }
        #endregion
    }
}

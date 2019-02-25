using AnlasYazilim.Software.UI.Win.Forms.Interfaces;

namespace AnlasYazilim.Software.UI.Win.Forms.BaseForms
{
    public partial class BaseKartlarForm : DevExpress.XtraBars.Ribbon.RibbonForm,Language
    {
        public string Language { get; set; }
        public BaseKartlarForm()
        {
            InitializeComponent();
            Language = Properties.Settings.Default.DilSecim;

            #region Dil Ayarları

            if (Language == "TR")
            {
                #region HeaderCaptions

                btnYeni.Caption = "Yeni";
                btnSil.Caption = "Sil";
                btnSec.Caption = "Seç";
                btnDuzelt.Caption = "Düzelt";
                btnYenile.Caption = "Yenile";
                btnFiltrele.Caption = "Filtrele";
                btnKolonlar.Caption = "Kolonlar";
                btnYazdir.Caption = "Yazdır";
                btnGonder.Caption = "Gönder";
                btnCikis.Caption = "Çıkış";

                #endregion
            }
            else if (Language == "EN")
            {
                #region HeaderCaptions

                btnYeni.Caption = "New";
                btnSil.Caption = "Delete";
                btnSec.Caption = "Select";
                btnDuzelt.Caption = "Edit";
                btnYenile.Caption = "Refresh";
                btnFiltrele.Caption = "Filter";
                btnKolonlar.Caption = "Columns";
                btnYazdir.Caption = "Print";
                btnGonder.Caption = "Send";
                btnCikis.Caption = "Exit";

                #endregion
            }
            else
            {
                #region HeaderCaptions

                btnYeni.Caption = "New";
                btnSil.Caption = "Delete";
                btnSec.Caption = "Select";
                btnDuzelt.Caption = "Edit";
                btnYenile.Caption = "Refresh";
                btnFiltrele.Caption = "Filter";
                btnKolonlar.Caption = "Columns";
                btnYazdir.Caption = "Print";
                btnGonder.Caption = "Send";
                btnCikis.Caption = "Exit";

                #endregion
            } 
            #endregion

        }

       
    }
}
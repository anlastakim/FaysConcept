using AnlasYazilim.Software.UI.Win.Forms.BaseForms;

namespace AnlasYazilim.OgrenciTakip.UI.Win.Forms.OkulForms
{
    public partial class OkulKarti : BaseKartForm
    {
        public void Dil()
        {
            if (Language == "TR")
            {
                btnYeni.Caption = "Yeni";
                btnSil.Caption = "Sil";
                btnKaydet.Caption = "Kaydet";
                btnGeriAl.Caption = "Geri Al";
                btnCikis.Caption = "Çıkış";
                this.Text = "Okul Kartları";
                layoutControlItem1.Text = "Kod";
                layoutControlItem2.Text = "Okul Adı";
                layoutControlItem3.Text = "İl";
                layoutControlItem4.Text = "İlçe";
                layoutControlItem5.Text = "Açıklama";
            }
            else if (Language == "EN")
            {
                btnYeni.Caption = "New";
                btnSil.Caption = "Delete";
                btnKaydet.Caption = "Save";
                btnGeriAl.Caption = "Undo";
                btnCikis.Caption = "Exit";
                this.Text = "School Cards";
                layoutControlItem1.Text = "Code";
                layoutControlItem2.Text = "School Name";
                layoutControlItem3.Text = "Country";
                layoutControlItem4.Text = "District";
                layoutControlItem5.Text = "Comment";
            }
            else
            {
                btnYeni.Caption = "New";
                btnSil.Caption = "Delete";
                btnKaydet.Caption = "Save";
                btnGeriAl.Caption = "Undo";
                btnCikis.Caption = "Exit";
                this.Text = "School Cards";
                layoutControlItem1.Text = "Code";
                layoutControlItem2.Text = "School Name";
                layoutControlItem3.Text = "Country";
                layoutControlItem4.Text = "District";
                layoutControlItem5.Text = "Comment";
            }
        }

        public OkulKarti()
        {
            InitializeComponent();
        }

        private void OkulKarti_Load(object sender, System.EventArgs e)
        {
            #region Dil Ayarları
            Language = Software.UI.Win.Properties.Settings.Default.DilSecim;
            Dil(); 
            #endregion



        }
    }
}
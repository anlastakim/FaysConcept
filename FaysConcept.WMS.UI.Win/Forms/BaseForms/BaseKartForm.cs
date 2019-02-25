using AnlasYazilim.Software.UI.Win.Forms.Interfaces;

namespace AnlasYazilim.Software.UI.Win.Forms.BaseForms
{
    public partial class BaseKartForm : DevExpress.XtraBars.Ribbon.RibbonForm,Language
    {

        
        public string Language { get; set; }
        public BaseKartForm()
        {
            InitializeComponent();

            if (Language == "TR")
            {
                btnYeni.Caption = "Yeni";
                btnSil.Caption = "Sil";
                btnKaydet.Caption = "Kaydet";
                btnGeriAl.Caption = "Geri Al";
                btnCikis.Caption = "Çıkış";
            } else if (Language=="EN")
            {
                btnYeni.Caption = "New";
                btnSil.Caption = "Delete";
                btnKaydet.Caption = "Save";
                btnGeriAl.Caption = "Undo";
                btnCikis.Caption = "Exit";
            } else
            {
                btnYeni.Caption = "Yeni";
                btnSil.Caption = "Sil";
                btnKaydet.Caption = "Kaydet";
                btnGeriAl.Caption = "Geri Al";
                btnCikis.Caption = "Çıkış";
            }

        }
    }
}
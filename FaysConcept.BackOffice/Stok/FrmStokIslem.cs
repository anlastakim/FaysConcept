using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FaysConcept.Entities.Context;
using FaysConcept.Entities.DataAccess;

namespace FaysConcept.BackOffice.Stok
{
    public partial class FrmStokIslem : Form
    {
        private Entities.Tables.Stok _entity;
        private StokDAL stokDal=new StokDAL();
        private FaysConceptContext context=new FaysConceptContext();
        //bizim olusturdugumuz entity
        public bool saved = false;
        // kapat butununa basıldığında gereksiz yere güncelleme işlemi yapmamak için ; form saved metodu (cariislem kaydet butonu altında) (addorrupdate) true ise listeyi güncelle


        public FrmStokIslem(Entities.Tables.Stok entity)
        //dışarıdan parametre ile isteyeceğimiz entity
      

        {
            InitializeComponent();
            _entity = entity;
            //dışarıdan aldığımız entity bizim içeride oluşturduğumuz entity e eşitledik.

            //databindings ozelligi alan atama
            toggledurumu.DataBindings.Add("EditValue", _entity, "Durumu");
            txtstokkodu.DataBindings.Add("Text", _entity, "StokKodu");
            txtbarkod.DataBindings.Add("Text", _entity, "BarkodNo");
            cmbbarkodturu.DataBindings.Add("Text", _entity, "BarkodTuru");
            txtstokadi.DataBindings.Add("Text", _entity, "StokAdi");
            btnbirimi.DataBindings.Add("Text", _entity, "Birimi");
            txtureticikodu.DataBindings.Add("Text", _entity, "UreticiKodu");
            txtgarantisuresi.DataBindings.Add("Text", _entity, "GarantiSuresi");

            calcmaxstokmiktari.DataBindings.Add("Text", _entity, "MaxStokMiktar");
            calcmaxstokmiktari.DataBindings[0].FormattingEnabled = true;
            calcmaxstokmiktari.DataBindings[0].FormatString = "N3";

            calcminstokmiktari.DataBindings.Add("Text", _entity, "MinStokMiktar");
            //virgülden sonra 3 hane göstermesi için kullanılan yapı aşağıdadır.
            calcminstokmiktari.DataBindings[0].FormattingEnabled = true;
            calcminstokmiktari.DataBindings[0].FormatString = "N3";

            txtaciklama.DataBindings.Add("Text", _entity, "Aciklama");
            btnstokgrubu.DataBindings.Add("Text", _entity, "StokGrubu");
            btnstokaltgrubu.DataBindings.Add("Text", _entity, "StokAltGrubu");
            btnmarka.DataBindings.Add("Text", _entity, "Marka");
            btnmodel.DataBindings.Add("Text", _entity, "Model");
            btnozelkod1.DataBindings.Add("Text", _entity, "OzelKod1");
            btnozelkod2.DataBindings.Add("Text", _entity, "OzelKod2");
            btnozelkod3.DataBindings.Add("Text", _entity, "OzelKod3");
            btnozelkod4.DataBindings.Add("Text", _entity, "OzelKod4");

            calcaliskdv.DataBindings.Add("Text", _entity, "AlisKdv");
            calcaliskdv.DataBindings[0].FormattingEnabled = true;
            calcaliskdv.DataBindings[0].FormatString = "'%'0";
            calcaliskdv.DataBindings[0].DataSourceNullValue = "0";

            calcsatiskdv.DataBindings.Add("Text", _entity, "SatisKdv");
            calcsatiskdv.DataBindings[0].FormattingEnabled = true;
            calcsatiskdv.DataBindings[0].FormatString = "'%'0";
            calcsatiskdv.DataBindings[0].DataSourceNullValue = "0";


            calcalisfiyati1.DataBindings.Add("Text", _entity, "AlisFiyat1");
            calcalisfiyati1.DataBindings[0].FormattingEnabled = true;
            calcalisfiyati1.DataBindings[0].FormatString = "C2";

            calcalisfiyati2.DataBindings.Add("Text", _entity, "AlisFiyat2");
            calcalisfiyati2.DataBindings[0].FormattingEnabled = true;
            calcalisfiyati2.DataBindings[0].FormatString = "C2";

            calcalisfiyati3.DataBindings.Add("Text", _entity, "AlisFiyat3");
            calcalisfiyati3.DataBindings[0].FormattingEnabled = true;
            calcalisfiyati3.DataBindings[0].FormatString = "C2";

            calcsatisfiyati1.DataBindings.Add("Text", _entity, "SatisFiyat1");
            calcsatisfiyati1.DataBindings[0].FormattingEnabled = true;
            calcsatisfiyati1.DataBindings[0].FormatString = "C2";

            calcsatisfiyati2.DataBindings.Add("Text", _entity, "SatisFiyat2");
            calcsatisfiyati2.DataBindings[0].FormattingEnabled = true;
            calcsatisfiyati2.DataBindings[0].FormatString = "C2";

            calcsatisfiyati3.DataBindings.Add("Text", _entity, "SatisFiyat3");
            calcsatisfiyati3.DataBindings[0].FormattingEnabled = true;
            calcsatisfiyati3.DataBindings[0].FormatString = "C2";


        }

        private void FrmStokIslem_Load(object sender, EventArgs e)
        {

        }

   

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (stokDal.AddOrUpdate(context, _entity))
            {
                stokDal.Save(context);
                saved = true;
                this.Close();
            }
       
           
            
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

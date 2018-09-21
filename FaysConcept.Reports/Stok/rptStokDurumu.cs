using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using FaysConcept.Entities.Context;
using FaysConcept.Entities.DataAccess;
using DevExpress.DataAccess.ObjectBinding;

namespace FaysConcept.Reports.Stok
{
    public partial class rptStokDurumu : DevExpress.XtraReports.UI.XtraReport
    {
        public rptStokDurumu()
        {
            InitializeComponent();
            FaysConceptContext context = new FaysConceptContext();
            StokDAL stokDAL = new StokDAL();

            //linq sorguları yapmak için
            ObjectDataSource stokDataSource = new ObjectDataSource { DataSource = stokDAL.StokListele(context) };
            this.DataSource = stokDataSource;
            colStokKodu.DataBindings.Add("Text", this.DataSource, "StokKodu");
            colBarkodNo.DataBindings.Add("Text", this.DataSource, "BarkodNo");
            colStokAdi.DataBindings.Add("Text", this.DataSource, "StokAdi");
            colBirimi.DataBindings.Add("Text", this.DataSource, "Birimi");
            colStokGrubu.DataBindings.Add("Text", this.DataSource, "StokGrubu");
            colStokAltGrubu.DataBindings.Add("Text", this.DataSource, "StokAltGrubu");
            colStokGiris.DataBindings.Add("Text", this.DataSource, "StokGiris");
            colStokCikis.DataBindings.Add("Text", this.DataSource, "StokCikis");
            colMevcutStok.DataBindings.Add("Text", this.DataSource, "MevcutStok");

        }

    }
}

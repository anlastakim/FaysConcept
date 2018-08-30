using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using FaysConcept.BackOffice.Ana_Menu;
using FaysConcept.BackOffice.Cari;
using FaysConcept.BackOffice.Depo;
using FaysConcept.BackOffice.Fisler;
using FaysConcept.BackOffice.Kasalar;
using FaysConcept.BackOffice.Stok;
using FaysConcept.BackOffice.Tanım;
using FaysConcept.Entities.Context;
using FaysConcept.Entities.DataAccess;
using FaysConcept.Entities.Tables;

namespace FaysConcept.BackOffice
{
    public partial class RibbonForm1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public RibbonForm1()
        {

       
            InitializeComponent();

            using (var context = new FaysConceptContext())
            {

                try
                {
                    context.Database.CreateIfNotExists();
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.Message);
                }
                   
               
              

            }
        }

        private void ribbon_Click(object sender, EventArgs e)
        {
          

        }

        private void RibbonForm1_Load(object sender, EventArgs e)
        {

            FrmAnaMenuBilgi form = new FrmAnaMenuBilgi();
            form.MdiParent = this;
            form.Show();
            //FaysConceptContext context = new FaysConceptContext();
            //CariDAL cariDal = new CariDAL();
            //Cari entity = new Cari
            //{
            //   // CariKodu = "123456789",
            //   //// CariAdi = "Sercan Hoşgören",
            //   //// Yetkili = "Sercan",
            //   // FaturaUnvani = "HOSGOREN"
            //};
            //cariDal.AddOrUpdate(context, entity);
            //cariDal.Save(context);
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmStok form=new FrmStok();
            form.MdiParent = this;
            form.Show();

        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmCariKart form = new FrmCariKart();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmCariKart form = new FrmCariKart();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmDepoKart form = new FrmDepoKart();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmFis form = new FrmFis();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
       
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmKasa form = new FrmKasa();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem21_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }
    }
}



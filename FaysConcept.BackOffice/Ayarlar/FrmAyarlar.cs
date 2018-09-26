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
using FaysConcept.Entities.DataAccess;
using FaysConcept.Entities.Tools;

namespace FaysConcept.BackOffice.Ayarlar
{
    public partial class FrmAyarlar : DevExpress.XtraEditors.XtraForm
    {
        FaysConceptContext context = new FaysConceptContext();
        DepoDAL depoDal = new DepoDAL();
        KullaniciDAL kullaniciDAL = new KullaniciDAL();

        public FrmAyarlar()
        {
            InitializeComponent();
            lookupDepo.Properties.DataSource = depoDal.GetAll(context);
            lookupDepo.EditValue = SettingsTool.AyarOku(SettingsTool.Ayarlar.FrmFisIslem_VarsayılanDepo);
            lookUpKullanici.Properties.DataSource = kullaniciDAL.GetAll(context);
            lookUpKullanici.EditValue = SettingsTool.AyarOku(SettingsTool.Ayarlar.FrmKullaniciGiris_VarsayılanKullanici);
            toggleGuncelle.IsOn = Convert.ToBoolean(SettingsTool.AyarOku(SettingsTool.Ayarlar.GenelAyarlar_GuncellemeKontrolu));
        }

        private void FrmAyarlar_Load(object sender, EventArgs e)
        {

        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SettingsTool.AyarDegistir(SettingsTool.Ayarlar.FrmFisIslem_VarsayılanDepo, lookupDepo.EditValue.ToString());
            SettingsTool.AyarDegistir(SettingsTool.Ayarlar.FrmKullaniciGiris_VarsayılanKullanici, lookUpKullanici.EditValue.ToString());
            SettingsTool.AyarDegistir(SettingsTool.Ayarlar.GenelAyarlar_GuncellemeKontrolu, toggleGuncelle.IsOn.ToString());
            SettingsTool.Save();
        }
    }
}
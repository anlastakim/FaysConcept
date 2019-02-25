using AnlasYazilim.Software.UI.Win.Forms.BaseForms;
using System;
using System.Windows.Forms;

namespace FaysConcept.WMS.UI.Win
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BaseKartlarForm());
        }
    }
}

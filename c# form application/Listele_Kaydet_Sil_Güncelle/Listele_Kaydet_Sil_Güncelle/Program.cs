using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Listele_Kaydet_Sil_Güncelle
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
            Application.Run(new Form1());
        }
    }
}

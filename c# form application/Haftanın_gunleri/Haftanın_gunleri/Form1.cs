using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Haftanın_gunleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buton_Click(object sender, EventArgs e)
        {
            string[] gunler = new string[7];
            gunler[0] = "pazartesi";
            gunler[1] = "salı";
            gunler[2] = "çarşamba";
            gunler[3] = "perşembe";
            gunler[4] = "cuma";
            gunler[5] = "cumartesi";
            gunler[6] = "pazar";

           
            
            int a = gunler_list.Items.Count;
            if (a == 0)
            {

                for (int i = 0; i < gunler.Length; i++)
                {
                    gunler_list.Items.Add(gunler[i]);
                }
            }
            else {
                MessageBox.Show("Günler gösterildi");
            
            }
            //veya foreach kullanılabilir
            //foreach (string i in gunler)  {    gunler_list.Items.Add(gunler[i]); }
            
        }

      
        
    }
}

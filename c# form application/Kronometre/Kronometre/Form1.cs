using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kronometre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int KalanSure;   //değişken tanımla

        private void btnBasla_Click(object sender, EventArgs e)
        {
            //baslangıç zamanı kalansure değişkenine atandı
            KalanSure = Convert.ToInt32(txtSure.Text);
            //Kalan süreyi kullanıcıya gösterdik
            lblSure.Text = Convert.ToString(KalanSure);

            //listbox  kontrolüne kayıt girilir
            lblKayit.Items.Add("Kronometra başlangıç: " + DateTime.Now.TimeOfDay.ToString());

            // ComboBox kontrolünden seçilen değer,
            // Timer kontrolünün çalışma hızını belirler. (Interval=Aralık)
            tmrKronometre.Interval = Convert.ToInt32(cmbInterval.Text);
            tmrKronometre.Start();

        }

        private void btnDur_Click(object sender, EventArgs e)
        {
            //timer kontrolünü durdur
            tmrKronometre.Stop();
            //listbox kayıt girilir
            lblKayit.Items.Add("Kronemetre durduruldu: " + DateTime.Now.TimeOfDay.ToString());
        }

        private void tmrKronometre_Tick(object sender, EventArgs e)
        {
            //Timer
            //Bir Windows sayacını temsil eder. Sayaç çalışmaya başladığı zaman, 
            //    belirli zaman aralıklarında Tick olayı gerçekleşir. Timer kontrolünün Interval değeri,
            //        Tick olayının kaç milisaniyede bir gerçekleşeceğini belirler. 
            //            Örneğin Interval değeri 2000 olan bir sayaç, Tick olayında
            //yazılan kodları iki saniyede bir çalıştıracaktır.


            // Her saniye geçtiğinde sure değeri 1 azalacaktır.
            KalanSure = KalanSure - 1;
            // KalanSure değeri kullancıya gösterilir
            lblSure.Text = KalanSure.ToString();

            // KalanSure değeri sıfıra ulaşmışsa kronometre durdurulur.
            if (KalanSure == 0)
            {
                tmrKronometre.Stop();
                lblKayit.Items.Add("süre doldu: " + DateTime.Now.TimeOfDay.ToString());

                MessageBox.Show("Süre Doldu ");
            }

        }

      
    }
}

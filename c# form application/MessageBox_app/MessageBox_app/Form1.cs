using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MessageBox_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Mesaj_Click(object sender, EventArgs e)
        {
            //• Text (Yazı): Mesaj kutusunda verilmek istenen bilgiyi tutan yazıdır
            //• Caption (Başlık): Mesaj kutusunun başlığıdır
            //• Buttons (Düğmeler): Mesaj kutusunda hangi düğmelerin gösterileceğini belirler.
            //• Icon (Simge): Mesaj kutusunda gösterilecek olan simgeyi ve açıldığı zaman çıkartılacak sesi belirler.

            MessageBox.Show("devam etmek istiyor musunuz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //Mesaj kutusu, kapanırken hangi düğmenin basıldığını DialogResult nesnesi ile programcıya bildirir.


            if (MessageBox.Show("Değişiklikler kaydedilsin mi?", "Kayıt", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("DialogResult.Yes yani evete bastınız");
            }
        }
    }
}

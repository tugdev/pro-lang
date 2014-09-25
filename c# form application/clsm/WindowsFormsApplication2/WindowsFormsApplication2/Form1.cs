using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("hello world! tarih " + DateTime.Today);
            MessageBox.Show("hello world! tarih " + DateTime.Now);
            // MessageBox.Show metodu ile kullanıcıya Merhaba diyoruz.
            // Now özelliği ile o andaki saat ve gün
            // değerlerini de kullanıcıya gösteriyoruz.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            // İşlem yapıldıktan sonra
            // TextBox kontrolüne odaklan
           // textBox1.Focus();

        }

        private void button3_Click(object sender, EventArgs e)
       {
         // BackColor (Arka plan rengi)
         // ForeColor (Önalan rengi)

            button3.BackColor = Color.DarkBlue;
            button3.ForeColor = Color.Purple;

            //birde labela özellik atalım
            button3.Height = 50;
            button3.Width = 50;

            // Label kontrolünü gizle
          //  label1.Visible = false;
            // Label kontrolünü göster
           // label1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = "yazılımcı tugdev";
            // İşlem yapıldıktan sonra
            // TextBox kontrolüne odaklan
            
            textBox2.Focus();
            textBox2.Select(8, 5);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox3.Text = "elma armut";
            //textBox3.Focus();
            textBox3.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //çalışma alanında comboboxa item ekleme
            //diğer itemler tasarım anında properties panelinden items öz. ile eklendi 
            comboBox1.Items.Add("deneme");
            comboBox1.Items.Add("deneme2");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("secilen1");
            listBox1.Items.Add("secilen2");

              
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("sayaç çalışıyor");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            timer1.Interval = 5000;
            timer1.Start();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

     
       
    }
}

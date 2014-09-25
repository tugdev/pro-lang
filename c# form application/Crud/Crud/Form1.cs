using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//EKLE_Access veritabanı bağlantısı icin
//using System.Data.OleDb;

namespace Crud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string ad, soyad, sinif;
        int numara;
        private void button1_Click(object sender, EventArgs e)
        {
            numara = Convert.ToInt32(textBox1.Text);
            ad = textBox2.Text;
            soyad = textBox3.Text;
            sinif = textBox4.Text;

            MessageBox.Show("ismi " + ad + " ,soyismi" + soyad + " , sınıfı " + sinif + " olan " + numara + " numaralı öğrenci");
            
        }

        
    }
}

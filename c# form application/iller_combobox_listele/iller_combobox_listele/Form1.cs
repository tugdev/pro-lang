using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient; //Kullanacağımız isim alanının tanımını yapıyoruz.

namespace iller_combobox_listele
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=CASPERIM; Initial Catalog=iller; Integrated Security=true");
        //iller veritabanı il tablosu
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from il", baglanti);
            SqlDataReader oku;
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                comboBox1.Items.Add(oku["ilAdi"].ToString());
            }
            oku.Close();
            baglanti.Close();
        }
        //SqlDataReader: Görevleri veri kaynağından, uygulama ortamına doğru belli 
        //    bir akım üzerinden hareket edecek veri parçalarının taşınmasını sağlamaktır.

      
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace toplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void listele()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=CASPERIM; Initial Catalog=islemler; Integrated Security=true");
            SqlCommand sorgu = new SqlCommand("select * from toplama", baglanti);
            SqlDataAdapter adaptor = new SqlDataAdapter(sorgu);
            DataSet veriSeti = new DataSet();

            adaptor.Fill(veriSeti);
            dataGridView1.DataSource = veriSeti.Tables[0];
        
        
        
        
        }


        private void btntopla_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, toplam;
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            toplam = sayi1 + sayi2;
            textBox3.Text = Convert.ToString(toplam);

         
            

            SqlConnection baglanti =new SqlConnection("Data Source=CASPERIM; Initial Catalog=islemler; Integrated Security=true");
            string komut = "insert into toplama values ('" + sayi1 + "','" + sayi2 + "','"+ toplam +"')";
            SqlCommand sorgu = new SqlCommand(komut, baglanti);

            try
            {
                baglanti.Open();
                sorgu.ExecuteNonQuery();
                MessageBox.Show("Kayıt Eklendi");
                baglanti.Close();
            }
            catch
            {
                MessageBox.Show("Ekleme işlemi Yapılamadı");
            }
            listele();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }


            
            
        }
    }


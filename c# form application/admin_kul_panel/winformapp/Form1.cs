using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace winformapp
{
    public partial class Form1 : Form
    {

        public Admin adm;
        public KullaniciKayit klkyt;
        public Kullanici kullnci;
        public AdminKayit admkyt;
        

        public Form1()
        {
            InitializeComponent();
            
            adm = new Admin();
            kullnci = new Kullanici();
            klkyt = new KullaniciKayit();
            admkyt = new AdminKayit();
            
            admkyt.frm1 = this;
            
            adm.frm1 = this;
            kullnci.frm1 = this;
            klkyt.frm1 = this;
            
         
        }


        SqlConnection bag = new SqlConnection(@"Data Source=.;Initial Catalog=adminpanel;Integrated Security=True");

      

        private void btnyenikullanici_Click(object sender, EventArgs e)
        {
            klkyt.ShowDialog();
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            if (rdadmin.Checked)
            {
                string ad;
                string sifre;
                bag.Open();
                SqlCommand admin1 = new SqlCommand("Select admusername from login where admusername='" + txtad.Text + "'", bag);
                SqlCommand sfr = new SqlCommand("Select admpassword from login where admpassword='" + txtparola.Text + "'", bag);

                try
                {
                    ad = admin1.ExecuteScalar().ToString();
                    sifre = sfr.ExecuteScalar().ToString();
                    if (ad == txtad.Text && sifre == txtparola.Text)
                    {
                        adm.ShowDialog();
                        txtad.Clear();
                        txtparola.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Adı veya Parola Hatalı");
                        txtad.Clear();
                        txtparola.Clear();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Böyle Bir Adminlik Yoktur");
                }
                bag.Close();
            }

            else if (rdkullanici.Checked)
            {
                string kuladi;
                string sifre;
                bag.Open();
                SqlCommand kulad1 = new SqlCommand("Select KulAdi from KullaniciBilgi where KulAdi='" + txtad.Text + "'", bag);
                SqlCommand kulsifre = new SqlCommand("Select KulSifre from KullaniciBilgi where KulSifre='" + txtparola.Text + "'", bag);

                try
                {
                    kuladi = kulad1.ExecuteScalar().ToString();
                    sifre = kulsifre.ExecuteScalar().ToString();
                    if (kuladi == txtad.Text && sifre == txtparola.Text)
                    {
                        kullnci.ShowDialog();
                        txtad.Clear();
                        txtparola.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Adı Veya Şifre Hatalı");
                        txtad.Clear();
                        txtparola.Clear();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Böyle Bir Kullanıcı Yoktur");
                }
                bag.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtad.Clear();
            txtparola.Clear();
        }

        private void btnkpt_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("Programı Kapatmak İstedğinizden Eminmisiniz", "Kapatma Uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        
    }
}

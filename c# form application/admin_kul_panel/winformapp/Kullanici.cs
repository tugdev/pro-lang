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
    public partial class Kullanici : Form
    {

        public Form1 frm1;
        public Kullanici()
        {
            InitializeComponent();
        }

        SqlConnection bag = new SqlConnection(@"Data Source=.;Initial Catalog=adminpanel;Integrated Security=True");


        private void listeleKul()
        {
            SqlCommand komutlistele = new SqlCommand("select * from KullaniciBilgi where KulAdi='kul'", bag);
            SqlDataAdapter adaptor = new SqlDataAdapter(komutlistele);
            DataSet ds = new DataSet();
            adaptor.Fill(ds);
            dataGVbilgi.DataSource = ds.Tables[0];



            dataGVbilgi.Columns["KulNo"].HeaderText = "Kullanıcı Numarası";
            dataGVbilgi.Columns["KulAdi"].HeaderText = "Kullanıcı Adı";
            dataGVbilgi.Columns["KulSoyadi"].HeaderText = "Kullanıcı Soyadı";
            dataGVbilgi.Columns["KulMail"].HeaderText = "Kullanıcı e-Mail";
            dataGVbilgi.Columns["KulSifre"].HeaderText = "Kul Sifre";
            //dataGVbilgi.Columns["KulSifre"].Visible = false;
            dataGVbilgi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


        }
        
        private void Kullanici_Load_1(object sender, EventArgs e)
        {
            listeleKul();
           
        }

        private void btnsifrdegstr_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void btnkydt_Click(object sender, EventArgs e)
        {
            bag.Open();
            SqlCommand sfr = new SqlCommand("update KullaniciBilgi set KulSifre='" + txtSifre.Text + "' where KulAdi = '" + txtkulad.Text + "'and KulSifre='" + txteskisfr.Text + "' ", bag);
            sfr.ExecuteNonQuery();
            bag.Close();
            listeleKul();
            MessageBox.Show("Şifre Başarılı Bir Şekilde Değiştirildi");
        }

     
        private void btniptl_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void btncks_Click(object sender, EventArgs e)
        {
            this.Close();
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

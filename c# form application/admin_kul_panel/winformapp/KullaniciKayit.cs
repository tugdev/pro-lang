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
    
    public partial class KullaniciKayit : Form
    {
        public Form1 frm1;
        public KullaniciKayit()
        {
            InitializeComponent();
        }

        SqlConnection bag = new SqlConnection(@"Data Source=.;Initial Catalog=adminpanel;Integrated Security=True");

    

        private void btniptl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnkydt_Click(object sender, EventArgs e)
        {
            if (txtklad.Text != "" && txtsyad.Text != "" && txteml.Text != "" && txtprla.Text != "")
            {
                bag.Open();
                SqlCommand kmt = new SqlCommand("insert into KullaniciBilgi values('" + txtklad.Text + "','" + txtsyad.Text + "','" + txteml.Text + "','" + txtprla.Text + "') ", bag);
                kmt.ExecuteNonQuery();
                kmt.Dispose();
                bag.Close();
                txtklad.Clear(); txtsyad.Clear(); txteml.Clear(); txtprla.Clear();

                MessageBox.Show("Kayıt işlemi tamamlandı !");
                this.Close();
            }
            else
            {
                MessageBox.Show("Boş alanları doldurunuz !!!");
            }
        }

        

       

    }
}

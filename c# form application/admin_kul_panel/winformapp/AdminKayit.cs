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
    public partial class AdminKayit : Form
    {
        public Form1 frm1;
        public AdminKayit()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection(@"Data Source=.;Initial Catalog=adminpanel;Integrated Security=True");

        private void btniptladm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnkaydetadm_Click(object sender, EventArgs e)
        {
            if (txtadmad.Text != "" && txtadmparola.Text != "")
            {
                bag.Open();
                SqlCommand kmt = new SqlCommand("insert into login values('" + txtadmad.Text + "','" + txtadmparola.Text + "') ", bag);
                kmt.ExecuteNonQuery();
                kmt.Dispose();
                bag.Close();
                txtadmad.Clear(); txtadmparola.Clear();
                frm1.adm.listeleAdm();
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

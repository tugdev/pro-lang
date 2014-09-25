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
    public partial class Admin : Form
    {
        public Form1 frm1;
        public Admin()
        {
            InitializeComponent();
        }

        SqlConnection bag = new SqlConnection(@"Data Source=.;Initial Catalog=adminpanel;Integrated Security=True");
        




        private void listeleKul()
        {
            SqlCommand komutlistele = new SqlCommand("select * from KullaniciBilgi order by KulNo", bag);
           
            SqlDataAdapter adaptor = new SqlDataAdapter(komutlistele);
            DataSet ds = new DataSet();
            adaptor.Fill(ds);
            dataGVKullanici.DataSource = ds.Tables[0];

            

            dataGVKullanici.Columns["KulNo"].HeaderText = "Kullanıcı Numarası";
            dataGVKullanici.Columns["KulAdi"].HeaderText = "Kullanıcı Adı";
            dataGVKullanici.Columns["KulSoyadi"].HeaderText = "Kullanıcı Soyadı";
            dataGVKullanici.Columns["KulMail"].HeaderText = "Kullanıcı e-Mail";
            dataGVKullanici.Columns["KulSifre"].Visible = false;
            dataGVKullanici.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


        }
        public void listeleAdm()
        {

            SqlCommand komutlistele = new SqlCommand("select * from login order by admid", bag);
            SqlDataAdapter adaptor = new SqlDataAdapter(komutlistele);
            DataSet ds = new DataSet();
            adaptor.Fill(ds);
            dataGVAdmin.DataSource = ds.Tables[0];



            dataGVAdmin.Columns["admid"].HeaderText = "Admin Numarası";
            dataGVAdmin.Columns["admusername"].HeaderText = "Admin Adı";
            dataGVAdmin.Columns["admpassword"].Visible = false;
            dataGVAdmin.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }
        private void Admin_Load(object sender, EventArgs e)
        {
            lblbilgi.Text = "Hoş Geldiniz ";
            listeleKul();
            listeleAdm();

            
        }

        private void btnkulsil_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("Kaydı Silmek istediğinizden Eminmisiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                bag.Open();
                SqlCommand kmt = new SqlCommand("Delete from KullaniciBilgi where KulNo='" + dataGVKullanici.CurrentRow.Cells[0].Value.ToString() + "'", bag);
                kmt.ExecuteNonQuery();
                bag.Close();
                listeleKul();
                MessageBox.Show("Silme işlemi gerçekleştirilmiştir");
            }
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("Programı Kapatmak İstedğinizden Eminmisiniz", "Kapatma Uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btngeridon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnadmekle_Click(object sender, EventArgs e)
        {
            frm1.admkyt.ShowDialog();
        }

       
    }
}

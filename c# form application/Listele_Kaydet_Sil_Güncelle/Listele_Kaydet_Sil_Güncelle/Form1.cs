using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Listele_Kaydet_Sil_Güncelle
{
    public partial class Form1 : Form
    {

        SqlConnection baglanti = new SqlConnection("Data Source=CASPERIM; Initial Catalog=personel; Integrated Security=true");
        //personel veritabanı kullanici tablosu
        public Form1()
        {
            InitializeComponent();
        }


        private void listele()
        {
            SqlCommand komutlistele = new SqlCommand("select * from kullanici order by kullaniciID", baglanti);
            SqlDataAdapter adaptor = new SqlDataAdapter(komutlistele);
            DataSet ds = new DataSet();
            adaptor.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            dataGridView1.Columns["kullaniciID"].Visible = false;
            dataGridView1.Columns["kullaniciAdi"].HeaderText = "Kullanıcı Adı";
            dataGridView1.Columns["parola"].HeaderText = "Parola";
            dataGridView1.Columns["adi"].HeaderText = "Adı";
            dataGridView1.Columns["soyadi"].HeaderText = "Soyadı";
            dataGridView1.Columns["dogumTarihi"].HeaderText = "Doğum Tarihi";



        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void name_kaydet_Click(object sender, EventArgs e)
        {
            
            
            
            SqlCommand komutkaydet = new SqlCommand("insert into kullanici values(@kullaniciAdi,@parola,@adi,@soyadi,@dogumTarihi)", baglanti);
             komutkaydet.Parameters.AddWithValue("@kullaniciAdi", textBox1.Text);
             komutkaydet.Parameters.AddWithValue("@parola", textBox2.Text);
             komutkaydet.Parameters.AddWithValue("@adi", textBox3.Text);
             komutkaydet.Parameters.AddWithValue("@soyadi", textBox4.Text);
             komutkaydet.Parameters.AddWithValue("@dogumTarihi", dateTimePicker1.Value);

             baglanti.Open();
             komutkaydet.ExecuteNonQuery();
             listele();
             baglanti.Close();
        }

        private void name_sil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("delete from kullanici where kullaniciID=@kullaniciID", baglanti);
            komutsil.Parameters.AddWithValue("@kullaniciID", dataGridView1.CurrentRow.Cells[0].Value);
            //DataGridView nesnesi üzerinde seçilen satırın, sıfırıncı indekse 
            //sahip alanının (kullaniciID alanı) değeri. Yani burada kullaniciID alanına göre silme işlemini gerçekleştiriyoruz.

            baglanti.Open();
            komutsil.ExecuteNonQuery();
            listele();
            baglanti.Close();
        
        
        
        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //burdaki amaç bilgiler form üzerinde gözüksün diye
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["kullaniciAdi"].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["parola"].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["adi"].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells["soyadi"].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells["dogumTarihi"].Value.ToString();
        }

        private void name_guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutGuncelle = new SqlCommand("UPDATE tablo_adi SET kullaniciAdi=@kullaniciAdi, parola=@parola, adi=@adi, soyadi=@soyadi, dogumTarihi=@dogumTarihi WHERE kullaniciID=@kullaniciID", baglanti);

            komutGuncelle.Parameters.AddWithValue("@kullaniciAdi", textBox1.Text);
            komutGuncelle.Parameters.AddWithValue("@parola", textBox2.Text);
            komutGuncelle.Parameters.AddWithValue("@adi", textBox3.Text);
            komutGuncelle.Parameters.AddWithValue("@soyadi", textBox4.Text);
            komutGuncelle.Parameters.AddWithValue("@dogumTarihi", dateTimePicker1.Value);
            komutGuncelle.Parameters.AddWithValue("@kullaniciID", dataGridView1.CurrentRow.Cells[0].Value); //DataGridView nesnesi üzerinde seçilen satırın, sıfırıncı indekse sahip alanının (kullaniciID alanı) değeri. Yani burada kullaniciID alanına göre güncelleme işlemini gerçekleştiriyoruz.

            baglanti.Open();
            komutGuncelle.ExecuteNonQuery();
            listele();
            baglanti.Close();

        }


       
    }
}

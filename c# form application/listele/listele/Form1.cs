using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace listele
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     

        private void Form1_Load(object sender, EventArgs e)
        {
            //bağlantı nesnesi 
            SqlConnection baglanti = new SqlConnection("Data Source=CASPERIM; Initial Catalog=ogrencitakip; Integrated Security=true");

            // komut nesnesi oluşturmamız ve SQL sorgumuzu komut nesnesi içerisinde belirtmemiz gerekiyor
            string komut = "select * from kayit";
            SqlCommand sorgu = new SqlCommand(komut, baglanti);

            //Şimdi de veri tabanı bağlantısı ile DataSet arasında köprü görevi gören adaptör nesnesini tanımlayacağız.
            //Tanımladığımız adaptör nesnesi içerisinde komutumuzu belirtiyoruz.
            SqlDataAdapter adaptor = new SqlDataAdapter(sorgu);

            // Adaptör tanımından sonra DataSet nesnesi tanımlıyoruz. SqlDataAdapter sayesinde veri tabanındaki veriler alınır.
            //SqlDataAdapter’ın Fill metodu ile DataSet’in içerisine aktarılır ve bağlantı kesilir. Böylece bağlantı boş yere açık
            //kalarak uygulamamızı yavaşlatmaz.

            //Bununla birlikte DataSet nesnesi, içerisinde birden fazla DataTable nesnesi barındırır. Bu da veri tabanındaki birden 
            //fazla tabloyu DataSet
            //içerisinde barındırabileceğimiz anlamına gelir.

            DataSet veriSeti = new DataSet();

            adaptor.Fill(veriSeti);
            //Son olarak DataSet içerisine aldığımız verileri DataGridView nesnesinin içerisine atıyoruz:

            dataGridView1.DataSource = veriSeti.Tables[0];
            //DataSet içerisinde birden fazla tablonun olabileceğinden bahsetmiştik.
            //Bu tablolar sıfırdan itibaren indekslenir. Bu yüzden DataSet’in Tables özelliğini kullanıyoruz.
            //    Bu özelliğin içerisinde de tablomuzun indeks numarasını belirtiyoruz. Biz sadece tek bir
            //tablo kullandık. Dolayısıyla sıfır indeksine sahip olan tabloyu DataGridView içerisine attık.

//            DataGridView nesnesinde bazı bilgilerin listelenmesini istemeyebiliriz. Örneğin “ID” türündeki alanların
            //görüntülenmesi hem güvenlik hem de görüntü açısından pek uygun değildir. Görüntülenmesini istemediğimiz
            //alanlar için Visible özelliğini kullanabiliriz:

            //Örneğin tablomuzda sıfırıncı indekste yer alan “ID” alanının DataGridView nesnesi üzerinde görüntülenmesini istemiyorsak:

            //dataGridView1.Columns[0].Visible = false;

            //İndeks belirtmek yerine alan adını da belirtebiliriz:

            //dataGridView1.Columns["ID"].Visible = false;

         //gözüken sutunları düzeltmekiçin kullanılır   
          //  dataGridView1.Columns["id"].Visible = false;
           
            //dataGridView1.Columns["ad"].HeaderText = "ad";
            //dataGridView1.Columns["ad"].Width = 140;
            //dataGridView1.Columns["soyad"].HeaderText = "soyad";
            //dataGridView1.Columns["soyad"].Width = 140;


        }
        
        
    }
}

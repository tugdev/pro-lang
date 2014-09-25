using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Array_metotlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void N_Length_Click(object sender, EventArgs e)
        {
            ComboBox[] c_dizi = new ComboBox[20];

            int[] sayi_dizisi = { 4, 5, 6, 8 };
            MessageBox.Show("c_dizi uzunluğu: " + c_dizi.Length.ToString() + "\ndizi uzunluğu: " + sayi_dizisi.Length.ToString());

        }

        private void N_Rank_Click(object sender, EventArgs e)
        {
            //Dizinin boyut sayısını veren özelliktir.
            int[] sayi_dizisi1 = { 4, 5, 6, 8 };
            int[,] sayi_dizisi2 ={ { 4, 5, 6, 8 },{5,8,9,6}};
            MessageBox.Show("sayi_dizisi1 Rankı: " + sayi_dizisi1.Rank.ToString() + "\nsayi_dizisi2 Rankı: " + sayi_dizisi2.Rank.ToString());
        }

        private void N_GetLength_Click(object sender, EventArgs e)
        {
            //İndisi verilen boyutun kaç elemanlı olduğunu gösterir. 
            //Burada indisin sıfırdan başladığına dikkat edilmelidir.
            int [,,,,] dizi = new int[10, 40, 50, 80, 90];
            MessageBox.Show(dizi.GetLength(4).ToString());
        }

        //Clear, Reverse, IndexOf metotları Array sınıfında Shared (paylaştırılmış) olarak tanımlı metotlardır.
        // İşlemin yapılacağı dizi parametre olarak verilmelidir

        private void N_Clear_Click(object sender, EventArgs e)
        {
            //Parametre olarak verilen dizinin, belirtilen indis aralığındaki tüm değerleri temizler.
            //Temizleme işleminde atanan değer, dizi elemanlarının tiplerine göre değişir.
            int[] dizi = { 12, 13, 14, 15 };
            Array.Clear(dizi, 1, 2);
            MessageBox.Show(dizi[2].ToString());
            // Dizinin tüm elemanlarını temizler
            //Array.Clear(dizi, 0, dizi.Length);
        }

        private void N_Reverse_Click(object sender, EventArgs e)
        {
            //Parametre olarak verilen dizinin eleman sırasını tersine çevirir.
            //Dizinin tüm elemanlarının veya belirli indis aralığındaki elemanlarının sırası tersine çevrilebilir.
            string[] harfler = {"a","b","c" };
            Array.Reverse(harfler);

            string[] harfler2 = { "A", "B", "C" };
            Array.Reverse(harfler2, 0, 1);  //indis aralıgını cevir

            MessageBox.Show("dizinin tamamını ters çevir ve 2. indisini söyle: "+ harfler[2] + " \ndizinin 0,1 indis aralığını ters çevir ve 2. indisini söyle: "+ harfler2[2]);



        }

        private void N_IndexOf_Click(object sender, EventArgs e)
        {
            //İlk parametrede verilen dizide, ikinci parametrede verilen değeri arar. 
            //Aranan değer dizide bulunursa indisi, bulunamazsa -1 döndürür.
            double[] notlar = { 78.1, 99.9, 100, 12.2 };
            float maxNot = 100;
            MessageBox.Show(Array.IndexOf(notlar, maxNot).ToString());
        
        }

        private void N_LastIndexOf_Click(object sender, EventArgs e)
        {
            //Aramayı sondan baslatarak aranan elemanın bastan kaçıncı sırada
            //olduğunu değer olarak döndürür.
            double[] notlar = { 78.1, 100, 99.9, 100, 12.2 };
            float maxNot = 100;
            MessageBox.Show(Array.LastIndexOf(notlar, maxNot).ToString());

        }

        private void N_Sort_Click(object sender, EventArgs e)
        {
            //Dizinin elemanlarını  küçükten büyüğe doğru sıralar.
            int [] sirala={1,8,75,42,14,3,25};
            Array.Sort(sirala);
            
            foreach (int i in sirala)
            {
                N_Sirala.Text +=" " + i.ToString() + "-";
            }

        }



          


    }
}

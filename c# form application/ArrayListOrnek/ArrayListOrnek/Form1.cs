using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;//Arraylist için 

namespace ArrayListOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArrayList liste = new ArrayList();
            liste.Add(12);
            liste.Add("deneme");
            liste.Add(true);
            liste.Add(12.5);
            liste.Add('A');

            foreach (object i in liste)
            {
                listBox1.Items.Add(i.ToString());  //listbox a eleman ekledik
            }

        }

        private void Ekle_Click(object sender, EventArgs e)
        {
           
            listBox1.Items.Add(textBox_Add.Text);

        }

        private void Sil_Click(object sender, EventArgs e)
        {
            Boolean silindimi = false;
            string silinecek = textBox_sil.Text;

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (silinecek == listBox1.Items[i].ToString())
                {
                    listBox1.Items.Remove(silinecek);
                    silindimi = true;
                }
            }

            if (!silindimi)
                MessageBox.Show(silinecek + " listemizde mevcut değil");



        }

        private void Sec_sil_Click(object sender, EventArgs e)
        {
           
            listBox1.Items.Remove(listBox1.SelectedItem);
            
        }

      

        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UrunYelpazesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            lblMesaj.Text = "";
            lbUrunler.Items.Clear();

            if (cmbStokDurumu.SelectedIndex == -1 && cmbTarihSirasi.SelectedIndex == -1)
            {
                lblMesaj.Text = "Stok Durumu ve Tarih Sırası seçiniz.";
            }
            else if (cmbStokDurumu.SelectedIndex == -1)
            {
                lblMesaj.Text = "Stok Durumunu seçiniz.";
            }
            else if (cmbTarihSirasi.SelectedIndex == -1)
            {
                lblMesaj.Text = "Tarih Sırasını seçiniz.";
            }
            else if (lbKategoriler.SelectedIndex == -1)
            {
                lblMesaj.Text = "Kategori seçiniz.";
            }
            else
            {
                switch (lbKategoriler.SelectedIndex)
                {
                    case 0:
                        // Sadece stokta bulunan ürünler eklenir.
                        lbUrunler.Items.Add("MSDN Tv Visual C# 5");
                        lbUrunler.Items.Add("MSDN Tv Visual C# 4");

                        if (cmbStokDurumu.SelectedIndex == 1)
                        {
                            lbUrunler.Items.Add("MSDN Tv Visual C#");
                            lbUrunler.Items.Add("MSDN Tv Visual C# 2");
                            lbUrunler.Items.Add("MSDN Tv Visual C# 3");
                        }
                        if (cmbTarihSirasi.SelectedIndex == 0)
                        {
                            lbUrunler.Items.Remove("MSDN Tv Visual C#");
                            lbUrunler.Items.Remove("MSDN Tv Visual C# 2");
                        }
                        break;
                    case 1:
                        lbUrunler.Items.Add("Yazılım Uzmanlığı 1");
                        lbUrunler.Items.Add("Yazılım Uzmanlığı 2");
                        lbUrunler.Items.Add("Yazılım Mühendisliği Orta Dzey");
                        lbUrunler.Items.Add("Yazılım Mühendisliği İleri Dzey");
                        if (cmbStokDurumu.SelectedIndex == 1)
                        {
                            lbUrunler.Items.Add("Yazılım Mühendisliği Başlangıç Düzeyi");
                            lbUrunler.Items.Add("Access Giriş");
                        }
                        if (cmbTarihSirasi.SelectedIndex == 0)
                        {
                            lbUrunler.Items.Remove("Yazılım Uzmanlığı 1");
                        }
                        break;
                    case 2:
                        lbUrunler.Items.Add("Visual Studio 6.0");
                        lbUrunler.Items.Add("Visual C# .NET Standard 2003");
                        lbUrunler.Items.Add("Visual C# C# Standard 2003");
                        if (cmbStokDurumu.SelectedIndex == 1)
                        {
                            lbUrunler.Items.Add("Visual Studio .NET 2005");
                        }
                        if (cmbTarihSirasi.SelectedIndex == 0)
                        {
                            lbUrunler.Items.Remove("Visual Studio 6.0");
                        }
                        break;
                }

                lblSecilenUrunler.Text = lbKategoriler.Text + " kategorisindeki ürünler";
            }
                       




        }
    }
}

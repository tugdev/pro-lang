namespace UrunYelpazesi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbUrunler = new System.Windows.Forms.ListBox();
            this.lbKategoriler = new System.Windows.Forms.ListBox();
            this.cmbTarihSirasi = new System.Windows.Forms.ComboBox();
            this.cmbStokDurumu = new System.Windows.Forms.ComboBox();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.lblSecilenUrunler = new System.Windows.Forms.Label();
            this.btnListele = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbUrunler
            // 
            this.lbUrunler.FormattingEnabled = true;
            this.lbUrunler.Location = new System.Drawing.Point(390, 61);
            this.lbUrunler.Name = "lbUrunler";
            this.lbUrunler.Size = new System.Drawing.Size(138, 147);
            this.lbUrunler.TabIndex = 0;
            // 
            // lbKategoriler
            // 
            this.lbKategoriler.FormattingEnabled = true;
            this.lbKategoriler.Items.AddRange(new object[] {
            " Video",
            " Kitap",
            " Yazılım"});
            this.lbKategoriler.Location = new System.Drawing.Point(50, 61);
            this.lbKategoriler.Name = "lbKategoriler";
            this.lbKategoriler.Size = new System.Drawing.Size(138, 147);
            this.lbKategoriler.TabIndex = 1;
            // 
            // cmbTarihSirasi
            // 
            this.cmbTarihSirasi.FormattingEnabled = true;
            this.cmbTarihSirasi.Items.AddRange(new object[] {
            "Son Çıkanlar",
            "Tüm Ürünler"});
            this.cmbTarihSirasi.Location = new System.Drawing.Point(22, 245);
            this.cmbTarihSirasi.Name = "cmbTarihSirasi";
            this.cmbTarihSirasi.Size = new System.Drawing.Size(193, 21);
            this.cmbTarihSirasi.TabIndex = 2;
            // 
            // cmbStokDurumu
            // 
            this.cmbStokDurumu.FormattingEnabled = true;
            this.cmbStokDurumu.Items.AddRange(new object[] {
            "Sadece Stoktakiler",
            "Hepsi"});
            this.cmbStokDurumu.Location = new System.Drawing.Point(366, 245);
            this.cmbStokDurumu.Name = "cmbStokDurumu";
            this.cmbStokDurumu.Size = new System.Drawing.Size(193, 21);
            this.cmbStokDurumu.TabIndex = 3;
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMesaj.Location = new System.Drawing.Point(0, 390);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(45, 13);
            this.lblMesaj.TabIndex = 4;
            this.lblMesaj.Text = "lblMesaj";
            // 
            // lblSecilenUrunler
            // 
            this.lblSecilenUrunler.AutoSize = true;
            this.lblSecilenUrunler.Location = new System.Drawing.Point(387, 9);
            this.lblSecilenUrunler.Name = "lblSecilenUrunler";
            this.lblSecilenUrunler.Size = new System.Drawing.Size(86, 13);
            this.lblSecilenUrunler.TabIndex = 5;
            this.lblSecilenUrunler.Text = "lblSecilenUrunler";
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(197, 315);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(193, 32);
            this.btnListele.TabIndex = 6;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 403);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.lblSecilenUrunler);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.cmbStokDurumu);
            this.Controls.Add(this.cmbTarihSirasi);
            this.Controls.Add(this.lbKategoriler);
            this.Controls.Add(this.lbUrunler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbUrunler;
        private System.Windows.Forms.ListBox lbKategoriler;
        private System.Windows.Forms.ComboBox cmbTarihSirasi;
        private System.Windows.Forms.ComboBox cmbStokDurumu;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Label lblSecilenUrunler;
        private System.Windows.Forms.Button btnListele;
    }
}


namespace winformapp
{
    partial class Admin
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGVKullanici = new System.Windows.Forms.DataGridView();
            this.dataGVAdmin = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnadmekle = new System.Windows.Forms.Button();
            this.btnkulsil = new System.Windows.Forms.Button();
            this.btngeridon = new System.Windows.Forms.Button();
            this.btnkapat = new System.Windows.Forms.Button();
            this.lblbilgi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVKullanici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(440, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcılar Listesi";
            // 
            // dataGVKullanici
            // 
            this.dataGVKullanici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVKullanici.Location = new System.Drawing.Point(277, 57);
            this.dataGVKullanici.Name = "dataGVKullanici";
            this.dataGVKullanici.Size = new System.Drawing.Size(429, 372);
            this.dataGVKullanici.TabIndex = 1;
            // 
            // dataGVAdmin
            // 
            this.dataGVAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVAdmin.Location = new System.Drawing.Point(17, 57);
            this.dataGVAdmin.Name = "dataGVAdmin";
            this.dataGVAdmin.Size = new System.Drawing.Size(241, 148);
            this.dataGVAdmin.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Admin Listesi";
            // 
            // btnadmekle
            // 
            this.btnadmekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnadmekle.Location = new System.Drawing.Point(38, 230);
            this.btnadmekle.Name = "btnadmekle";
            this.btnadmekle.Size = new System.Drawing.Size(189, 51);
            this.btnadmekle.TabIndex = 4;
            this.btnadmekle.Text = "Yeni Admin Ekle";
            this.btnadmekle.UseVisualStyleBackColor = false;
            this.btnadmekle.Click += new System.EventHandler(this.btnadmekle_Click);
            // 
            // btnkulsil
            // 
            this.btnkulsil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnkulsil.Location = new System.Drawing.Point(38, 304);
            this.btnkulsil.Name = "btnkulsil";
            this.btnkulsil.Size = new System.Drawing.Size(189, 51);
            this.btnkulsil.TabIndex = 5;
            this.btnkulsil.Text = "Seçili olan kullanıcıyı Sil";
            this.btnkulsil.UseVisualStyleBackColor = false;
            this.btnkulsil.Click += new System.EventHandler(this.btnkulsil_Click);
            // 
            // btngeridon
            // 
            this.btngeridon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btngeridon.Location = new System.Drawing.Point(38, 381);
            this.btngeridon.Name = "btngeridon";
            this.btngeridon.Size = new System.Drawing.Size(72, 49);
            this.btngeridon.TabIndex = 6;
            this.btngeridon.Text = "Geri Dön";
            this.btngeridon.UseVisualStyleBackColor = false;
            this.btngeridon.Click += new System.EventHandler(this.btngeridon_Click);
            // 
            // btnkapat
            // 
            this.btnkapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnkapat.Location = new System.Drawing.Point(155, 381);
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.Size = new System.Drawing.Size(72, 49);
            this.btnkapat.TabIndex = 7;
            this.btnkapat.Text = "Programı Kapat";
            this.btnkapat.UseVisualStyleBackColor = false;
            this.btnkapat.Click += new System.EventHandler(this.btnkapat_Click);
            // 
            // lblbilgi
            // 
            this.lblbilgi.AutoSize = true;
            this.lblbilgi.Location = new System.Drawing.Point(274, 9);
            this.lblbilgi.Name = "lblbilgi";
            this.lblbilgi.Size = new System.Drawing.Size(29, 14);
            this.lblbilgi.TabIndex = 8;
            this.lblbilgi.Text = "Bilgi";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(726, 442);
            this.Controls.Add(this.lblbilgi);
            this.Controls.Add(this.btnkapat);
            this.Controls.Add(this.btngeridon);
            this.Controls.Add(this.btnkulsil);
            this.Controls.Add(this.btnadmekle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGVAdmin);
            this.Controls.Add(this.dataGVKullanici);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVKullanici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGVKullanici;
        private System.Windows.Forms.DataGridView dataGVAdmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnadmekle;
        private System.Windows.Forms.Button btnkulsil;
        private System.Windows.Forms.Button btngeridon;
        private System.Windows.Forms.Button btnkapat;
        private System.Windows.Forms.Label lblbilgi;
    }
}
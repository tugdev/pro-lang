namespace winformapp
{
    partial class Kullanici
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
            this.dataGVbilgi = new System.Windows.Forms.DataGridView();
            this.btnsifrdegstr = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txteskisfr = new System.Windows.Forms.TextBox();
            this.txtkulad = new System.Windows.Forms.TextBox();
            this.lbleskisfr = new System.Windows.Forms.Label();
            this.lblklad = new System.Windows.Forms.Label();
            this.btniptl = new System.Windows.Forms.Button();
            this.btnkydt = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.lblsifre = new System.Windows.Forms.Label();
            this.btncks = new System.Windows.Forms.Button();
            this.btnkpt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVbilgi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGVbilgi
            // 
            this.dataGVbilgi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVbilgi.Location = new System.Drawing.Point(23, 20);
            this.dataGVbilgi.Name = "dataGVbilgi";
            this.dataGVbilgi.Size = new System.Drawing.Size(555, 78);
            this.dataGVbilgi.TabIndex = 0;
            // 
            // btnsifrdegstr
            // 
            this.btnsifrdegstr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnsifrdegstr.Location = new System.Drawing.Point(441, 118);
            this.btnsifrdegstr.Name = "btnsifrdegstr";
            this.btnsifrdegstr.Size = new System.Drawing.Size(109, 41);
            this.btnsifrdegstr.TabIndex = 1;
            this.btnsifrdegstr.Text = "Şifre Değiştir";
            this.btnsifrdegstr.UseVisualStyleBackColor = false;
            this.btnsifrdegstr.Click += new System.EventHandler(this.btnsifrdegstr_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txteskisfr);
            this.groupBox1.Controls.Add(this.txtkulad);
            this.groupBox1.Controls.Add(this.lbleskisfr);
            this.groupBox1.Controls.Add(this.lblklad);
            this.groupBox1.Controls.Add(this.btniptl);
            this.groupBox1.Controls.Add(this.btnkydt);
            this.groupBox1.Controls.Add(this.txtSifre);
            this.groupBox1.Controls.Add(this.lblsifre);
            this.groupBox1.Location = new System.Drawing.Point(23, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 193);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Şifre Değiştir";
            this.groupBox1.Visible = false;
            // 
            // txteskisfr
            // 
            this.txteskisfr.Location = new System.Drawing.Point(128, 73);
            this.txteskisfr.Name = "txteskisfr";
            this.txteskisfr.Size = new System.Drawing.Size(206, 22);
            this.txteskisfr.TabIndex = 7;
            // 
            // txtkulad
            // 
            this.txtkulad.Location = new System.Drawing.Point(128, 39);
            this.txtkulad.Name = "txtkulad";
            this.txtkulad.Size = new System.Drawing.Size(206, 22);
            this.txtkulad.TabIndex = 6;
            // 
            // lbleskisfr
            // 
            this.lbleskisfr.AutoSize = true;
            this.lbleskisfr.Location = new System.Drawing.Point(26, 73);
            this.lbleskisfr.Name = "lbleskisfr";
            this.lbleskisfr.Size = new System.Drawing.Size(37, 14);
            this.lbleskisfr.TabIndex = 5;
            this.lbleskisfr.Text = "Şifre :";
            // 
            // lblklad
            // 
            this.lblklad.AutoSize = true;
            this.lblklad.Location = new System.Drawing.Point(26, 39);
            this.lblklad.Name = "lblklad";
            this.lblklad.Size = new System.Drawing.Size(80, 14);
            this.lblklad.TabIndex = 4;
            this.lblklad.Text = "Kullanıcı Adı :";
            // 
            // btniptl
            // 
            this.btniptl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btniptl.Location = new System.Drawing.Point(246, 160);
            this.btniptl.Name = "btniptl";
            this.btniptl.Size = new System.Drawing.Size(87, 25);
            this.btniptl.TabIndex = 3;
            this.btniptl.Text = "İptal";
            this.btniptl.UseVisualStyleBackColor = false;
            this.btniptl.Click += new System.EventHandler(this.btniptl_Click);
            // 
            // btnkydt
            // 
            this.btnkydt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnkydt.Location = new System.Drawing.Point(128, 160);
            this.btnkydt.Name = "btnkydt";
            this.btnkydt.Size = new System.Drawing.Size(87, 25);
            this.btnkydt.TabIndex = 2;
            this.btnkydt.Text = "Kaydet";
            this.btnkydt.UseVisualStyleBackColor = false;
            this.btnkydt.Click += new System.EventHandler(this.btnkydt_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(128, 113);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(206, 22);
            this.txtSifre.TabIndex = 1;
            // 
            // lblsifre
            // 
            this.lblsifre.AutoSize = true;
            this.lblsifre.Location = new System.Drawing.Point(26, 113);
            this.lblsifre.Name = "lblsifre";
            this.lblsifre.Size = new System.Drawing.Size(62, 14);
            this.lblsifre.TabIndex = 0;
            this.lblsifre.Text = "Yeni Şifre :";
            // 
            // btncks
            // 
            this.btncks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btncks.Location = new System.Drawing.Point(441, 191);
            this.btncks.Name = "btncks";
            this.btncks.Size = new System.Drawing.Size(109, 45);
            this.btncks.TabIndex = 7;
            this.btncks.Text = "Çıkış";
            this.btncks.UseVisualStyleBackColor = false;
            this.btncks.Click += new System.EventHandler(this.btncks_Click);
            // 
            // btnkpt
            // 
            this.btnkpt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnkpt.Location = new System.Drawing.Point(441, 267);
            this.btnkpt.Name = "btnkpt";
            this.btnkpt.Size = new System.Drawing.Size(109, 44);
            this.btnkpt.TabIndex = 8;
            this.btnkpt.Text = "Programı Kapat";
            this.btnkpt.UseVisualStyleBackColor = false;
            this.btnkpt.Click += new System.EventHandler(this.btnkpt_Click);
            // 
            // Kullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(592, 323);
            this.Controls.Add(this.btnkpt);
            this.Controls.Add(this.btncks);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnsifrdegstr);
            this.Controls.Add(this.dataGVbilgi);
            this.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Kullanici";
            this.Text = "Kullanicilgn";
            this.Load += new System.EventHandler(this.Kullanici_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVbilgi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGVbilgi;
        private System.Windows.Forms.Button btnsifrdegstr;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btniptl;
        private System.Windows.Forms.Button btnkydt;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label lblsifre;
        private System.Windows.Forms.TextBox txteskisfr;
        private System.Windows.Forms.TextBox txtkulad;
        private System.Windows.Forms.Label lbleskisfr;
        private System.Windows.Forms.Label lblklad;
        private System.Windows.Forms.Button btncks;
        private System.Windows.Forms.Button btnkpt;
    }
}
namespace ArrayListOrnek
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Sil = new System.Windows.Forms.Button();
            this.Ekle = new System.Windows.Forms.Button();
            this.textBox_Add = new System.Windows.Forms.TextBox();
            this.textBox_sil = new System.Windows.Forms.TextBox();
            this.Sec_sil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(226, 144);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(183, 108);
            this.listBox1.TabIndex = 0;
            // 
            // Sil
            // 
            this.Sil.Location = new System.Drawing.Point(480, 30);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(100, 37);
            this.Sil.TabIndex = 1;
            this.Sil.Text = "Listedekini sil";
            this.Sil.UseVisualStyleBackColor = true;
            this.Sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // Ekle
            // 
            this.Ekle.Location = new System.Drawing.Point(21, 30);
            this.Ekle.Name = "Ekle";
            this.Ekle.Size = new System.Drawing.Size(100, 36);
            this.Ekle.TabIndex = 2;
            this.Ekle.Text = "Texbox yazanı Listeye ekle";
            this.Ekle.UseVisualStyleBackColor = true;
            this.Ekle.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // textBox_Add
            // 
            this.textBox_Add.Location = new System.Drawing.Point(21, 81);
            this.textBox_Add.Name = "textBox_Add";
            this.textBox_Add.Size = new System.Drawing.Size(100, 20);
            this.textBox_Add.TabIndex = 3;
            // 
            // textBox_sil
            // 
            this.textBox_sil.Location = new System.Drawing.Point(480, 81);
            this.textBox_sil.Name = "textBox_sil";
            this.textBox_sil.Size = new System.Drawing.Size(96, 20);
            this.textBox_sil.TabIndex = 4;
            // 
            // Sec_sil
            // 
            this.Sec_sil.Location = new System.Drawing.Point(241, 31);
            this.Sec_sil.Name = "Sec_sil";
            this.Sec_sil.Size = new System.Drawing.Size(100, 36);
            this.Sec_sil.TabIndex = 5;
            this.Sec_sil.Text = "Listboxta seçtiğini sil";
            this.Sec_sil.UseVisualStyleBackColor = true;
            this.Sec_sil.Click += new System.EventHandler(this.Sec_sil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 282);
            this.Controls.Add(this.Sec_sil);
            this.Controls.Add(this.textBox_sil);
            this.Controls.Add(this.textBox_Add);
            this.Controls.Add(this.Ekle);
            this.Controls.Add(this.Sil);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Sil;
        private System.Windows.Forms.Button Ekle;
        private System.Windows.Forms.TextBox textBox_Add;
        private System.Windows.Forms.TextBox textBox_sil;
        private System.Windows.Forms.Button Sec_sil;
    }
}


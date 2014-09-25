namespace winformapp
{
    partial class KullaniciKayit
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtklad = new System.Windows.Forms.TextBox();
            this.txtsyad = new System.Windows.Forms.TextBox();
            this.txteml = new System.Windows.Forms.TextBox();
            this.txtprla = new System.Windows.Forms.TextBox();
            this.btnkydt = new System.Windows.Forms.Button();
            this.btniptl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(149, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Kayıt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcı Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyadı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "E-Mail :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Parola :";
            // 
            // txtklad
            // 
            this.txtklad.Location = new System.Drawing.Point(135, 64);
            this.txtklad.Name = "txtklad";
            this.txtklad.Size = new System.Drawing.Size(222, 23);
            this.txtklad.TabIndex = 5;
            // 
            // txtsyad
            // 
            this.txtsyad.Location = new System.Drawing.Point(135, 123);
            this.txtsyad.Name = "txtsyad";
            this.txtsyad.Size = new System.Drawing.Size(222, 23);
            this.txtsyad.TabIndex = 6;
            // 
            // txteml
            // 
            this.txteml.Location = new System.Drawing.Point(135, 185);
            this.txteml.Name = "txteml";
            this.txteml.Size = new System.Drawing.Size(222, 23);
            this.txteml.TabIndex = 7;
            // 
            // txtprla
            // 
            this.txtprla.Location = new System.Drawing.Point(135, 251);
            this.txtprla.Name = "txtprla";
            this.txtprla.Size = new System.Drawing.Size(222, 23);
            this.txtprla.TabIndex = 8;
            // 
            // btnkydt
            // 
            this.btnkydt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnkydt.Location = new System.Drawing.Point(135, 305);
            this.btnkydt.Name = "btnkydt";
            this.btnkydt.Size = new System.Drawing.Size(87, 27);
            this.btnkydt.TabIndex = 9;
            this.btnkydt.Text = "Kaydet";
            this.btnkydt.UseVisualStyleBackColor = false;
            this.btnkydt.Click += new System.EventHandler(this.btnkydt_Click);
            // 
            // btniptl
            // 
            this.btniptl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btniptl.Location = new System.Drawing.Point(270, 305);
            this.btniptl.Name = "btniptl";
            this.btniptl.Size = new System.Drawing.Size(87, 27);
            this.btniptl.TabIndex = 10;
            this.btniptl.Text = "İptal";
            this.btniptl.UseVisualStyleBackColor = false;
            this.btniptl.Click += new System.EventHandler(this.btniptl_Click);
            // 
            // KullaniciKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(380, 378);
            this.Controls.Add(this.btniptl);
            this.Controls.Add(this.btnkydt);
            this.Controls.Add(this.txtprla);
            this.Controls.Add(this.txteml);
            this.Controls.Add(this.txtsyad);
            this.Controls.Add(this.txtklad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "KullaniciKayit";
            this.Text = "KullaniciKayit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtklad;
        private System.Windows.Forms.TextBox txtsyad;
        private System.Windows.Forms.TextBox txteml;
        private System.Windows.Forms.TextBox txtprla;
        private System.Windows.Forms.Button btnkydt;
        private System.Windows.Forms.Button btniptl;
    }
}
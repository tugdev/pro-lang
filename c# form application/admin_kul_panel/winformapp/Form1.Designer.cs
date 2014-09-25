namespace winformapp
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
            this.rdadmin = new System.Windows.Forms.RadioButton();
            this.rdkullanici = new System.Windows.Forms.RadioButton();
            this.btngiris = new System.Windows.Forms.Button();
            this.lblad = new System.Windows.Forms.Label();
            this.lblparola = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtparola = new System.Windows.Forms.TextBox();
            this.btnyenikullanici = new System.Windows.Forms.Button();
            this.btnkpt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdadmin
            // 
            this.rdadmin.AutoSize = true;
            this.rdadmin.Location = new System.Drawing.Point(328, 56);
            this.rdadmin.Name = "rdadmin";
            this.rdadmin.Size = new System.Drawing.Size(99, 19);
            this.rdadmin.TabIndex = 0;
            this.rdadmin.TabStop = true;
            this.rdadmin.Text = "Admin Giriş";
            this.rdadmin.UseVisualStyleBackColor = true;
            // 
            // rdkullanici
            // 
            this.rdkullanici.AutoSize = true;
            this.rdkullanici.Location = new System.Drawing.Point(462, 56);
            this.rdkullanici.Name = "rdkullanici";
            this.rdkullanici.Size = new System.Drawing.Size(113, 19);
            this.rdkullanici.TabIndex = 1;
            this.rdkullanici.TabStop = true;
            this.rdkullanici.Text = "Kullanıcı Giriş";
            this.rdkullanici.UseVisualStyleBackColor = true;
            // 
            // btngiris
            // 
            this.btngiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btngiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btngiris.Location = new System.Drawing.Point(328, 296);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(99, 54);
            this.btngiris.TabIndex = 2;
            this.btngiris.Text = "Giriş Yap";
            this.btngiris.UseVisualStyleBackColor = false;
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
            // 
            // lblad
            // 
            this.lblad.AutoSize = true;
            this.lblad.Location = new System.Drawing.Point(223, 128);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(93, 15);
            this.lblad.TabIndex = 3;
            this.lblad.Text = "Kullanıcı Adı :";
            // 
            // lblparola
            // 
            this.lblparola.AutoSize = true;
            this.lblparola.Location = new System.Drawing.Point(223, 204);
            this.lblparola.Name = "lblparola";
            this.lblparola.Size = new System.Drawing.Size(54, 15);
            this.lblparola.TabIndex = 4;
            this.lblparola.Text = "Parola :";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(328, 120);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(284, 23);
            this.txtad.TabIndex = 5;
            // 
            // txtparola
            // 
            this.txtparola.Location = new System.Drawing.Point(328, 201);
            this.txtparola.Name = "txtparola";
            this.txtparola.PasswordChar = '*';
            this.txtparola.Size = new System.Drawing.Size(284, 23);
            this.txtparola.TabIndex = 6;
            // 
            // btnyenikullanici
            // 
            this.btnyenikullanici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnyenikullanici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnyenikullanici.Location = new System.Drawing.Point(462, 296);
            this.btnyenikullanici.Name = "btnyenikullanici";
            this.btnyenikullanici.Size = new System.Drawing.Size(99, 54);
            this.btnyenikullanici.TabIndex = 7;
            this.btnyenikullanici.Text = "Yeni Kullanıcı";
            this.btnyenikullanici.UseVisualStyleBackColor = false;
            this.btnyenikullanici.Click += new System.EventHandler(this.btnyenikullanici_Click);
            // 
            // btnkpt
            // 
            this.btnkpt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnkpt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnkpt.Location = new System.Drawing.Point(76, 296);
            this.btnkpt.Name = "btnkpt";
            this.btnkpt.Size = new System.Drawing.Size(99, 54);
            this.btnkpt.TabIndex = 9;
            this.btnkpt.Text = "Programı Kapat";
            this.btnkpt.UseVisualStyleBackColor = false;
            this.btnkpt.Click += new System.EventHandler(this.btnkpt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::winformapp.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(632, 373);
            this.Controls.Add(this.btnkpt);
            this.Controls.Add(this.btnyenikullanici);
            this.Controls.Add(this.txtparola);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.lblparola);
            this.Controls.Add(this.lblad);
            this.Controls.Add(this.btngiris);
            this.Controls.Add(this.rdkullanici);
            this.Controls.Add(this.rdadmin);
            this.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdadmin;
        private System.Windows.Forms.RadioButton rdkullanici;
        private System.Windows.Forms.Button btngiris;
        private System.Windows.Forms.Label lblad;
        private System.Windows.Forms.Label lblparola;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txtparola;
        private System.Windows.Forms.Button btnyenikullanici;
        private System.Windows.Forms.Button btnkpt;
    }
}


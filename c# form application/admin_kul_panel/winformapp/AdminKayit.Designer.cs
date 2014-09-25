namespace winformapp
{
    partial class AdminKayit
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
            this.btnkaydetadm = new System.Windows.Forms.Button();
            this.btniptladm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtadmad = new System.Windows.Forms.TextBox();
            this.txtadmparola = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Kayıt";
            // 
            // btnkaydetadm
            // 
            this.btnkaydetadm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnkaydetadm.Location = new System.Drawing.Point(130, 210);
            this.btnkaydetadm.Name = "btnkaydetadm";
            this.btnkaydetadm.Size = new System.Drawing.Size(87, 27);
            this.btnkaydetadm.TabIndex = 1;
            this.btnkaydetadm.Text = "Kaydet";
            this.btnkaydetadm.UseVisualStyleBackColor = false;
            this.btnkaydetadm.Click += new System.EventHandler(this.btnkaydetadm_Click);
            // 
            // btniptladm
            // 
            this.btniptladm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btniptladm.Location = new System.Drawing.Point(236, 210);
            this.btniptladm.Name = "btniptladm";
            this.btniptladm.Size = new System.Drawing.Size(87, 27);
            this.btniptladm.TabIndex = 2;
            this.btniptladm.Text = "İptal Et";
            this.btniptladm.UseVisualStyleBackColor = false;
            this.btniptladm.Click += new System.EventHandler(this.btniptladm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kullanıcı Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Parola :";
            // 
            // txtadmad
            // 
            this.txtadmad.Location = new System.Drawing.Point(130, 60);
            this.txtadmad.Name = "txtadmad";
            this.txtadmad.Size = new System.Drawing.Size(193, 23);
            this.txtadmad.TabIndex = 5;
            // 
            // txtadmparola
            // 
            this.txtadmparola.Location = new System.Drawing.Point(130, 150);
            this.txtadmparola.Name = "txtadmparola";
            this.txtadmparola.Size = new System.Drawing.Size(193, 23);
            this.txtadmparola.TabIndex = 6;
            // 
            // AdminKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(351, 276);
            this.Controls.Add(this.txtadmparola);
            this.Controls.Add(this.txtadmad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btniptladm);
            this.Controls.Add(this.btnkaydetadm);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "AdminKayit";
            this.Text = "AdminKayit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnkaydetadm;
        private System.Windows.Forms.Button btniptladm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtadmad;
        private System.Windows.Forms.TextBox txtadmparola;
    }
}
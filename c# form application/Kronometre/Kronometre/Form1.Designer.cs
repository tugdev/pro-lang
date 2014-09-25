namespace Kronometre
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.tmrKronometre = new System.Windows.Forms.Timer(this.components);
            this.cmbInterval = new System.Windows.Forms.ComboBox();
            this.btnBasla = new System.Windows.Forms.Button();
            this.btnDur = new System.Windows.Forms.Button();
            this.lblKayit = new System.Windows.Forms.ListBox();
            this.txtSure = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Forte", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kronometrem";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSure.Location = new System.Drawing.Point(63, 10);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(42, 46);
            this.lblSure.TabIndex = 1;
            this.lblSure.Text = "0";
            this.lblSure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrKronometre
            // 
            this.tmrKronometre.Tick += new System.EventHandler(this.tmrKronometre_Tick);
            // 
            // cmbInterval
            // 
            this.cmbInterval.FormattingEnabled = true;
            this.cmbInterval.Items.AddRange(new object[] {
            "1000",
            "2000",
            "3000",
            "4000"});
            this.cmbInterval.Location = new System.Drawing.Point(12, 115);
            this.cmbInterval.Name = "cmbInterval";
            this.cmbInterval.Size = new System.Drawing.Size(235, 24);
            this.cmbInterval.TabIndex = 2;
            this.cmbInterval.Text = "Hız Seçin";
            // 
            // btnBasla
            // 
            this.btnBasla.Location = new System.Drawing.Point(25, 182);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(90, 68);
            this.btnBasla.TabIndex = 3;
            this.btnBasla.Text = "Başla";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // btnDur
            // 
            this.btnDur.Location = new System.Drawing.Point(120, 182);
            this.btnDur.Name = "btnDur";
            this.btnDur.Size = new System.Drawing.Size(90, 68);
            this.btnDur.TabIndex = 4;
            this.btnDur.Text = "Dur";
            this.btnDur.UseVisualStyleBackColor = true;
            this.btnDur.Click += new System.EventHandler(this.btnDur_Click);
            // 
            // lblKayit
            // 
            this.lblKayit.FormattingEnabled = true;
            this.lblKayit.ItemHeight = 16;
            this.lblKayit.Location = new System.Drawing.Point(225, 183);
            this.lblKayit.Name = "lblKayit";
            this.lblKayit.Size = new System.Drawing.Size(272, 100);
            this.lblKayit.TabIndex = 5;
            // 
            // txtSure
            // 
            this.txtSure.Location = new System.Drawing.Point(120, 63);
            this.txtSure.Name = "txtSure";
            this.txtSure.Size = new System.Drawing.Size(127, 23);
            this.txtSure.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(9, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Süreyi girin (saniye):";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSure);
            this.panel1.Location = new System.Drawing.Point(299, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 73);
            this.panel1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(296, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kalan Süre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(509, 324);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSure);
            this.Controls.Add(this.lblKayit);
            this.Controls.Add(this.btnDur);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.cmbInterval);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Yazılım Uzmanlığı Kronometre Uygulaması";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Timer tmrKronometre;
        private System.Windows.Forms.ComboBox cmbInterval;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Button btnDur;
        private System.Windows.Forms.ListBox lblKayit;
        private System.Windows.Forms.TextBox txtSure;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}


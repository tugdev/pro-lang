namespace Haftanın_gunleri
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
            this.buton = new System.Windows.Forms.Button();
            this.gunler_list = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buton
            // 
            this.buton.Location = new System.Drawing.Point(12, 26);
            this.buton.Name = "buton";
            this.buton.Size = new System.Drawing.Size(195, 32);
            this.buton.TabIndex = 0;
            this.buton.Text = "Günleri Göster";
            this.buton.UseVisualStyleBackColor = true;
            this.buton.Click += new System.EventHandler(this.buton_Click);
            // 
            // gunler_list
            // 
            this.gunler_list.FormattingEnabled = true;
            this.gunler_list.Location = new System.Drawing.Point(12, 74);
            this.gunler_list.Name = "gunler_list";
            this.gunler_list.Size = new System.Drawing.Size(195, 134);
            this.gunler_list.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 248);
            this.Controls.Add(this.gunler_list);
            this.Controls.Add(this.buton);
            this.Name = "Form1";
            this.Text = "Haftanın Günleri";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buton;
        private System.Windows.Forms.ListBox gunler_list;
    }
}


namespace Hastane_Proje
{
    partial class FrmHastaGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Msk_TC = new System.Windows.Forms.MaskedTextBox();
            this.Txt_Sifre = new System.Windows.Forms.TextBox();
            this.Lnk_UyeOl = new System.Windows.Forms.LinkLabel();
            this.Btn_Giris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(40, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Giris Paneli";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "TC Kimlik No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre:";
            // 
            // Msk_TC
            // 
            this.Msk_TC.Location = new System.Drawing.Point(202, 118);
            this.Msk_TC.Mask = "00000000000";
            this.Msk_TC.Name = "Msk_TC";
            this.Msk_TC.Size = new System.Drawing.Size(212, 36);
            this.Msk_TC.TabIndex = 3;
            this.Msk_TC.Text = "11111111111";
            this.Msk_TC.ValidatingType = typeof(int);
            // 
            // Txt_Sifre
            // 
            this.Txt_Sifre.Location = new System.Drawing.Point(202, 160);
            this.Txt_Sifre.Name = "Txt_Sifre";
            this.Txt_Sifre.Size = new System.Drawing.Size(212, 36);
            this.Txt_Sifre.TabIndex = 4;
            this.Txt_Sifre.Text = "1111";
            this.Txt_Sifre.UseSystemPasswordChar = true;
            // 
            // Lnk_UyeOl
            // 
            this.Lnk_UyeOl.AutoSize = true;
            this.Lnk_UyeOl.Location = new System.Drawing.Point(428, 167);
            this.Lnk_UyeOl.Name = "Lnk_UyeOl";
            this.Lnk_UyeOl.Size = new System.Drawing.Size(81, 29);
            this.Lnk_UyeOl.TabIndex = 5;
            this.Lnk_UyeOl.TabStop = true;
            this.Lnk_UyeOl.Text = "Üye Ol";
            this.Lnk_UyeOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Lnk_UyeOl_LinkClicked);
            // 
            // Btn_Giris
            // 
            this.Btn_Giris.Location = new System.Drawing.Point(273, 202);
            this.Btn_Giris.Name = "Btn_Giris";
            this.Btn_Giris.Size = new System.Drawing.Size(141, 57);
            this.Btn_Giris.TabIndex = 6;
            this.Btn_Giris.Text = "Giriş Yap";
            this.Btn_Giris.UseVisualStyleBackColor = true;
            this.Btn_Giris.Click += new System.EventHandler(this.Btn_Giris_Click);
            // 
            // FrmHastaGiris
            // 
            this.AcceptButton = this.Btn_Giris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(541, 283);
            this.Controls.Add(this.Btn_Giris);
            this.Controls.Add(this.Lnk_UyeOl);
            this.Controls.Add(this.Txt_Sifre);
            this.Controls.Add(this.Msk_TC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmHastaGiris";
            this.Text = "Hasta Giris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox Msk_TC;
        private System.Windows.Forms.TextBox Txt_Sifre;
        private System.Windows.Forms.LinkLabel Lnk_UyeOl;
        private System.Windows.Forms.Button Btn_Giris;
    }
}
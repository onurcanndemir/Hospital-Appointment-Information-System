namespace Hastane_Proje
{
    partial class FrmBilgiDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBilgiDuzenle));
            this.label7 = new System.Windows.Forms.Label();
            this.Btn_BilgiGuncelle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Cmb_Cinsiyet = new System.Windows.Forms.ComboBox();
            this.Msk_Telefon = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Soyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Ad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Sifre = new System.Windows.Forms.TextBox();
            this.Msk_TC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Script", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(9, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(462, 55);
            this.label7.TabIndex = 32;
            this.label7.Text = "Hasta Üyelik Güncelleme";
            // 
            // Btn_BilgiGuncelle
            // 
            this.Btn_BilgiGuncelle.Location = new System.Drawing.Point(186, 364);
            this.Btn_BilgiGuncelle.Name = "Btn_BilgiGuncelle";
            this.Btn_BilgiGuncelle.Size = new System.Drawing.Size(212, 50);
            this.Btn_BilgiGuncelle.TabIndex = 7;
            this.Btn_BilgiGuncelle.Text = "Bilgi Güncelle";
            this.Btn_BilgiGuncelle.UseVisualStyleBackColor = true;
            this.Btn_BilgiGuncelle.Click += new System.EventHandler(this.Btn_BilgiGuncelle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 29);
            this.label6.TabIndex = 30;
            this.label6.Text = "Cinsiyet:";
            // 
            // Cmb_Cinsiyet
            // 
            this.Cmb_Cinsiyet.FormattingEnabled = true;
            this.Cmb_Cinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.Cmb_Cinsiyet.Location = new System.Drawing.Point(186, 322);
            this.Cmb_Cinsiyet.Name = "Cmb_Cinsiyet";
            this.Cmb_Cinsiyet.Size = new System.Drawing.Size(212, 36);
            this.Cmb_Cinsiyet.TabIndex = 6;
            // 
            // Msk_Telefon
            // 
            this.Msk_Telefon.Location = new System.Drawing.Point(186, 238);
            this.Msk_Telefon.Mask = "(999) 000-0000";
            this.Msk_Telefon.Name = "Msk_Telefon";
            this.Msk_Telefon.Size = new System.Drawing.Size(212, 36);
            this.Msk_Telefon.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 29);
            this.label5.TabIndex = 27;
            this.label5.Text = "Telefon No:";
            // 
            // Txt_Soyad
            // 
            this.Txt_Soyad.Location = new System.Drawing.Point(186, 154);
            this.Txt_Soyad.Name = "Txt_Soyad";
            this.Txt_Soyad.Size = new System.Drawing.Size(212, 36);
            this.Txt_Soyad.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 29);
            this.label4.TabIndex = 25;
            this.label4.Text = "Soyad:";
            // 
            // Txt_Ad
            // 
            this.Txt_Ad.Location = new System.Drawing.Point(186, 112);
            this.Txt_Ad.Name = "Txt_Ad";
            this.Txt_Ad.Size = new System.Drawing.Size(212, 36);
            this.Txt_Ad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "Ad:";
            // 
            // Txt_Sifre
            // 
            this.Txt_Sifre.Location = new System.Drawing.Point(186, 280);
            this.Txt_Sifre.Name = "Txt_Sifre";
            this.Txt_Sifre.Size = new System.Drawing.Size(212, 36);
            this.Txt_Sifre.TabIndex = 5;
            // 
            // Msk_TC
            // 
            this.Msk_TC.Location = new System.Drawing.Point(186, 196);
            this.Msk_TC.Mask = "00000000000";
            this.Msk_TC.Name = "Msk_TC";
            this.Msk_TC.Size = new System.Drawing.Size(212, 36);
            this.Msk_TC.TabIndex = 3;
            this.Msk_TC.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 29);
            this.label3.TabIndex = 20;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 29);
            this.label2.TabIndex = 19;
            this.label2.Text = "TC Kimlik No:";
            // 
            // FrmBilgiDuzenle
            // 
            this.AcceptButton = this.Btn_BilgiGuncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(491, 440);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Btn_BilgiGuncelle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Cmb_Cinsiyet);
            this.Controls.Add(this.Msk_Telefon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_Soyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_Ad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Sifre);
            this.Controls.Add(this.Msk_TC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmBilgiDuzenle";
            this.Text = "Bilgi Güncelleme";
            this.Load += new System.EventHandler(this.FrmBilgiDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Btn_BilgiGuncelle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Cmb_Cinsiyet;
        private System.Windows.Forms.MaskedTextBox Msk_Telefon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Soyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Ad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Sifre;
        private System.Windows.Forms.MaskedTextBox Msk_TC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
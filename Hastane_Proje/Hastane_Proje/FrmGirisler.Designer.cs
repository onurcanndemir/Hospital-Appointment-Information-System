namespace Hastane_Proje
{
    partial class FrmGirisler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirisler));
            this.Btn_HastaGirisi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_DoktorGirisi = new System.Windows.Forms.Button();
            this.Btn_SekreterGirisi = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_HastaGirisi
            // 
            this.Btn_HastaGirisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_HastaGirisi.BackgroundImage")));
            this.Btn_HastaGirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_HastaGirisi.Location = new System.Drawing.Point(25, 171);
            this.Btn_HastaGirisi.Name = "Btn_HastaGirisi";
            this.Btn_HastaGirisi.Size = new System.Drawing.Size(220, 161);
            this.Btn_HastaGirisi.TabIndex = 0;
            this.Btn_HastaGirisi.UseVisualStyleBackColor = true;
            this.Btn_HastaGirisi.Click += new System.EventHandler(this.Btn_HastaGirisi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doktor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(601, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sekreter";
            // 
            // Btn_DoktorGirisi
            // 
            this.Btn_DoktorGirisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_DoktorGirisi.BackgroundImage")));
            this.Btn_DoktorGirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_DoktorGirisi.Location = new System.Drawing.Point(283, 171);
            this.Btn_DoktorGirisi.Name = "Btn_DoktorGirisi";
            this.Btn_DoktorGirisi.Size = new System.Drawing.Size(220, 161);
            this.Btn_DoktorGirisi.TabIndex = 6;
            this.Btn_DoktorGirisi.UseVisualStyleBackColor = true;
            this.Btn_DoktorGirisi.Click += new System.EventHandler(this.Btn_DoktorGirisi_Click);
            // 
            // Btn_SekreterGirisi
            // 
            this.Btn_SekreterGirisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_SekreterGirisi.BackgroundImage")));
            this.Btn_SekreterGirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_SekreterGirisi.Location = new System.Drawing.Point(544, 171);
            this.Btn_SekreterGirisi.Name = "Btn_SekreterGirisi";
            this.Btn_SekreterGirisi.Size = new System.Drawing.Size(220, 161);
            this.Btn_SekreterGirisi.TabIndex = 7;
            this.Btn_SekreterGirisi.UseVisualStyleBackColor = true;
            this.Btn_SekreterGirisi.Click += new System.EventHandler(this.Btn_SekreterGirisi_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(529, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(13, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(453, 71);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sea Green Hospital";
            // 
            // FrmGirisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(801, 397);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Btn_SekreterGirisi);
            this.Controls.Add(this.Btn_DoktorGirisi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_HastaGirisi);
            this.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmGirisler";
            this.Text = "Sea Green Hospital Giriş";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_HastaGirisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_DoktorGirisi;
        private System.Windows.Forms.Button Btn_SekreterGirisi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}


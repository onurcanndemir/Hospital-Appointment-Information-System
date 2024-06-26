﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hastane_Proje
{
    public partial class FrmHastaKayit : Form
    {
        public FrmHastaKayit()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void BtnKayitYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Hastalar (HastaAd,HastaSoyad,HastaTC,HastaTelefon,HastaSifre,HastaCinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Txt_Ad.Text);
            komut.Parameters.AddWithValue("@p2", Txt_Soyad.Text);
            komut.Parameters.AddWithValue("@p3", Msk_TC.Text);
            komut.Parameters.AddWithValue("@p4", Msk_Telefon.Text);
            komut.Parameters.AddWithValue("@p5", Txt_Sifre.Text);
            komut.Parameters.AddWithValue("@p6", Cmb_Cinsiyet.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kaydınız Gerçekleşmiştir. Şifreniz::"+Txt_Sifre.Text,"Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);


        }
    }
}

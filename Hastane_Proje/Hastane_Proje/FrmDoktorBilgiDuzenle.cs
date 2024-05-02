using System;
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
    public partial class FrmDoktorBilgiDuzenle : Form
    {
        public FrmDoktorBilgiDuzenle()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string TCNO;
        private void FrmDoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            Msk_TC.Text = TCNO;

            SqlCommand komut = new SqlCommand("Select * From Tbl_Doktorlar where DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Msk_TC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Txt_Ad.Text = dr[1].ToString();
                Txt_Soyad.Text = dr[2].ToString();
                Cmb_Brans.Text = dr[3].ToString();
                Txt_Sifre.Text = dr[5].ToString();
            }
            bgl.baglanti().Close();
        }

        private void Btn_BilgiGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Doktorlar set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p4 where DoktorTC=@p5", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Txt_Ad.Text);
            komut.Parameters.AddWithValue("@p2", Txt_Soyad.Text);
            komut.Parameters.AddWithValue("@p3", Cmb_Brans.Text);
            komut.Parameters.AddWithValue("@p4", Txt_Sifre.Text);
            komut.Parameters.AddWithValue("@p5", Msk_TC.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Güncellendi");

        }
    }
}

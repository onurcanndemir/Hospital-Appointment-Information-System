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
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From Tbl_Doktorlar", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
            bgl.baglanti().Close();




            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                Cmb_Brans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void Btn_Ekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Doktorlar (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC,DoktorSifre) values (@d1,@d2,@d3,@d4,@d5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", Txt_Ad.Text);
            komut.Parameters.AddWithValue("@d2", Txt_Soyad.Text);
            komut.Parameters.AddWithValue("@d3", Cmb_Brans.Text);
            komut.Parameters.AddWithValue("@d4", Msk_TC.Text);
            komut.Parameters.AddWithValue("d5", Txt_Sifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Eklendi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Txt_Ad.Text = "";
            Txt_Soyad.Text = "";
            Cmb_Brans.Text = "";
            Msk_TC.Text = "";
            Txt_Sifre.Text = "";
            

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            Txt_Ad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            Txt_Soyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            Cmb_Brans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            Msk_TC.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            Txt_Sifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From Tbl_Doktorlar where DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Msk_TC.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Txt_Ad.Text = "";
            Txt_Soyad.Text = "";
            Cmb_Brans.Text = "";
            Msk_TC.Text = "";
            Txt_Sifre.Text = "";
        }

        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update  Tbl_Doktorlar set DoktorAd=@d1,DoktorSoyad=@d2,DoktorBrans=@d3,DoktorSifre=@d5 where DoktorTC=@d4", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", Txt_Ad.Text);
            komut.Parameters.AddWithValue("@d2", Txt_Soyad.Text);
            komut.Parameters.AddWithValue("@d3", Cmb_Brans.Text);
            komut.Parameters.AddWithValue("@d4", Msk_TC.Text);
            komut.Parameters.AddWithValue("d5", Txt_Sifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Güncellendi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

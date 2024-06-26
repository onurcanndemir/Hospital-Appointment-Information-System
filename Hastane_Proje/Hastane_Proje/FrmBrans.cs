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
    public partial class FrmBrans : Form
    {
        public FrmBrans()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmBrans_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Branslar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            

        }

        private void Btn_Ekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Branslar (BransAd) values (@b1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@b1", Txt_BransAd.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            Txt_id.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            Txt_BransAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From Tbl_Branslar where Bransid=@b1", bgl.baglanti());
            komut.Parameters.AddWithValue("@b1", Txt_id.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Silindi !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_branslar set bransad=@p1 where bransid=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Txt_BransAd.Text);
            komut.Parameters.AddWithValue("@p2", Txt_id.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Güncellendi !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

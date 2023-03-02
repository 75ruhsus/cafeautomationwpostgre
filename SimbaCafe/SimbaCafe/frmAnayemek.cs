﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SimbaCafe
{
    public partial class frmAnayemek : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432; Database=simbacafe; user Id=postgres; password=assa12211221");
        public frmAnayemek()
        {
            InitializeComponent();
        }

        private void btnGeridon_Click(object sender, EventArgs e)
        {
            frmYemekekle frmYemekekle = new frmYemekekle();
            frmYemekekle.ShowDialog();
            this.Close();
        }

        private void btnListe_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from anayemek";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("DELETE from anayemek where id=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(txtId2.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün Silme İşlemi Başarılı Bir Şekilde Gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("insert into anayemek (id,ad,fiyat) values (@p1,@p2,@p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", int.Parse(txtId.Text));
            komut.Parameters.AddWithValue("@p2", txtAd.Text);
            komut.Parameters.AddWithValue("@p3", int.Parse(txtFiyat.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün Kaydı Başarılı Bir Şekilde Gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

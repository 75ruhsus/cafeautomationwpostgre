using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimbaCafe
{
    public partial class frmMasaAyar : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432; Database=simbacafe; user Id=postgres; password=assa12211221");
        public frmMasaAyar()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string masaid = txtSifre.Text;
            string idd = txtId.Text;
            NpgsqlCommand komut = new NpgsqlCommand("create table "+masaid+ " ( id_masa integer PRIMARY KEY NOT NULL, siparis character varying, tutar double precision)", baglanti);
            komut.ExecuteNonQuery();
            NpgsqlCommand komut2 = new NpgsqlCommand("insert into masalar(id_masalar,masad) values ("+idd+",'"+masaid+"')",baglanti);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Masa Kaydı Başarılı Bir Şekilde Gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from masalar";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string masaid = textBox2.Text;
            string masaad = textBox1.Text;
            NpgsqlCommand komut = new NpgsqlCommand("drop table "+masaad+"", baglanti);
            komut.ExecuteNonQuery();
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from masalar where id_masalar="+masaid+"", baglanti);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Masa Başarılı Bir Şekilde Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGeridon_Click(object sender, EventArgs e)
        {
            frmAyarlar frmAyarlar = new frmAyarlar();
            frmAyarlar.ShowDialog();
            this.Close();
        }

        private void frmMasaAyar_Load(object sender, EventArgs e)
        {

        }
    }
}

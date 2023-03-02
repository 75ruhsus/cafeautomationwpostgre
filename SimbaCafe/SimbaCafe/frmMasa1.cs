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
    public partial class frmMasa1 : Form
    {
        public frmMasa1()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432; Database=simbacafe; user Id=postgres; password=assa12211221");

        private void frmMasa1_Load(object sender, EventArgs e)
        {
            string sorgu = "Select * from masa1";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            string hesap = "select sum(tutar) from masa1";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(hesap, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void frmHesapKapa_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("DELETE from masa1", baglanti);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Adisyon Başarılı Bir Şekilde Kapandı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnGeridon_Click(object sender, EventArgs e)
        {
            frmMasalar frmMasalar = new frmMasalar();
            frmMasalar.ShowDialog();
            this.Close();
        }
    }
}

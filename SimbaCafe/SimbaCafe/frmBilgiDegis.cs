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
    public partial class frmBilgiDegis : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432; Database=simbacafe; user Id=postgres; password=assa12211221");
        public frmBilgiDegis()
        {
            InitializeComponent();
        }

        private void btnGeridon_Click(object sender, EventArgs e)
        {
            frmAyarlar frmAyarlar = new frmAyarlar();
            frmAyarlar.ShowDialog();
            this.Hide();
        }

        private void btnDegis_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update kullanici set pwd=@p2,gorev=@p3,telefon=@p4 where usr=@p1", baglanti);
            komut3.Parameters.AddWithValue("@p1", txtId2.Text);
            komut3.Parameters.AddWithValue("@p2", txtSifre2.Text);
            komut3.Parameters.AddWithValue("@p3", txtGorev2.Text);
            komut3.Parameters.AddWithValue("@p4", double.Parse(txtTel2.Text));
            komut3.ExecuteNonQuery();
            MessageBox.Show("Güncelleme İşlemi Başarılı Bir Şekilde Gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            baglanti.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("DELETE from kullanici where usr=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", txtId.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün Silme İşlemi Başarılı Bir Şekilde Gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void frmBilgiDegis_Load(object sender, EventArgs e)
        {

        }
    }
}

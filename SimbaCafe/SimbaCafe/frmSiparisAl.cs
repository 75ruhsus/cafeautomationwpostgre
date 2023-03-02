using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SimbaCafe
{
    public partial class frmSiparisAl : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432; Database=simbacafe; user Id=postgres; password=assa12211221");
        public frmSiparisAl()
        {
            InitializeComponent();
        }

        private void btnAna_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from anayemek", baglanti);
            da.Fill(dt);
            menubox.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                menubox.Items.Add(dr["ad"].ToString());
            }
            DataTable dtt = new DataTable();
            NpgsqlDataAdapter daa = new NpgsqlDataAdapter("select * from anayemek", baglanti);
            daa.Fill(dtt);
            menufiyat.Items.Clear();
            foreach (DataRow drr in dtt.Rows)
            {
                menufiyat.Items.Add(drr["fiyat"].ToString());
            }
        }

        private void btnBaslangic_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from baslangic", baglanti);
            da.Fill(dt);
            menubox.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                menubox.Items.Add(dr["ad"].ToString());
            }
            DataTable dtt = new DataTable();
            NpgsqlDataAdapter daa = new NpgsqlDataAdapter("select * from baslangic", baglanti);
            daa.Fill(dtt);
            menufiyat.Items.Clear();
            foreach (DataRow drr in dtt.Rows)
            {
                menufiyat.Items.Add(drr["fiyat"].ToString());
            }
        }

        private void btnKahva_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from kahvalti", baglanti);
            da.Fill(dt);
            menubox.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                menubox.Items.Add(dr["ad"].ToString());
            }
            DataTable dtt = new DataTable();
            NpgsqlDataAdapter daa = new NpgsqlDataAdapter("select * from kahvalti", baglanti);
            daa.Fill(dtt);
            menufiyat.Items.Clear();
            foreach (DataRow drr in dtt.Rows)
            {
                menufiyat.Items.Add(drr["fiyat"].ToString());
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from arayemek", baglanti);
            da.Fill(dt);
            menubox.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                menubox.Items.Add(dr["ad"].ToString());
            }
            DataTable dtt = new DataTable();
            NpgsqlDataAdapter daa = new NpgsqlDataAdapter("select * from arayemek", baglanti);
            daa.Fill(dtt);
            menufiyat.Items.Clear();
            foreach (DataRow drr in dtt.Rows)
            {
                menufiyat.Items.Add(drr["fiyat"].ToString());
            }
        }

        private void btnSoguk_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from sogukicecek", baglanti);
            da.Fill(dt);
            menubox.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                menubox.Items.Add(dr["ad"].ToString());
            }
            DataTable dtt = new DataTable();
            NpgsqlDataAdapter daa = new NpgsqlDataAdapter("select * from sogukicecek", baglanti);
            daa.Fill(dtt);
            menufiyat.Items.Clear();
            foreach (DataRow drr in dtt.Rows)
            {
                menufiyat.Items.Add(drr["fiyat"].ToString());
            }
        }

        private void btnSicak_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from sicakicecek", baglanti);
            da.Fill(dt);
            menubox.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                menubox.Items.Add(dr["ad"].ToString());
            }
            DataTable dtt = new DataTable();
            NpgsqlDataAdapter daa = new NpgsqlDataAdapter("select * from sicakicecek", baglanti);
            daa.Fill(dtt);
            menufiyat.Items.Clear();
            foreach (DataRow drr in dtt.Rows)
            {
                menufiyat.Items.Add(drr["fiyat"].ToString());
            }
        }

        private void btnSalata_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from salata", baglanti);
            da.Fill(dt);
            menubox.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                menubox.Items.Add(dr["ad"].ToString());
            }
            DataTable dtt = new DataTable();
            NpgsqlDataAdapter daa = new NpgsqlDataAdapter("select * from salata", baglanti);
            daa.Fill(dtt);
            menufiyat.Items.Clear();
            foreach (DataRow drr in dtt.Rows)
            {
                menufiyat.Items.Add(drr["fiyat"].ToString());
            }
        }

        private void btnTatli_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from tatli",baglanti);
            da.Fill(dt);
            menubox.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                menubox.Items.Add(dr["ad"].ToString());
            }
            DataTable dtt = new DataTable();
            NpgsqlDataAdapter daa = new NpgsqlDataAdapter("select * from tatli", baglanti);
            daa.Fill(dtt);
            menufiyat.Items.Clear();
            foreach (DataRow drr in dtt.Rows)
            {
                menufiyat.Items.Add(drr["fiyat"].ToString());
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            siparisbox.Items.Add(menubox.SelectedItem.ToString());
            siparisfiyat.Items.Add(menufiyat.SelectedItem.ToString());
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            siparisbox.Items.Remove(siparisbox.SelectedItem);
            siparisfiyat.Items.Remove(siparisfiyat.SelectedItem);
        }

        private void btnOnay_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string masadi = cbMasalar.Text;
            string siparis1 = siparisbox.Items[0].ToString();
            string siparis2 = siparisfiyat.Items[0].ToString();
            NpgsqlCommand komut = new NpgsqlCommand("insert into "+masadi+"(siparis,tutar) values(@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", siparis1);
            komut.Parameters.AddWithValue("@p2", double.Parse(siparis2));
            komut.ExecuteNonQuery();
            baglanti.Close();
            siparisbox.Items.Remove(siparisbox.Items[0]);
            siparisfiyat.Items.Remove(siparisfiyat.Items[0]);
        }

        private void btnGeridon_Click(object sender, EventArgs e)
        {
            frmAnamenu frmAnamenu = new frmAnamenu();
            frmAnamenu.Show();
            this.Close();
        }

        private void frmSiparisAl_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select masad from masalar", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbMasalar.DataSource = (dt);
            cbMasalar.DisplayMember = "masad";
            baglanti.Close();
        }

        private void cbMasalar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

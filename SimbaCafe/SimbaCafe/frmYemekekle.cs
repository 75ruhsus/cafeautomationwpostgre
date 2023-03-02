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

namespace SimbaCafe
{
    public partial class frmYemekekle : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432; Database=simbacafe; user Id=postgres; password=assa12211221");
        public frmYemekekle()
        {
            InitializeComponent();
        }

        private void btnGeridon_Click(object sender, EventArgs e)
        {
            frmAyarlar frmAyarlar = new frmAyarlar();
            frmAyarlar.ShowDialog();
            this.Hide();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

        }

        private void btnBaslangic_Click(object sender, EventArgs e)
        {
            frmBaslangic frmBaslangic = new frmBaslangic();
            frmBaslangic.ShowDialog();
            this.Close();
        }

        private void btnSoguk_Click(object sender, EventArgs e)
        {
            frmSogukicecek frmSogukicecek = new frmSogukicecek();
            frmSogukicecek.ShowDialog();
            this.Close();
        }

        private void btnKahva_Click(object sender, EventArgs e)
        {
            frmKahvalti frmKahvalti = new frmKahvalti();
            frmKahvalti.ShowDialog();
            this.Close();
        }

        private void btnSicak_Click(object sender, EventArgs e)
        {
            frmSicakicecek frmSicakicecek = new frmSicakicecek();
            frmSicakicecek.ShowDialog();
            this.Close();
        }

        private void btnAna_Click(object sender, EventArgs e)
        {
            frmAnayemek frmAnayemek = new frmAnayemek();
            frmAnayemek.ShowDialog();
            this.Close();
        }

        private void btnSalata_Click(object sender, EventArgs e)
        {
            frmSalata frmSalata = new frmSalata();
            frmSalata.ShowDialog();
            this.Close();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            frmArayemek frmArayemek = new frmArayemek();
             frmArayemek.ShowDialog();
            this.Close();
        }

        private void btnTatli_Click(object sender, EventArgs e)
        {
            frmTatli frmTatli = new frmTatli();
            frmTatli.ShowDialog();
            this.Close();
        }
    }
}
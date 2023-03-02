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
    public partial class frmAyarlar : Form
    {
        public frmAyarlar()
        {
            InitializeComponent();
        }

        private void btnGeridon_Click(object sender, EventArgs e)
        {
            frmAnamenu frmAnamenu = new frmAnamenu();
            frmAnamenu.ShowDialog();
            this.Close();
        }

        private void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            frmKullaniciEkle frmKullaniciEkle = new frmKullaniciEkle();
            frmKullaniciEkle.ShowDialog();
            this.Close();
        }

        private void btnKullaniciDegis_Click(object sender, EventArgs e)
        {
            frmBilgiDegis frmBilgiDegis = new frmBilgiDegis();
            frmBilgiDegis.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmKullaniciVeri frmKullaniciVeri = new frmKullaniciVeri();
            frmKullaniciVeri.ShowDialog();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmYemekekle frmYemekekle = new frmYemekekle();
            frmYemekekle.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMasaAyar frmMasaAyar = new frmMasaAyar();
            frmMasaAyar.ShowDialog();
            this.Close();
        }
    }
}

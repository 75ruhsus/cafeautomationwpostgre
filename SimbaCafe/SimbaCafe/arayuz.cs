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
    public partial class frmAnamenu : Form
    {
        public frmAnamenu()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
                Application.Exit();
        }

        private void btnKilit_Click(object sender, EventArgs e)
        {
            frmGiris frmGiris = new frmGiris();
            frmGiris.ShowDialog();
            this.Close();
        }

        private void btnMasalar_Click(object sender, EventArgs e)
        {
            frmSiparisAl frmSiparisAl = new frmSiparisAl();
            frmSiparisAl.ShowDialog();
            this.Close();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            frmMenu.ShowDialog();
            this.Close();
        }

        private void btnKasaIslemleri_Click(object sender, EventArgs e)
        {
            frmMasalar frmMasalar = new frmMasalar();
            frmMasalar.ShowDialog();
            this.Close();
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            frmAyarlar frmAyarlar = new frmAyarlar();
            frmAyarlar.ShowDialog();
            this.Close();
        }

        private void frmAnamenu_Load(object sender, EventArgs e)
        {

        }
    }
}

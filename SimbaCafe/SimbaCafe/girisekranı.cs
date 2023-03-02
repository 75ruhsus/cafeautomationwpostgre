using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SimbaCafe
{
    public partial class frmGiris : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432; Database=simbacafe; user Id=postgres; password=assa12211221");
        public frmGiris()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
                Application.Exit();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT COUNT(*) FROM kullanici WHERE usr='" + txtKullanici.Text + "' AND pwd='" + txtSifre.Text + "'", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                frmAnamenu frmAnamenu = new frmAnamenu();
                frmAnamenu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış","Hata!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbKullanici_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void cbKullanici_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void frmGiris_Load(object sender, EventArgs e)
        {
            
        }
    }
}

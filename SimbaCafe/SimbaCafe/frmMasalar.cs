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
    public partial class frmMasalar : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432; Database=simbacafe; user Id=postgres; password=assa12211221");
        public frmMasalar()
        {
            InitializeComponent();
        }

        private void btnGeridon_Click(object sender, EventArgs e)
        {
            frmAnamenu frmAnamenu = new frmAnamenu();
            frmAnamenu.ShowDialog();
            this.Close();
        }

        private void btnMasa1_Click(object sender, EventArgs e)
        {
            frmMasa1 frmMasa1 = new frmMasa1();
            frmMasa1.ShowDialog();
            this.Close();
        }

        private void btnMasa2_Click(object sender, EventArgs e)
        {
            frmMasa2 frmMasa2 = new frmMasa2();
            frmMasa2.ShowDialog();
            this.Close();
        }

        private void btnMasa3_Click(object sender, EventArgs e)
        {
            frmMasa3 frmMasa3 = new frmMasa3();
            frmMasa3.ShowDialog();
            this.Close();
        }

        private void btnMasa4_Click(object sender, EventArgs e)
        {
            frmMasa4 frmMasa4 = new frmMasa4();
            frmMasa4.ShowDialog();
            this.Close();
        }

        private void btnMasa5_Click(object sender, EventArgs e)
        {
            frmMasa5 frmMasa5 = new frmMasa5();
            frmMasa5.ShowDialog();
            this.Close();
        }

        private void btnMasa6_Click(object sender, EventArgs e)
        {
            frmMasa6 frmMasa6 = new frmMasa6();
            frmMasa6.ShowDialog();
            this.Close();
        }

        private void btnMasa7_Click(object sender, EventArgs e)
        {
            frmMasa7 frmMasa7 = new frmMasa7();
            frmMasa7.ShowDialog();
            this.Close();
        }

        private void btnMasa8_Click(object sender, EventArgs e)
        {
            frmMasa8 frmMasa8 = new frmMasa8();
            frmMasa8.ShowDialog();
            this.Close();
        }

        private void btnMasa9_Click(object sender, EventArgs e)
        {
            frmMasa9 frmMasa9 = new frmMasa9();
            frmMasa9.ShowDialog();
            this.Close();
        }

        private void btnMasa10_Click(object sender, EventArgs e)
        {
            frmMasa10 frmMasa10 = new frmMasa10();
            frmMasa10.ShowDialog();
            this.Close();
        }

        private void btnMasa11_Click(object sender, EventArgs e)
        {
            frmMasa11 frmMasa11 = new frmMasa11();
            frmMasa11.ShowDialog();
            this.Close();
        }

        private void btnMasa12_Click(object sender, EventArgs e)
        {
            frmMasa12 frmMasa12 = new frmMasa12();
            frmMasa12.ShowDialog();
            this.Close();
        }

        private void frmMasalar_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select id_masalar,masad from masalar", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DataSource = (dt);
            comboBox1.DisplayMember = "masad";
            comboBox1.ValueMember = "id_masalar";
            baglanti.Close();
        }
    }
}

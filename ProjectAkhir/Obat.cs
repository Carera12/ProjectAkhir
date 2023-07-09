using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectAkhir
{
    public partial class Obat : Form
    {
        private string stringConnection = "data source = MSI\\DAVITPH;" +
        "database=UAS_12B;User ID = sa; Password = DavitPH21";
        private SqlConnection koneksi;

        public Obat()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform()
        }

        private void refreshform()
        {
            txtNama.Text = "";
            txtNama.Enabled = false;

            cmbJenis.Text = "";
            cmbJenis.Enabled = false;

            txtHarga.Text = "";
            txtHarga.Enabled = false;

            txtIDPG.Text = "";
            txtIDPG.Enabled = false;

            txtIDG.Text = "";
            txtIDG.Enabled = false;

            btnSave.Enabled = false;
            btnClear.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Form1 mu = new Form1();
            mu.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Obat_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbJenis_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtHarga_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIDPG_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIDG_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

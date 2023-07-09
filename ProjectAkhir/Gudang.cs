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
    public partial class Gudang : Form
    {

        private string stringConnection = "data source = MSI\\DAVITPH;" +
        "database=Disconnected_Environment;User ID = sa; Password = DavitPH21";
        private SqlConnection koneksi;

        private void refreshform()
        {
            txtIDG.Text = "";
            txtIDG.Enabled = false;

            txtJumlah.Text = "";
            txtJumlah.Enabled = false;

            txtTanggal.Text = "";
            txtTanggal.Enabled = false;

            btnSave.Enabled = false;
            btnClear.Enabled = false;
        }

        public Gudang()
        {
            InitializeComponent();
        }

        private void Gudang_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Form1 mu = new Form1();
            mu.ShowDialog();
            this.Close();
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

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtJumlah_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTanggal_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

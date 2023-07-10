using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAkhir
{
    public partial class Pegawai : Form
    {
        public Pegawai()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Form1 mu = new Form1();
            mu.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtIDPeg.Text = "";
            txtNamaPeg.Text = "";
            txtAlmt.Text = "";
            txtNoTlp.Text = "";
            txtIDPeg.Enabled = true;
            txtNamaPeg.Enabled = true;
            cmbJK.Enabled = true;
            txtAlmt.Enabled = true;
            txtAlmt.Enabled = true;
            txtNoTlp.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            btnAdd.Enabled = false;
        }
        private void clearBinding()
        {
            this.txtIDPeg.DataBindings.Clear();
            this.txtNamaPeg.DataBindings.Clear();
            this.txtAlmt.DataBindings.Clear();
            this.cmbJK.DataBindings.Clear();
            this.txtNoTlp.DataBindings.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}

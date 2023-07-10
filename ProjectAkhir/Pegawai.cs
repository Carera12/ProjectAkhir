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

namespace ProjectAkhir
{
    public partial class Pegawai : Form
    {
        private string stringConnection = "Data Source=RARAIMUT\\CANDRARAKU;Initial Catalog=Aktivity6PABD;Persist Security Info=True;User ID=sa;Password=Rera1234";
        private SqlConnection koneksi;
        private string nim, nama, alamat, jk, prodi;
        private DateTime tgl;
        BindingSource customersBindingSource = new BindingSource();

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
        private void refreshform()
        {
            txtIDPeg.Enabled = false;
            txtNamaPeg.Enabled = false;
            cmbJK.Enabled = false;
            txtAlmt.Enabled = false;
            txtNoTlp.Enabled = false;
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
            clearBinding();
            FormDataPegawai_Load();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
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

        private void FormDataPegawai_Load()
        {
            koneksi.Open();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(new SqlCommand("SELECT ID_Pegawai, nama_pegawai, JK, Alamat, no_telepon FROM Pegawai", koneksi));
            DataSet ds = new DataSet();
            dataAdapter1.Fill(ds);

            this.customersBindingSource.DataSource = ds.Tables[0];
            this.txtIDPeg.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "ID_Pegawai", true));
            this.txtNamaPeg.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "nama_pegawai", true));
            this.txtAlmt.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "Alamat", true));
            this.cmbJK.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "JK", true));
            this.txtNoTlp.DataBindings.Add(
                 new Binding("Text", this.customersBindingSource, "no_telepon", true));
            koneksi.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}

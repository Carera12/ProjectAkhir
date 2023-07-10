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
    public partial class Supplier : Form
    {
        private string stringConnection = "Data Source=RARAIMUT\\CANDRARAKU;Initial Catalog=UAS_12B;Persist Security Info=True;User ID=sa;Password=Rera1234";
        private SqlConnection koneksi;
        private string id, nama, alamat, notlp;
        BindingSource customersBindingSource = new BindingSource();
        public Supplier()
        {
            InitializeComponent();
        }

        private void clearBinding()
        {
            this.txtIDSup.DataBindings.Clear();
            this.txtNamaSup.DataBindings.Clear();
            this.txtAlmt.DataBindings.Clear();
            this.txtNoTlp.DataBindings.Clear();
        }
        private void FormDataPegawai_Load()
        {
            koneksi.Open();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(new SqlCommand("SELECT ID_supplier, nama_supplier, Alamat_supplier, No_Telepon FROM Supplier", koneksi));
            DataSet ds = new DataSet();
            dataAdapter1.Fill(ds);

            this.customersBindingSource.DataSource = ds.Tables[0];
            this.txtIDSup.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "ID_supplier", true));
            this.txtNamaSup.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "nama_supplier", true));
            this.txtAlmt.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "Alamat_supplier", true));
            this.txtNoTlp.DataBindings.Add(
                 new Binding("Text", this.customersBindingSource, "No_Telepon", true));
            koneksi.Close();
        }

        private void refreshform()
        {
            txtIDSup.Enabled = false;
            txtNamaSup.Enabled = false;
            txtAlmt.Enabled = false;
            txtNoTlp.Enabled = false;
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
            clearBinding();
            FormDataPegawai_Load();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Form1 mu = new Form1();
            mu.ShowDialog();
        }

        private void Supplier_Load(object sender, EventArgs e)
        {

        }
    }
}

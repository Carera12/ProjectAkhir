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
            koneksi = new SqlConnection(stringConnection);
            this.bnSupplier.BindingSource = this.customersBindingSource;
            refreshform();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtIDSup.Text = "";
            txtNamaSup.Text = "";
            txtAlmt.Text = "";
            txtNoTlp.Text = "";
            txtIDSup.Enabled = true;
            txtNamaSup.Enabled = true;
            txtAlmt.Enabled = true;
            txtAlmt.Enabled = true;
            txtNoTlp.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            btnAdd.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            id = txtIDSup.Text.Trim();
            nama = txtNamaSup.Text.Trim();
            alamat = txtAlmt.Text.Trim();
            notlp = txtNoTlp.Text.Trim();

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(nama) || string.IsNullOrEmpty(alamat) || string.IsNullOrEmpty(notlp))
            {
                MessageBox.Show("Please fill in all identity fields!");
            }
            else
            {
                koneksi.Open();
                string query = "INSERT INTO Supplier (ID_supplier, nama_supplier, Alamat_supplier, No_Telepon) VALUES (@ID_supplier, @nama_supplier, @Alamat_supplier, @No_Telepon)";
                SqlCommand command = new SqlCommand(query, koneksi);
                command.Parameters.AddWithValue("@ID_supplier", id);
                command.Parameters.AddWithValue("@nama_supplier", nama);
                command.Parameters.AddWithValue("@Alamat_supplier", alamat);
                command.Parameters.AddWithValue("@No_Telepon", notlp);
                command.ExecuteNonQuery();
                koneksi.Close();

                MessageBox.Show("Data has been saved to the database.");
            }
            refreshform();
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

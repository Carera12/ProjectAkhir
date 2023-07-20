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
    public partial class Pembeli : Form
    {
        private string stringConnection = "Data Source=RARAIMUT\\CANDRARAKU;Initial Catalog=UAS_12B;Persist Security Info=True;User ID=sa;Password=Rera1234";
        private SqlConnection koneksi;
        private string id, nama, alamat, jk, notlp;
        BindingSource customersBindingSource = new BindingSource();

        private void btnClose_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string pem = dataGridView1.SelectedRows[0].Cells["ID_Pembeli"].Value.ToString();

                    koneksi.Open();
                    string str = "DELETE FROM dbo.Pembeli WHERE ID_Pembeli = @ID_Pembeli";
                    SqlCommand cmd = new SqlCommand(str, koneksi);
                    cmd.Parameters.AddWithValue("@ID_Pembeli", pem);
                    cmd.ExecuteNonQuery();
                    koneksi.Close();

                    MessageBox.Show("Data berhasil dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView();
                }
            }
            else
            {
                MessageBox.Show("Pilih baris data yang ingin dihapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }
        private void dataGridView()
        {
            koneksi.Open();
            string str = "SELECT ID_Pembeli, nama_pembeli, alamat, JK, no_telepon FROM dbo.Pembeli";
            SqlDataAdapter adapter = new SqlDataAdapter(str, koneksi);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            koneksi.Close();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            id = txtID.Text;
            nama = txtNama.Text;
            alamat = txtAlmt.Text;
            jk = cmbJK.Text;
            notlp = txtTlp.Text;

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(nama) || string.IsNullOrEmpty(alamat) || string.IsNullOrEmpty(jk) || string.IsNullOrEmpty(notlp))
            {
                MessageBox.Show("Please fill in all identity fields!");
            }
            else
            {
                koneksi.Open();
                string query = "INSERT INTO Pembeli (ID_Pembeli, nama_pembeli, alamat, JK, no_telepon) VALUES (@ID_Pembeli, @nama_pembeli, @alamat, @JK, @no_telepon)";
                SqlCommand command = new SqlCommand(query, koneksi);
                command.Parameters.AddWithValue("@ID_Pembeli", id);
                command.Parameters.AddWithValue("@nama_pembeli", nama);
                command.Parameters.AddWithValue("@alamat", alamat);
                command.Parameters.AddWithValue("@JK", jk);
                command.Parameters.AddWithValue("@no_telepon", notlp);
                command.ExecuteNonQuery();
                koneksi.Close();

                MessageBox.Show("Data has been saved to the database.");
            }
            dataGridView();
            refreshform();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtID.Enabled = true;
            txtNama.Enabled = true;
            txtAlmt.Enabled = true;
            txtTlp.Enabled = true;
            cmbJK.Enabled = true;

            btnSave.Enabled = true;
            btnClear.Enabled = true;
            btnAdd.Enabled = false;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            dataGridView();
            btnOpen.Enabled = false;
        }

        public Pembeli()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
        }

        private void refreshform()
        {
            txtID.Text = "";
            txtID.Enabled = false;
            txtNama.Text = "";
            txtNama.Enabled = false;
            txtAlmt.Text = "";
            txtAlmt.Enabled = false;
            txtTlp.Text = "";
            txtTlp.Enabled = false;

            cmbJK.Enabled = false;
            
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
            
        }



        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Pembeli_Load(object sender, EventArgs e)
        {
            koneksi.Open();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(new SqlCommand("SELECT ID_Pembeli, nama_pembeli, alamat, JK, no_telepon FROM Pembeli", koneksi));
            DataSet ds = new DataSet();
            dataAdapter1.Fill(ds);

            this.customersBindingSource.DataSource = ds.Tables[0];
            this.txtID.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "ID_Pembeli", true));
            this.txtNama.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "nama_pembeli", true));
            this.txtAlmt.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "alamat", true));
            this.cmbJK.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "JK", true));
            this.txtTlp.DataBindings.Add(
                 new Binding("Text", this.customersBindingSource, "no_telepon", true));
            koneksi.Close();
            refreshform();
        }
    }
}

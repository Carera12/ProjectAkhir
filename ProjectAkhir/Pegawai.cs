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
using System.Xml.Linq;

namespace ProjectAkhir
{
    public partial class Pegawai : Form
    {
        private string stringConnection = "Data Source=RARAIMUT\\CANDRARAKU;Initial Catalog=UAS_12B;Persist Security Info=True;User ID=sa;Password=Rera1234";
        private SqlConnection koneksi;
        private string id, nama, alamat, jk, notlp;
        BindingSource customersBindingSource = new BindingSource();

        public Pegawai()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }
        private void refreshform()
        {

            txtIDPeg.Text = "";
            txtIDPeg.Enabled = false;
            txtNamaPeg.Text = "";
            txtNamaPeg.Enabled = false;
            txtAlmt.Text = "";
            txtAlmt.Enabled = false;
            txtNoTlp.Text = "";
            txtNoTlp.Enabled = false;

            cmbJK.Enabled = false;

            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Pegawai_Load(object sender, EventArgs e)
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
            refreshform();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            dataGridView();
            btnOpen.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string pem = dataGridView1.SelectedRows[0].Cells["ID_Pegawai"].Value.ToString();

                    koneksi.Open();
                    string str = "DELETE FROM dbo.Pegawai WHERE ID_Pegawai = @ID_Pegawai";
                    SqlCommand cmd = new SqlCommand(str, koneksi);
                    cmd.Parameters.AddWithValue("@ID_Pegawai", pem);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            id = txtIDPeg.Text;
            nama = txtNamaPeg.Text;
            alamat = txtAlmt.Text;
            jk = cmbJK.Text;
            notlp = txtNoTlp.Text;

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(nama) || string.IsNullOrEmpty(alamat) || string.IsNullOrEmpty(jk) || string.IsNullOrEmpty(notlp))
            {
                MessageBox.Show("Please fill in all identity fields!");
            }
            else
            {
                koneksi.Open();
                string query = "INSERT INTO Pegawai (ID_Pegawai, nama_pegawai, Alamat, JK, no_telepon) VALUES (@ID_Pegawai, @nama_pegawai, @Alamat, @JK, @no_telepon)";
                SqlCommand command = new SqlCommand(query, koneksi);
                command.Parameters.AddWithValue("@ID_Pegawai", id);
                command.Parameters.AddWithValue("@nama_pegawai", nama);
                command.Parameters.AddWithValue("@Alamat", alamat);
                command.Parameters.AddWithValue("@JK", jk);
                command.Parameters.AddWithValue("@no_telepon", notlp);
                command.ExecuteNonQuery();
                koneksi.Close();

                MessageBox.Show("Data has been saved to the database.");
            }
            dataGridView();
            refreshform();
        }
        private void dataGridView()
        {
            koneksi.Open();
            string str = "SELECT ID_Pegawai, nama_pegawai, Alamat, JK, no_telepon FROM dbo.Pegawai";
            SqlDataAdapter adapter = new SqlDataAdapter(str, koneksi);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            koneksi.Close();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtIDPeg.Enabled = true;
            txtNamaPeg.Enabled = true;
            txtAlmt.Enabled = true;
            txtNoTlp.Enabled = true;

            cmbJK.Enabled = true;

            btnSave.Enabled = true;
            btnClear.Enabled = true;
            btnAdd.Enabled = false;
        }
        

        

        
    }
}

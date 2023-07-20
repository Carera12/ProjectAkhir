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
    public partial class Pembeli : Form
    {
        private string stringConnection = "Data Source=RARAIMUT\\CANDRARAKU;Initial Catalog=UAS_12B;Persist Security Info=True;User ID=sa;Password=Rera1234";
        private SqlConnection koneksi;
        private string nm, alm, id, tlp, JK;

        BindingSource customersBindingSource = new BindingSource();

        public Pembeli()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
        }

        private void refreshform()
        {
            txtId.Text = "";
            txtId.Enabled= false;

            txtNama.Text = "";
            txtNama.Enabled = false;

            cmbJK.Text = "";
            cmbJK.Enabled = false;

            txtAlamat.Text = "";
            txtAlamat.Enabled = false;

            txtNomer.Text = "";
            txtNomer.Enabled = false;

            btnSave.Enabled = false;
            btnClear.Enabled = false;

            btnSave.Enabled = false;
            btnClear.Enabled = false;
        }



        private void dataGridView()
        {
            koneksi.Open();
            string str = "SELECT ID_Pembeli, nama_pembeli, JK, alamat, no_telepon FROM dbo.Pembeli";
            SqlDataAdapter adapter = new SqlDataAdapter(str, koneksi);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            koneksi.Close();
        }

        private void Pembeli_Load(object sender, EventArgs e)
        {
            koneksi.Open();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(new SqlCommand("SELECT ID_Pembeli, nama_pembeli, JK, alamat, no_telepon FROM Pembeli", koneksi));
            DataSet ds = new DataSet();
            dataAdapter1.Fill(ds);

            this.customersBindingSource.DataSource = ds.Tables[0];
            this.txtId.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "ID_Pembeli", true));
            this.txtNama.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "nama_pembeli", true));
            this.txtAlamat.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "alamat", true));
            this.cmbJK.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "JK", true));
            this.txtNomer.DataBindings.Add(
                 new Binding("Text", this.customersBindingSource, "no_telepon", true));
            koneksi.Close();
            refreshform();
        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtJK_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtAlamat_TextChanged(object sender, EventArgs e)
        {

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            dataGridView();
            btnOpen.Enabled = false;
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

        private void txtNomer_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtNama.Enabled = true;
            cmbJK.Enabled = true;
            txtAlamat.Enabled = true;
            txtNomer.Enabled = true;
            txtId.Enabled = true;

            btnSave.Enabled = true;
            btnClear.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            nm = txtNama.Text;
            id = txtId.Text;
            JK = cmbJK.Text;
            alm = txtAlamat.Text;
            tlp = txtNomer.Text;


            koneksi.Open();

            string str = "INSERT INTO dbo.Pembeli (ID_Pembeli, nama_pembeli, JK, alamat, no_telepon)"
            + "VALUES(@ID_Pembeli, @nama_pembeli, @JK, @alamat, @no_telepon)";
            SqlCommand command = new SqlCommand(str, koneksi);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@ID_Pembeli", id);
            command.Parameters.AddWithValue("@nama_pembeli", nm);
            command.Parameters.AddWithValue("@JK", JK);
            command.Parameters.AddWithValue("@alamat", alm);
            command.Parameters.AddWithValue("@no_telepon", tlp);


            koneksi.Close();
            MessageBox.Show("Data Have been added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView();
            refreshform();

        }
    }
}


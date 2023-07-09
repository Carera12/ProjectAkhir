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
        private string stringConnection = "data source = MSI\\DAVITPH;" +
                "database=UAS_12B;User ID = sa; Password = DavitPH21";
        private SqlConnection koneksi;

        public Pembeli()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void refreshform()
        {

            txtNama.Text = "";
            txtNama.Enabled = false;

            txtJK.Text = "";
            txtJK.Enabled = false;

            txtAlamat.Text = "";
            txtAlamat.Enabled = false;

            txtNomer.Text = "";
            txtNomer.Enabled = false;

            btnSave.Enabled = false;
            btnClear.Enabled = false;

            btnSave.Enabled = false;
            btnClear.Enabled = false;
        }

        static string GenerateRandomNonRepetitiveString(int size)
        {
            Random random = new Random();
            const string chars = "123456789abcdef";
            char[] hexChars = new char[size];

            for (int i = 0; i < size; i++)
            {
                hexChars[i] = chars[random.Next(chars.Length)];

            }

            return new string(hexChars);

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

        private void txtNomer_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtNama.Enabled = true;
            txtJK.Enabled = true;
            txtAlamat.Enabled = true;
            txtNomer.Enabled = true;

            btnSave.Enabled = true;
            btnClear.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string nama_pembeli = txtNama.Text;
            string JK = txtJK.Text;
            string alamat = txtAlamat.Text;
            string no_telepon = txtNomer.Text;

            if (nama_pembeli == "")
            {
                MessageBox.Show("Masukkan Nama Pembeli", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (JK == "")
            {
                MessageBox.Show("Masukkan Jenis Kelamin", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (alamat == "")
            {
                MessageBox.Show("Masukkan Alamat Pembeli", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (no_telepon == "")
            {
                MessageBox.Show("Masukkan Nomer Telepon Pembeli", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string randomCode = GenerateRandomNonRepetitiveString(5);

                string str = "INSERT INTO dbo.Pembeli (ID_Pembeli, nama_pembeli, JK, alamat, no_telepon)" + "VALUES(@ID_Pembeli, @nama_pembeli, @JK, @alamat, @no_telepon)";
                using (SqlCommand command = new SqlCommand(str, koneksi))
                {
                    command.Parameters.Add("@ID_Pembeli", SqlDbType.VarChar).Value = randomCode;
                    command.Parameters.Add("@nama_pembeli", SqlDbType.VarChar).Value = nama_pembeli;
                    command.Parameters.Add("@JK", SqlDbType.VarChar).Value = JK;
                    command.Parameters.Add("@alamat", SqlDbType.VarChar).Value = alamat;
                    command.Parameters.Add("@no_telepon", SqlDbType.VarChar).Value = no_telepon;
                    command.ExecuteNonQuery();
                }

                koneksi.Close();
                MessageBox.Show("Data Have been added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                refreshform();

            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Form1 mu = new Form1();
            mu.ShowDialog();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            dataGridView();
            btnOpen.Enabled = false;
        }
    }
}

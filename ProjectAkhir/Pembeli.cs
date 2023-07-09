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
            string str = "SELECT nama_pembeli, JK, alamat, no_telepon FROM dbo.Pembeli";
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

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
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
            dataGridView();
            btnOpen.Enabled = false;
        }
    }
}

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
        "database=UAS_12B;User ID = sa; Password = DavitPH21";
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

        private void dataGridView()
        {
            koneksi.Open();
            string str = "SELECT ID_Gudang, Jumlah, tgl_masuk FROM dbo.Gudang";
            SqlDataAdapter adapter = new SqlDataAdapter(str, koneksi);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            koneksi.Close();
        }

        public Gudang()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void Gudang_Load(object sender, EventArgs e)
        {

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtIDG.Enabled = true;
            txtJumlah.Enabled = true;
            txtTanggal.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string IDGudang = txtIDG.Text;
            string Jumlah = txtJumlah.Text;
            DateTime Tanggal = txtTanggal.Value;


            if (IDGudang == "")
            {
                MessageBox.Show("Masukkan ID Gudang", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Jumlah == "")
            {
                MessageBox.Show("Masukkan Jumlah ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Tanggal == DateTime.MinValue)
            {
                MessageBox.Show("Masukkan Tanggal", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string str = "insert into dbo.Gudang (ID_Gudang, Jumlah, tgl_masuk)" + "values(@ID_Gudang, @Jumlah, @tgl_masuk)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("ID_Gudang", IDGudang));
                cmd.Parameters.Add(new SqlParameter("Jumlah",Jumlah));
                cmd.Parameters.Add(new SqlParameter("tgl_masuk", Tanggal));
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                refreshform();
            }
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtIDG_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

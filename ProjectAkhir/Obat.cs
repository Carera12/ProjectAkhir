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
    public partial class Obat : Form
    {
        private string stringConnection = "data source = MSI\\DAVITPH;" +
        "database=UAS_12B;User ID = sa; Password = DavitPH21";
        private SqlConnection koneksi;

        public Obat()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void refreshform()
        {
            txtNama.Text = "";
            txtNama.Enabled = false;

            cmbJenis.Text = "";
            cmbJenis.Enabled = false;

            txtHarga.Text = "";
            txtHarga.Enabled = false;

            cbxIDPG.Text = "";
            cbxIDPG.Enabled = false;

            cbxIDG.Text = "";
            cbxIDG.Enabled = false;

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


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Form1 mu = new Form1();
            mu.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Obat_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            dataGridView();
            btnOpen.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtNama.Enabled = true;
            txtHarga.Enabled = true;
            cmbJenis.Enabled = true;

            Gudangcbx();
            Pegawaicbx();

            btnSave.Enabled = true;
            btnClear.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbJenis_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtHarga_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxIDPG_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxIDG_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Gudangcbx()
        {
            koneksi.Open();
            String str = "select ID_Gudang from dbo.Gudang";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteReader();
            koneksi.Close();
            cbxIDG.DisplayMember = "ID_Gudang";
            cbxIDG.ValueMember = "ID_GUdang";
            cbxIDG.DataSource = ds.Tables[0];

        }

        private void Pegawaicbx()
        {
            koneksi.Open();
            String str = "select ID_Pegawai from dbo.Pegawai";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteReader();
            koneksi.Close();
            cbxIDPG.DisplayMember = "ID_Pegawai";
            cbxIDPG.ValueMember = "ID_Pegawai";
            cbxIDPG.DataSource = ds.Tables[0];

        }
    }
}

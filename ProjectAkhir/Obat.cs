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
using static System.Net.WebRequestMethods;

namespace ProjectAkhir
{
    public partial class Obat : Form
    {
        private string stringConnection = "Data Source=RARAIMUT\\CANDRARAKU;Initial Catalog=UAS_12B;Persist Security Info=True;User ID=sa;Password=Rera1234";
        private SqlConnection koneksi;
        private string id, nm, jns, hrg, idpgw, idgdg;

        BindingSource customersBindingSource = new BindingSource();

        public Obat()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void refreshform()
        {
            txtID.Text = "";
            txtID.Enabled= false;

            txtNama.Text = "";
            txtNama.Enabled = false;

            cmbJenis.Text = "";
            cmbJenis.Enabled = false;

            txtHarga.Text = "";
            txtHarga.Enabled = false;

            cmbIDPG.Text = "";
            cmbIDPG.Enabled = false;

            cmbIDG.Text = "";
            cmbIDG.Enabled = false;

            btnSave.Enabled = false;
            btnClear.Enabled = false;
        }
        private void dataGridView()
        {
            koneksi.Open();
            string str = "SELECT ID_Obat, nama_obat, jenis_obat, harga_obat, ID_Pegawai, ID_Gudang FROM dbo.Obat";
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
            koneksi.Open();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(new SqlCommand("SELECT ID_Obat, nama_obat, jenis_obat, harga_obat, ID_Pegawai, ID_Gudang FROM Obat", koneksi));
            DataSet ds = new DataSet();
            dataAdapter1.Fill(ds);

            this.customersBindingSource.DataSource = ds.Tables[0];
            this.txtID.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "ID_Obat", true));
            this.txtNama.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "nama_obat", true));
            this.cmbJenis.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "jenis_obat", true));
            this.txtHarga.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "harga_obat", true));
            this.cmbIDPG.DataBindings.Add(
                 new Binding("Text", this.customersBindingSource, "ID_Pegawai", true));
            this.cmbIDG.DataBindings.Add(
                 new Binding("Text", this.customersBindingSource, "ID_Gudang", true));
            koneksi.Close();
            refreshform();

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
            txtID.Enabled = true;
            txtNama.Enabled = true;
            txtHarga.Enabled = true;
            cmbJenis.Enabled = true;
            cmbIDPG.Enabled = true;
            cmbIDG.Enabled = true;

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
            id = txtID.Text;
            nm = txtNama.Text;
            jns = cmbJenis.Text;
            hrg = txtHarga.Text;
            idgdg = cmbIDG.SelectedValue.ToString();
            idpgw = cmbIDPG.SelectedValue.ToString();

            koneksi.Open();
            string strs = "select ID_Gudang from dbo.Gudang where ID_Gudang = @idg, " +
                "select ID_Pegawai from dbo.Pegawai where ID_Pegawai = @idp";
            SqlCommand cm = new SqlCommand(strs, koneksi);
            cm.CommandType = CommandType.Text;
            cm.Parameters.Add(new SqlParameter("@idg", idgdg));
            cm.Parameters.Add(new SqlParameter("@idp", idpgw));

            string str = "insert into dbo.Obat(ID_Obat, nama_obat, jenis_obat, harga_obat, ID_Pegawai, ID_Gudang)" +
                    "values (@idO, @nmO, @jnsO, @hrgO, @IDP, @IDG)";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@idO", id);
            cmd.Parameters.AddWithValue("@nmO", nm);
            cmd.Parameters.AddWithValue("@jnsO", jns);
            cmd.Parameters.AddWithValue("@hrgO", hrg);
            cmd.Parameters.AddWithValue("@IDP", idpgw);
            cmd.Parameters.AddWithValue("@IDG", idgdg);
            cmd.ExecuteNonQuery();

            koneksi.Close();
            MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView();
            refreshform();
        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbJenis_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            cmbIDG.DisplayMember = "ID_Gudang";
            cmbIDG.ValueMember = "ID_GUdang";
            cmbIDG.DataSource = ds.Tables[0];

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
            cmbIDPG.DisplayMember = "ID_Pegawai";
            cmbIDPG.ValueMember = "ID_Pegawai";
            cmbIDPG.DataSource = ds.Tables[0];

        }
    }
}

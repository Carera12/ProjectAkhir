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
            id = txtID.Text;
            nm = txtNama.Text;
            jns = cmbJenis.Text;
            hrg = txtHarga.Text;
            idgdg = cbxIDG.SelectedValue.ToString();
            idpgw = cbxIDPG.SelectedValue.ToString();

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

            refreshform();
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

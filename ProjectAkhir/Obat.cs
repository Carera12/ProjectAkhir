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
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Obat_Load(object sender, EventArgs e)
        {
            koneksi.Open();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(new SqlCommand("SELECT m.ID_Obat, m.nama_obat, m.jenis_obat, " +
                "m.harga_obat, p.ID_Pegawai, k.ID_Gudang FROM dbo.Obat m " +
                "JOIN dbo.Pegawai p ON m.ID_Pegawai = p.ID_Pegawai " +
                "JOIN dbo.Gudang k ON m.ID_Gudang = k.ID_Gudang", koneksi));
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
            txtID.Text = "";
            txtNama.Text = "";
            txtHarga.Text = "";
            cmbJenis.Text = "";
            cmbIDPG.Text = "";
            cmbIDG.Text = "";
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string pem = dataGridView1.SelectedRows[0].Cells["ID_Obat"].Value.ToString();

                    koneksi.Open();
                    string str = "DELETE FROM dbo.Obat WHERE ID_Obat = @ID_Obat";
                    SqlCommand cmd = new SqlCommand(str, koneksi);
                    cmd.Parameters.AddWithValue("@ID_Obat", pem);
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string idobt = txtID.Text;
            string nama = txtNama.Text;
            string harga = txtHarga.Text;
            string jenis = cmbJenis.Text;
            string idpeg = cmbIDPG.Text;
            string idgdg = cmbIDG.Text;

            if (string.IsNullOrEmpty(idobt) || string.IsNullOrEmpty(nama) ||
                string.IsNullOrEmpty(harga) || string.IsNullOrEmpty(jenis) ||
                string.IsNullOrEmpty(idpeg) || string.IsNullOrEmpty(idgdg))
            {
                MessageBox.Show("Mohon lengkapi semua kolom.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            koneksi.Open();

            // Check if the specified ID values exist in the related tables
            string checkStr = "SELECT COUNT(*) FROM dbo.Pegawai WHERE ID_Pegawai = @ID_Pegawai; SELECT COUNT(*) FROM dbo.Gudang WHERE ID_Gudang = @ID_Gudang";
            SqlCommand checkCmd = new SqlCommand(checkStr, koneksi);
            checkCmd.Parameters.AddWithValue("@ID_Pegawai", idpeg);
            checkCmd.Parameters.AddWithValue("@ID_Gudang", idgdg);
            int count = Convert.ToInt32(checkCmd.ExecuteScalar());

            if (count == 0)
            {
                koneksi.Close();
                MessageBox.Show("ID Pegawai atau ID Gudang tidak valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string updateStr = "UPDATE dbo.Obat SET ID_Obat = @ID_Obat, nama_obat = @nama_obat, jenis_obat = @jenis_obat, harga_obat = @harga_obat " +
                               "WHERE ID_Obat = @ID_Obat AND ID_Pegawai = @ID_Pegawai AND ID_Gudang = @ID_Gudang";
            SqlCommand updateCmd = new SqlCommand(updateStr, koneksi);
            updateCmd.Parameters.AddWithValue("@ID_Obat", idobt);
            updateCmd.Parameters.AddWithValue("@nama_obat", nama);
            updateCmd.Parameters.AddWithValue("@jenis_obat", jenis);
            updateCmd.Parameters.AddWithValue("@harga_obat", harga);
            updateCmd.Parameters.AddWithValue("@ID_Pegawai", idpeg);
            updateCmd.Parameters.AddWithValue("@ID_Gudang", idgdg);
            updateCmd.ExecuteNonQuery();

            koneksi.Close();
            MessageBox.Show("Data berhasil diperbarui.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView();
            refreshform();
        }

        private void label7_Click(object sender, EventArgs e)
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

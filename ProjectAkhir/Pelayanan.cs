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
    public partial class Pelayanan : Form
    {
        private string stringConnection = "Data Source=RARAIMUT\\CANDRARAKU;Initial Catalog=UAS_12B;Persist Security Info=True;User ID=sa;Password=Rera1234";
        private SqlConnection koneksi;
        private string idPel, idPem, idPeg;
        private DateTime date;
        BindingSource customersBindingSource = new BindingSource();
        public Pelayanan()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Form1 mu = new Form1();
            mu.ShowDialog();
        }

        private void Pelayanan_Load(object sender, EventArgs e)
        {
            koneksi.Open();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(new SqlCommand("SELECT ID_Pelayanan, tgl_pelayanan, ID_Pembeli, ID_Pegawai FROM Pelayanan", koneksi));
            DataSet ds = new DataSet();
            dataAdapter1.Fill(ds);

            this.customersBindingSource.DataSource = ds.Tables[0];
            this.txtIDPL.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "ID_Pelayanan", true));;
            this.dtTP.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "tgl_pelayanan", true));
            this.cmbPemb.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "ID_Pembeli", true));
            this.cmbPgw.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "ID_Pegawai", true));
            koneksi.Close();
            refreshform();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            dataGridView();
            btnOpen.Enabled = false;
        }

        private void pegawai()
        {
            koneksi.Open();
            string str = "select ID_Pegawai from dbo.Pegawai";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            koneksi.Close();
            cmbPgw.ValueMember = "ID_Pegawai";
            cmbPgw.DataSource = ds.Tables[0];
        }

        private void pembeli()
        {
            koneksi.Open();
            string str = "select ID_Pembeli from dbo.Pembeli";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteReader();
            koneksi.Close();
            cmbPemb.ValueMember = "ID_Pembeli";
            cmbPemb.DataSource = ds.Tables[0];
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select ID_Pelayanan, tgl_pelayanan, ID_Pembeli, ID_Pegawai from dbo.Pelayanan";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void refreshform()
        {
            txtIDPL.Text = "";
            txtIDPL.Enabled = false;

            dtTP.Enabled = false;

            cmbPemb.Enabled = false;
            cmbPemb.SelectedIndex = -1;
            cmbPgw.Enabled = false;
            cmbPgw.SelectedIndex = -1;

            btnSave.Enabled = false;
            btnClear.Enabled = false;
            btnAdd.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string pem = dataGridView1.SelectedRows[0].Cells["ID_Pelayanan"].Value.ToString();

                    koneksi.Open();
                    string str = "DELETE FROM dbo.Pelayanan WHERE ID_Pelayanan = @ID_Pelayanan";
                    SqlCommand cmd = new SqlCommand(str, koneksi);
                    cmd.Parameters.AddWithValue("@ID_Pelayanan", pem);
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtIDPL.Text = "";     
            txtIDPL.Enabled = true;

            dtTP.Value = DateTime.Today;
            dtTP.Enabled = true;

            cmbPgw.Enabled = true;
            cmbPemb.Enabled = true;

            pegawai();
            pembeli();
            btnSave.Enabled = true;
            btnClear.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            idPel = txtIDPL.Text;
            idPeg = cmbPgw.Text;
            idPem = cmbPemb.Text;
            date = dtTP.Value;

            koneksi.Open();
            string strs = "select ID_Pembeli from dbo.Pembeli where ID_Pembeli = @ID_Pembeli, " +
                "select ID_Pegawai from dbo.Pegawai where ID_Pegawai = @ID_Pegawai";
            SqlCommand cm = new SqlCommand(strs, koneksi);
            cm.CommandType = CommandType.Text;
            cm.Parameters.Add(new SqlParameter("@ID_Pembeli", idPem));
            cm.Parameters.Add(new SqlParameter("@ID_Pegawai", idPeg));

            string str = "insert into dbo.Pelayanan(ID_Pelayanan, tgl_pelayanan, ID_Pembeli, ID_Pegawai)" +
                    "values (@ID_Pelayanan, @tgl_pelayanan, @ID_Pembeli, @ID_Pegawai)";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ID_Pelayanan", idPel);
            cmd.Parameters.AddWithValue("@tgl_pelayanan", date);
            cmd.Parameters.AddWithValue("@ID_Pembeli", idPem);
            cmd.Parameters.AddWithValue("@ID_Pegawai", idPeg);
            cmd.ExecuteNonQuery();

            koneksi.Close();
            MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView();
            refreshform();
        }
    }
}

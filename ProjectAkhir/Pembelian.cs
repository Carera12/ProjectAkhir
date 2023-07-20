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
using static System.Net.WebRequestMethods;

namespace ProjectAkhir
{
    public partial class Pembelian : Form
    {
        private string stringConnection = "Data Source=RARAIMUT\\CANDRARAKU;Initial Catalog=UAS_12B;Persist Security Info=True;User ID=sa;Password=Rera1234";
        private SqlConnection koneksi;
        private string id, jml, ttl, pem, obt;
        private DateTime tgl;
        BindingSource customersBindingSource = new BindingSource();


        private void btnOpen_Click(object sender, EventArgs e)
        {
            dataGridView();
            btnOpen.Enabled = false;
        }

        public Pembelian()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }
        private void dataGridView()
        {
            koneksi.Open();
            string str = "SELECT ID_Pembelian, Jumlah_Pembelian, Total_Bayar, tgl_pembelian, ID_Pembeli, ID_Obat FROM Pembelian";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }
        private void refreshform()
        {
            txtIDPemb.Text = "";
            txtIDPemb.Enabled = false;

            txtJumPembe.Text = "";
            txtJumPembe.Enabled = false;

            txtTotBay.Text = "";
            txtTotBay.Enabled = false;

            dtTgl.Enabled = false;

            cmbIDPemb.Enabled = false;
            cmbIDPemb.SelectedIndex = -1;
            cmbObat.Enabled = false;
            cmbObat.SelectedIndex = -1;

            btnSave.Enabled = false;
            btnClear.Enabled = false;
            btnAdd.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtIDPemb.Text = "";
            txtIDPemb.Enabled = true;

            txtJumPembe.Text = "";
            txtJumPembe.Enabled = true;

            txtTotBay.Text = "";
            txtTotBay.Enabled = true;

            dtTgl.Value = DateTime.Today;
            dtTgl.Enabled = true;

            cmbObat.Enabled = true;
            cmbIDPemb.Enabled = true;

            obat();
            pembeli();
            btnSave.Enabled = true;
            btnClear.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            id = txtIDPemb.Text;
            jml = txtJumPembe.Text;
            ttl = txtTotBay.Text;
            tgl = dtTgl.Value;
            pem = cmbIDPemb.Text;
            obt = cmbObat.Text;

            koneksi.Open();
            string strs = "select ID_Pembeli from dbo.Pembeli where ID_Pembeli = @ID_Pembeli, " +
                "select ID_Obat from dbo.Obat where ID_Obat = @ID_Obat";
            SqlCommand cm = new SqlCommand(strs, koneksi);
            cm.CommandType = CommandType.Text;
            cm.Parameters.Add(new SqlParameter("@ID_Pembeli", pem));
            cm.Parameters.Add(new SqlParameter("@ID_Obat", obt));

            string str = "insert into dbo.Pembelian(ID_Pembelian, Jumlah_Pembelian, Total_Bayar, tgl_pembelian, ID_Pembeli, ID_Obat)" +
                    "values (@ID_Pembelian, @Jumlah_Pembelian, @Total_Bayar, @tgl_pembelian, @ID_Pembeli, @ID_Obat)";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ID_Pembelian", id);
            cmd.Parameters.AddWithValue("@Jumlah_Pembelian", jml);
            cmd.Parameters.AddWithValue("@Total_Bayar", ttl); 
            cmd.Parameters.AddWithValue("@tgl_pembelian", tgl);
            cmd.Parameters.AddWithValue("@ID_Pembeli", pem);
            cmd.Parameters.AddWithValue("@ID_Obat", obt);
            cmd.ExecuteNonQuery();

            koneksi.Close();
            MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView();
            refreshform();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Form1 mu = new Form1();
            mu.ShowDialog();
        }

        private void Pembelian_Load(object sender, EventArgs e)
        {
            koneksi.Open();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(new SqlCommand("SELECT ID_Pembelian, Jumlah_Pembelian, Total_Bayar, tgl_pembelian, ID_Pembeli, ID_Obat FROM Pembelian", koneksi));
            DataSet ds = new DataSet();
            dataAdapter1.Fill(ds);

            this.customersBindingSource.DataSource = ds.Tables[0];
            this.txtIDPemb.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "ID_Pembelian", true)); ;
            this.txtJumPembe.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "Jumlah_Pembelian", true));
            this.dtTgl.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "Total_Bayar", true));
            this.txtTotBay.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "tgl_pembelian", true)); ;
            this.cmbIDPemb.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "ID_Pembeli", true));
            this.cmbObat.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "ID_Obat", true));           
            koneksi.Close();
            refreshform();
        }
        private void obat()
        {
            koneksi.Open();
            string str = "select ID_Obat from dbo.Obat";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteReader();
            koneksi.Close();
            cmbObat.ValueMember = "ID_Obat";
            cmbObat.DataSource = ds.Tables[0];
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
            cmbIDPemb.ValueMember = "ID_Pembeli";
            cmbIDPemb.DataSource = ds.Tables[0];
        }

    }
}

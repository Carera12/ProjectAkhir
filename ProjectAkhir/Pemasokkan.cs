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
    public partial class Pemasokkan : Form
    {
        private string stringConnection = "Data Source=RARAIMUT\\CANDRARAKU;Initial Catalog=UAS_12B;Persist Security Info=True;User ID=sa;Password=Rera1234";
        private SqlConnection koneksi;
        private string id, jml, dt, sup, obt;
        BindingSource customersBindingSource = new BindingSource();

        public Pemasokkan()
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
        private void cbObat()
        {
            koneksi.Open();
            string str = "SELECT nama_obat FROM Obat";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteReader();
            koneksi.Close();
            cmbNamaSup.DisplayMember = "nama_obat";
            cmbNamaSup.ValueMember = "ID_Obat";
            cmbNamaSup.DataSource = ds.Tables[0];
        }


        private void Pemasokkan_Load(object sender, EventArgs e)
        {
            koneksi.Open();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(new SqlCommand("SELECT ID_Pemasokan, Jumlah_Pemasokan, tgl_Pemasokan, ID_Supplier, ID_Obat FROM Pemasokan", koneksi));
            DataSet ds = new DataSet();
            dataAdapter1.Fill(ds);

            this.customersBindingSource.DataSource = ds.Tables[0];
            this.txtIDPema.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "ID_Pemasokan", true));
            this.txtJumPema.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "Jumlah_Pemasokan", true));
            this.dtTP.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "tgl_Pemasokan", true));
            this.cmbNamaObat.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "ID_Supplier", true));
            this.cmbNamaSup.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "ID_Obat", true));
            koneksi.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtIDPema.Text = "";
            txtJumPema.Text = "";
            dtTP.Value = DateTime.Today;
            txtIDPema.Enabled = true;
            txtJumPema.Enabled = true;

            cmbNamaObat.Enabled = true;
            cmbNamaSup.Enabled = true;

            dtTP.Enabled = true;
            cbSupplier();
            cbObat();
            
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            btnAdd.Enabled = false;
        }
        private void cbSupplier()
        {
            koneksi.Open();
            string str = "SELECT nama_supplier FROM Supplier";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteReader();
            koneksi.Close();
            cmbNamaSup.DisplayMember = "nama_supplier";
            cmbNamaSup.ValueMember = "ID_supplier";
            cmbNamaSup.DataSource = ds.Tables[0];
        }
        

        private void label2_Click(object sender, EventArgs e)
        {
            
        }


        private void refreshform()
        {
            txtIDPema.Enabled = false;
            txtJumPema.Enabled = false;
            dtTP.Value = DateTime.Today;
            dtTP.Enabled = true;

            cmbNamaSup.Enabled = false;
            cmbNamaSup.SelectedIndex = -1;
            
            btnSave.Enabled = false;
            btnClear.Enabled = false;
            btnAdd.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            id = txtIDPema.Text;
            jml = txtJumPema.Text;
            dt = dtTP.Text;
            obt = cmbNamaObat.SelectedValue.ToString();
            sup = cmbNamaSup.SelectedValue.ToString();

            koneksi.Open();
            string strs = "select nama_supplier from dbo.Supplier where nama_supplier = @id_supplier, " +
                "select nama_obat from dbo.karyawan where nama_obat = @id_obat";
            SqlCommand cm = new SqlCommand(strs, koneksi);
            cm.CommandType = CommandType.Text;
            cm.Parameters.Add(new SqlParameter("@nama_supplier", obt));
            cm.Parameters.Add(new SqlParameter("@nama_obat", sup));

            string str = "insert into dbo.Pemasokan(ID_Pemasokan, Jumlah_Pemasokan, tgl_Pemasokan, ID_Supplier, ID_Obat)" +
                    "values (@ID_Pemasokan, @Jumlah_Pemasokan, @tgl_Pemasokan, @ID_Supplier, @ID_Obat)";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ID_Pemasokan", id);
            cmd.Parameters.AddWithValue("@Jumlah_Pemasokan", jml);
            cmd.Parameters.AddWithValue("@tgl_Pemasokan", dt);
            cmd.Parameters.AddWithValue("@ID_Supplier", obt);
            cmd.Parameters.AddWithValue("@ID_Obat", sup);
            cmd.ExecuteNonQuery();

            koneksi.Close();
            MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            refreshform();
        }
    }
}

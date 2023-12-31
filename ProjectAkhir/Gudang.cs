﻿using System;
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

        private string stringConnection = "Data Source=RARAIMUT\\CANDRARAKU;Initial Catalog=UAS_12B;Persist Security Info=True;User ID=sa;Password=Rera1234";
        private SqlConnection koneksi;
        private string id, jml;
        private DateTime tgl;
        BindingSource customersBindingSource = new BindingSource();



        private void refreshform()
        {
            txtIDG.Text = "";
            txtIDG.Enabled = false;

            txtJumlah.Text = "";
            txtJumlah.Enabled = false;

            txtTanggal.Text = "";
            txtTanggal.Enabled = false;

            btnAdd.Enabled = true;
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
            
        }

        private void Gudang_Load(object sender, EventArgs e)
        {
            koneksi.Open();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(new SqlCommand("SELECT ID_Gudang, Jumlah, tgl_masuk FROM Gudang", koneksi));
            DataSet ds = new DataSet();
            dataAdapter1.Fill(ds);

            this.customersBindingSource.DataSource = ds.Tables[0];
            this.txtIDG.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "ID_Gudang", true));
            this.txtJumlah.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "Jumlah", true));
            this.txtTanggal.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "tgl_masuk", true));
            koneksi.Close();
            refreshform();
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

            txtTanggal.Value = DateTime.Today;
            txtTanggal.Enabled = true;

            btnSave.Enabled = true;
            btnClear.Enabled = true;
            btnAdd.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            id = txtIDG.Text;
            jml = txtJumlah.Text;
            tgl = txtTanggal.Value;

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(jml))
            {
                MessageBox.Show("Please fill in all identity fields!");
            }
            else
            {
                koneksi.Open();
                string query = "INSERT INTO Gudang (ID_Gudang, Jumlah, tgl_masuk) VALUES (@ID_Gudang, @Jumlah, @tgl_masuk)";
                SqlCommand command = new SqlCommand(query, koneksi);
                command.Parameters.AddWithValue("@ID_Gudang", id);
                command.Parameters.AddWithValue("@Jumlah", jml);
                command.Parameters.AddWithValue("@tgl_masuk", tgl);
                command.ExecuteNonQuery();
                koneksi.Close();

                MessageBox.Show("Data has been saved to the database.");
            }
            dataGridView();
            refreshform();
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

        private void Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string pem = dataGridView1.SelectedRows[0].Cells["ID_Gudang"].Value.ToString();

                    koneksi.Open();
                    string str = "DELETE FROM dbo.Gudang WHERE ID_Gudang = @ID_Gudang";
                    SqlCommand cmd = new SqlCommand(str, koneksi);
                    cmd.Parameters.AddWithValue("@ID_Gudang", pem);
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

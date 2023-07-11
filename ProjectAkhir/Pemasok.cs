﻿using System;
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
    public partial class Pemasok : Form
    {
        private string stringConnection = "Data Source=RARAIMUT\\CANDRARAKU;Initial Catalog=UAS_12B;Persist Security Info=True;User ID=sa;Password=Rera1234";
        private SqlConnection koneksi;
        private string id, jml, sup, obt;
        private DateTime tgl;
        BindingSource customersBindingSource = new BindingSource();

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtid.Enabled = true;
            txtJml.Text = "";
            txtJml.Enabled = true;

            dtTgl.Value = DateTime.Today;
            dtTgl.Enabled = true;

            cmbSup.Enabled = true;
            cmbObt.Enabled = true;

            cbSupplier();
            cbObat();

            btnSave.Enabled = true;
            btnClear.Enabled = true;
        }

        private void cbSupplier()
        {
            koneksi.Open();
            string str = "SELECT ID_supplier FROM Supplier";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteReader();
            koneksi.Close();
            cmbSup.ValueMember = "ID_supplier";
            cmbSup.DataSource = ds.Tables[0];
        }
        private void cbObat()
        {
            koneksi.Open();
            string str = "SELECT ID_Obat FROM Obat";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteReader();
            koneksi.Close();
            cmbObt.ValueMember = "ID_Obat";
            cmbObt.DataSource = ds.Tables[0];
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            gridView();
            klikOpen.Enabled = false;
        }
        private void gridView()
        {
            koneksi.Open();
            string str = "select ID_Pemasokan, Jumlah_Pemasokan, tgl_Pemasokan, ID_supplier, ID_Obat from dbo.Pemasokan";
            SqlDataAdapter sa = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            sa.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            id = txtid.Text;
            jml = txtJml.Text;
            tgl = dtTgl.Value;
            sup = cmbSup.Text;
            obt = cmbObt.Text;

            koneksi.Open();
            string strs = "select ID_supplier from dbo.Supplier where ID_supplier = @ID_supplier, " +
                "select ID_Obat from dbo.Obat where ID_Obat = @ID_Obat";
            SqlCommand cm = new SqlCommand(strs, koneksi);
            cm.CommandType= CommandType.Text;
            cm.Parameters.Add(new SqlParameter("@ID_supplier", sup));
            cm.Parameters.Add(new SqlParameter("@ID_Obat", obt));

            string str = "insert into dbo.Pemasokan(ID_Pemasokan, Jumlah_Pemasokan, tgl_Pemasokan, ID_supplier, ID_Obat" +
                "values (@ID_Pemasokan, @Jumlah_Pemasokan, @tgl_Pemasokan, @ID_supplier, @ID_Obat)";
            SqlCommand cmn = new SqlCommand(str, koneksi);
            cmn.CommandType= CommandType.Text;
            cmn.Parameters.AddWithValue("@ID_Pemasokan", id);
            cmn.Parameters.AddWithValue("@Jumlah_Pemasokan", jml);
            cmn.Parameters.AddWithValue("@tgl_Pemasokan", tgl);
            cmn.Parameters.AddWithValue("@ID_supplier", sup);
            cmn.Parameters.AddWithValue("@ID_Obat", obt);
            

            koneksi.Close();
            MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            gridView();
            refreshform();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Form1 mu = new Form1();
            mu.ShowDialog();
        }

        public Pemasok()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
        }

        private void Pemasok_Load(object sender, EventArgs e)
        {
            koneksi.Open();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(new SqlCommand("SELECT ID_Pemasokan, Jumlah_Pemasokan, tgl_Pemasokan, ID_supplier, ID_Obat FROM Pemasokan", koneksi));
            DataSet ds = new DataSet();
            dataAdapter1.Fill(ds);

            this.customersBindingSource.DataSource = ds.Tables[0];
            this.txtid.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "ID_Pemasokan", true));
            this.txtJml.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "Jumlah_Pemasokan", true));
            this.dtTgl.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "tgl_Pemasokan", true));
            this.cmbSup.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "ID_supplier", true));
            this.cmbObt.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "ID_Obat", true));
            koneksi.Close();
            refreshform();
        }
        private void refreshform()
        {
            txtid.Text = "";
            txtid.Enabled = false;
            txtJml.Text = "";
            txtJml.Enabled = false;

            dtTgl.Enabled = false;

            cmbSup.Enabled = false;
            cmbSup.SelectedIndex = -1;
            cmbObt.Enabled = false;
            cmbObt.SelectedIndex = -1;

            btnSave.Enabled = false;
            btnClear.Enabled = false;
            btnAdd.Enabled = true;
        }
    }
}
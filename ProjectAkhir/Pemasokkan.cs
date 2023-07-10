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
                        
        }
        

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
    }
}

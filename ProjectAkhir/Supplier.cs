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
    public partial class Supplier : Form
    {
        private string stringConnection = "Data Source=RARAIMUT\\CANDRARAKU;Initial Catalog=UAS_12B;Persist Security Info=True;User ID=sa;Password=Rera1234";
        private SqlConnection koneksi;
        private string id, nama, alamat, notlp;
        BindingSource customersBindingSource = new BindingSource();
        public Supplier()
        {
            InitializeComponent();
        }

        private void clearBinding()
        {
            this.txtIDSup.DataBindings.Clear();
            this.txtNamaSup.DataBindings.Clear();
            this.txtAlmt.DataBindings.Clear();
            this.txtNoTlp.DataBindings.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Form1 mu = new Form1();
            mu.ShowDialog();
        }

        private void Supplier_Load(object sender, EventArgs e)
        {

        }
    }
}

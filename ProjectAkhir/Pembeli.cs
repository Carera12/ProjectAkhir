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

namespace ProjectAkhir
{
    public partial class Pembeli : Form
    {
        private string stringConnection = "data source = MSI\\DAVITPH;" +
                "database=UAS_12B;User ID = sa; Password = DavitPH21";
        private SqlConnection koneksi;

        private string nama, alamat, jk, no;
        BindingSource customerBindingSource = new BindingSource();

        public Pembeli()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            this.bindingNavigator1.BindingSource = this.customerBindingSource;
            refreshform();
        }

        private void refreshform()
        {
            txtNama.Enabled = false;
            txtJK.Enabled = false;
            txtAlamat.Enabled = false;
            txtNomer.Enabled = false;
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
            clearBinding();
        }

        private void clearBinding()
        {
            this.txtNama.DataBindings.Clear();
            this.txtAlamat.DataBindings.Clear();
            this.txtJK.DataBindings.Clear();
            this.txtNomer.DataBindings.Clear();
        }

        static string GenerateRandomNonRepetitiveString(int size)
        {
            Random random = new Random();
            const string chars = "123456789abcdef";
            char[] hexChars = new char[size];

            for (int i = 0; i < size; i++)
            {
                hexChars[i] = chars[random.Next(chars.Length)];

            }

            return new string(hexChars);

        }

        private void Pembeli_Load(object sender, EventArgs e)
        {

        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtJK_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtAlamat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNomer_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Form1 mu = new Form1();
            mu.ShowDialog();
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAkhir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            Pembeli pb = new Pembeli();
            pb.Show();
            this.Hide();
        }

        private void DataPegawai_Click(object sender, EventArgs e)
        {
            Pegawai pg = new Pegawai();
            pg.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Obat ob = new Obat();
            ob.Show();
            this.Hide();
        }

        private void DataPelayanan_Click(object sender, EventArgs e)
        {
            Pelayanan pln = new Pelayanan();
            pln.Show();
            this.Hide();
        }

        private void DataPembelian_Click(object sender, EventArgs e)
        {
            Pembelian pbn = new Pembelian();
            pbn.Show();
            this.Hide();
        }

        private void DataPemasokkan_Click(object sender, EventArgs e)
        {

            Pemasok pmn = new Pemasok();
            pmn.Show();
            this.Hide();
        }

        private void DataSupplier_Click(object sender, EventArgs e)
        {
            Supplier sp = new Supplier();
            sp.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Gudang gd = new Gudang();
            gd.Show();
            this.Hide();
        }
    }
}

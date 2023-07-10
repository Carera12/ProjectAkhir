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
            Supplier sp = new Supplier();
            sp.ShowDialog();
            this.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataPembeliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pembeli pb = new Pembeli();
            pb.ShowDialog();
            this.Close();

        }

        private void dataPegawaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pegawai pg = new Pegawai();
            pg.Show();
            this.Hide();
        }

        private void dataObatToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Obat ob = new Obat();
            ob.ShowDialog();

            this.Close();
        }

        private void dataGudangToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Gudang gd = new Gudang();
            gd.ShowDialog();
            this.Close();
        }

        private void dataTransaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
 
            Pembelian pbn = new Pembelian();
            pbn.ShowDialog();
            this.Close();
        }

        private void dataPelayananToolStripMenuItem_Click(object sender, EventArgs e)
        {
 
            Pelayanan pln = new Pelayanan();
            pln.ShowDialog();
            this.Close();
        }

        private void dataPemasokanToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Pemasokkan pmn = new Pemasokkan();
            pmn.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

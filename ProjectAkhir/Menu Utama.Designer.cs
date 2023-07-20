namespace ProjectAkhir
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DataGudang = new System.Windows.Forms.Button();
            this.DataSupplier = new System.Windows.Forms.Button();
            this.DataPemasokkan = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.DataPelayanan = new System.Windows.Forms.Button();
            this.DataPembelian = new System.Windows.Forms.Button();
            this.DataPembeli = new System.Windows.Forms.Button();
            this.DataPegawai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DataGudang
            // 
            this.DataGudang.BackColor = System.Drawing.Color.LemonChiffon;
            this.DataGudang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DataGudang.BackgroundImage")));
            this.DataGudang.Location = new System.Drawing.Point(533, 270);
            this.DataGudang.Name = "DataGudang";
            this.DataGudang.Size = new System.Drawing.Size(144, 72);
            this.DataGudang.TabIndex = 8;
            this.DataGudang.Text = "Gudang";
            this.DataGudang.UseVisualStyleBackColor = false;
            this.DataGudang.Click += new System.EventHandler(this.button8_Click);
            // 
            // DataSupplier
            // 
            this.DataSupplier.BackColor = System.Drawing.Color.LemonChiffon;
            this.DataSupplier.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DataSupplier.BackgroundImage")));
            this.DataSupplier.Location = new System.Drawing.Point(334, 315);
            this.DataSupplier.Name = "DataSupplier";
            this.DataSupplier.Size = new System.Drawing.Size(144, 72);
            this.DataSupplier.TabIndex = 7;
            this.DataSupplier.Text = "Supplier";
            this.DataSupplier.UseVisualStyleBackColor = false;
            this.DataSupplier.Click += new System.EventHandler(this.DataSupplier_Click);
            // 
            // DataPemasokkan
            // 
            this.DataPemasokkan.BackColor = System.Drawing.Color.LemonChiffon;
            this.DataPemasokkan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DataPemasokkan.BackgroundImage")));
            this.DataPemasokkan.Location = new System.Drawing.Point(126, 270);
            this.DataPemasokkan.Name = "DataPemasokkan";
            this.DataPemasokkan.Size = new System.Drawing.Size(144, 72);
            this.DataPemasokkan.TabIndex = 6;
            this.DataPemasokkan.Text = "Pemasokkan";
            this.DataPemasokkan.UseVisualStyleBackColor = false;
            this.DataPemasokkan.Click += new System.EventHandler(this.DataPemasokkan_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LemonChiffon;
            this.button5.Location = new System.Drawing.Point(330, 53);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(144, 72);
            this.button5.TabIndex = 5;
            this.button5.Text = "Obat";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // DataPelayanan
            // 
            this.DataPelayanan.BackColor = System.Drawing.Color.LemonChiffon;
            this.DataPelayanan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DataPelayanan.BackgroundImage")));
            this.DataPelayanan.Location = new System.Drawing.Point(210, 181);
            this.DataPelayanan.Name = "DataPelayanan";
            this.DataPelayanan.Size = new System.Drawing.Size(144, 72);
            this.DataPelayanan.TabIndex = 4;
            this.DataPelayanan.Text = "Pelayanan";
            this.DataPelayanan.UseVisualStyleBackColor = false;
            this.DataPelayanan.Click += new System.EventHandler(this.DataPelayanan_Click);
            // 
            // DataPembelian
            // 
            this.DataPembelian.BackColor = System.Drawing.Color.LemonChiffon;
            this.DataPembelian.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DataPembelian.BackgroundImage")));
            this.DataPembelian.Location = new System.Drawing.Point(422, 181);
            this.DataPembelian.Name = "DataPembelian";
            this.DataPembelian.Size = new System.Drawing.Size(144, 72);
            this.DataPembelian.TabIndex = 3;
            this.DataPembelian.Text = "Pembelian";
            this.DataPembelian.UseVisualStyleBackColor = false;
            this.DataPembelian.Click += new System.EventHandler(this.DataPembelian_Click);
            // 
            // DataPembeli
            // 
            this.DataPembeli.BackColor = System.Drawing.Color.LemonChiffon;
            this.DataPembeli.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DataPembeli.BackgroundImage")));
            this.DataPembeli.Location = new System.Drawing.Point(122, 91);
            this.DataPembeli.Name = "DataPembeli";
            this.DataPembeli.Size = new System.Drawing.Size(144, 72);
            this.DataPembeli.TabIndex = 2;
            this.DataPembeli.Text = "Pembeli";
            this.DataPembeli.UseVisualStyleBackColor = false;
            this.DataPembeli.Click += new System.EventHandler(this.button2_Click);
            // 
            // DataPegawai
            // 
            this.DataPegawai.BackColor = System.Drawing.Color.LemonChiffon;
            this.DataPegawai.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DataPegawai.BackgroundImage")));
            this.DataPegawai.Location = new System.Drawing.Point(529, 91);
            this.DataPegawai.Name = "DataPegawai";
            this.DataPegawai.Size = new System.Drawing.Size(144, 72);
            this.DataPegawai.TabIndex = 1;
            this.DataPegawai.Text = "Pegawai";
            this.DataPegawai.UseVisualStyleBackColor = false;
            this.DataPegawai.Click += new System.EventHandler(this.DataPegawai_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataGudang);
            this.Controls.Add(this.DataSupplier);
            this.Controls.Add(this.DataPemasokkan);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.DataPelayanan);
            this.Controls.Add(this.DataPembelian);
            this.Controls.Add(this.DataPembeli);
            this.Controls.Add(this.DataPegawai);
            this.Name = "Form1";
            this.Text = "Menu Utama";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button DataPegawai;
        private System.Windows.Forms.Button DataPembeli;
        private System.Windows.Forms.Button DataPembelian;
        private System.Windows.Forms.Button DataPelayanan;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button DataPemasokkan;
        private System.Windows.Forms.Button DataSupplier;
        private System.Windows.Forms.Button DataGudang;
    }
}


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
            this.DataGudang = new System.Windows.Forms.Button();
            this.DataSupplier = new System.Windows.Forms.Button();
            this.DataPemasokkan = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.DataPelayanan = new System.Windows.Forms.Button();
            this.DataPembelian = new System.Windows.Forms.Button();
            this.DataPembeli = new System.Windows.Forms.Button();
            this.DataPegawai = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DataGudang
            // 
            this.DataGudang.BackColor = System.Drawing.Color.LemonChiffon;
            this.DataGudang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGudang.Image = global::ProjectAkhir.Properties.Resources.warehouse;
            this.DataGudang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DataGudang.Location = new System.Drawing.Point(226, 270);
            this.DataGudang.Name = "DataGudang";
            this.DataGudang.Size = new System.Drawing.Size(159, 114);
            this.DataGudang.TabIndex = 8;
            this.DataGudang.Text = "Gudang";
            this.DataGudang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DataGudang.UseVisualStyleBackColor = false;
            this.DataGudang.Click += new System.EventHandler(this.button8_Click);
            // 
            // DataSupplier
            // 
            this.DataSupplier.BackColor = System.Drawing.Color.LemonChiffon;
            this.DataSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataSupplier.Image = global::ProjectAkhir.Properties.Resources.agreement;
            this.DataSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DataSupplier.Location = new System.Drawing.Point(52, 270);
            this.DataSupplier.Name = "DataSupplier";
            this.DataSupplier.Size = new System.Drawing.Size(159, 114);
            this.DataSupplier.TabIndex = 7;
            this.DataSupplier.Text = "Supplier";
            this.DataSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DataSupplier.UseVisualStyleBackColor = false;
            this.DataSupplier.Click += new System.EventHandler(this.DataSupplier_Click);
            // 
            // DataPemasokkan
            // 
            this.DataPemasokkan.BackColor = System.Drawing.Color.LemonChiffon;
            this.DataPemasokkan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataPemasokkan.Image = global::ProjectAkhir.Properties.Resources.delivery_box;
            this.DataPemasokkan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DataPemasokkan.Location = new System.Drawing.Point(600, 270);
            this.DataPemasokkan.Name = "DataPemasokkan";
            this.DataPemasokkan.Size = new System.Drawing.Size(159, 114);
            this.DataPemasokkan.TabIndex = 6;
            this.DataPemasokkan.Text = "Pemasokkan";
            this.DataPemasokkan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DataPemasokkan.UseVisualStyleBackColor = false;
            this.DataPemasokkan.Click += new System.EventHandler(this.DataPemasokkan_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LemonChiffon;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = global::ProjectAkhir.Properties.Resources.medicine;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(409, 135);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(159, 114);
            this.button5.TabIndex = 5;
            this.button5.Text = "Obat";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // DataPelayanan
            // 
            this.DataPelayanan.BackColor = System.Drawing.Color.LemonChiffon;
            this.DataPelayanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataPelayanan.Image = global::ProjectAkhir.Properties.Resources.customer;
            this.DataPelayanan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DataPelayanan.Location = new System.Drawing.Point(600, 135);
            this.DataPelayanan.Name = "DataPelayanan";
            this.DataPelayanan.Size = new System.Drawing.Size(159, 114);
            this.DataPelayanan.TabIndex = 4;
            this.DataPelayanan.Text = "Pelayanan";
            this.DataPelayanan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DataPelayanan.UseVisualStyleBackColor = false;
            this.DataPelayanan.Click += new System.EventHandler(this.DataPelayanan_Click);
            // 
            // DataPembelian
            // 
            this.DataPembelian.BackColor = System.Drawing.Color.LemonChiffon;
            this.DataPembelian.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataPembelian.Image = global::ProjectAkhir.Properties.Resources.cart;
            this.DataPembelian.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DataPembelian.Location = new System.Drawing.Point(409, 270);
            this.DataPembelian.Name = "DataPembelian";
            this.DataPembelian.Size = new System.Drawing.Size(159, 114);
            this.DataPembelian.TabIndex = 3;
            this.DataPembelian.Text = "Pembelian";
            this.DataPembelian.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DataPembelian.UseVisualStyleBackColor = false;
            this.DataPembelian.Click += new System.EventHandler(this.DataPembelian_Click);
            // 
            // DataPembeli
            // 
            this.DataPembeli.BackColor = System.Drawing.Color.LemonChiffon;
            this.DataPembeli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataPembeli.Image = global::ProjectAkhir.Properties.Resources.user;
            this.DataPembeli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DataPembeli.Location = new System.Drawing.Point(52, 135);
            this.DataPembeli.Name = "DataPembeli";
            this.DataPembeli.Size = new System.Drawing.Size(159, 114);
            this.DataPembeli.TabIndex = 2;
            this.DataPembeli.Text = "Pembeli";
            this.DataPembeli.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DataPembeli.UseVisualStyleBackColor = false;
            this.DataPembeli.Click += new System.EventHandler(this.button2_Click);
            // 
            // DataPegawai
            // 
            this.DataPegawai.BackColor = System.Drawing.Color.LemonChiffon;
            this.DataPegawai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataPegawai.Image = global::ProjectAkhir.Properties.Resources.user;
            this.DataPegawai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DataPegawai.Location = new System.Drawing.Point(226, 135);
            this.DataPegawai.Name = "DataPegawai";
            this.DataPegawai.Size = new System.Drawing.Size(159, 114);
            this.DataPegawai.TabIndex = 1;
            this.DataPegawai.Text = "Pegawai";
            this.DataPegawai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DataPegawai.UseVisualStyleBackColor = false;
            this.DataPegawai.Click += new System.EventHandler(this.DataPegawai_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(160, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 54);
            this.label1.TabIndex = 9;
            this.label1.Text = "Apotek Cemara";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.BackgroundImage = global::ProjectAkhir.Properties.Resources.logoapotekcemara;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
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
            this.PerformLayout();

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
        private System.Windows.Forms.Label label1;
    }
}


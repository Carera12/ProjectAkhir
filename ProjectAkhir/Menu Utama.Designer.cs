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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.dataPembeliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataPegawaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataObatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGudangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataTransaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataPelayananToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataPemasokanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // dataPembeliToolStripMenuItem
            // 
            this.dataPembeliToolStripMenuItem.Name = "dataPembeliToolStripMenuItem";
            this.dataPembeliToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dataPembeliToolStripMenuItem.Text = "Data Pembeli";
            // 
            // dataPegawaiToolStripMenuItem
            // 
            this.dataPegawaiToolStripMenuItem.Name = "dataPegawaiToolStripMenuItem";
            this.dataPegawaiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dataPegawaiToolStripMenuItem.Text = "Data Pegawai";
            // 
            // dataObatToolStripMenuItem
            // 
            this.dataObatToolStripMenuItem.Name = "dataObatToolStripMenuItem";
            this.dataObatToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dataObatToolStripMenuItem.Text = "Data Obat";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dataToolStripMenuItem.Text = "Data Suplier";
            this.dataToolStripMenuItem.Click += new System.EventHandler(this.dataToolStripMenuItem_Click);
            // 
            // dataGudangToolStripMenuItem
            // 
            this.dataGudangToolStripMenuItem.Name = "dataGudangToolStripMenuItem";
            this.dataGudangToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dataGudangToolStripMenuItem.Text = "Data Gudang";
            // 
            // dataTransaksiToolStripMenuItem
            // 
            this.dataTransaksiToolStripMenuItem.Name = "dataTransaksiToolStripMenuItem";
            this.dataTransaksiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dataTransaksiToolStripMenuItem.Text = "Data Pembelian";
            // 
            // dataPelayananToolStripMenuItem
            // 
            this.dataPelayananToolStripMenuItem.Name = "dataPelayananToolStripMenuItem";
            this.dataPelayananToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dataPelayananToolStripMenuItem.Text = "Data Pelayanan";
            // 
            // dataPemasokanToolStripMenuItem
            // 
            this.dataPemasokanToolStripMenuItem.Name = "dataPemasokanToolStripMenuItem";
            this.dataPemasokanToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dataPemasokanToolStripMenuItem.Text = "Data Pemasokan";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataPembeliToolStripMenuItem,
            this.dataPegawaiToolStripMenuItem,
            this.dataObatToolStripMenuItem,
            this.dataToolStripMenuItem,
            this.dataGudangToolStripMenuItem,
            this.dataTransaksiToolStripMenuItem,
            this.dataPelayananToolStripMenuItem,
            this.dataPemasokanToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(162, 24);
            this.toolStripDropDownButton1.Text = "Data Apotek Cemara";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Menu Utama";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem dataPembeliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataPegawaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataObatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataGudangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataTransaksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataPelayananToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataPemasokanToolStripMenuItem;
    }
}


namespace ProjectAkhir
{
    partial class Pemasokkan
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelObat = new System.Windows.Forms.Label();
            this.cbIDSupplier = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtJumPema = new System.Windows.Forms.TextBox();
            this.txtIDPema = new System.Windows.Forms.TextBox();
            this.cmbNamaObat = new System.Windows.Forms.ComboBox();
            this.cmbNamaSup = new System.Windows.Forms.ComboBox();
            this.dtTP = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(580, 209);
            this.dataGridView1.TabIndex = 0;
            // 
            // labelObat
            // 
            this.labelObat.AutoSize = true;
            this.labelObat.Location = new System.Drawing.Point(371, 321);
            this.labelObat.Name = "labelObat";
            this.labelObat.Size = new System.Drawing.Size(76, 16);
            this.labelObat.TabIndex = 1;
            this.labelObat.Text = "Nama Obat";
            // 
            // cbIDSupplier
            // 
            this.cbIDSupplier.AutoSize = true;
            this.cbIDSupplier.Location = new System.Drawing.Point(371, 275);
            this.cbIDSupplier.Name = "cbIDSupplier";
            this.cbIDSupplier.Size = new System.Drawing.Size(97, 16);
            this.cbIDSupplier.TabIndex = 2;
            this.cbIDSupplier.Text = "Nama Supplier";
            this.cbIDSupplier.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tanggal Pemasokkan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Jumlah Pemasokkan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "ID Pemasokkan";
            // 
            // btnOpen
            // 
            this.btnOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOpen.Location = new System.Drawing.Point(653, 48);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(55, 32);
            this.btnOpen.TabIndex = 6;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(653, 159);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(55, 27);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(653, 105);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(55, 32);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(653, 203);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(55, 29);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(21, 405);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtJumPema
            // 
            this.txtJumPema.Location = new System.Drawing.Point(192, 318);
            this.txtJumPema.Name = "txtJumPema";
            this.txtJumPema.Size = new System.Drawing.Size(135, 22);
            this.txtJumPema.TabIndex = 12;
            // 
            // txtIDPema
            // 
            this.txtIDPema.Location = new System.Drawing.Point(192, 272);
            this.txtIDPema.Name = "txtIDPema";
            this.txtIDPema.Size = new System.Drawing.Size(135, 22);
            this.txtIDPema.TabIndex = 13;
            // 
            // cmbNamaObat
            // 
            this.cmbNamaObat.FormattingEnabled = true;
            this.cmbNamaObat.Location = new System.Drawing.Point(474, 318);
            this.cmbNamaObat.Name = "cmbNamaObat";
            this.cmbNamaObat.Size = new System.Drawing.Size(142, 24);
            this.cmbNamaObat.TabIndex = 14;
            // 
            // cmbNamaSup
            // 
            this.cmbNamaSup.FormattingEnabled = true;
            this.cmbNamaSup.Location = new System.Drawing.Point(474, 272);
            this.cmbNamaSup.Name = "cmbNamaSup";
            this.cmbNamaSup.Size = new System.Drawing.Size(142, 24);
            this.cmbNamaSup.TabIndex = 15;
            // 
            // dtTP
            // 
            this.dtTP.Location = new System.Drawing.Point(356, 368);
            this.dtTP.Name = "dtTP";
            this.dtTP.Size = new System.Drawing.Size(200, 22);
            this.dtTP.TabIndex = 16;
            // 
            // Pemasokkan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtTP);
            this.Controls.Add(this.cmbNamaSup);
            this.Controls.Add(this.cmbNamaObat);
            this.Controls.Add(this.txtIDPema);
            this.Controls.Add(this.txtJumPema);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbIDSupplier);
            this.Controls.Add(this.labelObat);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Pemasokkan";
            this.Text = "Pemasokkan";
            this.Load += new System.EventHandler(this.Pemasokkan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelObat;
        private System.Windows.Forms.Label cbIDSupplier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtJumPema;
        private System.Windows.Forms.TextBox txtIDPema;
        private System.Windows.Forms.ComboBox cmbNamaObat;
        private System.Windows.Forms.ComboBox cmbNamaSup;
        private System.Windows.Forms.DateTimePicker dtTP;
    }
}
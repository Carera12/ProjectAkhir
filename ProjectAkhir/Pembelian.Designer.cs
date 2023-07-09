namespace ProjectAkhir
{
    partial class Pembelian
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtTotBay = new System.Windows.Forms.TextBox();
            this.txtJumPembe = new System.Windows.Forms.TextBox();
            this.txtIDPemb = new System.Windows.Forms.TextBox();
            this.txttglPembe = new System.Windows.Forms.TextBox();
            this.cmbIDPemb = new System.Windows.Forms.ComboBox();
            this.cmbObat = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(98, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(517, 226);
            this.dataGridView1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID Obat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID Pembeli";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tanggal Pembelian";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Total Bayar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Jumlah pembelian";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(95, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "ID Pembelian";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(642, 200);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(54, 36);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(642, 145);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(54, 33);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(642, 39);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(54, 31);
            this.btnOpen.TabIndex = 11;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(642, 96);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(54, 29);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(17, 403);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(64, 35);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtTotBay
            // 
            this.txtTotBay.Location = new System.Drawing.Point(220, 333);
            this.txtTotBay.Name = "txtTotBay";
            this.txtTotBay.Size = new System.Drawing.Size(116, 22);
            this.txtTotBay.TabIndex = 14;
            // 
            // txtJumPembe
            // 
            this.txtJumPembe.Location = new System.Drawing.Point(220, 298);
            this.txtJumPembe.Name = "txtJumPembe";
            this.txtJumPembe.Size = new System.Drawing.Size(116, 22);
            this.txtJumPembe.TabIndex = 15;
            // 
            // txtIDPemb
            // 
            this.txtIDPemb.Location = new System.Drawing.Point(220, 261);
            this.txtIDPemb.Name = "txtIDPemb";
            this.txtIDPemb.Size = new System.Drawing.Size(116, 22);
            this.txtIDPemb.TabIndex = 16;
            // 
            // txttglPembe
            // 
            this.txttglPembe.Location = new System.Drawing.Point(494, 261);
            this.txttglPembe.Name = "txttglPembe";
            this.txttglPembe.Size = new System.Drawing.Size(121, 22);
            this.txttglPembe.TabIndex = 17;
            // 
            // cmbIDPemb
            // 
            this.cmbIDPemb.FormattingEnabled = true;
            this.cmbIDPemb.Location = new System.Drawing.Point(494, 298);
            this.cmbIDPemb.Name = "cmbIDPemb";
            this.cmbIDPemb.Size = new System.Drawing.Size(121, 24);
            this.cmbIDPemb.TabIndex = 18;
            // 
            // cmbObat
            // 
            this.cmbObat.FormattingEnabled = true;
            this.cmbObat.Location = new System.Drawing.Point(494, 333);
            this.cmbObat.Name = "cmbObat";
            this.cmbObat.Size = new System.Drawing.Size(121, 24);
            this.cmbObat.TabIndex = 19;
            // 
            // Pembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbObat);
            this.Controls.Add(this.cmbIDPemb);
            this.Controls.Add(this.txttglPembe);
            this.Controls.Add(this.txtIDPemb);
            this.Controls.Add(this.txtJumPembe);
            this.Controls.Add(this.txtTotBay);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Pembelian";
            this.Text = "Pembelian";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtTotBay;
        private System.Windows.Forms.TextBox txtJumPembe;
        private System.Windows.Forms.TextBox txtIDPemb;
        private System.Windows.Forms.TextBox txttglPembe;
        private System.Windows.Forms.ComboBox cmbIDPemb;
        private System.Windows.Forms.ComboBox cmbObat;
    }
}
namespace LatihanGitHub_Rara
{
    partial class FormSiswa
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
            this.lblNama = new System.Windows.Forms.Label();
            this.txtNisn = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.btnTutup = new System.Windows.Forms.Button();
            this.dgvSiswa = new System.Windows.Forms.DataGridView();
            this.lblSiswa = new System.Windows.Forms.Label();
            this.clmNisn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAlamat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiswa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(176, 94);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(47, 20);
            this.lblNama.TabIndex = 0;
            this.lblNama.Text = "NISN";
            this.lblNama.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNisn
            // 
            this.txtNisn.Location = new System.Drawing.Point(323, 94);
            this.txtNisn.Name = "txtNisn";
            this.txtNisn.Size = new System.Drawing.Size(172, 26);
            this.txtNisn.TabIndex = 1;
            this.txtNisn.TextChanged += new System.EventHandler(this.txtNisn_TextChanged);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(212, 231);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(101, 38);
            this.btnSimpan.TabIndex = 2;
            this.btnSimpan.Text = "SIMPAN";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "NAMA";
            // 
            // lblAlamat
            // 
            this.lblAlamat.AutoSize = true;
            this.lblAlamat.Location = new System.Drawing.Point(176, 167);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.Size = new System.Drawing.Size(73, 20);
            this.lblAlamat.TabIndex = 4;
            this.lblAlamat.Text = "ALAMAT";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(323, 130);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(172, 26);
            this.txtNama.TabIndex = 5;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(323, 167);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(172, 26);
            this.txtAlamat.TabIndex = 6;
            this.txtAlamat.TextChanged += new System.EventHandler(this.txtAlamat_TextChanged);
            // 
            // btnTutup
            // 
            this.btnTutup.Location = new System.Drawing.Point(350, 231);
            this.btnTutup.Name = "btnTutup";
            this.btnTutup.Size = new System.Drawing.Size(104, 38);
            this.btnTutup.TabIndex = 7;
            this.btnTutup.Text = "TUTUP";
            this.btnTutup.UseVisualStyleBackColor = true;
            this.btnTutup.Click += new System.EventHandler(this.btnTutup_Click);
            // 
            // dgvSiswa
            // 
            this.dgvSiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiswa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmNisn,
            this.clmNama,
            this.clmAlamat});
            this.dgvSiswa.Location = new System.Drawing.Point(33, 292);
            this.dgvSiswa.Name = "dgvSiswa";
            this.dgvSiswa.RowHeadersWidth = 62;
            this.dgvSiswa.RowTemplate.Height = 28;
            this.dgvSiswa.Size = new System.Drawing.Size(559, 150);
            this.dgvSiswa.TabIndex = 8;
            // 
            // lblSiswa
            // 
            this.lblSiswa.AutoSize = true;
            this.lblSiswa.Location = new System.Drawing.Point(289, 31);
            this.lblSiswa.Name = "lblSiswa";
            this.lblSiswa.Size = new System.Drawing.Size(109, 20);
            this.lblSiswa.TabIndex = 9;
            this.lblSiswa.Text = "DATA SISWA";
            // 
            // clmNisn
            // 
            this.clmNisn.HeaderText = "NISN";
            this.clmNisn.MinimumWidth = 8;
            this.clmNisn.Name = "clmNisn";
            // 
            // clmNama
            // 
            this.clmNama.HeaderText = "NAMA";
            this.clmNama.MinimumWidth = 8;
            this.clmNama.Name = "clmNama";
            this.clmNama.Width = 150;
            // 
            // clmAlamat
            // 
            this.clmAlamat.HeaderText = "ALAMAT";
            this.clmAlamat.MinimumWidth = 8;
            this.clmAlamat.Name = "clmAlamat";
            this.clmAlamat.Width = 150;
            // 
            // FormSiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 531);
            this.Controls.Add(this.lblSiswa);
            this.Controls.Add(this.dgvSiswa);
            this.Controls.Add(this.btnTutup);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.lblAlamat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtNisn);
            this.Controls.Add(this.lblNama);
            this.Name = "FormSiswa";
            this.Text = "FormSiswa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiswa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.TextBox txtNisn;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAlamat;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Button btnTutup;
        private System.Windows.Forms.DataGridView dgvSiswa;
        private System.Windows.Forms.Label lblSiswa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNisn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAlamat;
    }
}
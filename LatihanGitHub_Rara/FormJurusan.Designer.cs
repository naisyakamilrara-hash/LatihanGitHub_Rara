namespace LatihanGitHub_Rara
{
    partial class FormJurusan
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
            this.lblJurusan = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.lbljurusanSiswa = new System.Windows.Forms.Label();
            this.cmdJurusan = new System.Windows.Forms.ComboBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnTutup = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jurusan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(51, 44);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(44, 16);
            this.lblNama.TabIndex = 0;
            this.lblNama.Text = "Nama";
            this.lblNama.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblJurusan
            // 
            this.lblJurusan.AutoSize = true;
            this.lblJurusan.Location = new System.Drawing.Point(51, 79);
            this.lblJurusan.Name = "lblJurusan";
            this.lblJurusan.Size = new System.Drawing.Size(54, 16);
            this.lblJurusan.TabIndex = 1;
            this.lblJurusan.Text = "Jurusan";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(131, 44);
            this.txtNama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(196, 22);
            this.txtNama.TabIndex = 2;
            // 
            // lbljurusanSiswa
            // 
            this.lbljurusanSiswa.AutoSize = true;
            this.lbljurusanSiswa.Location = new System.Drawing.Point(141, 9);
            this.lbljurusanSiswa.Name = "lbljurusanSiswa";
            this.lbljurusanSiswa.Size = new System.Drawing.Size(93, 16);
            this.lbljurusanSiswa.TabIndex = 3;
            this.lbljurusanSiswa.Text = "Jurusan Siswa";
            this.lbljurusanSiswa.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // cmdJurusan
            // 
            this.cmdJurusan.FormattingEnabled = true;
            this.cmdJurusan.Items.AddRange(new object[] {
            "RPL",
            "TKJ",
            "Multimedia",
            ""});
            this.cmdJurusan.Location = new System.Drawing.Point(131, 79);
            this.cmdJurusan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdJurusan.Name = "cmdJurusan";
            this.cmdJurusan.Size = new System.Drawing.Size(191, 24);
            this.cmdJurusan.TabIndex = 4;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(105, 120);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(73, 33);
            this.btnSimpan.TabIndex = 5;
            this.btnSimpan.Text = "SIMPAN";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnTutup
            // 
            this.btnTutup.Location = new System.Drawing.Point(198, 120);
            this.btnTutup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTutup.Name = "btnTutup";
            this.btnTutup.Size = new System.Drawing.Size(70, 33);
            this.btnTutup.TabIndex = 6;
            this.btnTutup.Text = "TUTUP";
            this.btnTutup.UseVisualStyleBackColor = true;
            this.btnTutup.Click += new System.EventHandler(this.btnTutup_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nama,
            this.Jurusan});
            this.dataGridView1.Location = new System.Drawing.Point(13, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(348, 151);
            this.dataGridView1.TabIndex = 7;
            // 
            // Nama
            // 
            this.Nama.HeaderText = "Nama";
            this.Nama.MinimumWidth = 6;
            this.Nama.Name = "Nama";
            this.Nama.Width = 125;
            // 
            // Jurusan
            // 
            this.Jurusan.HeaderText = "Jurusan";
            this.Jurusan.MinimumWidth = 6;
            this.Jurusan.Name = "Jurusan";
            this.Jurusan.Width = 125;
            // 
            // FormJurusan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 357);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnTutup);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.cmdJurusan);
            this.Controls.Add(this.lbljurusanSiswa);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.lblJurusan);
            this.Controls.Add(this.lblNama);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormJurusan";
            this.Text = "FormJurusan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblJurusan;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label lbljurusanSiswa;
        private System.Windows.Forms.ComboBox cmdJurusan;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnTutup;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jurusan;
    }
}
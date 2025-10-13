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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnKembali = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(12, 55);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(51, 20);
            this.lblNama.TabIndex = 0;
            this.lblNama.Text = "Nama";
            this.lblNama.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblJurusan
            // 
            this.lblJurusan.AutoSize = true;
            this.lblJurusan.Location = new System.Drawing.Point(12, 99);
            this.lblJurusan.Name = "lblJurusan";
            this.lblJurusan.Size = new System.Drawing.Size(66, 20);
            this.lblJurusan.TabIndex = 1;
            this.lblJurusan.Text = "Jurusan";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(102, 55);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(323, 26);
            this.txtNama.TabIndex = 2;
            // 
            // lbljurusanSiswa
            // 
            this.lbljurusanSiswa.AutoSize = true;
            this.lbljurusanSiswa.Location = new System.Drawing.Point(154, 9);
            this.lbljurusanSiswa.Name = "lbljurusanSiswa";
            this.lbljurusanSiswa.Size = new System.Drawing.Size(112, 20);
            this.lbljurusanSiswa.TabIndex = 3;
            this.lbljurusanSiswa.Text = "Jurusan Siswa";
            this.lbljurusanSiswa.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "RPL",
            "TKJ",
            "Multimedia",
            ""});
            this.comboBox1.Location = new System.Drawing.Point(102, 99);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(105, 28);
            this.comboBox1.TabIndex = 4;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(102, 165);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 27);
            this.btnSimpan.TabIndex = 5;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(191, 165);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 27);
            this.btnHapus.TabIndex = 6;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(286, 165);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(75, 27);
            this.btnKembali.TabIndex = 7;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // FormJurusan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 277);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbljurusanSiswa);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.lblJurusan);
            this.Controls.Add(this.lblNama);
            this.Name = "FormJurusan";
            this.Text = "FormJurusan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblJurusan;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label lbljurusanSiswa;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnKembali;
    }
}
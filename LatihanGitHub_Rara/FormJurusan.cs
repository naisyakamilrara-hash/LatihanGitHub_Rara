using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatihanGitHub_Rara
{
    public partial class FormJurusan : Form
    {
        public FormJurusan()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            DialogResult pilih = MessageBox.Show("Simpan Data?", "Konfirmasi", MessageBoxButtons.YesNo);

            if (pilih == DialogResult.Yes)
            {
                String[] data = {txtNama.Text, cmdJurusan.Text };

                dataGridView1.Rows.Add(data);

                MessageBox.Show("Simpan Berhasil!");
                txtNama.Clear();
                cmdJurusan.SelectedIndex = -1;
                txtNama.Focus();
            }
            if (pilih == DialogResult.No)
            {
                MessageBox.Show("Simpan Dibatalkan!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnKembali_Click(object sender, EventArgs e)
        {

        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            DialogResult pilih = MessageBox.Show("Tututp Form?", "Konfirmasi", MessageBoxButtons.YesNo);

            if (pilih == DialogResult.Yes)
            {
                Close();
            }
            if (pilih == DialogResult.No)
            {
            }
        }
    }
}

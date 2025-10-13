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
    public partial class FormSiswa : Form
    {
        public FormSiswa()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtAlamat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNisn_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            DialogResult pilih = MessageBox.Show("Simpan Data?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (pilih == DialogResult.Yes)
            {
                String[] data = { txtNisn.Text, txtNama.Text, txtAlamat.Text };
                dgvSiswa.Rows.Add(data); MessageBox.Show("Simpan Berhasil!");
                txtNisn.Clear(); txtNama.Clear(); txtAlamat.Clear(); txtNisn.Focus();
            }
            if (pilih == DialogResult.No)
            {
                MessageBox.Show("Simpan Dibatalkan!");
            }
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

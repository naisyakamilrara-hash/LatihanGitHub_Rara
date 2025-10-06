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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pilihan = MessageBox.Show("Tutup form?",
                "konfirmasi", MessageBoxButtons.YesNo);

            if (pilihan == DialogResult.Yes) ;
            {
                Close();
            }

            if (pilihan == DialogResult.No) ;
            {
                Close();
            }

        }
    }
}

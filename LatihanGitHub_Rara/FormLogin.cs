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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            txtPassword.PasswordChar = '♡';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("username tidak boleh kosong!!");
                txtUsername.Focus();
                return;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Password tidak boleh kosong!!");
                txtPassword.Focus();
                return;
            }
            if (txtUsername.Text == "Rara" && txtPassword.Text == "020208")
            {
                MessageBox.Show("Login Berhasil!!");
                FormMenu fd = new FormMenu();
                fd.ShowDialog();
                txtUsername.Clear();
                txtPassword.Clear();

            }
            if (txtUsername.Text == "Aura" && txtPassword.Text == "150208")
            {
                MessageBox.Show("Login Berhasil!!");
                FormMenu fd = new FormMenu();
                fd.ShowDialog();
                txtUsername.Clear();
                txtPassword.Clear();
            }
            if (txtUsername.Text == "Tata" && txtPassword.Text == "030508")
            {
                MessageBox.Show("Login Berhasil!!");
                FormMenu fd = new FormMenu();
                fd.ShowDialog();
                txtUsername.Clear();
                txtPassword.Clear();
            }
            if (txtUsername.Text == "Yasmin" && txtPassword.Text == "271208")
            {
                MessageBox.Show("Login Berhasil!!");
                FormMenu fd = new FormMenu();
                fd.ShowDialog();
                txtUsername.Clear();
                txtPassword.Clear();
            }
            else
            {
                MessageBox.Show("Login Gagal!");
                txtUsername.Text = "";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

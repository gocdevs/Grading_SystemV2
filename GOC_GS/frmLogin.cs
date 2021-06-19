using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOC_GS
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Equals("Admin") && txtPassword.Text.Equals("123456"))
            {
                MessageBox.Show("Welcome!");
                frmMain frm = new frmMain();
                frm.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Username or Password not found ");
                txtUserName.Focus();
                return;
            }
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(this, new EventArgs());
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(this, new EventArgs());
            }
        }
    }
}

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
    public partial class frmConnectionSettings : Form
    {
        public frmConnectionSettings()
        {
            InitializeComponent();
        }

        private void GetServerSettings()
        {
            txtDSN.Text = GOC_GS.Config.DSN;
            txtHost.Text = GOC_GS.Config.DB_HOST;
            txtName.Text = GOC_GS.Config.DB_NAME;
            txtUser.Text = GOC_GS.Config.DB_USER;
            txtPassword.Text = GOC_GS.Config.DB_PASSWORD;
        }

        private bool CheckRequiredFields()
        {
            if (txtDSN.Text == "")
            {
                return false;
            }

            if (txtHost.Text == "")
            {
                return false;
            }

            if (txtName.Text == "")
            {
                return false;
            }

            if (txtUser.Text == "")
            {
                return false;
            }

            return true;
        }

        public void setThis()
        {
            if (this.CheckRequiredFields() == true)
            {
                //set properties
                GOC_GS.Config.DSN = txtDSN.Text;
                GOC_GS.Config.DB_HOST = txtHost.Text;
                GOC_GS.Config.DB_NAME = txtName.Text;
                GOC_GS.Config.DB_USER = txtUser.Text;
                GOC_GS.Config.DB_PASSWORD = txtPassword.Text;

                //save settings
                GOC_GS.Config.saveSettings();

                if (GOC_GS.Config.TestConnection())
                {
                    MessageBox.Show("Successfully Connected to Database", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //if (flag == "Client")
                    //{
                    //    frmFrontMain frmFrontMain = new frmFrontMain();
                    //    frmFrontMain.ShowDialog();
                    //    this.Dispose();
                    //    this.Close();
                    //}
                }
            }
            else
            {
                MessageBox.Show("Please fill out all required fields", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frmConnectionSettings_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                this.Dispose();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                btnSaveConfiguration.PerformClick();
            }
        }

        private void btnSaveConfiguration_Click(object sender, EventArgs e)
        {
            setThis();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

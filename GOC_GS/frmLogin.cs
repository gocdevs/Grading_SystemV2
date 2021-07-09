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
        Users user = new Users();
        List<Users> users = new List<Users>();

        public string UserType, Full_Name, Teacher_Id;
        public bool Flag;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text) && string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please enter your Username and Password.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
                return;
            }
            else
            {
                //clear list
                users.Clear();
                //pass value
                user.User_id = txtUserName.Text;
                user.Password = txtPassword.Text;
                users = user.GetUserType();

                foreach (var item in users)
                {
                    //pass variable to form Assesment                   
                    UserType = item.User_type;
                    Full_Name = item.Full_name;          
                    Teacher_Id = item.User_id;
                    Flag = true;
                }
                //credential();
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

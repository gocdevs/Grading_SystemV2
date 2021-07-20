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

        public string UserType, Username, Password, First_Name, Last_Name, Teacher_Id, Full_Name;
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
                    Teacher_Id = item.Faculty_id;
                    Flag = true;
                }
                Check_Credential();
            }
        }

        public void Check_Credential()
        {

            if (Flag == true)
            {
                if (UserType.Equals("Admin"))
                {
                    frmMain main = new frmMain();

                    main.Access_Control = UserType.ToString();
                    main.UserType = UserType.ToString();
                    main.Username = Full_Name.ToString();
                    main.Teacher_Id = Teacher_Id.ToString();

                    main.AccessGrant();
                    main.Show();
                    this.Hide();
                }

                else if (UserType.Equals("Teacher"))
                {
                    frmMain main = new frmMain();

                    //main.Access_Control = "Teacher";

                    main.Access_Control = UserType.ToString();
                    main.UserType = UserType.ToString();
                    main.Username = Full_Name.ToString();
                    main.Teacher_Id = Teacher_Id.ToString();

                    main.AccessGrant();

                    main.btnFacultyLoading.Visible = false;
                    main.btnFileMaintenance.Visible = false;
                    main.btnStudentData.Visible = false;
                    main.btnStudentSubject.Visible = false;
                  

                    main.Show();
                    this.Hide();
                }
                else
                {
                    string message = "Erorr";
                    string title = "GOC_INFO_SYS";

                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);

                    if (result == DialogResult.OK)
                    {
                        Flag = false;
                        return;
                    }
                }
            }
            else
            {
                string message = "User not existing";
                string title = "GOC_INFO_SYS";

                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);

                if (result == DialogResult.OK)
                {
                    return;
                }
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

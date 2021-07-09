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
    public partial class frmUsers : Form
    {
        Models.Faculty faculty = new Models.Faculty();
        List<Models.Faculty> list_faculty = new List<Models.Faculty>();

        Users user = new Users();
        List<Users> list_users = new List<Users>();

        Util_RequiredFields util = new Util_RequiredFields();

        public int id;
        public frmUsers()
        {
            InitializeComponent();
            faculty.LoadDataTableName(dgvFacultyName);
        }

        public void Reset()
        {
            txtPass.Text = "";
            txtUsername.Text = "";
            cmbUserType.Text = "";          

            btnAdd.Text = "&Add New";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "&Update")
            {
                util.ValidateTextBox2(txtPass, txtUsername);// Validation before Updating
                util.ValidateCombobox1(cmbUserType);// Validation before Updating
                if (util.readyToSave == 1)
                {
                    #region UPDATE DISCOUNT
                        user.Id = id;
                        user.User_id = txtUsername.Text;
                        user.Password = txtPass.Text;
                        user.User_type = cmbUserType.Text;

                        foreach (DataGridViewRow row in dgvFacultyName.SelectedRows)
                        {
                        

                            user.Faculty_id = row.Cells[0].Value.ToString();
                            user.Full_name = row.Cells[1].Value.ToString();
                        }
                        
                        user.Update();
                        Reset();
                    #endregion              
                }
                else
                {
                    Reset();
                    return;
                }
            }
            else
            {
                util.ValidateTextBox2(txtPass, txtUsername);// Validation before Updating
                util.ValidateCombobox1(cmbUserType);// Validation before Updating
                if (util.readyToSave == 1)
                {

                 
                    user.Id = id;
                    user.User_id = txtUsername.Text;
                    user.Password = txtPass.Text;
                    user.User_type = cmbUserType.Text;

                    foreach (DataGridViewRow row in dgvFacultyName.SelectedRows)
                    {


                        user.Faculty_id = row.Cells[0].Value.ToString();
                        user.Full_name = row.Cells[1].Value.ToString();
                    }

                    user.Save();
                    Reset();
                }
                else
                {
                    Reset();
                    return;
                }
            }
           user.LoadDataTable(dgvList);
        }
    }
}

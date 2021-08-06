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
            user.LoadDataTable(dgvList);

            HeaderFixSubject();
            AddImageDataGrid(dgvList);
        }

        public void AddImageDataGrid(DataGridView dgv)
        {
            DataGridViewImageColumn dimg = new DataGridViewImageColumn();
            dimg.Image = Properties.Resources.edit;
            dimg.HeaderText = "Edit";
            dimg.ImageLayout = DataGridViewImageCellLayout.Normal;
            dimg.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv.Columns.Add(dimg);


            DataGridViewImageColumn dimgDelete = new DataGridViewImageColumn();
            dimgDelete.Image = Properties.Resources.delete;
            dimgDelete.HeaderText = "Delete";
            dimgDelete.ImageLayout = DataGridViewImageCellLayout.Normal;
            dimgDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv.Columns.Add(dimgDelete);
        }


        public void HeaderFixSubject()
        {
            dgvList.Columns["password"].Visible = false;
            dgvList.Columns["id"].Visible = false;

            dgvList.Columns["faculty_id"].HeaderText = "Faculty Id";
            dgvList.Columns["user_id"].HeaderText = "Username";
            dgvList.Columns["user_type"].HeaderText = "User Type";
            dgvList.Columns["full_name"].HeaderText = "Teacher Name";

            #region Header Name
            DataGridViewColumn FillSize = dgvList.Columns[5];
            FillSize.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvFacultyName.Columns["faculty_id"].HeaderText = "Faculty Id";
            DataGridViewColumn FillSize1 = dgvFacultyName.Columns[0];
            FillSize1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            #endregion
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

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                id = Convert.ToInt32(dgvList.Rows[e.RowIndex].Cells[2].Value.ToString());//for editing criteria

                //pass value to edit mode               
                txtUsername.Text = dgvList.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtPass.Text = dgvList.Rows[e.RowIndex].Cells[5].Value.ToString();
                cmbUserType.Text = dgvList.Rows[e.RowIndex].Cells[6].Value.ToString();
              

                btnAdd.Text = "&Update";//set button to Update                
            }

            else if (e.ColumnIndex == 1)
            {
                string message = "Do you want to delete this record?";
                string title = "Grading System";

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    user.Id = Convert.ToInt32(dgvList.Rows[e.RowIndex].Cells[2].Value.ToString());//for editing criteria
                    user.Delete();
                    Reset();
                    user.LoadDataTable(dgvList);
                }
                else
                {
                    return;
                }
            }
        }
    }
}

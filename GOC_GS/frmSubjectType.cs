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
    public partial class frmSubjectType : Form
    {

        public frmSubjectType()
        {
            InitializeComponent();
            subjectType.LoadDataTable(dgvList);
            AddImageDataGrid(dgvList);
            HeaderFix(dgvList);
        }
        SubjectType subjectType = new SubjectType();
        List<SubjectType> section_list = new List<SubjectType>();

        Util_RequiredFields util = new Util_RequiredFields();

        public int id;

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

        public void HeaderFix(DataGridView dgv)
        {
            #region Header Name
            dgv.Columns["id"].Visible = false;

            dgv.Columns["subject_type"].HeaderText = "Subject Type";//to fix the header Name           

            DataGridViewColumn FillSize = dgv.Columns[1];
            FillSize.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            #endregion
        }

        public void Reset()
        {
            txtSubjectType.Text = "";
           
            btnAdd.Text = "&Add New";
        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                id = Convert.ToInt32(dgvList.Rows[e.RowIndex].Cells[2].Value.ToString());//for editing criteria

                //pass value to edit mode               
                txtSubjectType.Text = dgvList.Rows[e.RowIndex].Cells[3].Value.ToString();              

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
                    subjectType.Id = Convert.ToInt32(dgvList.Rows[e.RowIndex].Cells[2].Value.ToString());//for editing criteria
                    subjectType.Delete();

                    subjectType.LoadDataTable(dgvList);
                }
                else
                {
                    return;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "&Update")
            {
                util.ValidateTextBox1(txtSubjectType);// Validation before Updating               
                if (util.readyToSave == 1)
                {
                    #region UPDATE DISCOUNT
                    subjectType.Id = id;
                    subjectType.Subject_type = txtSubjectType.Text.ToUpper();

                    subjectType.Update();
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
                util.ValidateTextBox1(txtSubjectType);// Validation before Updating              

                if (util.readyToSave == 1)
                {
                    subjectType.Id = id;
                    subjectType.Subject_type = txtSubjectType.Text.ToUpper();

                    subjectType.Save();
                    Reset();
                }
                else
                {
                    Reset();
                    return;
                }
            }
            subjectType.LoadDataTable(dgvList);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

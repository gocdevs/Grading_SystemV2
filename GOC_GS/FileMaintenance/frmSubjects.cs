using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOC_GS
{
    public partial class frmSubjects : Form
    {
        public frmSubjects()
        {
            InitializeComponent();
            subject.LoadDataTable(dgvList);
            
            AddImageDataGrid(dgvList);
            HeaderFix(dgvList);

            subject_types.LoadCombo(cmbSTypes);                       
            strand.LoadCombo(cmbStrand);

        }

        Subjects subject = new Subjects();        
        List<Subjects> subject_list = new List<Subjects>();

        SubjectType subject_types = new SubjectType();
        List<SubjectType> subject_type_list = new List<SubjectType>();

        Section section = new Section();
        List<Section> sections_list = new List<Section>();

        Strand strand = new Strand();             
        List<Strand> strands_list = new List<Strand>();
        

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
            dgv.Columns["subject_code"].HeaderText = "Subject Code";//to fix the header Name
            dgv.Columns["subject_name"].HeaderText = "Subject Name";//to fix the header Name
            dgv.Columns["subject_type"].HeaderText = "Subject Type";//to fix the header Name
            dgv.Columns["semester"].HeaderText = "Semester";//to fix the header Name
            dgv.Columns["grade_level"].HeaderText = "Grade Level";//to fix the header Name
            dgv.Columns["strand"].HeaderText = "Strand";//to fix the header Name

            DataGridViewColumn FillSize = dgv.Columns[2];
            FillSize.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DataGridViewColumn FillSize1 = dgv.Columns[3];
            FillSize1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            #endregion
        }

        public void Reset()
        {
            txtSCode.Text = "";
            txtSName.Text = "";
            cmbSTypes.Text = "";
            cmbSemester.Text = "";
            cmbGradeLevel.Text = "";
            cmbStrand.Text = "";

            btnAdd.Text = "&Add New";
        }


        //Cellcontent Event for Datagrid
        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                id = Convert.ToInt32(dgvList.Rows[e.RowIndex].Cells[2].Value.ToString());//for editing criteria

                //pass value to edit mode               
                txtSCode.Text = dgvList.Rows[e.RowIndex].Cells[3].Value.ToString();   
                txtSName.Text = dgvList.Rows[e.RowIndex].Cells[4].Value.ToString();
                cmbSTypes.Text = dgvList.Rows[e.RowIndex].Cells[5].Value.ToString();
                cmbSemester.Text = dgvList.Rows[e.RowIndex].Cells[6].Value.ToString();
                cmbGradeLevel.Text = dgvList.Rows[e.RowIndex].Cells[7].Value.ToString();                                             
                cmbStrand.Text = dgvList.Rows[e.RowIndex].Cells[8].Value.ToString();

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
                    subject.Id = Convert.ToInt32(dgvList.Rows[e.RowIndex].Cells[2].Value.ToString());//for editing criteria
                    subject.Delete();

                    subject.LoadDataTable(dgvList);
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
                util.ValidateTextBox2(txtSCode, txtSName);// Validation before Updating
                util.ValidateCombobox4(cmbGradeLevel, cmbSemester, cmbStrand, cmbSTypes);// Validation before Updating
                if (util.readyToSave == 1)
                {
                    #region UPDATE DISCOUNT
                    subject.Id = id;
                    subject.Subject_code = txtSCode.Text;
                    subject.Subject_name = util.ToProperCase(txtSName.Text);
                    subject.Subject_type = cmbSTypes.Text;
                    subject.Semester = cmbSemester.Text;
                    subject.Grade_level = cmbGradeLevel.Text;
                    subject.Strand = cmbStrand.Text;

                    subject.Update();
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
                util.ValidateTextBox2(txtSCode, txtSName);// Validation before Updating
                util.ValidateCombobox4(cmbGradeLevel, cmbSemester, cmbStrand, cmbSTypes);// Validation before Updating

                if (util.readyToSave == 1)
                {
                    

                    subject.Id = id;
                    subject.Subject_code = txtSCode.Text.ToUpper();                    
                    subject.Subject_name = util.ToProperCase(txtSName.Text);
                    subject.Subject_type = cmbSTypes.Text.ToUpper();
                    subject.Semester = cmbSemester.Text;
                    subject.Grade_level = cmbGradeLevel.Text;
                    subject.Strand = cmbStrand.Text;

                    subject.Save();
                    Reset();
                }
                else
                {
                    Reset();
                    return;
                }
            }
            subject.LoadDataTable(dgvList);
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

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace GOC_GS
{
    public partial class frmFacultyLoadings : Form
    {
        Section section = new Section();
        Strand strand = new Strand();
        Subjects subjects = new Subjects();
        Models.Faculty fl = new Models.Faculty();
        FacultyLoading facultyLoads = new FacultyLoading();

        List<Subjects> subjects_list = new List<Subjects>();
        List<Strand> strands_list = new List<Strand>();
        List<Section> sections_list = new List<Section>();

        public int id;
        public frmFacultyLoadings()
        {
            InitializeComponent();
            subjects.LoadDataTable(dgvSubjects);
            //section.LoadCombo(cmbSection);
            strand.LoadCombo(cmbStrand);           
            fl.LoadDataTableName(dgvFacultyName);
            //HeaderFixSubject(dgvSubjects);
           
            AddImageDataGrid(dgvNewSubjects);
            AddImageDataGridLoading(dgvFacultyLoads);

            dgvFacultyName.Columns["faculty_id"].HeaderText = "Faculty Id";
            DataGridViewColumn FillSize1 = dgvFacultyName.Columns[1];
            FillSize1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            CountFacultyName();
        }

        public void SearchTeacherName(DataGridView dgv, TextBox txt)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(GOC_GS.Config.GetConnectionString()))
                {
                    con.Open();
                    string sql = "SELECT  faculty_id, CONCAT(fname,' ', Left(mname,1) ,'. ',lname) Fullname FROM faculty WHERE lname LIKE('%" + txt.Text + "%') OR fname LIKE('%" + txt.Text + "%') ";

                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    MySqlDataAdapter da = new MySqlDataAdapter();

                    da.SelectCommand = cmd;

                    //initialize new datatable and load data to datagridview
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv.DataSource = dt;

                    con.Close();
                }
            }

            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "Grading System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }//End of Load

        public void CountFacultyName()
        {
            lblFacultyNo.Refresh();
            lblFacultyNo.Text = dgvFacultyName.Rows.Count.ToString();
        }

        public void CountSubjectAssigned()
        {
            lblSubjectAssigned.Refresh();
            lblSubjectAssigned.Text = dgvFacultyLoads.Rows.Count.ToString();
        }

        public void LoadSubjects()
        {
            subjects_list.Clear();
            subjects_list = subjects.Load();
            dgvNewSubjects.Rows.Clear();
            foreach (var item in subjects_list)
            {
                if (item.Grade_level == cmbGradeLevel.Text && item.Semester == cmbSemester.Text && item.Strand == cmbStrand.Text)
                {
                    dgvNewSubjects.Rows.Add(item.Id, item.Subject_code, item.Subject_name, item.Grade_level, item.Subject_type, item.Strand, item.Semester);
                }                
            }
        }

        public void LoadSubjectsAll()
        {
            subjects_list.Clear();
            subjects_list = subjects.Load();
            dgvNewSubjects.Rows.Clear();
            foreach (var item in subjects_list)
            {                
                dgvNewSubjects.Rows.Add(item.Id, item.Subject_code, item.Subject_name, item.Grade_level, item.Subject_type, item.Strand, item.Semester);                
            }
        }

        public void LoadSubjectSpecific()
        {
            subjects_list.Clear();
            subjects_list = subjects.Load();
            dgvNewSubjects.Rows.Clear();

            String txt = util.ToProperCase(txtSubjectName.Text);

            foreach (var item in subjects_list)
            {               
                if (item.Subject_name.Contains(txt))
                {
                    dgvNewSubjects.Rows.Add(item.Id, item.Subject_code, item.Subject_name, item.Grade_level, item.Subject_type, item.Strand, item.Semester);
                }               
            }
        }

        public void HeaderFixSubject(DataGridView dgv)
        {
            #region Header Name
            dgv.Columns["id"].Visible = false;
            dgv.Columns["subject_code"].HeaderText = "Subject Code";//to fix the header Name
            dgv.Columns["subject_name"].HeaderText = "Subject Name";//to fix the header Name
            dgv.Columns["subject_type"].HeaderText = "Subject Type";//to fix the header Name
            dgv.Columns["sem"].HeaderText = "Semester";//to fix the header Name
            dgv.Columns["grade_level"].HeaderText = "Grade Level";//to fix the header Name
            dgv.Columns["strand"].HeaderText = "Strand";//to fix the header Name

            DataGridViewColumn FillSize = dgv.Columns[2];
            FillSize.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DataGridViewColumn FillSize1 = dgv.Columns[3];
            FillSize1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;           
            #endregion
        }

        public void AddImageDataGrid(DataGridView dgv)
        {
            DataGridViewImageColumn dimg = new DataGridViewImageColumn();
            dimg.Image = Properties.Resources.add_green;
            dimg.HeaderText = "Add Subject";
            dimg.ImageLayout = DataGridViewImageCellLayout.Normal;
            dimg.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv.Columns.Add(dimg);            
        }

        public void AddImageDataGridLoading(DataGridView dgv)
        {
            DataGridViewImageColumn dimg = new DataGridViewImageColumn();
            dimg.Image = Properties.Resources.delete;
            dimg.HeaderText = "Remove Subject";
            dimg.ImageLayout = DataGridViewImageCellLayout.Normal;
            dimg.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
         
            dgv.Columns.Add(dimg);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        String FacultyId, FullName, SubjectCode, SubjectType, GradeLevel, Strand, Semester;

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadSubjects();
        }

        private void btnSearchAll_Click(object sender, EventArgs e)
        {
            txtSubjectName.Enabled = true;
            txtSubjectName.Focus();
            LoadSubjectsAll();
        }

        Util_RequiredFields util = new Util_RequiredFields();

        private void txtSubjectName_TextChanged(object sender, EventArgs e)
        {
           
            LoadSubjectSpecific();
        }

        private void txtFacultyName_TextChanged(object sender, EventArgs e)
        {
            SearchTeacherName(dgvFacultyName, txtFacultyName);
            CountFacultyName();
        }

        private void dgvNewSubjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {            
                foreach (DataGridViewRow row in dgvFacultyName.SelectedRows)
                {
                    FacultyId = row.Cells[0].Value.ToString();
                    FullName = row.Cells[1].Value.ToString();
                }

                foreach (DataGridViewRow row in dgvNewSubjects.SelectedRows)
                {
                    SubjectCode = row.Cells[1].Value.ToString();
                    SubjectType = row.Cells[3].Value.ToString();
                    GradeLevel = row.Cells[5].Value.ToString();
                    Strand = row.Cells[6].Value.ToString();
                    Semester = row.Cells[4].Value.ToString();
                }               
                dgvFacultyLoads.Rows.Add(FacultyId, FullName, SubjectCode, SubjectType, GradeLevel, Strand, Semester);
            }

            CountSubjectAssigned();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvFacultyLoads.Rows.Count > 0)
            {
                string message = "Do you want to save all record?";
                string title = "GOC_Grading_System";

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    for (int i = 0; i < dgvFacultyLoads.Rows.Count; i++)
                    {                      
                        facultyLoads.Faculty_id = dgvFacultyLoads.Rows[i].Cells[0].FormattedValue.ToString();
                        facultyLoads.FullName = dgvFacultyLoads.Rows[i].Cells[1].FormattedValue.ToString();

                        facultyLoads.SubjectCode = dgvFacultyLoads.Rows[i].Cells[2].FormattedValue.ToString();
                        facultyLoads.GradeLevel = dgvFacultyLoads.Rows[i].Cells[3].FormattedValue.ToString();

                        facultyLoads.Semester = dgvFacultyLoads.Rows[i].Cells[5].FormattedValue.ToString();
                        facultyLoads.Strand = dgvFacultyLoads.Rows[i].Cells[4].FormattedValue.ToString();

                        facultyLoads.SubjectType = dgvFacultyLoads.Rows[i].Cells[6].FormattedValue.ToString();
                      
                        facultyLoads.Save();

                    }
                    MessageBox.Show("Record Saved!", "Grading System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvFacultyLoads.Rows.Clear();
                }
                else
                {
                    return;
                }

            }
            else
            {

            }

            CountSubjectAssigned();
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            string message = "Do you want to delete all record? in the list";
            string title = "GOC_Grading_System";

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                dgvFacultyLoads.Rows.Clear();
            }
            else
            {
                return;
            }

            CountSubjectAssigned();
        }

        private void dgvFacultyLoads_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            base.OnClick(e);
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
          
        }

        private void dgvFacultyLoads_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                if (dgvFacultyLoads.Rows.Count < 1)
                {

                }
                else
                {
                    foreach (DataGridViewRow row in dgvFacultyName.SelectedRows)
                    {

                        dgvFacultyLoads.Rows.RemoveAt(row.Index);
                    }
                }                
            }
          
            foreach (DataGridViewColumn column in dgvFacultyName.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            
        }
        private void dgvSubjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
           
        }
    }
}



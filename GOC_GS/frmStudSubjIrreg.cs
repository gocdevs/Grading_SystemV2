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
    public partial class frmStudSubjIrreg : Form
    {
        public frmStudSubjIrreg()
        {
            InitializeComponent();
            
            section.LoadCombo(cmbSection);
            strand.LoadCombo(cmbStrand);
        }

        Models.StudentData studentData = new Models.StudentData();
        List<Models.StudentData> List_studentData = new List<Models.StudentData>();

        Models.StudentProfile studProf = new Models.StudentProfile();
        List<Models.StudentProfile> list_studProf = new List<Models.StudentProfile>();

        Section section = new Section();
        Strand strand = new Strand();

        Subjects subject = new Subjects();
        List<Subjects> subject_list = new List<Subjects>();

        FacultyLoading floading = new FacultyLoading();
        List<FacultyLoading> list_floading = new List<FacultyLoading>();

        Util_RequiredFields util = new Util_RequiredFields();

        public String strand_item;
        public string fullname;

 //************************************************************************************************************************************************************

        private void FilterBySection()
        {
            list_studProf.Clear();
            list_studProf = studProf.LoadStudentToGrade();// filter student accdg to Type ex. New Student , Tranferee

            dgvStudNames.Rows.Clear();
            foreach (var item in list_studProf)
            {
                if (cmbSection.Text.Equals(item.Section) && cmbStrand.Text.Equals(item.Strand) && (item.Student_Type.Contains("Tra") || item.Student_Type.Contains("tran")))
                {
                    if (item.MName.Trim() == "")
                    {
                        fullname = item.LName + ", " + item.FName + " " + item.MName + "";
                    }
                    else
                    {
                        fullname = item.LName + ", " + item.FName + " " + item.MName + ".";
                    }

                    dgvStudNames.Rows.Add(item.Id,  item.GOC_No, fullname, item.Section, item.Strand);

                    lblStrand.Refresh();
                    lblStrand.Text = item.Strand;
                    //cmbStrand.Text = item.Strand;
                }
            }
        }

        private void RecordCount()
        {
            lblCount.Text = dgvStudNames.Rows.Count.ToString();
        }

        private void loadSubj()
        {
            subject.Grade_level = cmbGradeLevel.Text;
            subject.Strand = lblStrand.Text;
            subject.Semester = cmbSemester.Text;
            subject_list.Clear();
            dgvSubjects.Rows.Clear();
            subject_list = subject.LoadThisSubjects();

            foreach (var item in subject_list)
            {
                dgvSubjects.Rows.Add(item.Id, item.Subject_code, item.Subject_name, item.Grade_level, item.Subject_type, item.Strand, item.Semester);
            }
        }

        public void LoadSubjectsAll()
        {
            subject_list.Clear();
            subject_list = subject.Load();
            dgvSubjects.Rows.Clear();
            foreach (var item in subject_list)
            {
                dgvSubjects.Rows.Add(item.Id, item.Subject_code, item.Subject_name, item.Grade_level, item.Subject_type, item.Strand, item.Semester);
            }
        }

        public void LoadFacultySubject()
        {
            list_floading.Clear();
            list_floading = floading.InsertTeacherToGrading();
            dgvSubjects.Rows.Clear();
            foreach (var item in list_floading)
            {
                dgvSubjects.Rows.Add(item.Id, item.FullName, item.SubjectCode, item.Strand, item.Semester, item.GradeLevel, item.Section);
            }
        }

        public void LoadSubjectSpecific()
        {
            subject_list.Clear();
            subject_list = subject.Load();
            dgvSubjects.Rows.Clear();

            String txt = util.ToProperCase(txtSubjectName.Text);

            foreach (var item in subject_list)
            {
                if (item.Subject_name.Contains(txt))
                {
                    dgvSubjects.Rows.Add(item.Id, item.Subject_code, item.Subject_name, item.Grade_level, item.Subject_type, item.Strand, item.Semester);
                }
            }
        }

        //*************************************************************************************************************************************************************************************************************

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FilterBySection();
            RecordCount();
            //loadSubj();
        }

        public void AddImageDataGrid(DataGridView dgv)
        {
            DataGridViewImageColumn dimg = new DataGridViewImageColumn();
            dimg.Image = Properties.Resources.add_green;
            dimg.HeaderText = "Assign";
            dimg.ImageLayout = DataGridViewImageCellLayout.Normal;
            dimg.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv.Columns.Add(dimg);           
        }

        public void AddDelete(DataGridView dgv)
        {
            DataGridViewImageColumn dimg = new DataGridViewImageColumn();
            dimg.Image = Properties.Resources.delete;
            dimg.HeaderText = "Remove";
            dimg.ImageLayout = DataGridViewImageCellLayout.Normal;
            dimg.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv.Columns.Add(dimg);
        }


        private void btnSearchAll_Click(object sender, EventArgs e)
        {
            txtSubjectName.Enabled = true;
            txtSubjectName.Focus();
            LoadFacultySubject();
            AddImageDataGrid(dgvSubjects);
            AddDelete(dgvTransSubjects);
        }

        private void txtSubjectName_TextChanged(object sender, EventArgs e)
        {
            LoadSubjectSpecific();
        }

        public string id, GOCNo, TeacherName, Fullname, SubjectCode, Section, Strand, SubjCode, SubjName, GradeLevel, SubjStrand, Semester;

        private void dgvTransSubjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTransSubjects.Rows.Count < 1)
            {

            }
            else
            {
                foreach (DataGridViewRow row in dgvTransSubjects.SelectedRows)
                {

                    dgvTransSubjects.Rows.RemoveAt(row.Index);
                }
            }
        }

        private void dgvSubjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                foreach (DataGridViewRow row in dgvSubjects.SelectedRows)
                {
                    id = row.Cells[0].Value.ToString();
                    TeacherName = row.Cells[1].Value.ToString();
                    SubjectCode = row.Cells[2].Value.ToString();
                    Strand = row.Cells[3].Value.ToString();
                    Semester = row.Cells[4].Value.ToString();
                    GradeLevel = row.Cells[5].Value.ToString();
                    Section = row.Cells[6].Value.ToString();
                }

                if (dgvTransSubjects.Rows.Count < 1)
                {
                    dgvTransSubjects.Rows.Add(id, TeacherName, SubjectCode, Strand, Semester, GradeLevel, Section);
                }
                else
                {
                    //check if duplicate id is in the datagrid
                    for (int i = 0; i < dgvTransSubjects.Rows.Count; i++)
                    {
                        if (id == dgvTransSubjects.Rows[i].Cells[0].FormattedValue.ToString())
                        {
                            MessageBox.Show("Duplicate Entry Detected","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            return;
                        }
                    }

                    dgvTransSubjects.Rows.Add(id, TeacherName, SubjectCode, Strand, Semester, GradeLevel, Section);
                }                              
            }      
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvStudNames.SelectedRows)
            {
                GOCNo = row.Cells[1].Value.ToString();
                Fullname = row.Cells[2].Value.ToString();
                Section = row.Cells[3].Value.ToString();
                Strand = row.Cells[4].Value.ToString();               
            }

            foreach (DataGridViewRow row in dgvSubjects.SelectedRows)
            {
                SubjCode = row.Cells[1].Value.ToString();
                SubjName = row.Cells[2].Value.ToString();
                GradeLevel = row.Cells[3].Value.ToString();
                SubjStrand = row.Cells[4].Value.ToString();
                Semester = row.Cells[5].Value.ToString();
            }

            //dgvFacultyLoads.Rows.Add(FacultyId, FullName, SubjectCode, SubjectType, GradeLevel, Strand, Semester);
            MessageBox.Show(GOCNo +" "+ Fullname +" "+ Section+" "+ Strand);
            MessageBox.Show(SubjCode + " " + SubjName + " " + GradeLevel + " " + SubjStrand+" "+Semester);
        }
    }
}

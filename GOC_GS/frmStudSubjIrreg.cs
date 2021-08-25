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
            loadSubj();
        }

        private void btnSearchAll_Click(object sender, EventArgs e)
        {
            txtSubjectName.Enabled = true;
            txtSubjectName.Focus();
            LoadSubjectsAll();
        }

        private void txtSubjectName_TextChanged(object sender, EventArgs e)
        {
            LoadSubjectSpecific();
        }
    }
}

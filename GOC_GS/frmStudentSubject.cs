using MySql.Data.MySqlClient;
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
    public partial class frmStudentSubject : Form
    {
        Models.StudentData studentData = new Models.StudentData();
        Section section = new Section();
        Strand strand = new Strand();
        Subjects subject = new Subjects();
        List<Subjects> subject_list = new List<Subjects>();

        DataTable dt = new DataTable();
        BindingSource bs = new BindingSource();

        //DataTable subject_dt = new DataTable();
        //BindingSource subject_bs = new BindingSource();

        public frmStudentSubject()
        {
            InitializeComponent();
            studentData.LoadStudentList(dgvStudentName);
            HeaderFix(dgvStudentName);

            section.LoadCombo(cmbSection);
            strand.LoadCombo(cmbStrand);

            //subject.LoadDataTable(dgvSubjects);

          
            LoadMe();

        }

        public void LoadMe()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(GOC_GS.Config.GetConnectionString()))
                {
                    con.Open();

                    string sql = "SELECT lrn_no, CONCAT(fname,' ', Left(mname,1) ,'. ',lname) FullName, section, strand FROM student_profile";

                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    MySqlDataAdapter da = new MySqlDataAdapter();

                    da.SelectCommand = cmd;

                    //initialize new datatable and load data to datagridview
                    dt = new DataTable();
                    bs = new BindingSource();
                    da.Fill(dt);

                    bs.DataSource = dt;
                    dgvStudentName.DataSource = bs;

                    con.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR :  " + ex.ToString(), "Grading System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        public void HeaderFix(DataGridView dgv)
        {
            #region Header Name           
            dgv.Columns["section"].HeaderText = "Section";//to fix the header Name           
            //DataGridViewColumn FillSize = dgv.Columns[0];
            //FillSize.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //DataGridViewColumn FillSize2 = dgv.Columns[1];
            //FillSize2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            #endregion
        }

        private void cmbSection_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            bs.Filter = string.Format("section LIKE '%{0}%'", cmbSection.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //clear list
            subject_list.Clear();
            dgvSubjects.Rows.Clear();
            //pass value to list
          
            subject.Semester = cmbSemester.Text;
            subject.Grade_level = cmbGradeLevel.Text;
            subject_list = subject.LoadThisSubjects();

            //loop through load it to list view
            foreach (var item in subject_list)
            {
                dgvSubjects.Rows.Add(item.Id, item.Subject_code, item.Subject_name, item.Grade_level, item.Subject_type, item.Strand, item.Semester);
            }//End LoadSchedule()
        }

        public string StudentName, stud_section, LRN;
        public string SubjectCode, SubjectType, GradeLevel, Strand, Semester, Section, SubjectName;
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvStudentName.Rows.Count; i++)
            {
                LRN = dgvStudentName.Rows[i].Cells[0].FormattedValue.ToString();
                StudentName = dgvStudentName.Rows[i].Cells[1].FormattedValue.ToString();
                Section = dgvStudentName.Rows[i].Cells[2].FormattedValue.ToString();
                Strand = dgvStudentName.Rows[i].Cells[3].FormattedValue.ToString();

                for (int x = 0; x < dgvSubjects.Rows.Count; x++)
                {
                    //SubjectCode = dgvSubjects.Rows[x].Cells[0].FormattedValue.ToString();
                    SubjectCode = dgvSubjects.Rows[x].Cells[1].FormattedValue.ToString();//Code
                    SubjectName = dgvSubjects.Rows[x].Cells[2].FormattedValue.ToString();//name
                    GradeLevel = dgvSubjects.Rows[x].Cells[3].FormattedValue.ToString();//Code                                
                    Semester = dgvSubjects.Rows[x].Cells[6].FormattedValue.ToString();//name

                    dgvStudentSubjects.Rows.Add(LRN, StudentName, SubjectName, GradeLevel, Strand, Section, Semester);

                    Grading grading = new Grading();
                    grading.LRN_No = LRN;
                    grading.Fullname = StudentName;
                    grading.Subject_Code = SubjectCode;
                    grading.Subject_Desc = SubjectName;
                    grading.Units = "0";
                    grading.FirstGrade = "0";
                    grading.SecondGrade = "0";
                    grading.Average = "0";
                    grading.Remarks = "0";
                    grading.Semester = Semester;
                    grading.Grade_level = GradeLevel;
                    grading.Section = Section;
                    grading.Strand = Strand;

                    grading.Save();
                }

               // MessageBox.Show(LRN + " " + StudentName + " " + Section + " " + Strand); //Subject name               
            }      
        }
    }
}

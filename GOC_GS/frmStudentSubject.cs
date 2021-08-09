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
using System.Threading;
using System.Configuration;


namespace GOC_GS
{
    public partial class frmStudentSubject : Form
    {
        Models.StudentData studentData = new Models.StudentData();
        List<Models.StudentData> List_studentData = new List<Models.StudentData>();

        Models.StudentProfile studProf = new Models.StudentProfile();
        List<Models.StudentProfile> list_studProf = new List<Models.StudentProfile>();


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
            pnlLoading.Hide();
            studentData.LoadStudentList(dgvStudentNames);

            LoadMe();

            HeaderFix(dgvStudentNames);

            section.LoadCombo(cmbSection);
            strand.LoadCombo(cmbStrand);

            //subject.LoadDataTable(dgvSubjects);
            //progressBar1.Visible = false;
        }

        public string fullname;
        public void LoadMe()
        {
            list_studProf.Clear();
            list_studProf = studProf.LoadStudentToGrade();

            foreach (var item in list_studProf)
            {

                //string last = item.MName;
                //string mname = last.Substring(0,1);
               
                if (item.MName == "")
                {
                    fullname = item.LName + ", " + item.FName + " " + item.MName + "";
                }
                else
                {
                    fullname = item.LName + ", " + item.FName + " " + item.MName + ".";
                }


                dgvStudNames.Rows.Add(item.Id, item.LRN_No, fullname , item.Section, item.Strand);
            }
        }

       

        public void HeaderFix(DataGridView dgv)
        {
            #region Header Name     
                  
            dgv.Columns["section"].HeaderText = "Section";
            dgv.Columns["lrn_no"].HeaderText = "LRN No.";
            dgv.Columns["strand"].HeaderText = "Strand";



            DataGridViewColumn FillSize2 = dgv.Columns[1];
            FillSize2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DataGridViewColumn FillSize = dgv.Columns[2];
            FillSize.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            #endregion
        }

        private void cmbSection_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            bs.Filter = string.Format("section LIKE '%{0}%'", cmbSection.Text);
            //LoadTVL();
            RecordCount();
            //studentData.LoadStudentList(dgvStudentName);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //clear list
            subject_list.Clear();
            dgvSubjects.Rows.Clear();
            //pass value to list
          
            subject.Semester = cmbSemester.Text;
            subject.Grade_level = cmbGradeLevel.Text;
            subject.Strand = cmbStrand.Text;
            subject_list = subject.LoadThisSubjects();

            //loop through load it to list view
            foreach (var item in subject_list)
            {
                dgvSubjects.Rows.Add(item.Id, item.Subject_code, item.Subject_name, item.Grade_level, item.Subject_type, item.Strand, item.Semester);
            }//End LoadSchedule()
        }
        private void RecordCount()
        {

            lblCount.Text = dgvStudentNames.Rows.Count.ToString();
        }

        public string StudentName, stud_section, LRN;

        private void cmbSection_Enter(object sender, EventArgs e)
        {
            bs.Filter = string.Format("section LIKE '%{0}%'", cmbSection.Text);
            RecordCount();
        }

        private void cmbSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTVL();
            RecordCount();

            //clear list
            subject_list.Clear();
            dgvSubjects.Rows.Clear();
            //pass value to list

            subject.Semester = cmbSemester.Text;
            subject.Grade_level = cmbGradeLevel.Text;
            subject.Strand = cmbStrand.Text;
            subject_list = subject.LoadThisSubjects();

            //loop through load it to list view
            foreach (var item in subject_list)
            {
                dgvSubjects.Rows.Add(item.Id, item.Subject_code, item.Subject_name, item.Grade_level, item.Subject_type, item.Strand, item.Semester);
            }//End LoadSchedule()
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
           
        }

        private void cmbGradeLevel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbStrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.PerformClick();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadTVL();
        }

        private void LoadTVL()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(GOC_GS.Config.GetConnectionString()))
                {
                    con.Open();

                    string sql = "SELECT lrn_no, CONCAT(fname,' ', Left(mname,1) ,'. ',lname) FullName, section, strand  FROM student_profile WHERE strand LIKE('" + cmbStrand.Text + "')";

                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    MySqlDataAdapter da = new MySqlDataAdapter();

                    da.SelectCommand = cmd;

                    //initialize new datatable and load data to datagridview
                    dt = new DataTable();

                    da.Fill(dt);


                    dgvStudentNames.DataSource = dt;


                    con.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR :  " + ex.ToString(), "Grading System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //studentData.LoadStudentList(dgvStudentName);
        }

        public string SubjectCode, SubjectType, GradeLevel, Strand, Semester, Section, SubjectName;
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //LoadTVL();
            //RecordCount();
            //pnlLoading.Show();

            for (int i = 0; i < dgvStudentNames.Rows.Count; i++)
            {
                LRN = dgvStudentNames.Rows[i].Cells[0].FormattedValue.ToString();
                StudentName = dgvStudentNames.Rows[i].Cells[1].FormattedValue.ToString();
                Section = dgvStudentNames.Rows[i].Cells[2].FormattedValue.ToString();
                Strand = dgvStudentNames.Rows[i].Cells[3].FormattedValue.ToString();

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
                    this.Refresh();                       
                }
                //MessageBox.Show(i.ToString());
                pnlLoading.Show();
                lblLoading.Text = (i + 1) + " records saved.";
            }
            
            pnlLoading.Hide();
            MessageBox.Show("Data Successfully Save", "Grading System", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

    }
}

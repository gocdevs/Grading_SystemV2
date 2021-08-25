using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using MySql.Data.MySqlClient;

namespace GOC_GS.Models
{
    class StudentProfile
    {
        List<StudentProfile> studentProfiles = new List<StudentProfile>();

        protected int id;
        protected string goc_no;
        protected string lrn_no;
        protected string fname;
        protected string mname;
        protected string lname;
        protected string grade_level;
        protected string section;
        protected string strand;
        protected string academic_status;
        protected string sex;
        protected string student_type;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string GOC_No
        {
            get { return goc_no; }
            set { goc_no = value; }
        }

        public string LRN_No
        {
            get { return lrn_no; }
            set { lrn_no = value; }
        }

        public string FName
        {
            get { return fname; }
            set { fname = value; }
        }

        public string MName
        {
            get { return mname; }
            set { mname = value; }
        }

        public string LName
        {
            get { return lname; }
            set { lname = value; }
        }

        public string Grade_Level
        {
            get { return grade_level; }
            set { grade_level = value; }
        }

        public string Section
        {
            get { return section; }
            set { section = value; }
        }

        public string Strand
        {
            get { return strand; }
            set { strand = value; }
        }

        public string Academic_Status
        {
            get { return academic_status; }
            set { academic_status = value; }
        }

        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        public string Student_Type
        {
            get { return student_type; }
            set { student_type = value; }
        }

        Microsoft.Office.Interop.Excel.Application application;
        Microsoft.Office.Interop.Excel.Workbook workbook;
        Microsoft.Office.Interop.Excel.Worksheet worksheet;
        Microsoft.Office.Interop.Excel.Range range;

        protected string filePath;

        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }

        public void openFile()
        {
            OpenFileDialog openFD = new OpenFileDialog();
            openFD.Filter = "Excel Office |*.xls; *.xlsx";
            if (openFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filePath = openFD.FileName;
            }
        }

        public void importFile(DataGridView dgv)
        {
            try
            {
                if (filePath != null)
                {
                    application = new Microsoft.Office.Interop.Excel.Application();
                    workbook = application.Workbooks.Open(filePath);
                    worksheet = workbook.Worksheets["sheet1"];
                    range = worksheet.UsedRange;

                    //load datagrid
                    int xlRow;
                    dgv.Rows.Clear();
                    for (xlRow = 2; xlRow <= range.Rows.Count; xlRow++)
                    {
                        dgv.Rows.Add(range.Cells[xlRow, 1].Text,
                                    range.Cells[xlRow, 2].Text,
                                    range.Cells[xlRow, 3].Text,
                                    range.Cells[xlRow, 4].Text,
                                    range.Cells[xlRow, 5].Text,
                                    range.Cells[xlRow, 6].Text,
                                    range.Cells[xlRow, 7].Text,
                                    range.Cells[xlRow, 8].Text,
                                    range.Cells[xlRow, 9].Text,
                                    range.Cells[xlRow, 10].Text,
                                    range.Cells[xlRow, 11].Text //Student Type
                                    );                       
                    }
                    //end load datagrid

                    workbook.Close();
                    application.Quit();
                   
                    MessageBox.Show("All data load Successfully", "Ready to save into Database", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FileMaintenance.frmStudentProfile frm = new FileMaintenance.frmStudentProfile();
                    frm.tmrCount.Enabled = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "Grading System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Save()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOC_GS.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    string sql = "INSERT INTO student_profile(goc_no ,lrn_no ,fname ,mname ,lname,grade_level,section,strand,academic_status,sex,student_type) " +
                                    " VALUES (@goc_no,@lrn_no,@fname,@mname,@lname,@grade_level,@section,@strand,@academic_status,@sex,@student_type);";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("goc_no", goc_no);
                    cmd.Parameters.AddWithValue("lrn_no", lrn_no);
                    cmd.Parameters.AddWithValue("fname", fname);
                    cmd.Parameters.AddWithValue("mname", mname);
                    cmd.Parameters.AddWithValue("lname", lname);
                    cmd.Parameters.AddWithValue("grade_level", grade_level);
                    cmd.Parameters.AddWithValue("section", section);
                    cmd.Parameters.AddWithValue("strand", strand);
                    cmd.Parameters.AddWithValue("academic_status", academic_status);
                    cmd.Parameters.AddWithValue("sex", sex);
                    cmd.Parameters.AddWithValue("student_type", student_type);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "Grading System", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public List<StudentProfile> LoadStudent()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOC_GS.Config.GetConnectionString()))
                {
                    //try to open connection
                    con.Open();
                    //prepare sql query

                    string sql = "SELECT * FROM student_profile";
                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    //loop while have record
                    while (reader.Read())
                    {
                        //instantiate model
                        StudentProfile stud = new StudentProfile();

                        //prepare properties                                               
                        stud.id = Convert.ToInt32(reader["id"].ToString());
                        stud.goc_no = reader["goc_no"].ToString();
                        stud.lrn_no = reader["lrn_no"].ToString();
                        stud.fname = reader["fname"].ToString();
                        stud.mname = reader["mname"].ToString();
                        stud.lname = reader["lname"].ToString();
                        stud.grade_level = reader["grade_level"].ToString();
                        stud.section = reader["section"].ToString();
                        stud.strand = reader["strand"].ToString();
                        stud.academic_status = reader["academic_status"].ToString();
                        stud.sex = reader["sex"].ToString();
                        stud.student_type = reader["student_type"].ToString();
                        studentProfiles.Add(stud);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return studentProfiles;
        }//End of Load

        public List<StudentProfile> LoadStudentToGrade()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOC_GS.Config.GetConnectionString()))
                {
                    //try to open connection
                    con.Open();
                    //prepare sql query
                    string sql = "SELECT id, goc_no, fname, lname ,CONCAT(LEFT(mname,1)) mname, section, strand,student_type ,sex FROM student_profile";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    //loop while have record
                    while (reader.Read())
                    {
                        //instantiate model
                        StudentProfile stud = new StudentProfile();

                        //prepare properties                                               
                        stud.id = Convert.ToInt32(reader["id"].ToString());
                        //stud.goc_no = reader["goc_no"].ToString();
                        stud.goc_no = reader["goc_no"].ToString();
                        stud.fname = reader["fname"].ToString();
                        stud.mname = reader["mname"].ToString();
                        stud.lname = reader["lname"].ToString();
                        //stud.grade_level = reader["grade_level"].ToString();
                        stud.section = reader["section"].ToString();
                        stud.strand = reader["strand"].ToString();
                        stud.student_type = reader["student_type"].ToString();
                        stud.sex = reader["sex"].ToString();

                        studentProfiles.Add(stud);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return studentProfiles;
        }//End of Load

        //Update
        public void Update()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOC_GS.Config.GetConnectionString()))
                {
                    //try to open connection
                    con.Open();
                    string sql = "UPDATE student_profile SET goc_no=@goc_no, lrn_no=@lrn_no, fname=@fname," +
                        "lname=@lname, mname=@mname, grade_level=@grade_level, section=@section, strand=@strand," +
                        "academic_status=@academic_status, sex=@sex, student_type=@student_type WHERE id=@id;";

                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.Parameters.AddWithValue("goc_no", goc_no);
                    cmd.Parameters.AddWithValue("lrn_no", lrn_no);
                    cmd.Parameters.AddWithValue("fname", fname);
                    cmd.Parameters.AddWithValue("lname", lname);
                    cmd.Parameters.AddWithValue("mname", mname);
                    cmd.Parameters.AddWithValue("grade_level", grade_level);
                    cmd.Parameters.AddWithValue("section", section);
                    cmd.Parameters.AddWithValue("strand", strand);
                    cmd.Parameters.AddWithValue("academic_status", academic_status);
                    cmd.Parameters.AddWithValue("sex", sex);
                    cmd.Parameters.AddWithValue("student_type", student_type);

                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("Recorde Updated!", "Grading System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.Message.ToString(), "Grading System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }       
    }
}


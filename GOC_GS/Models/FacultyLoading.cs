using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOC_GS
{
    class FacultyLoading
    {
        List<FacultyLoading> faculty_list = new List<FacultyLoading>();

        protected int id;
        protected string faculty_id;
        protected string fullname;
        protected string subjectCode;
        protected string section;
        protected string gradeLevel;
        protected string strand;
        protected string semester;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Faculty_id
        {
            get { return faculty_id; }
            set { faculty_id = value; }
        }

        public string FullName
        {
            get { return fullname; }
            set { fullname = value; }
        }

        public string SubjectCode
        {
            get { return subjectCode; }
            set { subjectCode = value; }
        }

        public string Section
        {
            get { return section; }
            set { section = value; }
        }

        public string GradeLevel
        {
            get { return gradeLevel; }
            set { gradeLevel = value; }
        }

        public string Strand
        {
            get { return strand; }
            set { strand = value; }
        }

        public string Semester
        {
            get { return semester; }
            set { semester = value; }
        }


        //Save Records
        public void Save()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOC_GS.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    string sql = "INSERT INTO faculty_loads(faculty_id, fullname, subject_code, section, strand, semester) " +
                                    " VALUES (@faculty_id, @fullname, @subjectCode, @section, @strand, @semester);";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("faculty_id", faculty_id);
                    cmd.Parameters.AddWithValue("fullname", fullname);
                    cmd.Parameters.AddWithValue("subjectCode", subjectCode);
                    cmd.Parameters.AddWithValue("section", section);
                    cmd.Parameters.AddWithValue("strand", strand);
                    cmd.Parameters.AddWithValue("semester", semester);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "Grading System", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}

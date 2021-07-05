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
        protected string fullName;
        protected string subjectCode;
        protected string subjectType;
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
            get { return fullName; }
            set { fullName = value; }
        }

        public string SubjectCode
        {
            get { return subjectCode; }
            set { subjectCode = value; }
        }

        public string SubjectType
        {
            get { return subjectType; }
            set { subjectType = value; }
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

                    string sql = "INSERT INTO faculty(faculty_id, lname, fname, mname, course, specialize_subject, adviser_of, employment_status) " +
                                    " VALUES (@faculty_id, @lname, @fname, @mname, @course, @specialize_subject, @adviser_of, @employment_status);";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("faculty_id", faculty_id);
                    //cmd.Parameters.AddWithValue("lname", lname);
                    //cmd.Parameters.AddWithValue("fname", fname);
                    //cmd.Parameters.AddWithValue("mname", mname);
                    //cmd.Parameters.AddWithValue("course", course);
                    //cmd.Parameters.AddWithValue("specialize_subject", specialize_subject);
                    //cmd.Parameters.AddWithValue("adviser_of", adviser_of);
                    //cmd.Parameters.AddWithValue("employment_status", employment_status);

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

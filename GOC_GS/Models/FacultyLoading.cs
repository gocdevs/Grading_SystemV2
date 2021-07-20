using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
        protected string subjectType;


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

        public string SubjectType
        {
            get { return subjectType; }
            set { subjectType = value; }
        }

        public List<FacultyLoading> FilterSubjectViaSection()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOC_GS.Config.GetConnectionString()))
                {
                    //try to open connection
                    con.Open();
                    //prepare sql query
                    string sql = "SELECT * FROM faculty_loads";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    //loop while have record
                    while (reader.Read())
                    {
                        //instantiate model
                        FacultyLoading loading = new FacultyLoading();

                        //prepare properties                       
                        loading.subjectCode = reader["subject_code"].ToString();
                        loading.section = reader["section"].ToString();
                        loading.gradeLevel = reader["grade_level"].ToString();
                        loading.faculty_id = reader["faculty_id"].ToString();
                        faculty_list.Add(loading);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return faculty_list;
        }//End of Load

        //Retrieve Data from DB
        public void LoadDataTable(DataGridView dgv)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(GOC_GS.Config.GetConnectionString()))
                {
                    con.Open();
                    string sql = "SELECT * FROM faculty_loads";

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

                    string sql = "INSERT INTO faculty_loads(faculty_id, fullname, subject_code, section, strand, semester,subjectType,grade_level) " +
                                    " VALUES (@faculty_id, @fullname, @subjectCode, @section, @strand, @semester,@subjectType,@gradeLevel);";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("faculty_id", faculty_id);
                    cmd.Parameters.AddWithValue("fullname", fullname);
                    cmd.Parameters.AddWithValue("subjectCode", subjectCode);
                    cmd.Parameters.AddWithValue("section", section);
                    cmd.Parameters.AddWithValue("strand", strand);
                    cmd.Parameters.AddWithValue("semester", semester);
                    cmd.Parameters.AddWithValue("subjectType", subjectType);
                    cmd.Parameters.AddWithValue("gradeLevel", gradeLevel);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "Grading System", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

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

                    string sql = "UPDATE faculty_loads SET section=@section"+
                                    " WHERE id=@id;";

                    MySqlCommand cmd = new MySqlCommand(sql, con);
                
                    cmd.Parameters.AddWithValue("section", section);
                    cmd.Parameters.AddWithValue("id", id);


                    cmd.ExecuteNonQuery();

                    
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.Message.ToString(), "Grading System", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

    }
}

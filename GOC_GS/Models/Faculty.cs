using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GOC_GS.Models
{
    class Faculty
    {
        List<Faculty> faculty_list = new List<Faculty>();

        protected int id;
        protected string faculty_id;
        protected string lname;
        protected string fname;
        protected string mname;
        protected string course;
        protected string specialize_subject;
        protected string adviser_of;
        protected string employment_status;

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

        public string Last_name
        {
            get { return lname; }
            set { lname = value; }
        }

        public string First_name
        {
            get { return fname; }
            set { fname = value; }
        }

        public string Middle_name
        {
            get { return mname; }
            set { mname = value; }
        }
        public string Course
        {
            get { return course; }
            set { course = value; }
        }

        public string Specialize_subject
        {
            get { return specialize_subject; }
            set { specialize_subject = value; }
        }

        public string Adviser_of
        {
            get { return adviser_of; }
            set { adviser_of = value; }
        }

        public string Emp_status
        {
            get { return employment_status; }
            set { employment_status = value; }
        }



        //Retrieve Data from DB
        public void LoadDataTable(DataGridView dgv)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(GOC_GS.Config.GetConnectionString()))
                {
                    con.Open();
                    string sql = "SELECT * FROM faculty";

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

        public void LoadDataTableName(DataGridView dgv)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(GOC_GS.Config.GetConnectionString()))
                {
                    con.Open();
                    string sql = "SELECT faculty_id, CONCAT(fname,' ', Left(mname,1) ,'. ',lname) Fullname FROM faculty ";

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

                    string sql = "INSERT INTO faculty(faculty_id, lname, fname, mname, course, specialize_subject, adviser_of, employment_status) " +
                                    " VALUES (@faculty_id, @lname, @fname, @mname, @course, @specialize_subject, @adviser_of, @employment_status);";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("faculty_id", faculty_id);
                    cmd.Parameters.AddWithValue("lname", lname);
                    cmd.Parameters.AddWithValue("fname", fname);
                    cmd.Parameters.AddWithValue("mname", mname);
                    cmd.Parameters.AddWithValue("course", course);
                    cmd.Parameters.AddWithValue("specialize_subject", specialize_subject);
                    cmd.Parameters.AddWithValue("adviser_of", adviser_of);
                    cmd.Parameters.AddWithValue("employment_status", employment_status);

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

                    string sql = "UPDATE faculty SET faculty_id=@faculty_id, lname=@lname, fname=@fname, mname=@mname, course=@course, specialize_subject=@specialize_subject, adviser_of=@adviser_of, employment_status=@employment_status" +
                                    " WHERE id=@id;";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("id", id);
                    cmd.Parameters.AddWithValue("faculty_id", faculty_id);
                    cmd.Parameters.AddWithValue("lname", lname);
                    cmd.Parameters.AddWithValue("fname", fname);
                    cmd.Parameters.AddWithValue("mname", mname);
                    cmd.Parameters.AddWithValue("course", course);
                    cmd.Parameters.AddWithValue("specialize_subject", specialize_subject);
                    cmd.Parameters.AddWithValue("adviser_of", adviser_of);
                    cmd.Parameters.AddWithValue("employment_status", employment_status);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Recorde Updated!", "Grading System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.Message.ToString(), "Grading System", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        //Delete
        public void Delete()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOC_GS.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    string sql = "DELETE  FROM faculty WHERE id=@id;";

                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record deleted!", "Grading System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "Grading System", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        //GetByID
        public List<Faculty> GetById()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOC_GS.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    //prepare sql query
                    string sql = "SELECT * FROM faculty WHERE faculty_id = @faculty_id;";


                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("faculty_id", faculty_id);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    //loop while have record
                    while (reader.Read())
                    {
                        //instantiate model
                        Faculty faculty = new Faculty();

                        //prepare properties                        
                        faculty.Faculty_id = reader["faculty_id"].ToString();
                        faculty.lname = reader["lname"].ToString();
                        faculty.fname = reader["fname"].ToString();
                        faculty.mname = reader["mname"].ToString();
                        faculty.course = reader["course"].ToString();
                        faculty.specialize_subject = reader["specialize_subject"].ToString();
                        faculty.adviser_of = reader["adviser_of"].ToString();
                        faculty.employment_status = reader["employment_status"].ToString();

                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.Message.ToString(), "Enrollment System", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return faculty_list;
        }
    }
}

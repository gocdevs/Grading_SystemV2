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
    class Subjects
    {
        //Array List
        List<Subjects> subjects = new List<Subjects>();

        protected int id;
        protected string subject_code;
        protected string subject_name;
        protected string subject_type;
        protected string semester;
        protected string grade_level;
        protected string strand;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Subject_code
        {
            get { return subject_code; }
            set { subject_code = value; }
        }

        public string Subject_name
        {
            get { return subject_name; }
            set { subject_name = value; }
        }

        public string Subject_type
        {
            get { return subject_type; }
            set { subject_type = value; }
        }

        public string Semester
        {
            get { return semester; }
            set { semester = value; }
        }

        public string Grade_level
        {
            get { return grade_level; }
            set { grade_level = value; }
        }

        public string Strand
        {
            get { return strand; }
            set { strand = value; }
        }



        public List<Subjects> LoadThisSubjects()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOC_GS.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    //prepare sql query
                    string sql = "SELECT * FROM subjects WHERE sem=@term and grade_level=@gradeLevel and strand=@strand";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("term", semester);
                    cmd.Parameters.AddWithValue("gradeLevel", grade_level);
                    cmd.Parameters.AddWithValue("strand", strand);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    //loop while have record
                    while (reader.Read())
                    {
                        //instantiate model
                        Subjects subject = new Subjects();

                        //prepare properties
                        subject.subject_code = reader["subject_code"].ToString();
                        subject.subject_name = reader["subject_name"].ToString();
                        subject.semester = reader["sem"].ToString();
                        subject.grade_level = reader["grade_level"].ToString();
                        subject.strand = reader["strand"].ToString();

                        subjects.Add(subject);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return subjects;
        }//End of Load


        public void LoadDataSubjects(DataGridView dgv)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(GOC_GS.Config.GetConnectionString()))
                {                    
                    con.Open();
                  
                    string sql ="SELECT * FROM subjects";

                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    MySqlDataAdapter da = new MySqlDataAdapter();

                    da.SelectCommand = cmd;

                    //initialize new datatable and load data to datagridview
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv.DataSource = dt;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "Grading System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//End of Load
        
        //Retrieve Data from DB
        public void LoadDataTable(DataGridView dgv)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(GOC_GS.Config.GetConnectionString()))
                {
                  

                    #region Old Code
                    //string sql = "SELECT * FROM subject";

                    //MySqlCommand cmd = new MySqlCommand(sql, con);

                    //MySqlDataReader reader = cmd.ExecuteReader();

                    ////loop while have record
                    //while (reader.Read())
                    //{
                    //    //instantiate model
                    //    Subjects subject = new Subjects();

                    //    //prepare properties
                    //    subject.id = Convert.ToInt32(reader["id"].ToString());
                    //    subject.subject_code = reader["subject_code"].ToString();
                    //    subject.subject_name = reader["subject_name"].ToString();
                    //    subject.subject_type = reader["subject_type"].ToString();                        
                    //    subject.semester = reader["semester"].ToString();
                    //    subject.grade_level = reader["grade_level"].ToString();
                    //    subject.strand = reader["strand"].ToString();

                    //    subjects.Add(subject);
                    #endregion

                    con.Open();
                    string sql = "SELECT * FROM subjects";

                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    MySqlDataAdapter da = new MySqlDataAdapter();

                    da.SelectCommand = cmd;

                    //initialize new datatable and load data to datagridview
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv.DataSource = dt;
                }
            }
            
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "Grading System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }//End of Load

        public List<Subjects> LoadCombo(ComboBox cmb)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(GOC_GS.Config.GetConnectionString()))
                {
                    con.Open();
                    string sql = "SELECT subject_name FROM subjects";

                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    MySqlDataAdapter da = new MySqlDataAdapter();

                    da.SelectCommand = cmd;

                    //initialize new datatable and load data to datagridview
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmb.DataSource = dt;
                    cmb.ValueMember = "subject_name";
                    cmb.DisplayMember = "subject_name";
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "Grading System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return subjects;
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

                    string sql = "INSERT INTO subjects(subject_code ,subject_name ,subject_type ,grade_level ,strand,semester) " +
                                    " VALUES (@subject_code,@subject_name,@subject_type,@grade_level,@strand,@semester);";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("subject_code", subject_code);
                    cmd.Parameters.AddWithValue("subject_name", subject_name);                    
                    cmd.Parameters.AddWithValue("subject_type", subject_type);
                    cmd.Parameters.AddWithValue("grade_level", grade_level);
                    cmd.Parameters.AddWithValue("semester", semester);
                    cmd.Parameters.AddWithValue("strand", strand);

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

                    string sql = "UPDATE subjects SET subject_code=@subject_code,subject_name=@subject_name,subject_type=@subject_type,grade_level=@grade_level,strand=@strand,semester=@semester" +
                                    " WHERE id=@id;";

                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.Parameters.AddWithValue("subject_code", subject_code);
                    cmd.Parameters.AddWithValue("subject_name", subject_name);
                    cmd.Parameters.AddWithValue("subject_type", subject_type);
                    cmd.Parameters.AddWithValue("grade_level", grade_level);
                    cmd.Parameters.AddWithValue("semester", semester);
                    cmd.Parameters.AddWithValue("strand", strand);

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

                    string sql = "DELETE  FROM subjects WHERE id=@id;";

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
        public List<Subjects> GetById()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOC_GS.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    //prepare sql query
                    string sql = "SELECT * FROM subjects WHERE subject_code =@subject_code;";


                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("subject_code", subject_code);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    //loop while have record
                    while (reader.Read())
                    {
                        //instantiate model
                        Subjects subject = new Subjects();

                        //prepare properties                        
                        subject.subject_code = reader["subject_code"].ToString();
                        subject.subject_name = reader["subject_name"].ToString();
                        subject.subject_type = reader["subject_type"].ToString();
                        subject.semester = reader["semester"].ToString();
                        subject.grade_level = reader["grade_level"].ToString();
                        subject.strand = reader["strand"].ToString();

                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.Message.ToString(), "Enrollment System", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return subjects;
        }
    }
}

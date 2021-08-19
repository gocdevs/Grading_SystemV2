using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOC_GS
{
    class Grading
    {
        List<Grading> grading_list = new List<Grading>();

        protected int id;
        protected string lrn_no;
        protected string fullname;
        protected string subject_code;
        protected string subject_desc;
        protected string units;
        protected string first_or_3rd_Q;
        protected string second_or_4th_Q;
        protected string average;
        protected string remarks;
        protected string sem;
        protected string grade_level;
        protected string section;
        protected string strand;

        protected string subject_teacher;
        protected string faculty_id;


        public string Fullname
        {
            get { return fullname; }
            set { fullname = value; }
        }

        public string Subject_Code
        {
            get { return subject_code; }
            set { subject_code = value; }
        }

        public string Subject_Desc
        {
            get { return subject_desc; }
            set { subject_desc = value; }
        }
        public string Units
        {
            get { return units; }
            set { units = value; }
        }
        public string FirstGrade
        {
            get { return first_or_3rd_Q; }
            set { first_or_3rd_Q = value; }
        }

        public string SecondGrade
        {
            get { return second_or_4th_Q; }
            set { second_or_4th_Q = value; }
        }

        public string Average
        {
            get { return average; }
            set { average = value; }
        }

        public string Remarks
        {
            get { return remarks; }
            set { remarks = value; }
        }

        public string Sem
        {
            get { return sem; }
            set { sem = value; }
        }


        public string Grade_level
        {
            get { return grade_level; }
            set { grade_level = value; }
        }


        public string Section
        {
            get { return section; }
            set { section = value; }
        }
        public string Semester
        {
            get { return sem; }
            set { sem = value; }
        }

        public string Strand
        {
            get { return strand; }
            set { strand = value; }
        }


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string LRN_No
        {
            get { return lrn_no; }
            set { lrn_no = value; }
        }

        List<Grading> grades = new List<Grading>();
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

                    string sql = "INSERT INTO grading(lrn_no, fullname, subject_code, subject_desc,units, first_or_3rd_Q, second_or_4th_Q, remarks, sem, grade_level, section, strand,average)" +
                                    "VALUES (@lrn_no, @fullname, @subject_code, @subject_desc, @units, @first_or_3rd_Q, @second_or_4th_Q, @remarks, @sem, @grade_level, @section, @strand,@average);";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("lrn_no", lrn_no);
                    cmd.Parameters.AddWithValue("fullname", fullname);
                    cmd.Parameters.AddWithValue("subject_code", subject_code);
                    cmd.Parameters.AddWithValue("subject_desc", subject_desc);
                    cmd.Parameters.AddWithValue("units", units);
                    cmd.Parameters.AddWithValue("first_or_3rd_Q", first_or_3rd_Q);
                    cmd.Parameters.AddWithValue("second_or_4th_Q", second_or_4th_Q);
                    cmd.Parameters.AddWithValue("remarks", remarks);
                    cmd.Parameters.AddWithValue("average", average);
                    cmd.Parameters.AddWithValue("sem", sem);
                    cmd.Parameters.AddWithValue("grade_level", grade_level);
                    cmd.Parameters.AddWithValue("section", section);
                    cmd.Parameters.AddWithValue("strand", strand);

                    cmd.ExecuteNonQuery();                                      
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "Grading System", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

       
        public List<Grading> Load()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(GOC_GS.Config.GetConnectionString()))
                {
                    con.Open();

                    string sql = "SELECT * FROM grading";

                    MySqlCommand cmd = new MySqlCommand(sql, con);                   
                    MySqlDataReader reader = cmd.ExecuteReader();

                    //loop while have record
                    while (reader.Read())
                    {
                        //instantiate model
                        Grading grade = new Grading();

                        //prepare properties
                        grade.id = Convert.ToInt32(reader["id"].ToString());
                        grade.lrn_no = reader["lrn_no"].ToString();
                        grade.fullname = reader["fullname"].ToString();
                        grade.subject_code = reader["subject_code"].ToString();
                        grade.subject_desc = reader["subject_desc"].ToString();
                        grade.units = reader["units"].ToString();
                        grade.first_or_3rd_Q = reader["first_or_3rd_Q"].ToString();
                        grade.second_or_4th_Q = reader["second_or_4th_Q"].ToString();
                        grade.average = reader["average"].ToString();
                        grade.remarks = reader["remarks"].ToString();
                        grade.sem = reader["sem"].ToString();
                        grade.grade_level = reader["grade_level"].ToString();
                        grade.section = reader["section"].ToString();
                        grade.strand = reader["strand"].ToString();

                        grades.Add(grade);
                    }
                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("ERROR : " + ex.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return grades;
        }//End of Load

        public void UpdateTheGrades()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOC_GS.Config.GetConnectionString()))
                {
                    //try to open connection
                    con.Open();
                    //string sql = "UPDATE grading SET first_or_3rd_Q=@first_or_3rd_Q, second_or_4th_Q=@second_or_4th_Q," +
                    //    "average=@average, remarks=@remarks WHERE id=@id;";

                    string sql = "UPDATE grading SET first_or_3rd_Q=@first_or_3rd_Q ,second_or_4th_Q=@second_or_4th_Q  ,average=@average,remarks=@remarks WHERE id=@id;";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("id", id);
                    //cmd.Parameters.AddWithValue("subject_code", subject_code);
                    //cmd.Parameters.AddWithValue("grade_level", grade_level);
                    //cmd.Parameters.AddWithValue("section", section);

                    cmd.Parameters.AddWithValue("first_or_3rd_Q", first_or_3rd_Q);
                    cmd.Parameters.AddWithValue("second_or_4th_Q", second_or_4th_Q);
                    cmd.Parameters.AddWithValue("average", average);
                    cmd.Parameters.AddWithValue("remarks", remarks);
                    //cmd.Parameters.AddWithValue("mname", faculty_id);


                    //cmd.Parameters.AddWithValue("fullname", fullname);

                    cmd.ExecuteNonQuery();

                    //MessageBox.Show("Recorde Updated!", "Grading System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.Message.ToString(), "Grading System", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        //Update
        public void Update_Info_Grade()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOC_GS.Config.GetConnectionString()))
                {
                    //try to open connection
                    con.Open();
                    string sql = "UPDATE grading SET goc_no=@goc_no, lrn_no=@lrn_no, fname=@fname," +
                        "lname=@lname, mname=@mname, grade_level=@grade_level, section=@section, strand=@strand," +
                        "academic_status=@academic_status WHERE id=@id;";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("id", id);
                    //cmd.Parameters.AddWithValue("goc_no", goc_no);
                    //cmd.Parameters.AddWithValue("lrn_no", lrn_no);
                    //cmd.Parameters.AddWithValue("fname", fname);
                    //cmd.Parameters.AddWithValue("lname", lname);
                    //cmd.Parameters.AddWithValue("mname", mname);
                    cmd.Parameters.AddWithValue("grade_level", grade_level);
                    cmd.Parameters.AddWithValue("section", section);
                    cmd.Parameters.AddWithValue("strand", strand);
                    //cmd.Parameters.AddWithValue("fullname", fullname);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Recorde Updated!", "Grading System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.Message.ToString(), "Grading System", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public string thisfullname;
        public List<Grading> Get_Name()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOC_GS.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    //prepare sql query
                    string sql = "SELECT CONCAT(lname,', ', fname,' ',Left(mname,1) ,'.') FullName FROM student_profile WHERE lrn_no=@lrn_no";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("lrn_no", lrn_no);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    //loop while have record
                    while (reader.Read())
                    {
                        //instantiate model
                        Grading sp = new Grading();

                        //prepare properties
                        sp.fullname = reader["FullName"].ToString();
                        

                        grading_list.Add(sp);

                        thisfullname = sp.fullname.ToString();
                    }

                   
                }

                //string sql2 = "UPDATE grading SET fullname=@thisfullname WHERE lrn_no=@lrn_no";

                //MySqlCommand cmd2 = new MySqlCommand(sql2, con);

                //cmd2.Parameters.AddWithValue("id", id);
                //cmd2.Parameters.AddWithValue("thisfullname", thisfullname);
                //cmd2.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return grading_list;           
        }//End of Load

        public void Update_Name()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOC_GS.Config.GetConnectionString()))
                {
                    //try to open connection
                    con.Open();
                    string sql = "UPDATE grading SET fullname=@fullname WHERE lrn_no=@lrn_no;";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("lrn_no", lrn_no);                   
                    cmd.Parameters.AddWithValue("fullname", fullname);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Recorde Updated!", "Grading System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.Message.ToString(), "Grading System", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


    }
}

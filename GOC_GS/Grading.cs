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

                    string sql = "INSERT INTO grading(lrn_no, fullname, subject_code, subject_desc,units, 1st_or_3rd_Q, 2nd_or_4th_Q, remarks, sem, grade_level, section, strand)" +
                                    "VALUES (@lrn_no, @fullname, @subject_code, @subject_desc, @units, @1st_or_3rd_Q, @2nd_or_4th_Q, @remarks, @sem, @grade_level, @section, @strand);";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("lrn_no", lrn_no);
                    cmd.Parameters.AddWithValue("fullname", fullname);
                    cmd.Parameters.AddWithValue("subject_code", subject_code);
                    cmd.Parameters.AddWithValue("subject_desc", subject_desc);
                    cmd.Parameters.AddWithValue("units", units);
                    cmd.Parameters.AddWithValue("1st_or_3rd_Q", first_or_3rd_Q);
                    cmd.Parameters.AddWithValue("2nd_or_4th_Q", second_or_4th_Q);
                    cmd.Parameters.AddWithValue("remarks", remarks);
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
    }
}

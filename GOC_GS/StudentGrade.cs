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
    class StudentGrade
    {
        List<Grading> grading_list = new List<Grading>();

        protected int id;
        protected string lrn_no;
        protected string fullname;
        protected string subject_code;
        protected string subject_desc;
        protected string firstGrade;
        protected string secondGrade;
        protected string average;
        protected string remarks;
        protected string sem;
        protected string grade_level;
        protected string section;
        protected string strand;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Strand
        {
            get { return strand; }
            set { strand = value; }
        }

        public string Section
        {
            get { return section; }
            set { section = value; }
        }

        public string Grade_level
        {
            get { return grade_level; }
            set { grade_level = value; }
        }


        public string Subject_desc
        {
            get { return subject_desc; }
            set { subject_desc = value; }
        }

        public string FirstGrade
        {
            get { return firstGrade; }
            set { firstGrade = value; }
        }

        public string SecondGrade
        {
            get { return secondGrade; }
            set { secondGrade = value; }
        }

        public string Average
        {
            get { return average; }
            set { average = value; }
        }

        public string Subject_code
        {
            get { return subject_code; }
            set { subject_code = value; }
        }

        public string Fullname
        {
            get { return fullname; }
            set { fullname = value; }
        }

        public string LRN_no
        {
            get { return lrn_no; }
            set { lrn_no = value; }
        }

        //Retrieve Data from DB
        public void LoadDataTable(DataGridView dgv)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(GOC_GS.Config.GetConnectionString()))
                {
                    con.Open();
                    string sql = "SELECT * FROM grading";

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


    }
}

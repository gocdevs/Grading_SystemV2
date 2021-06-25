using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace GOC_GS.Models
{
    class StudentData
    {
        //Initialize variable
        protected string lname;
        protected string grade_level;
        protected string strand;
        DataTable dt;

        public string Lname
        {
            get { return lname; }
            set { lname = value; }
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

        public void initDatagrid(DataGridView dgv)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(GOC_GS.Config.GetConnectionString()))
                {
                    con.Open();

                    string sql = "SELECT goc_no,lrn_no, CONCAT(fname,' ', Left(mname,1) ,'. ',lname) Fullname,grade_level,section,strand,academic_status FROM student_profile ORDER BY lname";

                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    MySqlDataAdapter da = new MySqlDataAdapter();

                    da.SelectCommand = cmd;

                    //initialize new datatable and load data to datagridview
                    dt = new DataTable();
                    da.Fill(dt);
                    dgv.DataSource = dt;

                    con.Close();
                }
            }

            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "Grading System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Load Datagrid
        public void LoadDataTable(DataGridView dgv)
        {
            if (grade_level != "" && strand == "" && lname == "")
            {
                try
                {
                    using (MySqlConnection con = new MySqlConnection(GOC_GS.Config.GetConnectionString()))
                    {
                        con.Open();

                        string sql = "SELECT goc_no,lrn_no, CONCAT(fname,' ', Left(mname,1) ,'. ',lname) Fullname,grade_level,section,strand,academic_status  FROM student_profile WHERE  grade_level ='" + grade_level + "'";

                        MySqlCommand cmd = new MySqlCommand(sql, con);
                        MySqlDataAdapter da = new MySqlDataAdapter();

                        da.SelectCommand = cmd;

                        //initialize new datatable and load data to datagridview
                        dt = new DataTable();
                        da.Fill(dt);
                        dgv.DataSource = dt;

                        con.Close();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("ERROR :  " + ex.ToString(), "Grading System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (grade_level == "" && strand != "" && lname == "")
            {
                try
                {
                    using (MySqlConnection con = new MySqlConnection(GOC_GS.Config.GetConnectionString()))
                    {
                        con.Open();

                        string sql = "SELECT goc_no,lrn_no, CONCAT(fname,' ', Left(mname,1) ,'. ',lname) Fullname,grade_level,section,strand,academic_status  FROM student_profile WHERE strand ='" + strand + "'";

                        MySqlCommand cmd = new MySqlCommand(sql, con);
                        MySqlDataAdapter da = new MySqlDataAdapter();

                        da.SelectCommand = cmd;

                        //initialize new datatable and load data to datagridview
                        dt = new DataTable();
                        da.Fill(dt);
                        dgv.DataSource = dt;

                        con.Close();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("ERROR : Data Not Found" + ex.ToString(), "Grading System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (grade_level != "" && strand != "" && lname == "")
            {
                try
                {
                    using (MySqlConnection con = new MySqlConnection(GOC_GS.Config.GetConnectionString()))
                    {
                        con.Open();

                        string sql = "SELECT goc_no,lrn_no, CONCAT(fname,' ', Left(mname,1) ,'. ',lname) Fullname,grade_level,section,strand,academic_status FROM student_profile WHERE grade_level ='" + grade_level + "'AND strand ='" + strand + "'";

                        MySqlCommand cmd = new MySqlCommand(sql, con);
                        MySqlDataAdapter da = new MySqlDataAdapter();

                        da.SelectCommand = cmd;

                        //initialize new datatable and load data to datagridview
                        dt = new DataTable();
                        da.Fill(dt);
                        dgv.DataSource = dt;

                        con.Close();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("ERROR : Data Not Found", "Grading System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (lname != "")

                try
                {
                    using (MySqlConnection con = new MySqlConnection(GOC_GS.Config.GetConnectionString()))
                    {
                        con.Open();

                        string sql = "SELECT goc_no,lrn_no, CONCAT(fname,' ', Left(mname,1) ,'. ',lname) Fullname,grade_level,section,strand,academic_status FROM student_profile WHERE lname Like '%" + lname + "%'";

                        MySqlCommand cmd = new MySqlCommand(sql, con);
                        MySqlDataAdapter da = new MySqlDataAdapter();

                        da.SelectCommand = cmd;

                        //initialize new datatable and load data to datagridview
                        dt = new DataTable();
                        da.Fill(dt);
                        dgv.DataSource = dt;

                        con.Close();
                    }
                }

                catch (MySqlException ex)
                {
                    MessageBox.Show("ERROR : " + ex.ToString(), "Grading System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
    }
    //End of Load


}

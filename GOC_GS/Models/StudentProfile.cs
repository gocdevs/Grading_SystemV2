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
                                    range.Cells[xlRow, 9].Text
                                    );
                    }
                    //end load datagrid

                    workbook.Close();
                    application.Quit();
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

                    string sql = "INSERT INTO student_profile(goc_no ,lrn_no ,fname ,mname ,lname,grade_level,section,strand,academic_status) " +
                                    " VALUES (@goc_no,@lrn_no,@fname,@mname,@lname,@grade_level,@section,@strand,@academic_status);";

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

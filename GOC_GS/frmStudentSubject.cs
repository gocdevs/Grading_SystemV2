using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOC_GS
{
    public partial class frmStudentSubject : Form
    {
        Models.StudentData studentData = new Models.StudentData();
        Section section = new Section();
        Strand strand = new Strand();
        Subjects subject = new Subjects();
        List<Subjects> subject_list = new List<Subjects>();

        DataTable dt = new DataTable();
        BindingSource bs = new BindingSource();

        //DataTable subject_dt = new DataTable();
        //BindingSource subject_bs = new BindingSource();

        public frmStudentSubject()
        {
            InitializeComponent();
            studentData.LoadStudentList(dgvStudentName);
            HeaderFix(dgvStudentName);

            section.LoadCombo(cmbSection);
            strand.LoadCombo(cmbStrand);

            //subject.LoadDataTable(dgvSubjects);

          
            LoadMe();

        }

        public void LoadMe()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(GOC_GS.Config.GetConnectionString()))
                {
                    con.Open();

                    string sql = "SELECT CONCAT(fname,' ', Left(mname,1) ,'. ',lname) FullName, section FROM student_profile";

                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    MySqlDataAdapter da = new MySqlDataAdapter();

                    da.SelectCommand = cmd;

                    //initialize new datatable and load data to datagridview
                    dt = new DataTable();
                    bs = new BindingSource();
                    da.Fill(dt);

                    bs.DataSource = dt;
                    dgvStudentName.DataSource = bs;

                    con.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR :  " + ex.ToString(), "Grading System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        public void HeaderFix(DataGridView dgv)
        {
            #region Header Name           
            dgv.Columns["section"].HeaderText = "Section";//to fix the header Name           
            DataGridViewColumn FillSize = dgv.Columns[0];
            FillSize.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DataGridViewColumn FillSize2 = dgv.Columns[1];
            FillSize2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            #endregion
        }

        private void cmbSection_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            bs.Filter = string.Format("section LIKE '%{0}%'", cmbSection.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //clear list
            subject_list.Clear();
            dgvSubjects.Rows.Clear();
            //pass value to list
          
            subject.Semester = cmbSemester.Text;
            subject.Grade_level = cmbGradeLevel.Text;
            subject_list = subject.LoadThisSubjects();

            //loop through load it to list view
            foreach (var item in subject_list)
            {
                dgvSubjects.Rows.Add(item.Id, item.Subject_code, item.Subject_name, item.Grade_level, item.Subject_type, item.Strand, item.Semester);
            }//End LoadSchedule()
        }
    }
}

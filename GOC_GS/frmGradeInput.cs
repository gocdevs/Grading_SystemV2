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
    public partial class frmGradeInput : Form
    {
        StudentGrade studentGrade = new StudentGrade();
        Strand strand = new Strand();

        FacultyLoading fl = new FacultyLoading();
        List<FacultyLoading> fList = new List<FacultyLoading>();

        Section section = new Section();
        List<Section> sections = new List<Section>();

        frmMain main = new frmMain();
        
        public frmGradeInput()
        {
            InitializeComponent();
            studentGrade.LoadDataTable(dgvList);
            //strand.LoadCombo(cmbStrand);
        }

        private void FilterSection()
        {
            //clear list
            sections.Clear();
            sections = section.LoadSection();

            cmbSection.Items.Clear();
            //loop through load it to list view
            foreach (var item in sections)
            {
                if (cmbGradeLevel.Text == item.Grade_Level)
                {
                    cmbSection.Items.Add(item.Section_name);
                }               
            }           
        }

        private void FilterSubject()
        {
            //clear list
            fList.Clear();
            fList = fl.FilterSubjectViaSection();

            cmbSubject.Items.Clear();
            //loop through load it to list view
            foreach (var item in fList)
            {
                if (cmbSection.Text == item.Section && main.lblFacultyId.Text == item.Faculty_id )
                {
                    cmbSubject.Items.Add(item.SubjectCode);
                }
            }
        }

        private void cmbGradeLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterSection();
        }

        private void cmbGradeLevel_Click(object sender, EventArgs e)
        {
            FilterSection();
        }

        private void cmbSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterSubject();
        }

        private void cmbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(GOC_GS.Config.GetConnectionString()))
                {
                    con.Open();
                    string sql = "SELECT * FROM grading WHERE sem = '"+cmbTerm.Text+ "' AND subject_code='"+cmbSubject.Text+"'";
                    //string sql = "SELECT * FROM grading WHERE subject_code '" + cmbSubject.Text + "' and sem '" + cmbTerm.Text + "' and  grade_level '" + cmbGradeLevel.Text + "'" +
                    //    " and section '" + cmbSection.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    MySqlDataAdapter da = new MySqlDataAdapter();

                    da.SelectCommand = cmd;

                    //initialize new datatable and load data to datagridview
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvList.DataSource = dt;

                    con.Close();
                }
            }

            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "Grading System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

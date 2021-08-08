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
    public partial class frmStudentInfo : Form
    {
        public string goc_no, lrn_no, fname, lname, mname, grade_level, section, strand, academic_status, fullname;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int id;


        Models.StudentProfile sp = new Models.StudentProfile();
        List<Models.StudentProfile> sp_list = new List<Models.StudentProfile>();

        Grading gs = new Grading();
        List<Grading> gs_list = new List<Grading>();


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            sp.Id = id;
            sp.GOC_No = txtGOC.Text;
            sp.LRN_No = txtLRN.Text;
            sp.FName = txtFName.Text;
            sp.LName = txtLName.Text;
            sp.MName = txtMName.Text;
            sp.Grade_Level = txtGLevel.Text;
            sp.Strand = txtStrand.Text;
            sp.Section = txtSection.Text;
            sp.Academic_Status = txtAcademicStat.Text;

            sp.Update();

            //fullname = String.Len();
            //MessageBox.Show(fullname);

            gs.LRN_No = txtLRN.Text;
            gs_list = gs.Get_Name();           
            foreach (var item in gs_list)
            {
                fullname = item.Fullname;
            }

            gs.LRN_No = txtLRN.Text;
            gs.Fullname = fullname;
            gs.Update_Name();

        }

        public frmStudentInfo()
        {
            InitializeComponent();
        }

        public void Render()
        {
            txtId.Text = id.ToString();
            txtGOC.Text = goc_no;
            txtLRN.Text = lrn_no;
            txtFName.Text = fname;
            txtLName.Text = lname;
            txtMName.Text = mname;
            txtGLevel.Text = grade_level;
            txtStrand.Text = strand;
            txtSection.Text = section;
            txtAcademicStat.Text = academic_status;
        }

    }
}

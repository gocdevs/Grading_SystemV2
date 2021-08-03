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
        public string goc_no, lrn_no, fname, lname, mname, grade_level, section, strand, academic_status;
        public frmStudentInfo()
        {
            InitializeComponent();
        }

        public void Render()
        {
            //    info.goc_no = dgvStudentList.Rows[e.RowIndex].Cells[1].Value.ToString();
            //    info.lrn_no = dgvStudentList.Rows[e.RowIndex].Cells[2].Value.ToString();
            //    info.fullname = dgvStudentList.Rows[e.RowIndex].Cells[3].Value.ToString();
            //    info.grade_level = dgvStudentList.Rows[e.RowIndex].Cells[4].Value.ToString();
            //    info.section = dgvStudentList.Rows[e.RowIndex].Cells[5].Value.ToString();
            //    info.strand = dgvStudentList.Rows[e.RowIndex].Cells[6].Value.ToString();
            //    info.academic_status = dgvStudentList.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtGOC.Text = goc_no;
            txtLRN.Text = lrn_no;
            txtFName.Text = fname;
            txtLName.Text = lname;
            txtMName.Text = mname;
            txtGLevel.Text = grade_level;
            txtStrand.Text = strand;
            txtSection.Text = section;
        }

    }
}

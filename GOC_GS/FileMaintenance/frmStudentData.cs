using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GOC_GS.Models;

namespace GOC_GS.FileMaintenance
{
    public partial class frmStudentData : Form
    {
        public frmStudentData()
        {
            InitializeComponent();
            strand.LoadCombo(cmbStrand);
            sda.initDatagrid(dgvStudentList);
            HeaderFixSubject(dgvStudentList);
        }


        public void HeaderFixSubject(DataGridView dgv)
        {
            #region Header Name
            //dgv.Columns["id"].Visible = false;
            dgv.Columns["Fullname"].HeaderText = "Name";//to fix the header Name
            dgv.Columns["goc_no"].HeaderText = "GOC No.";//to fix the header Name
            dgv.Columns["lrn_no"].HeaderText = "LRN No.";//to fix the header Name
            dgv.Columns["grade_level"].HeaderText = "Grade Level";//to fix the header Name
            dgv.Columns["section"].HeaderText = "Section";//to fix the header Name
            dgv.Columns["strand"].HeaderText = "Strand";//to fix the header Name
            dgv.Columns["academic_status"].HeaderText = "Academic Status";//to fix the header Name

            DataGridViewColumn FillSize = dgv.Columns[2];
            FillSize.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DataGridViewColumn FillSize1 = dgv.Columns[3];
            FillSize1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            #endregion
        }

        StudentData sda = new StudentData();
        Strand strand = new Strand();

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            sda.Lname = txtSearch.Text;
            sda.Grade_level = cmbGradeLevel.Text;
            sda.Strand = cmbStrand.Text;
            sda.LoadDataTable(dgvStudentList);
        }

        private void cmbGradeLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            sda.Lname = txtSearch.Text;
            sda.Grade_level = cmbGradeLevel.Text;
            sda.Strand = cmbStrand.Text;
            sda.LoadDataTable(dgvStudentList);
        }

        private void cmbStrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            sda.Lname = txtSearch.Text;
            sda.Grade_level = cmbGradeLevel.Text;
            sda.Strand = cmbStrand.Text;
            sda.LoadDataTable(dgvStudentList);
        }
    }
}

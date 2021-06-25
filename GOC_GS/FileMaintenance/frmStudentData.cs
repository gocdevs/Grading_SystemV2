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

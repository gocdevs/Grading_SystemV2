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
    public partial class frmStudentProfile : Form
    {
        public frmStudentProfile()
        {
            InitializeComponent();
        }

        StudentProfile student_Profile = new StudentProfile();
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            student_Profile.openFile();
            txtFilePath.Text = student_Profile.FilePath;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            student_Profile.FilePath = txtFilePath.Text;
            student_Profile.importFile(dgvStudentList);
        }
    }
}

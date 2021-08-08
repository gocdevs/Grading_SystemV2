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
            //tmrCount.Enabled = true;
            student_Profile.FilePath = txtFilePath.Text;
            student_Profile.importFile(dgvStudentList);                      
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveToDatabase_Click(object sender, EventArgs e)
        {
            Util_RequiredFields util = new Util_RequiredFields();

            if (dgvStudentList.RowCount > 0)
            {
                for (int i = 0; i < dgvStudentList.Rows.Count; i++)
                {
                    student_Profile.GOC_No = dgvStudentList.Rows[i].Cells[0].Value.ToString();
                    student_Profile.LRN_No = dgvStudentList.Rows[i].Cells[1].Value.ToString();
                    student_Profile.FName = util.ToProperCase(dgvStudentList.Rows[i].Cells[2].Value.ToString());
                    student_Profile.MName = util.ToProperCase(dgvStudentList.Rows[i].Cells[3].Value.ToString());
                    student_Profile.LName = util.ToProperCase(dgvStudentList.Rows[i].Cells[4].Value.ToString());
                    student_Profile.Grade_Level = dgvStudentList.Rows[i].Cells[5].Value.ToString();
                    student_Profile.Section = util.ToProperCase(dgvStudentList.Rows[i].Cells[6].Value.ToString());
                    student_Profile.Strand = util.ToProperCase(dgvStudentList.Rows[i].Cells[7].Value.ToString());
                    student_Profile.Academic_Status = util.ToProperCase(dgvStudentList.Rows[i].Cells[8].Value.ToString());

                    student_Profile.Save();
                }

                MessageBox.Show("Data Successfully Save", "Grading System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                return;
            }
        }

        private void tmrCount_Tick(object sender, EventArgs e)
        {
            //pnlLoading.Visible = true;
            lblLoading.Refresh();
            lblLoading.Text = (dgvStudentList.Rows.Count) + " records saved.";            
        }
    }
}


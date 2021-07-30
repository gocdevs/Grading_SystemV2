using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GOC_GS.FileMaintenance;

namespace GOC_GS
{
    public partial class frmMain : Form
    {
        frmGradeInput grade = new frmGradeInput();
        public string Access_Control, Username, UserType, Teacher_Id;
        public frmMain()
        {
            InitializeComponent();
        }

        public void AccessGrant()
        {
            if (Access_Control.Equals("Admin"))
            {
                //MessageBox.Show("Welcome " + Access_Control + ": " + Last_Name + ", " + First_Name);
                //lblAccessTag.Text = "Logged in as " + Access_Control + "\n Name: " + Last_Name + ", " + First_Name;
                //lblIdNo.Text = Teacher_Id;
                //MessageBox.Show(Teacher_Id);
                lblFacultyId.Text = Teacher_Id;
                lblUser.Text = Username;
                lblUserStatus.Text = UserType;
                grade.teacher_id = Teacher_Id;
            }

            else if (Access_Control.Equals("Teacher"))
            {
                //MessageBox.Show("Welcome " + Access_Control + ": " + Last_Name + ", " + First_Name);
                //lblAccessTag.Text = "Logged in as " + Access_Control + "\n Name: " + Last_Name + ", " + First_Name;
                //lblIdNo.Text = Teacher_Id;
                //MessageBox.Show(Teacher_Id);
                lblFacultyId.Text = Teacher_Id;
                lblUser.Text = Username;
                lblUserStatus.Text = UserType;
                grade.teacher_id = Teacher_Id;

            }

        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlAllContainer.Controls.Clear();
            pnlAllContainer.Visible = true;

            //load the form
            frmFileMaintenance frm = new frmFileMaintenance();
            frm.TopLevel = false;
            frm.AutoScroll = true;

            pnlAllContainer.Controls.Add(frm);
            frm.Show();


            //frmSubjects f = new frmSubjects();
            //frmMain mainwin = (frmMain)Application.OpenForms["frmMain"];
            //mainwin.pnlAllContainer.Controls.Clear();
            //f.TopLevel = false;
            //f.AutoScroll = true;
            //mainwin.pnlAllContainer.Controls.Add(f);
            //f.Show();
        }

        private void btnGrading_Click(object sender, EventArgs e)
        {
            pnlAllContainer.Controls.Clear();
            pnlAllContainer.Visible = true;

            //load the form
            frmGradeInput frm = new frmGradeInput();
            frm.TopLevel = false;
            frm.AutoScroll = true;
            frm.teacher_id = Teacher_Id;
            pnlAllContainer.Controls.Add(frm);
            frm.Show();
        }

        private void btnViewGrades_Click(object sender, EventArgs e)
        {
            
        }

        private void btnConSettings_Click(object sender, EventArgs e)
        {
            frmConnectionSettings frm = new frmConnectionSettings();
            frm.ShowDialog();
        }

        private void btnFacultyLoading_Click(object sender, EventArgs e)
        {
            pnlAllContainer.Controls.Clear();
            pnlAllContainer.Visible = true;

            //load the form
            frmFacultySetUp frm = new frmFacultySetUp();
            frm.TopLevel = false;
            frm.AutoScroll = true;

            pnlAllContainer.Controls.Add(frm);
            frm.Show();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
           
        }

        private void btnStudentData_Click(object sender, EventArgs e)
        {
            pnlAllContainer.Controls.Clear();
            pnlAllContainer.Visible = true;

            //load the form
            frmStudentData frm = new frmStudentData();
            frm.TopLevel = false;
            frm.AutoScroll = true;

            pnlAllContainer.Controls.Add(frm);
            frm.Show();
        }

        private void btnStudentSubject_Click(object sender, EventArgs e)
        {
            pnlAllContainer.Controls.Clear();
            pnlAllContainer.Visible = true;

            //load the form
            frmStudentSubject frm = new frmStudentSubject();
            frm.TopLevel = false;
            frm.AutoScroll = true;

            pnlAllContainer.Controls.Add(frm);
            frm.Show();
        }
    }
}

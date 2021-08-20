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
        List<Panel> listpanel = new List<Panel>();
        private int index;
        public frmMain()
        {
            InitializeComponent();

            listpanel.Add(pnlAdminView);
            listpanel.Add(pnlTeacherView);            
            listpanel[index].BringToFront();
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
                grade.teacher_name = Username;

                //pnlAdminView.Visible = true;
                //pnlAdminView.Location = new Point(7, 200);
                listpanel[0].BringToFront();
                listpanel[0].Visible = true;
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
                grade.teacher_name = Username;

                //pnlTeacherView.Visible = true;
                //pnlTeacherView.Location = new Point(200, 200);
                listpanel[1].BringToFront();
                listpanel[1].Visible = true;

            }

        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           


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
            

        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDashBoard_Click_1(object sender, EventArgs e)
        {
            pnlAllContainer.Controls.Clear();
            pnlAllContainer.Visible = true;

            //load the form
            frmDashboard frm = new frmDashboard();
            frm.TopLevel = false;
            frm.AutoScroll = true;

            pnlAllContainer.Controls.Add(frm);
            frm.Show();
        }

        private void btnFileMaintenance_Click(object sender, EventArgs e)
        {
            pnlAllContainer.Controls.Clear();
            pnlAllContainer.Visible = true;

            //load the form
            frmFileMaintenance frm = new frmFileMaintenance();
            frm.TopLevel = false;
            frm.AutoScroll = true;

            pnlAllContainer.Controls.Add(frm);
            frm.Show();
        }

        private void btnFacultyLoading_Click_1(object sender, EventArgs e)
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

        private void btnStudentSubject_Click_1(object sender, EventArgs e)
        {
            pnlAllContainer.Controls.Clear();
            pnlAllContainer.Visible = true;

            //load the form
            frmStudentType frm = new frmStudentType();
            frm.TopLevel = false;
            frm.AutoScroll = true;

            pnlAllContainer.Controls.Add(frm);
            frm.Show();
        }

        private void btnStudentData_Click_1(object sender, EventArgs e)
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

        private void btnGrading_Click_1(object sender, EventArgs e)
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

        private void btnGrading_Click_2(object sender, EventArgs e)
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

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport();
            frm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
           
        }

        private void btnStudentData_Click(object sender, EventArgs e)
        {
            
        }

        private void btnStudentSubject_Click(object sender, EventArgs e)
        {
            
        }
    }
}

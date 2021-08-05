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
    public partial class frmFileMaintenance : Form
    {
        public frmFileMaintenance()
        {
            InitializeComponent();
        }

        private void btnSubjects_Click(object sender, EventArgs e)
        {
            frmSubjects frm = new frmSubjects();
            frmMain mainwin = (frmMain)Application.OpenForms["frmMain"];
            mainwin.pnlAllContainer.Controls.Clear();
            frm.TopLevel = false;
            frm.AutoScroll = true;
            mainwin.pnlAllContainer.Controls.Add(frm);
            frm.Show();
        }

        private void btnSection_Click(object sender, EventArgs e)
        {
            frmSection frm = new frmSection();
            frmMain mainwin = (frmMain)Application.OpenForms["frmMain"];
            mainwin.pnlAllContainer.Controls.Clear();
            frm.TopLevel = false;
            frm.AutoScroll = true;
            mainwin.pnlAllContainer.Controls.Add(frm);
            frm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStrand_Click(object sender, EventArgs e)
        {
            frmStrand frm = new frmStrand();
            frmMain mainwin = (frmMain)Application.OpenForms["frmMain"];
            mainwin.pnlAllContainer.Controls.Clear();
            frm.TopLevel = false;
            frm.AutoScroll = true;
            mainwin.pnlAllContainer.Controls.Add(frm);
            frm.Show();
        }

        private void btnSubjectType_Click(object sender, EventArgs e)
        {
            frmSubjectType frm = new frmSubjectType();
            frmMain mainwin = (frmMain)Application.OpenForms["frmMain"];
            mainwin.pnlAllContainer.Controls.Clear();
            frm.TopLevel = false;
            frm.AutoScroll = true;
            mainwin.pnlAllContainer.Controls.Add(frm);
            frm.Show();
        }

        private void btnFaculty_Click(object sender, EventArgs e)
        {
            frmFaculty frm = new frmFaculty();
            frmMain mainwin = (frmMain)Application.OpenForms["frmMain"];
            mainwin.pnlAllContainer.Controls.Clear();
            frm.TopLevel = false;
            frm.AutoScroll = true;
            mainwin.pnlAllContainer.Controls.Add(frm);
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmStudentProfile frm = new frmStudentProfile();
            frmMain mainwin = (frmMain)Application.OpenForms["frmMain"];
            mainwin.pnlAllContainer.Controls.Clear();
            frm.TopLevel = false;
            frm.AutoScroll = true;
            mainwin.pnlAllContainer.Controls.Add(frm);
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmUsers frm = new frmUsers();
            frmMain mainwin = (frmMain)Application.OpenForms["frmMain"];
            mainwin.pnlAllContainer.Controls.Clear();
            frm.TopLevel = false;
            frm.AutoScroll = true;
            mainwin.pnlAllContainer.Controls.Add(frm);
            frm.Show();

        }
    }
}

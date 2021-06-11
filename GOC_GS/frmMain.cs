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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
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
            frmFacultyLoadings frm = new frmFacultyLoadings();
            frm.TopLevel = false;
            frm.AutoScroll = true;

            pnlAllContainer.Controls.Add(frm);
            frm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

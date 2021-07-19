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
    public partial class frmFacultySetUp : Form
    {
        public frmFacultySetUp()
        {
            InitializeComponent();
        }

        private void btnLoadSection_Click(object sender, EventArgs e)
        {
            frmFacultyLoadSection frm = new frmFacultyLoadSection();
            frmMain mainwin = (frmMain)Application.OpenForms["frmMain"];
            mainwin.pnlAllContainer.Controls.Clear();
            frm.TopLevel = false;
            frm.AutoScroll = true;
            mainwin.pnlAllContainer.Controls.Add(frm);
            frm.Show();
        }

        private void btnLoads_Click(object sender, EventArgs e)
        {
            frmFacultyLoadings frm = new frmFacultyLoadings();
            frmMain mainwin = (frmMain)Application.OpenForms["frmMain"];
            mainwin.pnlAllContainer.Controls.Clear();
            frm.TopLevel = false;
            frm.AutoScroll = true;
            mainwin.pnlAllContainer.Controls.Add(frm);
            frm.Show();
        }
    }
}

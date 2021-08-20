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
    public partial class frmStudentType : Form
    {
        public frmStudentType()
        {
            InitializeComponent();
        }

        private void btnRegular_Click(object sender, EventArgs e)
        {
            frmStudentSubject frm = new frmStudentSubject();
            frmMain mainwin = (frmMain)Application.OpenForms["frmMain"];
            mainwin.pnlAllContainer.Controls.Clear();
            frm.TopLevel = false;
            frm.AutoScroll = true;
            mainwin.pnlAllContainer.Controls.Add(frm);
            frm.Show();
        }
    }
}

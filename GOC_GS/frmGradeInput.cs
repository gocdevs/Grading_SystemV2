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
    public partial class frmGradeInput : Form
    {
        StudentGrade studentGrade = new StudentGrade();
        Strand strand = new Strand();
        
        public frmGradeInput()
        {
            InitializeComponent();
            studentGrade.LoadDataTable(dgvList);
            //strand.LoadCombo(cmbStrand);

        }
    }
}

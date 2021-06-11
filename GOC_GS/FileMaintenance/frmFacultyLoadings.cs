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
    public partial class frmFacultyLoadings : Form
    {
        Section section = new Section();
        Strand strand = new Strand();
        Subjects subjects = new Subjects();
       

        List<Subjects> subjects_list = new List<Subjects>();
        List<Strand> strands_list = new List<Strand>();
        List<Section> sections_list = new List<Section>();
       
        public frmFacultyLoadings()
        {
            InitializeComponent();
            subjects.LoadDataTable(dgvSubjects);
            section.LoadCombo(cmbSection);
            strand.LoadCombo(cmbStrand);
           
            HeaderFixSubject(dgvSubjects);
        }

        public void HeaderFixSubject(DataGridView dgv)
        {
            #region Header Name
            dgv.Columns["id"].Visible = false;
            dgv.Columns["subject_code"].HeaderText = "Subject Code";//to fix the header Name
            dgv.Columns["subject_name"].HeaderText = "Subject Name";//to fix the header Name
            dgv.Columns["subject_type"].HeaderText = "Subject Type";//to fix the header Name
            dgv.Columns["semester"].HeaderText = "Semester";//to fix the header Name
            dgv.Columns["grade_level"].HeaderText = "Grade Level";//to fix the header Name
            dgv.Columns["strand"].HeaderText = "Strand";//to fix the header Name

            DataGridViewColumn FillSize = dgv.Columns[2];
            FillSize.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DataGridViewColumn FillSize1 = dgv.Columns[3];
            FillSize1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            #endregion
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

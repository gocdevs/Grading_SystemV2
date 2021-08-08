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
    public partial class frmStudentData : Form
    {
        StudentProfile sp = new StudentProfile();
        List<StudentProfile> sp_list = new List<StudentProfile>();

        frmStudentInfo info = new frmStudentInfo();

        public frmStudentData()
        {
            InitializeComponent();
            strand.LoadCombo(cmbStrand);
            //sda.LoadGrid(dgvStudentList);
            Load();
            //HeaderFixSubject(dgvStudentList);
            AddImageDataGrid(dgv);
        }
        public void AddImageDataGrid(DataGridView dgv)
        {
            DataGridViewImageColumn dimg = new DataGridViewImageColumn();
            dimg.Image = Properties.Resources.edit;
            dimg.HeaderText = "Edit";
            dimg.ImageLayout = DataGridViewImageCellLayout.Normal;
            dimg.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv.Columns.Add(dimg);            
        }

        public void Load()
        {
            sp_list.Clear();
            sp_list = sp.LoadStudent();
            foreach (var item in sp_list)
            {
                dgv.Rows.Add(item.Id,item.GOC_No,item.LRN_No ,item.FName, item.MName, item.LName, item.Grade_Level, item.Section, item.Strand, item.Academic_Status);              
            }         
        }


        public void HeaderFixSubject(DataGridView dgv)
        {
            #region Header Name
            dgv.Columns["id"].Visible = false;
            dgv.Columns["goc_no"].HeaderText = "GOC No.";//to fix the header Name
            dgv.Columns["lrn_no"].HeaderText = "LRN No.";//to fix the header Name
            dgv.Columns["fname"].HeaderText = "First Name";//to fix the header Name
            dgv.Columns["mname"].HeaderText = "Middle Name";//to fix the header Name
            dgv.Columns["lname"].HeaderText = "Last Name";//to fix the header Name          
            dgv.Columns["grade_level"].HeaderText = "Grade Level";//to fix the header Name
            dgv.Columns["section"].HeaderText = "Section";//to fix the header Name
            dgv.Columns["strand"].HeaderText = "Strand";//to fix the header Name
            dgv.Columns["academic_status"].HeaderText = "Academic Status";//to fix the header Name

            //DataGridViewColumn FillSize = dgv.Columns[2];
            //FillSize.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //DataGridViewColumn FillSize1 = dgv.Columns[3];
            //FillSize1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            #endregion
        }

        StudentData sda = new StudentData();
        Strand strand = new Strand();

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            sda.Lname = txtSearch.Text;
            sda.Grade_level = cmbGradeLevel.Text;
            sda.Strand = cmbStrand.Text;
            sda.LoadDataTable(dgvStudentList);
        }

        private void cmbGradeLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            sda.Lname = txtSearch.Text;
            sda.Grade_level = cmbGradeLevel.Text;
            sda.Strand = cmbStrand.Text;
            sda.LoadDataTable(dgvStudentList);
        }

        private void cmbStrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            sda.Lname = txtSearch.Text;
            sda.Grade_level = cmbGradeLevel.Text;
            sda.Strand = cmbStrand.Text;
            sda.LoadDataTable(dgvStudentList);
        }

       
        
        private void dgvStudentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
       
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 10)//select to edit
            {
                //MessageBox.Show("aa");
                //pass value to edit mode
                info.id = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[0].Value.ToString());
                info.goc_no = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                info.lrn_no = dgv.Rows[e.RowIndex].Cells[2].Value.ToString();

                info.fname = dgv.Rows[e.RowIndex].Cells[3].Value.ToString();                
                info.mname = dgv.Rows[e.RowIndex].Cells[4].Value.ToString();
                info.lname = dgv.Rows[e.RowIndex].Cells[5].Value.ToString();

                info.grade_level = dgv.Rows[e.RowIndex].Cells[6].Value.ToString();
                info.section = dgv.Rows[e.RowIndex].Cells[7].Value.ToString();
                info.strand = dgv.Rows[e.RowIndex].Cells[8].Value.ToString();
                info.academic_status = dgv.Rows[e.RowIndex].Cells[9].Value.ToString();
            }

            //info.Show();

            //frmFacultyLoadSection frm = new frmFacultyLoadSection();
            frmMain mainwin = (frmMain)Application.OpenForms["frmMain"];
            mainwin.pnlAllContainer.Controls.Clear();
            info.TopLevel = false;
            info.AutoScroll = true;
            mainwin.pnlAllContainer.Controls.Add(info);
            info.Show();


            info.Render();
            


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

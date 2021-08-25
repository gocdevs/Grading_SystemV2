using MySql.Data.MySqlClient;
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

        FacultyLoading fl = new FacultyLoading();
        List<FacultyLoading> fList = new List<FacultyLoading>();

        Section section = new Section();
        List<Section> sections = new List<Section>();

      
      

        Grading grade = new Grading();
        List<Grading> grades = new List<Grading>();

        public string teacher_id, teacher_name;

        public frmGradeInput()
        {
            InitializeComponent();
            cmbGender.Text = "Male";
            //studentGrade.LoadDataTable(dgvList);
            //strand.LoadCombo(cmbStrand);

            //handle this to handle keypress event...
            dgvGrades.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(dgvGrades_EditingControlShowing);
            dgvGrades.CellEndEdit += new DataGridViewCellEventHandler(dgvGrades_CellEndEdit);

            ((DataGridViewTextBoxColumn)dgvGrades.Columns[5]).MaxInputLength = 5;
            ((DataGridViewTextBoxColumn)dgvGrades.Columns[6]).MaxInputLength = 5;
        }

        private void RecordCount()
        {         
            
            lblNum.Text = dgvGrades.Rows.Count.ToString();
        }

        public void HeaderFix(DataGridView dgv)
        {
            #region Header Name
            dgv.Columns["id"].Visible = false;
            dgv.Columns["units"].Visible = false;
            dgv.Columns["subject_code"].Visible = false;
            dgv.Columns["subject_desc"].Visible = false;
            dgv.Columns["sem"].Visible = false;
            dgv.Columns["grade_level"].Visible = false;
            dgv.Columns["section"].Visible = false;
            dgv.Columns["strand"].Visible = false;

            dgv.Columns["lrn_no"].HeaderText = "LRN No.";
            dgv.Columns["fullname"].HeaderText = "Student Name";
            //dgv.Columns["subject_code"].HeaderText = "Subject Code";
            dgv.Columns["first_or_3rd_Q"].HeaderText = "First Quarter";
            dgv.Columns["second_or_4th_Q"].HeaderText = "Second Quarter";
            dgv.Columns["average"].HeaderText = "Average";
            dgv.Columns["remarks"].HeaderText = "Remarks";

            DataGridViewColumn FillSize = dgv.Columns[2];
            FillSize.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //DataGridViewColumn FillSize2 = dgv.Columns[3];
            //FillSize2.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DataGridViewColumn FillSize3 = dgv.Columns[6];
            FillSize3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DataGridViewColumn FillSize4 = dgv.Columns[7];
            FillSize4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            #endregion
        }

        private void FilterSection()
        {
            ////clear list
            //sections.Clear();
            //sections = section.LoadSection();

            //cmbSection.Items.Clear();
            ////loop through load it to list view
            //foreach (var item in sections)
            //{
            //    if (cmbGradeLevel.Text == item.Grade_Level)
            //    {
            //        cmbSection.Items.Add(item.Section_name);
            //    }               
            //}
            //

            //clear list
            fList.Clear();
            fl.Faculty_id = teacher_id;
            fList = fl.FilterSubjectViaSection();

            cmbSection.Items.Clear();
            //loop through load it to list view

            //foreach (var item in fList)
            //{
            //    if (cmbGradeLevel.Text == item.GradeLevel && teacher_id == item.Faculty_id)
            //    {
            //        cmbSection.Items.Add(item.Section.Distinct().ToArray());
            //    }
            //}

            foreach (var item in fList)
            {
                
                cmbSection.Items.Add(item.Section);
               
            }
        }

        private void FilterSubject()
        {
            //clear list
            fList.Clear();
            fl.Faculty_id = teacher_id;
            fl.Section = cmbSection.Text;
            fList = fl.LoadSubjectCode();

            cmbSubject.Items.Clear();
            //loop through load it to list view
            
            foreach (var item in fList)
            {
                
                    cmbSubject.Items.Add(item.SubjectCode);
                
            }
        }

        private void cmbGradeLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterSection();
        }

        private void cmbGradeLevel_Click(object sender, EventArgs e)
        {
            FilterSection();
        }

        private void cmbSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterSubject();
        }

        private void cmbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbTerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTerm.SelectedIndex == 0)
            {
                dgvGrades.Columns[5].HeaderText = "First Quarter";
                dgvGrades.Columns[6].HeaderText = "Second Quarter";               
               
            }
            else
            {
                dgvGrades.Columns[5].HeaderText = "Third Quarter";
                dgvGrades.Columns[6].HeaderText = "Fourth Quarter";               
                
            }            
        }

        public void LoadGrading()
        {
            //clear list
            grades.Clear();
            dgvGrades.Rows.Clear();
            //pass value to list
            grades = grade.Load();

            //loop through load it to list view
            foreach (var item in grades)
            {
                if (item.Subject_Code == cmbSubject.Text && item.Sem == cmbTerm.Text && cmbSection.Text == item.Section)
                {
                    dgvGrades.Rows.Add(item.Id, item.GOC_No, item.Fullname, item.Subject_Code, item.Units, item.FirstGrade, item.SecondGrade, item.Average, item.Remarks, item.Sem, item.Grade_level, item.Section, item.Strand);
                   
                }
                //else
                //{
                //    MessageBox.Show("NO STUDENTS FOUND");
                //}                                
            }//End LoadSchedule()

            lblSection.Text = cmbSection.Text;
        }

        private void dgvGrades_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow rw in this.dgvGrades.Rows)
            {
                for (int i = 0; i < rw.Cells.Count; i++)
                {
                    if (rw.Cells[i].Value == null || rw.Cells[i].Value == DBNull.Value || String.IsNullOrWhiteSpace(rw.Cells[i].Value.ToString()))
                    {
                        //MessageBox.Show("No Empty grades");
                        rw.Cells[i].Value = "0";
                        break;
                    }
                }
            }

            //dgvGrades.Rows[n].Cells[5] --- First Quarter
            //dgvGrades.Rows[n].Cells[6] --- Second Quarter
            //dgvGrades.Rows[n].Cells[7] --- OUTPUT

            #region Validate Remarks Passed of Failed
            for (int n = 0; n < dgvGrades.Rows.Count; n++)
            {
                double num1 = Convert.ToDouble(dgvGrades.Rows[n].Cells[6].Value);
                double num2 = Convert.ToDouble(dgvGrades.Rows[n].Cells[5].Value);
                double average = (num1 + num2) / 2;
                double ans = Math.Round(average, MidpointRounding.AwayFromZero);


                //string average = ((Double.Parse(dgvGrades.Rows[n].Cells[6].Value.ToString()) + Double.Parse(dgvGrades.Rows[n].Cells[5].Value.ToString())) / 2).ToString("0.##");
                //double ans = Math.Round(Convert.ToDouble(average),0);
                dgvGrades.Rows[n].Cells[7].Value = ans.ToString("0.##");
            }

            foreach (DataGridViewRow Myrow in dgvGrades.Rows)
            {   //Here 2 cell is target value and 1 cell is Volume
                if (Convert.ToDouble(Myrow.Cells[7].Value) < 75)// Or your condition 
                {                   
                    Myrow.Cells[8].Style.BackColor = ColorTranslator.FromHtml("#FF7E61");
                    Myrow.Cells[8].Style.ForeColor = ColorTranslator.FromHtml("#00000");                   
                    Myrow.Cells[8].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    Myrow.Cells[8].Value = "FAILED";
                }
                else
                {
                    Myrow.Cells[8].Style.BackColor = ColorTranslator.FromHtml("#0080CF");
                    Myrow.Cells[8].Style.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
                    Myrow.Cells[8].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    Myrow.Cells[8].Value = "PASSED";
                  
                }
            }


            #endregion

            #region for Cell [5]
            foreach (DataGridViewRow Myrow in dgvGrades.Rows)
            {   //Here 2 cell is target value and 1 cell is Volume
                if (Convert.ToDouble(Myrow.Cells[5].Value) < 75 && Convert.ToDouble(Myrow.Cells[5].Value) >= 60 && Convert.ToDouble(Myrow.Cells[5].Value) != 0)// Or your condition 
                {
                    Myrow.Cells[5].Style.BackColor = ColorTranslator.FromHtml("#3C66A2");
                    Myrow.Cells[5].Style.ForeColor = Color.White;
                    //Myrow.Cells[5].Value = "0";
                }
                else if (Convert.ToDouble(Myrow.Cells[5].Value) < 60 && Convert.ToDouble(Myrow.Cells[5].Value) != 0)
                {
                    Myrow.Cells[5].Style.BackColor = Color.White;
                    Myrow.Cells[5].Style.ForeColor = Color.Black;
                    Myrow.Cells[5].Value = "0";
                }
                else if (Convert.ToDouble(Myrow.Cells[5].Value) > 100)
                {
                    Myrow.Cells[5].Style.BackColor = Color.White;
                    Myrow.Cells[5].Style.ForeColor = Color.Black;
                    Myrow.Cells[5].Value = "0";
                }                
            }
            #endregion

            #region for cell[6]
            foreach (DataGridViewRow Myrow in dgvGrades.Rows)
            {   //Here 2 cell is target value and 1 cell is Volume
                if (Convert.ToDouble(Myrow.Cells[6].Value) < 75 && Convert.ToDouble(Myrow.Cells[6].Value) >= 60 && Convert.ToDouble(Myrow.Cells[6].Value) != 0)// Or your condition 
                {
                    Myrow.Cells[6].Style.BackColor = ColorTranslator.FromHtml("#3C66A2");
                    Myrow.Cells[6].Style.ForeColor = Color.White;
                    //Myrow.Cells[5].Value = "0";
                }
                else if (Convert.ToDouble(Myrow.Cells[6].Value) < 60 && Convert.ToDouble(Myrow.Cells[6].Value) != 0)
                {
                    Myrow.Cells[6].Style.BackColor = Color.White;
                    Myrow.Cells[6].Style.ForeColor = Color.Black;
                    Myrow.Cells[6].Value = "0";
                }
                else if (Convert.ToDouble(Myrow.Cells[6].Value) > 100)
                {
                    Myrow.Cells[6].Style.BackColor = Color.White;
                    Myrow.Cells[6].Style.ForeColor = Color.Black;
                    Myrow.Cells[6].Value = "0";
                }
            }
            #endregion
        }

        public void CheckGrade()
        {
            for (int n = 0; n < dgvGrades.Rows.Count; n++)
            {
                double num1 = Convert.ToDouble(dgvGrades.Rows[n].Cells[6].Value);
                double num2 = Convert.ToDouble(dgvGrades.Rows[n].Cells[5].Value);
                double average = (num1 + num2) / 2;
                double ans = Math.Round(average, MidpointRounding.AwayFromZero);


                //string average = ((Double.Parse(dgvGrades.Rows[n].Cells[6].Value.ToString()) + Double.Parse(dgvGrades.Rows[n].Cells[5].Value.ToString())) / 2).ToString("0.##");
                //double ans = Math.Round(Convert.ToDouble(average),0);
                dgvGrades.Rows[n].Cells[7].Value = ans.ToString("0.##");

            }

            foreach (DataGridViewRow Myrow in dgvGrades.Rows)
            {   //Here 2 cell is target value and 1 cell is Volume
                if (Convert.ToDouble(Myrow.Cells[7].Value) < 75)// Or your condition 
                {
                    Myrow.Cells[8].Style.BackColor = Color.Red;
                    Myrow.Cells[8].Style.ForeColor = Color.White;
                    Myrow.Cells[8].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    Myrow.Cells[8].Value = "FAILED";

                }
                else
                {
                    Myrow.Cells[8].Style.BackColor = Color.Green;
                    Myrow.Cells[8].Style.ForeColor = Color.White;
                    Myrow.Cells[8].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    Myrow.Cells[8].Value = "PASSED";
                }
            }

            foreach (DataGridViewRow Myrow in dgvGrades.Rows)
            {   //Here 2 cell is target value and 1 cell is Volume
                if (Convert.ToDouble(Myrow.Cells[5].Value) < 75 && Convert.ToDouble(Myrow.Cells[5].Value) != 0)// Or your condition 
                {
                    Myrow.Cells[5].Style.BackColor = Color.Brown;
                    Myrow.Cells[5].Style.ForeColor = Color.White;
                }
                else if (Convert.ToDouble(Myrow.Cells[5].Value) > 100)
                {
                    Myrow.Cells[5].Style.BackColor = Color.Brown;
                    Myrow.Cells[5].Style.ForeColor = Color.White;
                }
                else
                {
                    Myrow.Cells[5].Style.BackColor = Color.White;
                    Myrow.Cells[5].Style.ForeColor = Color.Black;
                }
            }

            foreach (DataGridViewRow Myrow in dgvGrades.Rows)
            {   //Here 2 cell is target value and 1 cell is Volume
                if (Convert.ToDouble(Myrow.Cells[6].Value) < 75 && Convert.ToDouble(Myrow.Cells[6].Value) != 0)// Or your condition 
                {
                    Myrow.Cells[6].Style.BackColor = Color.Brown;
                    Myrow.Cells[6].Style.ForeColor = Color.White;
                }
                else if (Convert.ToDouble(Myrow.Cells[6].Value) > 100)
                {
                    Myrow.Cells[6].Style.BackColor = Color.Brown;
                    Myrow.Cells[6].Style.ForeColor = Color.White;
                    //MessageBox.Show("morethan 100");
                    //break;
                }
                else
                {
                    Myrow.Cells[6].Style.BackColor = Color.White;
                    Myrow.Cells[6].Style.ForeColor = Color.Black;
                }
            }
        }

        private void colScores_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void dgvGrades_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //control input for column 4
            e.Control.KeyPress -= new KeyPressEventHandler(colScores_KeyPress);

            //column to control input
            if ((dgvGrades.CurrentCell.ColumnIndex == 5))
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(colScores_KeyPress);
                }
            }

            if ((dgvGrades.CurrentCell.ColumnIndex == 6))
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(colScores_KeyPress);
                }
            }
        }

        private void btnLoadStud_Click(object sender, EventArgs e)
        {
            LoadGrading();
            RecordCount();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport();

            frmMain main = new frmMain();

         
         
            frm.section = cmbSection.Text;
            frm.gradeLevel = cmbGradeLevel.Text;
            frm.semester = cmbTerm.Text;
            frm.subject = cmbSubject.Text;
            //frm.teacher_name = main.Username.ToUpper();
            frm.Grades();
            frm.Show();
        }

        public int gradeId;
        public string inputGrade1, inputGrade2, gradeAverage, gradeRemark;
        Grading grd = new Grading();
        private void btnSaveGrades_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvGrades.Rows.Count; i++)
            {
                gradeId =Convert.ToInt32(dgvGrades.Rows[i].Cells[0].FormattedValue.ToString());
                inputGrade1 = dgvGrades.Rows[i].Cells[5].FormattedValue.ToString();
                inputGrade2 = dgvGrades.Rows[i].Cells[6].FormattedValue.ToString();
                gradeAverage = dgvGrades.Rows[i].Cells[7].FormattedValue.ToString();
                gradeRemark = dgvGrades.Rows[i].Cells[8].FormattedValue.ToString();

                grd.Id = gradeId;
                grd.FirstGrade = inputGrade1;
                grd.SecondGrade = inputGrade2;
                grd.Average = gradeAverage;
                grd.Remarks = gradeRemark;

                grd.UpdateTheGrades();
            }

            MessageBox.Show("Grades Successfully Save", "Grading System", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

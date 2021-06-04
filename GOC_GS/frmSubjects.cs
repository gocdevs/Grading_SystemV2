﻿using System;
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
    public partial class frmSubjects : Form
    {
        public frmSubjects()
        {
            InitializeComponent();
            subject.LoadDataTable(dgvList);
            AddImageDataGrid(dgvList);
            HeaderFix(dgvList);
        }

        Subjects subject = new Subjects();
        List<Subjects> subject_list = new List<Subjects>();

        Util_RequiredFields util = new Util_RequiredFields();

        public int id;

        public void AddImageDataGrid(DataGridView dgv)
        {
            DataGridViewImageColumn dimg = new DataGridViewImageColumn();
            dimg.Image = Properties.Resources.edit;
            dimg.HeaderText = "Edit";
            dimg.ImageLayout = DataGridViewImageCellLayout.Normal;
            dimg.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv.Columns.Add(dimg);


            DataGridViewImageColumn dimgDelete = new DataGridViewImageColumn();
            dimgDelete.Image = Properties.Resources.delete;
            dimgDelete.HeaderText = "Delete";
            dimgDelete.ImageLayout = DataGridViewImageCellLayout.Normal;
            dimgDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv.Columns.Add(dimgDelete);
        }

        public void HeaderFix(DataGridView dgv)
        {
            #region Header Name
            dgv.Columns["id"].Visible = false;

            DataGridViewColumn FillSize = dgv.Columns[2];
            FillSize.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            #endregion
        }

        public void Reset()
        {
            txtSCode.Text = "";
            txtSName.Text = "";
            cmbSTypes.Text = "";
            cmbSemester.Text = "";
            cmbGradeLevel.Text = "";
            cmbStrand.Text = "";

            btnAdd.Text = "&Add New";

        }


        //Cellcontent Event for Datagrid
        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                id = Convert.ToInt32(dgvList.Rows[e.RowIndex].Cells[2].Value.ToString());//for editing criteria

                //pass value to edit mode               
                txtSCode.Text = dgvList.Rows[e.RowIndex].Cells[3].Value.ToString();   
                txtSName.Text = dgvList.Rows[e.RowIndex].Cells[4].Value.ToString();
                cmbGradeLevel.Text = dgvList.Rows[e.RowIndex].Cells[6].Value.ToString();
                cmbSemester.Text = dgvList.Rows[e.RowIndex].Cells[5].Value.ToString();
                cmbSTypes.Text = dgvList.Rows[e.RowIndex].Cells[7].Value.ToString();                               
                cmbStrand.Text = dgvList.Rows[e.RowIndex].Cells[8].Value.ToString();

                btnAdd.Text = "&Update";//set button to Update                
            }

            else if (e.ColumnIndex == 1)
            {
                string message = "Do you want to delete this record?";
                string title = "Grading System";

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    subject.Id = Convert.ToInt32(dgvList.Rows[e.RowIndex].Cells[2].Value.ToString());//for editing criteria
                    subject.Delete();

                    subject.LoadDataTable(dgvList);
                }
                else
                {
                    return;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "&Update")
            {
                util.ValidateTextBox2(txtSCode, txtSName);// Validation before Updating
                util.ValidateCombobox4(cmbGradeLevel, cmbSemester, cmbStrand, cmbSTypes);// Validation before Updating
                if (util.readyToSave == 1)
                {
                    #region UPDATE DISCOUNT
                    subject.Id = id;
                    subject.Subject_code = txtSCode.Text;
                    subject.Subject_name = txtSName.Text;
                    subject.Subject_type = cmbSTypes.Text;
                    subject.Semester = cmbSemester.Text;
                    subject.Grade_level = cmbGradeLevel.Text;
                    subject.Strand = cmbStrand.Text;

                    subject.Update();
                    Reset();
                    #endregion              
                }
                else
                {
                    Reset();
                    return;
                }
            }
            else
            {
                util.ValidateTextBox2(txtSCode, txtSName);// Validation before Updating
                util.ValidateCombobox4(cmbGradeLevel, cmbSemester, cmbStrand, cmbSTypes);// Validation before Updating

                if (util.readyToSave == 1)
                {
                    subject.Id = id;
                    subject.Subject_code = txtSCode.Text;
                    subject.Subject_name = txtSName.Text;
                    subject.Subject_type = cmbSTypes.Text;
                    subject.Semester = cmbSemester.Text;
                    subject.Grade_level = cmbGradeLevel.Text;
                    subject.Strand = cmbStrand.Text;

                    subject.Save();
                    Reset();
                }
                else
                {
                    Reset();
                    return;
                }
            }
            subject.LoadDataTable(dgvList);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}

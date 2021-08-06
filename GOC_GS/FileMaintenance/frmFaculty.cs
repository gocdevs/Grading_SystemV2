﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GOC_GS.Models;

namespace GOC_GS
{
    public partial class frmFaculty : Form
    {
        public frmFaculty()
        {
            InitializeComponent();
            faculty.LoadDataTable(dgvFacultyList);
            AddImageDataGrid(dgvFacultyList);
            HeaderFix(dgvFacultyList);

            section.LoadCombo(cmbAdviserOf);
            subjects.LoadCombo(cmbSpecializeSubject);
        }

        Faculty faculty = new Faculty();
        List<Faculty> faculty_list = new List<Faculty>();

        Section section = new Section();
        List<Section> section_list = new List<Section>();

        Subjects subjects = new Subjects();
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
            //dgv.Columns["subject_code"].HeaderText = "Subject Code";//to fix the header Name

            DataGridViewColumn FillSize = dgv.Columns[2];
            FillSize.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            #endregion
        }

        public void Reset()
        {
            txtFacultyId.Text = "";
            txtLName.Text = "";
            txtFName.Text = "";
            txtMName.Text = "";
            txtCourse.Text = "";
            cmbSpecializeSubject.Text = "";
            cmbAdviserOf.Text = "";
            cmbEStatus.Text = "";

            btnAdd.Text = "&Add New";
        }

        private void dgvFacultyList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                id = Convert.ToInt32(dgvFacultyList.Rows[e.RowIndex].Cells[2].Value.ToString());//for editing criteria

                //pass value to edit mode
                //
                txtFacultyId.Text = dgvFacultyList.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtFName.Text = dgvFacultyList.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtLName.Text = dgvFacultyList.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtMName.Text = dgvFacultyList.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtCourse.Text = dgvFacultyList.Rows[e.RowIndex].Cells[7].Value.ToString();
                cmbSpecializeSubject.Text = dgvFacultyList.Rows[e.RowIndex].Cells[8].Value.ToString();
                cmbAdviserOf.Text = dgvFacultyList.Rows[e.RowIndex].Cells[9].Value.ToString();
                cmbEmp.Text = dgvFacultyList.Rows[e.RowIndex].Cells[10].Value.ToString();
                cmbEStatus.Text = dgvFacultyList.Rows[e.RowIndex].Cells[10].Value.ToString();

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
                    faculty.Id = Convert.ToInt32(dgvFacultyList.Rows[e.RowIndex].Cells[2].Value.ToString());//for editing criteria
                    faculty.Delete();

                   faculty.LoadDataTable(dgvFacultyList);
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
                util.ValidateTextBox5(txtFacultyId, txtLName, txtFName, txtMName, txtCourse);// Validation before Updating
                util.ValidateCombobox3(cmbAdviserOf, cmbSpecializeSubject, cmbEStatus);// Validation before Updating
                if (util.readyToSave == 1)
                {
                    #region UPDATE DISCOUNT
                    faculty.Id = id;
                    faculty.Faculty_id = txtFacultyId.Text;
                    faculty.Last_name = txtLName.Text;
                    faculty.First_name = txtFName.Text;
                    faculty.Middle_name = txtMName.Text;
                    faculty.Course = txtCourse.Text;
                    faculty.Specialize_subject = cmbSpecializeSubject.Text;
                    faculty.Adviser_of = cmbAdviserOf.Text;
                    faculty.Emp_status = cmbEStatus.Text;

                    faculty.Update();
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
                util.ValidateTextBox5(txtFacultyId, txtLName, txtFName, txtMName, txtCourse);// Validation before Updating
                util.ValidateCombobox3(cmbAdviserOf, cmbSpecializeSubject, cmbEStatus);// Validation before Updating

                if (util.readyToSave == 1)
                {
                    faculty.Id = id;
                    faculty.Faculty_id = txtFacultyId.Text;
                    faculty.Last_name = txtLName.Text;
                    faculty.First_name = txtFName.Text;
                    faculty.Middle_name = txtMName.Text;
                    faculty.Course = txtCourse.Text;
                    faculty.Specialize_subject = cmbSpecializeSubject.Text;
                    faculty.Adviser_of = cmbAdviserOf.Text;
                    faculty.Emp_status = cmbEStatus.Text;

                    faculty.Save();
                    Reset();
                }
                else
                {
                    Reset();
                    return;
                }
            }
            faculty.LoadDataTable(dgvFacultyList);
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}

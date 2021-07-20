﻿using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class frmFacultyLoadSection : Form
    {
        Models.Faculty fl = new Models.Faculty();
        FacultyLoading facultyLoading = new FacultyLoading();
        Section section = new Section();
        List<Section> sections = new List<Section>();

        DataTable dt = new DataTable();
        //DataTable comboSection = new DataTable();

        public frmFacultyLoadSection()
        {
            InitializeComponent();
           
            facultyLoading.LoadDataTable(dgvFacultyLoads);        
            LoadCombo();
            HeaderFix(dgvFacultyLoads);
            AutoComplete();
        }
        
        public void LoadCombo()
        {
            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();

            cmb.HeaderText = "Section";
            cmb.Name = "Combo";
            ArrayList row = new ArrayList();

            //clear list
            sections.Clear();         
            sections = section.LoadSectionCombo();

            //loop through load it to list view
            foreach (var item in sections)
            {
                //Load to datagridView
                row.Add(item.Section_name);
            }

            cmb.Items.AddRange(row.ToArray());

            //datagridadd column
            dgvFacultyLoads.Columns.Add(cmb);
        }

        public void HeaderFix(DataGridView dgv)
        {
            #region Header Name
            dgv.Columns["id"].Visible = false;
            dgv.Columns["date_assigned"].Visible = false;
          
            dgv.Columns["strand"].Visible = false;

            dgv.Columns["faculty_id"].HeaderText = "Faculty Id";
            dgv.Columns["fullname"].HeaderText = "Faculty Name";
            dgv.Columns["subject_code"].HeaderText = "Subject Code";
           
            dgv.Columns["semester"].HeaderText = "Semester";
            dgv.Columns["grade_level"].HeaderText = "Grade Level";
            dgv.Columns["subjectType"].HeaderText = "Subject Type";//to fix the header Name           

            DataGridViewColumn FillSize = dgv.Columns[7];
            FillSize.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

           

            #endregion
        }

        private void AutoComplete()
        {

            try
            {
                using (MySqlConnection con = new MySqlConnection(GOC_GS.Config.GetConnectionString()))
                {
                    //string sql = "SELECT * FROM grading WHERE CONCAT(`full_name`,) LIKE '%" + valueToSearch + "%'";
                    string sql = "SELECT fullname FROM faculty_loads";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    con.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
                    while (reader.Read())
                    {
                        MyCollection.Add(reader.GetString(0));
                    }
                    txtStudent.AutoCompleteCustomSource = MyCollection;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.Message.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvFacultyLoads_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dgvFacultyLoads_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
           
        }

        private void frmFacultyLoadSection_Load(object sender, EventArgs e)
        {
            dgvFacultyLoads.EditingControlShowing += dgvFacultyLoads_EditingControlShowing;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvFacultyLoads.Rows.Count > 0)
            {
                string message = "Do you want to save all record?";
                string title = "GOC_Grading_System";

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;                                                                                                                                                                                                                                                                                                                                                                                                                   
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    //MessageBox.Show(dgvFacultyLoads.Rows[0].Cells[9].FormattedValue.ToString());

                    for (int i = 0; i < dgvFacultyLoads.Rows.Count; i++)
                    {
                        if (dgvFacultyLoads.Rows[i].Cells[0].FormattedValue.Equals(""))
                        {
                            facultyLoading.Id = Convert.ToInt32(dgvFacultyLoads.Rows[i].Cells[1].FormattedValue.ToString());
                            facultyLoading.Section = dgvFacultyLoads.Rows[i].Cells[9].FormattedValue.ToString();

                            facultyLoading.Update();
                        }
                        else
                        {
                            facultyLoading.Id = Convert.ToInt32(dgvFacultyLoads.Rows[i].Cells[1].FormattedValue.ToString());
                            facultyLoading.Section = dgvFacultyLoads.Rows[i].Cells[0].FormattedValue.ToString();

                            facultyLoading.Update();
                        }                      
                    }
                    MessageBox.Show("Recorde Updated!", "Grading System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    facultyLoading.LoadDataTable(dgvFacultyLoads);
                }
                else
                {
                    return;
                }
            }
            else
            {

            }
        }

        private void txtStudent_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.KeyChar = Char.pro(e.KeyChar);
        }

        private void txtStudent_TextChanged(object sender, EventArgs e)
        {            
            if (txtStudent.Text == "")
            {
                try
                {
                    using (MySqlConnection con = new MySqlConnection(GOC_GS.Config.GetConnectionString()))
                    {
                        con.Open();
                        string sql = "SELECT * FROM faculty_loads";

                        MySqlCommand cmd = new MySqlCommand(sql, con);
                        MySqlDataAdapter da = new MySqlDataAdapter();

                        da.SelectCommand = cmd;

                        //initialize new datatable and load data to datagridview
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvFacultyLoads.DataSource = dt;

                        con.Close();
                    }
                }

                catch (MySqlException ex)
                {
                    MessageBox.Show("ERROR : " + ex.ToString(), "Grading System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    using (MySqlConnection con = new MySqlConnection(GOC_GS.Config.GetConnectionString()))
                    {
                        con.Open();
                        string sql = "SELECT * FROM faculty_loads WHERE fullname LIKE('" + txtStudent.Text + "')";

                        MySqlCommand cmd = new MySqlCommand(sql, con);
                        MySqlDataAdapter da = new MySqlDataAdapter();

                        da.SelectCommand = cmd;

                        //initialize new datatable and load data to datagridview
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvFacultyLoads.DataSource = dt;

                        con.Close();
                    }
                }

                catch (MySqlException ex)
                {
                    MessageBox.Show("ERROR : " + ex.ToString(), "Grading System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }            
        }
    }
}



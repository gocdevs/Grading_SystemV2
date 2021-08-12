using MySql.Data.MySqlClient;
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
        DataTable dt = new DataTable();

        Models.Faculty fl = new Models.Faculty();
        FacultyLoading facultyLoading = new FacultyLoading();
        Section section = new Section();
        List<Section> sections = new List<Section>();
               
        public int id;
        public string this_section;
        public frmFacultyLoadSection()
        {
            InitializeComponent();
           
            facultyLoading.LoadDataTable(dgvFacultyLoads);        
            LoadCombo();
            HeaderFix(dgvFacultyLoads);
            AutoComplete();
            AddImageDataGrid(dgvFacultyLoads);
            CountLoads();
        }

        public void CountLoads()
        {
            lblFaculty.Text =  dgvFacultyLoads.Rows.Count.ToString();
        }

        public void AddImageDataGrid(DataGridView dgv)
        {
            DataGridViewImageColumn dimg2 = new DataGridViewImageColumn();
            dimg2.Image = Properties.Resources.add_green;
            dimg2.HeaderText = "Assign Section";
            dimg2.ImageLayout = DataGridViewImageCellLayout.Normal;
            dimg2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgv.Columns.Add(dimg2);

            DataGridViewImageColumn dimg = new DataGridViewImageColumn();
            dimg.Image = Properties.Resources.delete;
            dimg.HeaderText = "Remove Subject";
            dimg.ImageLayout = DataGridViewImageCellLayout.Normal;
            dimg.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgv.Columns.Add(dimg);

           
        }

        public void LoadCombo()
        {
            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();

            cmb.HeaderText = "Section to be Assigned";
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
          
            dgv.Columns["strand"].HeaderText = "Strand";

            dgv.Columns["faculty_id"].HeaderText = "Faculty Id";
            dgv.Columns["fullname"].HeaderText = "Faculty Name";
            dgv.Columns["subject_code"].HeaderText = "Subject Code";
            dgv.Columns["section"].HeaderText = "Assigned Section ";

            dgv.Columns["semester"].HeaderText = "Semester";
            dgv.Columns["grade_level"].HeaderText = "Grade Level";
            dgv.Columns["subjectType"].HeaderText = "Subject Type";//to fix the header Name           

            DataGridViewColumn FillSize = dgv.Columns[2];
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
                        //if (dgvFacultyLoads.Rows[i].Cells[10].FormattedValue.Equals(""))//Section to be assigned
                        //{
                            facultyLoading.Id = Convert.ToInt32(dgvFacultyLoads.Rows[i].Cells[3].FormattedValue.ToString());//id
                            facultyLoading.Section = dgvFacultyLoads.Rows[i].Cells[0].FormattedValue.ToString();//Updated Section

                            facultyLoading.Update();
                        //}

                        //if (dgvFacultyLoads.Rows[i].Cells[0].FormattedValue.Equals(""))
                        //{
                            //facultyLoading.Id = Convert.ToInt32(dgvFacultyLoads.Rows[i].Cells[2].FormattedValue.ToString());//id
                            //facultyLoading.Section = dgvFacultyLoads.Rows[i].Cells[0].FormattedValue.ToString();//Updated Section

                            //facultyLoading.Update();
                        //}
                       

                    }
                    MessageBox.Show("Recorde Updated!", "Grading System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    facultyLoading.LoadDataTable(dgvFacultyLoads);
                    CountLoads();
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

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            string message = "Do you want to delete all records?";
            string title = "Grading System";

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    //prepare connection string 
                    using (MySqlConnection con = new MySqlConnection(GOC_GS.Config.GetConnectionString()))
                    {

                        //try to open connection
                        con.Open();

                        string sql = "DELETE FROM faculty_loads";

                        MySqlCommand cmd = new MySqlCommand(sql, con);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record deleted!", "Grading System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("ERROR : " + ex.ToString(), "Grading System", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                facultyLoading.LoadDataTable(dgvFacultyLoads);
                CountLoads();
            }
            else
            {
                return;
            }            
        }

        private void dgvFacultyLoads_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                string message = "Do you want to delete this record?";
                string title = "Grading System";

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    id = Convert.ToInt32(dgvFacultyLoads.Rows[e.RowIndex].Cells[3].Value.ToString());

                    #region Delete Specific
                    try
                    {
                        //prepare connection string 
                        using (MySqlConnection con = new MySqlConnection(GOC_GS.Config.GetConnectionString()))
                        {

                            //try to open connection
                            con.Open();

                            string sql = "DELETE FROM faculty_loads WHERE id=@id";

                            MySqlCommand cmd = new MySqlCommand(sql, con);
                            cmd.Parameters.AddWithValue("id", id);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Record deleted!", "Grading System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("ERROR : " + ex.ToString(), "Grading System", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    facultyLoading.LoadDataTable(dgvFacultyLoads);
                    CountLoads();

                    #endregion
                }
                else
                {
                    return;
                }
            }

            else if (e.ColumnIndex == 1)
            {
                //id = Convert.ToInt32(dgvFacultyLoads.Rows[e.RowIndex].Cells[3].Value.ToString());
                //this_section = dgvFacultyLoads.Rows[e.RowIndex].Cells[0].Value.ToString();

                // MessageBox.Show(id.ToString() +" "+ this_section);
                //foreach (DataGridViewRow row in dgvFacultyLoads.SelectedRows)
                //{                   
                //    id = Convert.ToInt32(row.Cells[3].Value.ToString());//id
                //    this_section = row.Cells[0].Value.ToString();//Section to Set

                //    MessageBox.Show(id.ToString() + " " + this_section);

                //    //facultyLoading.Id = id;
                //    //facultyLoading.Section = this_section;
                //    //facultyLoading.Update();
                //}


                var ctr = 0;

                for (int i = 0; i < dgvFacultyLoads.Rows.Count; i++)
                {
                    if (!dgvFacultyLoads.Rows[i].Cells[0].FormattedValue.Equals(""))//Section to be assigned
                    {
                        ctr = 1;
                    }

                    else
                    {
                        //MessageBox.Show("Please check the section to assign","Grading System",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        //return;
                    }
                }

                if (ctr == 1)
                {
                    string message = "Do you want to assign the teacher to this section?";
                    string title = "Grading System";

                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        id = Convert.ToInt32(dgvFacultyLoads.Rows[e.RowIndex].Cells[3].Value.ToString());
                        this_section = dgvFacultyLoads.Rows[e.RowIndex].Cells[0].Value.ToString();

                        facultyLoading.Id = id;
                        facultyLoading.Section = this_section;
                        facultyLoading.Update();

                        //foreach (DataGridViewRow row in dgvFacultyLoads.SelectedRows)
                        //{
                        //    //id = Convert.ToInt32(row.Cells[3].Value.ToString());//id
                        //    //this_section = row.Cells[0].Value.ToString();//Section to Set

                        //    id = Convert.ToInt32(row.Cells[3].Value.ToString());//id
                        //    this_section = row.Cells[0].Value.ToString();//Section to Set

                        //    facultyLoading.Id = id;
                        //    facultyLoading.Section = this_section;
                        //    facultyLoading.Update();
                        //}

                        MessageBox.Show("Recorde Updated!", "Grading System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        facultyLoading.LoadDataTable(dgvFacultyLoads);
                        CountLoads();
                    }
                }
            }
            else
            {
                return;
            }                   
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}




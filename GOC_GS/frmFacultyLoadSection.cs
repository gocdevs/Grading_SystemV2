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
        Models.Faculty fl = new Models.Faculty();
        FacultyLoading facultyLoading = new FacultyLoading();
        Section section = new Section();
        List<Section> sections = new List<Section>();

        DataTable dt = new DataTable();
        //DataTable comboSection = new DataTable();

        public frmFacultyLoadSection()
        {
            InitializeComponent();
            fl.LoadDataTableName(dgvFacultyName);
            facultyLoading.LoadDataTable(dgvFacultyLoads);        
            LoadCombo();
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
    }
}


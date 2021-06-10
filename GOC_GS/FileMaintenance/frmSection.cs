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
    public partial class frmSection : Form
    {
        public frmSection()
        {
            InitializeComponent();
            section.LoadDataTable(dgvList);
            AddImageDataGrid(dgvList);
            HeaderFix(dgvList);
        }

        Section section = new Section();
        List<Section> section_list = new List<Section>();

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
            txtSectionName.Text = "";          
            cmbGradeLevel.Text = "";
            cmbStrand.Text = "";

            btnAdd.Text = "&Add New";
        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                id = Convert.ToInt32(dgvList.Rows[e.RowIndex].Cells[2].Value.ToString());//for editing criteria

                //pass value to edit mode               
                txtSectionName.Text = dgvList.Rows[e.RowIndex].Cells[3].Value.ToString();
                cmbStrand.Text = dgvList.Rows[e.RowIndex].Cells[4].Value.ToString();
                cmbGradeLevel.Text = dgvList.Rows[e.RowIndex].Cells[5].Value.ToString();               

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
                    section.Id = Convert.ToInt32(dgvList.Rows[e.RowIndex].Cells[2].Value.ToString());//for editing criteria
                    section.Delete();

                    section.LoadDataTable(dgvList);
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
                util.ValidateTextBox1(txtSectionName);// Validation before Updating
                util.ValidateCombobox2(cmbGradeLevel, cmbStrand);// Validation before Updating
                if (util.readyToSave == 1)
                {
                    #region UPDATE DISCOUNT
                    section.Id = id;
                    section.Section_name = txtSectionName.Text;
                    section.Grade_Level = cmbGradeLevel.Text;
                    section.Strand = cmbStrand.Text;                  

                    section.Update();
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
                util.ValidateTextBox1(txtSectionName);// Validation before Updating
                util.ValidateCombobox2(cmbGradeLevel, cmbStrand);// Validation before Updating

                if (util.readyToSave == 1)
                {
                    section.Id = id;
                    section.Section_name = txtSectionName.Text;
                    section.Grade_Level = cmbGradeLevel.Text;
                    section.Strand = cmbStrand.Text;

                    section.Save();
                    Reset();
                }
                else
                {
                    Reset();
                    return;
                }
            }
            section.LoadDataTable(dgvList);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

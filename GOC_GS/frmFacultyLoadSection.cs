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
    public partial class frmFacultyLoadSection : Form
    {
        public frmFacultyLoadSection()
        {
            InitializeComponent();
        }

        public void AddImageDataGridLoading(DataGridView dgv , DataGridViewComboBoxColumn dgvCmb)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(GOC_GS.Config.GetConnectionString()))
                {
                    con.Open();
                    string sql = "SELECT strand_name FROM strand";

                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    MySqlDataAdapter da = new MySqlDataAdapter();

                    da.SelectCommand = cmd;

                    //initialize new datatable and load data to datagridview
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv.DataSource = dt;
                }
            }

            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "Grading System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            dgvCmb.HeaderText = "Section";




            dgvCmb.Items.Add("Ghanashyam");
            dgvCmb.Items.Add("Jignesh");
            dgvCmb.Items.Add("Ishver");
            dgvCmb.Items.Add("Anand");

            dgvCmb.Name = "cmbName";
            dgv.Columns.Add(dgvCmb);
        }
    }
}

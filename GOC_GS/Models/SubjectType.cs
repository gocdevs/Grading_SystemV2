using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace GOC_GS
{
    class SubjectType
    {
        //Array List
        List<SubjectType> subjectTypes = new List<SubjectType>();

        protected int id;
        protected string subject_type;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Subject_type
        {
            get { return subject_type; }
            set { subject_type = value; }
        }

        //Retrieve Data from DB
        public void LoadDataTable(DataGridView dgv)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(GOC_GS.Config.GetConnectionString()))
                {                 
                    con.Open();
                    string sql = "SELECT * FROM subject_type";

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

        }//End of Load

        public List<SubjectType> LoadCombo(ComboBox cmb)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(GOC_GS.Config.GetConnectionString()))
                {
                    con.Open();
                    string sql = "SELECT subject_type FROM subject_type ORDER BY subject_type ASC";

                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    MySqlDataAdapter da = new MySqlDataAdapter();

                    da.SelectCommand = cmd;

                    //initialize new datatable and load data to datagridview
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmb.DataSource = dt;
                    cmb.ValueMember = "subject_type";
                    cmb.DisplayMember = "subject_type";
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "Grading System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return subjectTypes;
        }//End of Load

        //Save Records
        public void Save()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOC_GS.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    string sql = "INSERT INTO subject_type(subject_type) " +
                                    " VALUES (@subject_type);";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("subject_type", subject_type);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "Grading System", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        //Update
        public void Update()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOC_GS.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    string sql = "UPDATE subject_type SET subject_type=@subject_type" +
                                    " WHERE id=@id;";

                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.Parameters.AddWithValue("subject_type", subject_type);
                    
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Recorde Updated!", "Grading System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.Message.ToString(), "Grading System", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        //Delete
        public void Delete()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOC_GS.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    string sql = "DELETE  FROM subject_type WHERE id=@id;";

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
        }
    }
}

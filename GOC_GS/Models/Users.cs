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
    class Users
    {
        protected int id;
        protected string faculty_id;
        protected string user_id;
        protected string password;
        protected string user_type;
        protected string full_name;

        List<Users> users = new List<Users>();

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Faculty_id
        {
            get { return faculty_id; }
            set { faculty_id = value; }
        }

        public string User_id
        {
            get { return user_id; }
            set { user_id = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string User_type
        {
            get { return user_type; }
            set { user_type = value; }
        }

        public string Full_name
        {
            get { return full_name; }
            set { full_name = value; }
        }

       


        public void Save()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOC_GS.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    string sql = "INSERT INTO users(faculty_id, user_id, password, user_type, full_name) " +
                                    " VALUES (@faculty_id, @user_id, @password, @user_type, @full_name);";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("faculty_id", faculty_id);
                    cmd.Parameters.AddWithValue("user_id", user_id);
                    cmd.Parameters.AddWithValue("password", password);
                    cmd.Parameters.AddWithValue("user_type", user_type);
                    cmd.Parameters.AddWithValue("full_name", full_name);
                           

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

                    string sql = "UPDATE users SET faculty_id=@faculty_id, user_id=@user_id, password=@password, user_type=@user_type, full_name=@full_name" +
                                    " WHERE id=@id;";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("id", id);
                    cmd.Parameters.AddWithValue("faculty_id", faculty_id);
                    cmd.Parameters.AddWithValue("user_id", user_id);
                    cmd.Parameters.AddWithValue("password", password);
                    cmd.Parameters.AddWithValue("user_type", user_type);
                    cmd.Parameters.AddWithValue("full_name", full_name);


                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Recorde Updated!", "Grading System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.Message.ToString(), "Grading System", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void LoadDataTable(DataGridView dgv)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(GOC_GS.Config.GetConnectionString()))
                {
                    con.Open();
                    string sql = "SELECT * FROM users ";

                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    MySqlDataAdapter da = new MySqlDataAdapter();

                    da.SelectCommand = cmd;

                    //initialize new datatable and load data to datagridview
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv.DataSource = dt;

                    con.Close();
                }
            }

            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "Grading System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }//End of Load

        public List<Users> GetUserType()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(GOC_GS.Config.GetConnectionString()))
                {
                    con.Open();

                    string sql = "SELECT * FROM users WHERE user_id =@userId AND password=@password;";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    //ito yung parameter para makapag filter ng records 
                    cmd.Parameters.AddWithValue("userId", user_id);
                    cmd.Parameters.AddWithValue("password", password);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Users user = new Users();
                     
                        //ito yung gusto mong palabasing na record from the filtered query
                        user.user_type = reader["user_type"].ToString();
                        user.user_id = reader["user_id"].ToString();
                        user.password = reader["password"].ToString();
                        user.faculty_id = reader["faculty_id"].ToString();
                        user.full_name = reader["full_name"].ToString();
                       
                        users.Add(user);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error : " + ex.Message.ToString(), "Grading System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return users;

        }

        public void Delete()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOC_GS.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    string sql = "DELETE  FROM users WHERE id=@id;";

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

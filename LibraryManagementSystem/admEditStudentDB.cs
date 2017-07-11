using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace LibraryManagementSystem
{
    public partial class admEditStudentDB : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        
        // selected book id
        int selected_user_id;

        private void admEditStudentDB_Load(object sender, EventArgs e)
        {
            // display table
            displayUsers();
        }

        public admEditStudentDB()
        {
            InitializeComponent();
        }

        public void displayUsers()
        {
            // establish connection to db
            string connectionString = ConfigurationManager.ConnectionStrings["LibraryManagementSystem.Properties.Settings.LibraryDB"].ToString();
            con = new SqlConnection(connectionString);

            // on intialise display books table
            cmd = new SqlCommand("select user_id as 'User ID', admin as 'Admin ?', name as 'Name', address as 'Address', password as 'Password', email as 'E-mail' from users order by user_id asc", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            editStudentDBDgvTable.DataSource = ds.Tables[0];
            editStudentDBDgvTable.ReadOnly = true;

            // add sort functionality to admin column
            editStudentDBDgvTable.Columns[1].SortMode = DataGridViewColumnSortMode.Automatic;
        }

        public void clearFields()
        {
            editStudentDBTbxUserID.Text = string.Empty;
            admStudentDBTbxName.Text = string.Empty;
            editStudentDBTbxAddress.Text = string.Empty;
            editStudentDBTbxPassword.Text = string.Empty;
            editStudentDBTbxEmail.Text = string.Empty;
            admStudentDBCbAdmin.Checked = false;
        }

        private void editStudentDBBtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            admStartPage asp = new admStartPage();
            asp.Show();
        }

        private void editStudentDBBtnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            login lg = new login();
            lg.Show();
        }

        // search functionality
        private void editStudentDBBtnSearch_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();

            try
            {
                // try to check if search query is number
                int search_id = int.Parse(editStudentDBTbxSearch.Text);
                cmd = new SqlCommand("select user_id as 'User ID', admin as 'Admin ?', name as 'Name', address as 'Address', password as 'Password', email as 'E-mail' from users where user_id = @searchQuery", con);
                cmd.Parameters.AddWithValue("@searchQuery", search_id);
            }
            catch
            {
                // go with it not a number
                cmd = new SqlCommand("select user_id as 'User ID', admin as 'Admin ?', name as 'Name', address as 'Address', password as 'Password', email as 'E-mail' from users where name like @searchQuery", con);
                cmd.Parameters.AddWithValue("@searchQuery", "%" + editStudentDBTbxSearch.Text + "%");
            }
            

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            editStudentDBDgvTable.DataSource = ds.Tables[0];
            
        }

        // cell click event
        private void editStudentDBDgvTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // remove column headers
            if(e.RowIndex != -1 && e.RowIndex != editStudentDBDgvTable.Rows.Count - 1 )
            {
                // copy value to variable even if unnecessary
                selected_user_id = Convert.ToInt32(editStudentDBDgvTable.Rows[e.RowIndex].Cells[0].Value);
                bool admin = Convert.ToBoolean(editStudentDBDgvTable.Rows[e.RowIndex].Cells[1].Value);
                string name = Convert.ToString(editStudentDBDgvTable.Rows[e.RowIndex].Cells[2].Value);
                string address = Convert.ToString(editStudentDBDgvTable.Rows[e.RowIndex].Cells[3].Value);
                string password = Convert.ToString(editStudentDBDgvTable.Rows[e.RowIndex].Cells[4].Value);
                string email = Convert.ToString(editStudentDBDgvTable.Rows[e.RowIndex].Cells[5].Value);

                // paste into textbox
                editStudentDBTbxUserID.Text = Convert.ToString(selected_user_id);
                admStudentDBCbAdmin.Checked = admin;
                admStudentDBTbxName.Text = name;
                editStudentDBTbxAddress.Text = address;
                editStudentDBTbxPassword.Text = password;
                editStudentDBTbxEmail.Text = email;
            }
        }

        // CLEAR BUTTON
        private void admEditStudentDBBtnClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        // SAVE EDIT BUTTON
        private void editStudentDBBtnSave_Click(object sender, EventArgs e)
        {
            // variables 
            int user_id = 0;
            bool admin;
            string name;
            string address;
            string password;
            string email;

            bool preliminaryAcceptedState = true;

            // open connection
            if (con.State == ConnectionState.Closed)
                con.Open();

            // copy values
            // copy value to variable even make sure correct format
            try
            {
                user_id = Convert.ToInt32(editStudentDBTbxUserID.Text);
            }
            catch
            {
                MessageBox.Show("Please make sure that the UserID is an interger.");
                preliminaryAcceptedState = false;
            }
            admin = admStudentDBCbAdmin.Checked;
            name = admStudentDBTbxName.Text;
            address = editStudentDBTbxAddress.Text;
            password = editStudentDBTbxPassword.Text;
            email = editStudentDBTbxEmail.Text;

            // try to edit users only if all pevious info is healthy
            if (preliminaryAcceptedState == true)
            {
                try
                {
                    cmd = new SqlCommand("update users set user_id = @user_id, admin = @admin, name = @name, address = @address, password = @password, email = @email where user_id = @selected_user_id", con);
                    cmd.Parameters.AddWithValue("@user_id", user_id);
                    cmd.Parameters.AddWithValue("@admin", admin);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@selected_user_id", selected_user_id);

                    int result = cmd.ExecuteNonQuery();
                    if (result == 1)
                    {
                        MessageBox.Show("Changes successfully saved.");
                        clearFields();
                    }

                    // display updated books
                    displayUsers();
                } 
                catch
                {
                    MessageBox.Show("There is already a user with this UserID.\nUserID's have to be distinct.");
                }
            }
        }

        // ADD TO DB BUTTON
        private void editStudentDBBtnAddToDB_Click(object sender, EventArgs e)
        {
            // variables 
            int user_id = 0;
            bool admin;
            string name;
            string address;
            string password;
            string email;

            bool preliminaryAcceptedState = true;

            // open connection
            if (con.State == ConnectionState.Closed)
                con.Open();

            // copy values
            // copy value to variable even make sure correct format
            try
            {
                user_id = Convert.ToInt32(editStudentDBTbxUserID.Text);
            }
            catch
            {
                MessageBox.Show("Please make sure that the UserID is an interger.");
                preliminaryAcceptedState = false;
            }
            admin = admStudentDBCbAdmin.Checked;
            name = admStudentDBTbxName.Text;
            address = editStudentDBTbxAddress.Text;
            password = editStudentDBTbxPassword.Text;
            email = editStudentDBTbxEmail.Text;

            // try to edit users only if all pevious info is healthy
            if (preliminaryAcceptedState == true)
            {
                try
                {
                    cmd = new SqlCommand("insert into users values(@user_id, @admin, @name, @address, @password, @email) ", con);
                    cmd.Parameters.AddWithValue("@user_id", user_id);
                    cmd.Parameters.AddWithValue("@admin", admin);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@email", email);

                    int result = cmd.ExecuteNonQuery();
                    if (result == 1)
                    {
                        MessageBox.Show("User successfully added.");
                        clearFields();
                    }

                    // display updated books
                    displayUsers();
                }
                catch
                {
                    MessageBox.Show("There is already a user with this UserID.\nUserID's have to be distinct.");
                }
            }
        }

        private void editStudentDBBtnDelete_Click(object sender, EventArgs e)
        {
            // variables 
            int user_id = 0;

            bool preliminaryAcceptedState = true;

            // open connection
            if (con.State == ConnectionState.Closed)
                con.Open();

            // copy values
            // copy value to variable even make sure correct format
            try
            {
                user_id = Convert.ToInt32(editStudentDBTbxUserID.Text);
            }
            catch
            {
                MessageBox.Show("Please make sure that the UserID is an interger.");
                preliminaryAcceptedState = false;
            }

            // try to edit users only if all pevious info is healthy
            if (preliminaryAcceptedState == true)
            {
                try
                {
                    cmd = new SqlCommand("delete from users where user_id = @user_id", con);
                    cmd.Parameters.AddWithValue("@user_id", user_id);

                    int result = cmd.ExecuteNonQuery();
                    if (result == 1)
                    {
                        MessageBox.Show("User successfully deleted.");
                        clearFields();
                    }

                    // display updated books
                    displayUsers();
                }
                catch
                {
                    MessageBox.Show("Cannot delete a user with an issued book.\nPlease make sure that he has returned the book before deleting him.");
                }
            }
        }
    }
}

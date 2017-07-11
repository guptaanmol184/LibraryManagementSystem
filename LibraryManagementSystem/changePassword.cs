using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    public partial class changePassword : Form
    {
        SqlConnection con;
        SqlCommand cmd;

        // userid and pwd
        public int userid;
        public string password;

        public changePassword()
        {
            InitializeComponent();
        }

        private void changePassword_Load(object sender, EventArgs e)
        {
            // clear all boxes
            clear();

            // copy pwd and id
            userid = login.userid;
            password = login.password;

            // establish connection to db
            string connectionString = ConfigurationManager.ConnectionStrings["LibraryManagementSystem.Properties.Settings.LibraryDB"].ToString();
            con = new SqlConnection(connectionString);
        }

        public void clear()
        {
            chnagePassTbxConfirmPass.Text = string.Empty;
            chnagePassTbxCurPass.Text = string.Empty;
            chnagePassTbxNewPass.Text = string.Empty;
        }

        private void chnagePassbtnSubmit_Click(object sender, EventArgs e)
        {
            // check if original password matches
            if(password == chnagePassTbxCurPass.Text)
            {
                if(chnagePassTbxNewPass.Text == chnagePassTbxConfirmPass.Text)
                {
                    // open connection
                    if (con.State == ConnectionState.Closed)
                        con.Open();

                    cmd = new SqlCommand("update users set password = @password where user_id = @user_id", con);
                    cmd.Parameters.AddWithValue("@password", chnagePassTbxNewPass.Text);
                    cmd.Parameters.AddWithValue("@user_id", userid);

                    int result = cmd.ExecuteNonQuery();

                    if(result == 1)
                    {
                        // show update
                        MessageBox.Show("Password successfully updated.\nPlease login with the new credentials on the new screen.");

                        // login
                        this.Hide();
                        login lg = new login();
                        lg.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Please make sure the new passwords should match.");
                }
            }
            else
            {
                MessageBox.Show("Please make sure the 'current password' matches your current password.");
            }
        }

        private void changePassBtnCancel_Click(object sender, EventArgs e)
        {
            // take back to login screen
            this.Hide();
            login lg = new login();
            lg.Show();
        }
    }
}

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
    public partial class admIssue : Form
    {
        SqlConnection con;
        SqlCommand cmd;

        public admIssue()
        {
            InitializeComponent();
        }

        private void admIssue_Load(object sender, EventArgs e)
        {

            // establish connection to db
            string connectionString = ConfigurationManager.ConnectionStrings["LibraryManagementSystem.Properties.Settings.LibraryDB"].ToString();
            con = new SqlConnection(connectionString);

            // display table
            display();

            // select both radio button by default
            admIssueRbBoth.Select();
        }

        public void display()
        {
            // on intialise display books table
            cmd = new SqlCommand("select book_id as 'Book ID', title as 'Title', author as 'Author', publisher as 'Publisher', year_of_pub as 'Y.O.P', genres as 'Genres' from books where book_id not in ( select i_book_id from issue)", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            admIssueDgvTable.DataSource = ds.Tables[0];

            // make read only
            admIssueDgvTable.ReadOnly = true;
        }

        public void clearFields()
        {
            admIssueTbxSearchQuery.Text = string.Empty;
            admIssueTbxUserID.Text = string.Empty;
            amdIssueTbxBookID.Text = string.Empty;
        }

        private void admIssueDgvTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // when not column header
            if(e.RowIndex != -1 && e.RowIndex != admIssueDgvTable.Rows.Count - 1)
            {
                amdIssueTbxBookID.Text = Convert.ToString(admIssueDgvTable.Rows[e.RowIndex].Cells[0].Value);
            }
        }

        private void admIssueBtnIssue_Click(object sender, EventArgs e)
        {
            // open connection
            if (con.State == ConnectionState.Closed)
                con.Open();

            // variables
            int user_id = 0; 
            int book_id = 0;

            bool preliminaryAcceptedState = true;

            // check credentials
            try
            {
                user_id = int.Parse(admIssueTbxUserID.Text);
            }
            catch
            {
                MessageBox.Show("User ID should be an integer.");
                preliminaryAcceptedState = false;
            }
            try
            {
                book_id = int.Parse(amdIssueTbxBookID.Text);
            }
            catch
            {
                MessageBox.Show("Book ID should be an interger.");
                preliminaryAcceptedState = false;
            }


            // check two issues
            cmd = new SqlCommand("select * from issue where i_user_id = @user_id", con);
            cmd.Parameters.AddWithValue("@user_id", user_id);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            int rows = ds.Tables[0].Rows.Count;

            if(rows >= 2)
            {
                MessageBox.Show("Cannot issue more books.\nA user can only issue 2 books.");
                preliminaryAcceptedState = false;
            }

            // check someone already issued
            cmd = new SqlCommand("select * from issue where i_book_id = @book_id", con);
            cmd.Parameters.AddWithValue("@book_id", book_id);
            SqlDataAdapter sda1 = new SqlDataAdapter(cmd);
            DataSet ds1 = new DataSet();
            sda1.Fill(ds1);

            int rows1 = ds1.Tables[0].Rows.Count;

            if(rows1 > 0)
            {
                MessageBox.Show("The book has already been issued by someone else.\nCannot issue book.");
                preliminaryAcceptedState = false;
            }

            // issue entry in table
            if(preliminaryAcceptedState == true)
            {
                try
                {
                    cmd = new SqlCommand("insert into issue values(@user_id, @book_id, CONVERT(date, GETDATE()))", con);
                    cmd.Parameters.AddWithValue("@user_id", user_id);
                    cmd.Parameters.AddWithValue("@book_id", book_id);

                    int result = cmd.ExecuteNonQuery();

                    if(result == 1)
                    {
                        MessageBox.Show("Book successfully issued.");
                        display();
                        clearFields();
                    }
                }
                catch
                {
                    MessageBox.Show("Please make sure that the the Book ID and User ID is valid.\nIf you still get an error then contact the developer.");
                }

            }
        }

        private void admIssueBtnSearch_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();

            if (admIssueRbBoth.Checked == true)
            {
                cmd = new SqlCommand("select book_id as 'Book ID', title as 'Title', author as 'Author', publisher as 'Publisher', year_of_pub as 'Y.O.P', genres as 'Genres' from books where ( title like @searchQuery or author like @searchQuery ) and book_id not in ( select i_book_id from issue)", con);
                cmd.Parameters.AddWithValue("@searchQuery", "%" + admIssueTbxSearchQuery.Text + "%");

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                admIssueDgvTable.DataSource = ds.Tables[0];
            }
            else if (admIssueRbTitle.Checked == true)
            {
                cmd = new SqlCommand("select book_id as 'Book ID', title as 'Title', author as 'Author', publisher as 'Publisher', year_of_pub as 'Y.O.P', genres as 'Genres' from books where title like @searchQuery and book_id not in ( select i_book_id from issue)", con);
                cmd.Parameters.AddWithValue("@searchQuery", "%" + admIssueTbxSearchQuery.Text + "%");

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                admIssueDgvTable.DataSource = ds.Tables[0];
            }
            else if (admIssueRbAuthor.Checked == true)
            {
                cmd = new SqlCommand("select book_id as 'Book ID', title as 'Title', author as 'Author', publisher as 'Publisher', year_of_pub as 'Y.O.P', genres as 'Genres' from books where author like @searchQuery and book_id not in ( select i_book_id from issue)", con);
                cmd.Parameters.AddWithValue("@searchQuery", "%" + admIssueTbxSearchQuery.Text + "%");

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                admIssueDgvTable.DataSource = ds.Tables[0];
            }
        }

        private void admIssueBooksBtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            admStartPage asp = new admStartPage();
            asp.Show();
        }

        private void admIssueBooksBtnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            login lg = new login();
            lg.Show();
        }
    }
}

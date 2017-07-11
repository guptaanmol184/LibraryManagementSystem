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
    public partial class usrIssuedBooks : Form
    {
        SqlConnection con;
        SqlCommand cmd;

        // userid and pwd
        public int userid;
        public string password;

        public usrIssuedBooks()
        {
            InitializeComponent();
        }

        private void usrIssuedBooks_Load(object sender, EventArgs e)
        {
            // copy userid and pwd
            userid = login.userid;
            password = login.password;

            // establish connection to db
            string connectionString = ConfigurationManager.ConnectionStrings["LibraryManagementSystem.Properties.Settings.LibraryDB"].ToString();
            con = new SqlConnection(connectionString);

            // on intialise display books table
            cmd = new SqlCommand("select date_issued as 'Date Issued', DATEDIFF(day, date_issued, CONVERT(date, GETDATE()))  as 'Total days passed', book_id as 'Book ID', title as 'Title', author as 'Author', publisher as 'Publisher', year_of_pub as 'Year of Publication', genres as 'Genres' from issue, books where i_user_id = @user_id and i_book_id = book_id", con);
            cmd.Parameters.AddWithValue("@user_id", userid);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            usrIssuedBooksDgvBooks.DataSource = ds.Tables[0];
            usrIssuedBooksDgvBooks.ReadOnly = true;
        }

        private void usrIssuedBooksBtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            userBookSearch ubs = new userBookSearch();
            ubs.Show();
        }
    }
}

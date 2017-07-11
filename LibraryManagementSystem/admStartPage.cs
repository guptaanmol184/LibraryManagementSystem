using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{

    // this class functions as a redirecting hub
    public partial class admStartPage : Form
    {

        public admStartPage()
        {
            InitializeComponent();
        }

        private void admStartPage_Load(object sender, EventArgs e)
        {

        }

        private void admStartPageBtnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            login lg = new login();
            lg.Show();
        }

        private void admStartPageBtnChangePassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            changePassword cp = new changePassword();
            cp.Show();
        }

        private void admStartPageBtnBookSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            admBookSearch abs = new admBookSearch();
            abs.Show();
        }

        private void admStartPageBtnEditBookDB_Click(object sender, EventArgs e)
        {
            this.Hide();
            admEditBookDB aeb = new admEditBookDB();
            aeb.Show();
        }

        private void admStartPageBtnEditStudentDB_Click(object sender, EventArgs e)
        {
            this.Hide();
            admEditStudentDB aes = new admEditStudentDB();
            aes.Show();
        }

        private void admStartPageBtnIssue_Click(object sender, EventArgs e)
        {
            this.Hide();
            admIssue ai = new admIssue();
            ai.Show();
        }

        private void admStartPageBtnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            admReturn ar = new admReturn();
            ar.Show();
        }
    }
}

namespace LibraryManagementSystem
{
    partial class userBookSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.usrBookSearchBtnLogout = new System.Windows.Forms.Button();
            this.UserBookSearchBtnSearch = new System.Windows.Forms.Button();
            this.UserBookSearchTbxQuery = new System.Windows.Forms.TextBox();
            this.userBookSearchRbBoth = new System.Windows.Forms.RadioButton();
            this.userBookSearchRbAuthor = new System.Windows.Forms.RadioButton();
            this.userBookSearchRbTitle = new System.Windows.Forms.RadioButton();
            this.userBookSearchLblSearch = new System.Windows.Forms.Label();
            this.userBookSearchDgv = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBookSearchDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.usrBookSearchBtnLogout);
            this.panel1.Controls.Add(this.UserBookSearchBtnSearch);
            this.panel1.Controls.Add(this.UserBookSearchTbxQuery);
            this.panel1.Controls.Add(this.userBookSearchRbBoth);
            this.panel1.Controls.Add(this.userBookSearchRbAuthor);
            this.panel1.Controls.Add(this.userBookSearchRbTitle);
            this.panel1.Controls.Add(this.userBookSearchLblSearch);
            this.panel1.Controls.Add(this.userBookSearchDgv);
            this.panel1.Location = new System.Drawing.Point(43, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1277, 722);
            this.panel1.TabIndex = 0;
            // 
            // usrBookSearchBtnLogout
            // 
            this.usrBookSearchBtnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.usrBookSearchBtnLogout.Location = new System.Drawing.Point(1051, 85);
            this.usrBookSearchBtnLogout.Name = "usrBookSearchBtnLogout";
            this.usrBookSearchBtnLogout.Size = new System.Drawing.Size(75, 35);
            this.usrBookSearchBtnLogout.TabIndex = 21;
            this.usrBookSearchBtnLogout.Text = "Logout";
            this.usrBookSearchBtnLogout.UseVisualStyleBackColor = true;
            this.usrBookSearchBtnLogout.Click += new System.EventHandler(this.UserBookSearchBtnLogout_Click);
            // 
            // UserBookSearchBtnSearch
            // 
            this.UserBookSearchBtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserBookSearchBtnSearch.Location = new System.Drawing.Point(460, 121);
            this.UserBookSearchBtnSearch.Name = "UserBookSearchBtnSearch";
            this.UserBookSearchBtnSearch.Size = new System.Drawing.Size(88, 33);
            this.UserBookSearchBtnSearch.TabIndex = 19;
            this.UserBookSearchBtnSearch.Text = "Search";
            this.UserBookSearchBtnSearch.UseVisualStyleBackColor = true;
            this.UserBookSearchBtnSearch.Click += new System.EventHandler(this.UserBookSearchBtnSearch_Click);
            // 
            // UserBookSearchTbxQuery
            // 
            this.UserBookSearchTbxQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserBookSearchTbxQuery.Location = new System.Drawing.Point(221, 92);
            this.UserBookSearchTbxQuery.Name = "UserBookSearchTbxQuery";
            this.UserBookSearchTbxQuery.Size = new System.Drawing.Size(327, 23);
            this.UserBookSearchTbxQuery.TabIndex = 18;
            // 
            // userBookSearchRbBoth
            // 
            this.userBookSearchRbBoth.AutoSize = true;
            this.userBookSearchRbBoth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBookSearchRbBoth.Location = new System.Drawing.Point(364, 121);
            this.userBookSearchRbBoth.Name = "userBookSearchRbBoth";
            this.userBookSearchRbBoth.Size = new System.Drawing.Size(61, 24);
            this.userBookSearchRbBoth.TabIndex = 17;
            this.userBookSearchRbBoth.TabStop = true;
            this.userBookSearchRbBoth.Text = "Both";
            this.userBookSearchRbBoth.UseVisualStyleBackColor = true;
            // 
            // userBookSearchRbAuthor
            // 
            this.userBookSearchRbAuthor.AutoSize = true;
            this.userBookSearchRbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBookSearchRbAuthor.Location = new System.Drawing.Point(283, 121);
            this.userBookSearchRbAuthor.Name = "userBookSearchRbAuthor";
            this.userBookSearchRbAuthor.Size = new System.Drawing.Size(75, 24);
            this.userBookSearchRbAuthor.TabIndex = 16;
            this.userBookSearchRbAuthor.TabStop = true;
            this.userBookSearchRbAuthor.Text = "Author";
            this.userBookSearchRbAuthor.UseVisualStyleBackColor = true;
            // 
            // userBookSearchRbTitle
            // 
            this.userBookSearchRbTitle.AutoSize = true;
            this.userBookSearchRbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBookSearchRbTitle.Location = new System.Drawing.Point(221, 121);
            this.userBookSearchRbTitle.Name = "userBookSearchRbTitle";
            this.userBookSearchRbTitle.Size = new System.Drawing.Size(56, 24);
            this.userBookSearchRbTitle.TabIndex = 15;
            this.userBookSearchRbTitle.TabStop = true;
            this.userBookSearchRbTitle.Text = "Title";
            this.userBookSearchRbTitle.UseVisualStyleBackColor = true;
            // 
            // userBookSearchLblSearch
            // 
            this.userBookSearchLblSearch.AutoSize = true;
            this.userBookSearchLblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBookSearchLblSearch.Location = new System.Drawing.Point(151, 95);
            this.userBookSearchLblSearch.Name = "userBookSearchLblSearch";
            this.userBookSearchLblSearch.Size = new System.Drawing.Size(64, 20);
            this.userBookSearchLblSearch.TabIndex = 14;
            this.userBookSearchLblSearch.Text = "Search:";
            // 
            // userBookSearchDgv
            // 
            this.userBookSearchDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.userBookSearchDgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userBookSearchDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.userBookSearchDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userBookSearchDgv.Location = new System.Drawing.Point(157, 207);
            this.userBookSearchDgv.Name = "userBookSearchDgv";
            this.userBookSearchDgv.Size = new System.Drawing.Size(969, 481);
            this.userBookSearchDgv.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(980, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 35);
            this.button1.TabIndex = 22;
            this.button1.Text = "Change Password";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.userBookSeacrhBtnChangePassword_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(980, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 35);
            this.button2.TabIndex = 23;
            this.button2.Text = "Issued Books";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.usrBookSearchBtnIssuedBooks_Click);
            // 
            // userBookSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 781);
            this.Controls.Add(this.panel1);
            this.Name = "userBookSearch";
            this.Text = "Search Books";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.userBookSearch_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBookSearchDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button usrBookSearchBtnLogout;
        private System.Windows.Forms.Button UserBookSearchBtnSearch;
        private System.Windows.Forms.TextBox UserBookSearchTbxQuery;
        private System.Windows.Forms.RadioButton userBookSearchRbBoth;
        private System.Windows.Forms.RadioButton userBookSearchRbAuthor;
        private System.Windows.Forms.RadioButton userBookSearchRbTitle;
        private System.Windows.Forms.Label userBookSearchLblSearch;
        private System.Windows.Forms.DataGridView userBookSearchDgv;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}
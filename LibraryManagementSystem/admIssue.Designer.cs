namespace LibraryManagementSystem
{
    partial class admIssue
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.admIssueBooksBtnLogout = new System.Windows.Forms.Button();
            this.admIssueBooksBtnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.admIssueBtnSearch = new System.Windows.Forms.Button();
            this.admIssueTbxSearchQuery = new System.Windows.Forms.TextBox();
            this.admIssueRbBoth = new System.Windows.Forms.RadioButton();
            this.admIssueRbAuthor = new System.Windows.Forms.RadioButton();
            this.admIssueRbTitle = new System.Windows.Forms.RadioButton();
            this.admBookSearchLblSearch = new System.Windows.Forms.Label();
            this.admIssueDgvTable = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.admIssueBtnIssue = new System.Windows.Forms.Button();
            this.admIssueTbxUserID = new System.Windows.Forms.TextBox();
            this.amdIssueTbxBookID = new System.Windows.Forms.TextBox();
            this.admIssueLblUserID = new System.Windows.Forms.Label();
            this.admIssueLblBookID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admIssueDgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.admIssueBooksBtnLogout);
            this.panel1.Controls.Add(this.admIssueBooksBtnBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.admIssueBtnSearch);
            this.panel1.Controls.Add(this.admIssueTbxSearchQuery);
            this.panel1.Controls.Add(this.admIssueRbBoth);
            this.panel1.Controls.Add(this.admIssueRbAuthor);
            this.panel1.Controls.Add(this.admIssueRbTitle);
            this.panel1.Controls.Add(this.admBookSearchLblSearch);
            this.panel1.Controls.Add(this.admIssueDgvTable);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.admIssueBtnIssue);
            this.panel1.Controls.Add(this.admIssueTbxUserID);
            this.panel1.Controls.Add(this.amdIssueTbxBookID);
            this.panel1.Controls.Add(this.admIssueLblUserID);
            this.panel1.Controls.Add(this.admIssueLblBookID);
            this.panel1.Location = new System.Drawing.Point(69, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 711);
            this.panel1.TabIndex = 0;
            // 
            // admIssueBooksBtnLogout
            // 
            this.admIssueBooksBtnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admIssueBooksBtnLogout.Location = new System.Drawing.Point(717, 17);
            this.admIssueBooksBtnLogout.Name = "admIssueBooksBtnLogout";
            this.admIssueBooksBtnLogout.Size = new System.Drawing.Size(77, 30);
            this.admIssueBooksBtnLogout.TabIndex = 68;
            this.admIssueBooksBtnLogout.Text = "Logout";
            this.admIssueBooksBtnLogout.UseVisualStyleBackColor = true;
            this.admIssueBooksBtnLogout.Click += new System.EventHandler(this.admIssueBooksBtnLogout_Click);
            // 
            // admIssueBooksBtnBack
            // 
            this.admIssueBooksBtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admIssueBooksBtnBack.Location = new System.Drawing.Point(25, 17);
            this.admIssueBooksBtnBack.Name = "admIssueBooksBtnBack";
            this.admIssueBooksBtnBack.Size = new System.Drawing.Size(77, 30);
            this.admIssueBooksBtnBack.TabIndex = 67;
            this.admIssueBooksBtnBack.Text = "Back";
            this.admIssueBooksBtnBack.UseVisualStyleBackColor = true;
            this.admIssueBooksBtnBack.Click += new System.EventHandler(this.admIssueBooksBtnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "( Only books that are not issued )";
            // 
            // admIssueBtnSearch
            // 
            this.admIssueBtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admIssueBtnSearch.Location = new System.Drawing.Point(552, 204);
            this.admIssueBtnSearch.Name = "admIssueBtnSearch";
            this.admIssueBtnSearch.Size = new System.Drawing.Size(88, 33);
            this.admIssueBtnSearch.TabIndex = 64;
            this.admIssueBtnSearch.Text = "Search";
            this.admIssueBtnSearch.UseVisualStyleBackColor = true;
            this.admIssueBtnSearch.Click += new System.EventHandler(this.admIssueBtnSearch_Click);
            // 
            // admIssueTbxSearchQuery
            // 
            this.admIssueTbxSearchQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admIssueTbxSearchQuery.Location = new System.Drawing.Point(199, 175);
            this.admIssueTbxSearchQuery.Name = "admIssueTbxSearchQuery";
            this.admIssueTbxSearchQuery.Size = new System.Drawing.Size(441, 23);
            this.admIssueTbxSearchQuery.TabIndex = 63;
            // 
            // admIssueRbBoth
            // 
            this.admIssueRbBoth.AutoSize = true;
            this.admIssueRbBoth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admIssueRbBoth.Location = new System.Drawing.Point(342, 204);
            this.admIssueRbBoth.Name = "admIssueRbBoth";
            this.admIssueRbBoth.Size = new System.Drawing.Size(61, 24);
            this.admIssueRbBoth.TabIndex = 62;
            this.admIssueRbBoth.TabStop = true;
            this.admIssueRbBoth.Text = "Both";
            this.admIssueRbBoth.UseVisualStyleBackColor = true;
            // 
            // admIssueRbAuthor
            // 
            this.admIssueRbAuthor.AutoSize = true;
            this.admIssueRbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admIssueRbAuthor.Location = new System.Drawing.Point(261, 204);
            this.admIssueRbAuthor.Name = "admIssueRbAuthor";
            this.admIssueRbAuthor.Size = new System.Drawing.Size(75, 24);
            this.admIssueRbAuthor.TabIndex = 61;
            this.admIssueRbAuthor.TabStop = true;
            this.admIssueRbAuthor.Text = "Author";
            this.admIssueRbAuthor.UseVisualStyleBackColor = true;
            // 
            // admIssueRbTitle
            // 
            this.admIssueRbTitle.AutoSize = true;
            this.admIssueRbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admIssueRbTitle.Location = new System.Drawing.Point(199, 204);
            this.admIssueRbTitle.Name = "admIssueRbTitle";
            this.admIssueRbTitle.Size = new System.Drawing.Size(56, 24);
            this.admIssueRbTitle.TabIndex = 60;
            this.admIssueRbTitle.TabStop = true;
            this.admIssueRbTitle.Text = "Title";
            this.admIssueRbTitle.UseVisualStyleBackColor = true;
            // 
            // admBookSearchLblSearch
            // 
            this.admBookSearchLblSearch.AutoSize = true;
            this.admBookSearchLblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admBookSearchLblSearch.Location = new System.Drawing.Point(129, 178);
            this.admBookSearchLblSearch.Name = "admBookSearchLblSearch";
            this.admBookSearchLblSearch.Size = new System.Drawing.Size(64, 20);
            this.admBookSearchLblSearch.TabIndex = 59;
            this.admBookSearchLblSearch.Text = "Search:";
            // 
            // admIssueDgvTable
            // 
            this.admIssueDgvTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.admIssueDgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.admIssueDgvTable.Location = new System.Drawing.Point(25, 281);
            this.admIssueDgvTable.Name = "admIssueDgvTable";
            this.admIssueDgvTable.Size = new System.Drawing.Size(769, 405);
            this.admIssueDgvTable.TabIndex = 58;
            this.admIssueDgvTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.admIssueDgvTable_CellClick);
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(25, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(769, 2);
            this.label7.TabIndex = 57;
            // 
            // admIssueBtnIssue
            // 
            this.admIssueBtnIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.admIssueBtnIssue.Location = new System.Drawing.Point(341, 102);
            this.admIssueBtnIssue.Name = "admIssueBtnIssue";
            this.admIssueBtnIssue.Size = new System.Drawing.Size(96, 33);
            this.admIssueBtnIssue.TabIndex = 19;
            this.admIssueBtnIssue.Text = "Issue";
            this.admIssueBtnIssue.UseVisualStyleBackColor = true;
            this.admIssueBtnIssue.Click += new System.EventHandler(this.admIssueBtnIssue_Click);
            // 
            // admIssueTbxUserID
            // 
            this.admIssueTbxUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.admIssueTbxUserID.Location = new System.Drawing.Point(374, 65);
            this.admIssueTbxUserID.Name = "admIssueTbxUserID";
            this.admIssueTbxUserID.Size = new System.Drawing.Size(151, 31);
            this.admIssueTbxUserID.TabIndex = 18;
            // 
            // amdIssueTbxBookID
            // 
            this.amdIssueTbxBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.amdIssueTbxBookID.Location = new System.Drawing.Point(374, 19);
            this.amdIssueTbxBookID.Name = "amdIssueTbxBookID";
            this.amdIssueTbxBookID.Size = new System.Drawing.Size(151, 31);
            this.amdIssueTbxBookID.TabIndex = 17;
            // 
            // admIssueLblUserID
            // 
            this.admIssueLblUserID.AutoSize = true;
            this.admIssueLblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.admIssueLblUserID.Location = new System.Drawing.Point(267, 68);
            this.admIssueLblUserID.Name = "admIssueLblUserID";
            this.admIssueLblUserID.Size = new System.Drawing.Size(95, 25);
            this.admIssueLblUserID.TabIndex = 16;
            this.admIssueLblUserID.Text = "User ID: ";
            // 
            // admIssueLblBookID
            // 
            this.admIssueLblBookID.AutoSize = true;
            this.admIssueLblBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admIssueLblBookID.Location = new System.Drawing.Point(263, 22);
            this.admIssueLblBookID.Name = "admIssueLblBookID";
            this.admIssueLblBookID.Size = new System.Drawing.Size(99, 25);
            this.admIssueLblBookID.TabIndex = 15;
            this.admIssueLblBookID.Text = "Book ID: ";
            // 
            // admIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 764);
            this.Controls.Add(this.panel1);
            this.Name = "admIssue";
            this.Text = "Issue Books";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.admIssue_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admIssueDgvTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label admIssueLblUserID;
        private System.Windows.Forms.Label admIssueLblBookID;
        private System.Windows.Forms.TextBox admIssueTbxUserID;
        private System.Windows.Forms.TextBox amdIssueTbxBookID;
        private System.Windows.Forms.Button admIssueBtnIssue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView admIssueDgvTable;
        private System.Windows.Forms.Button admIssueBtnSearch;
        private System.Windows.Forms.TextBox admIssueTbxSearchQuery;
        private System.Windows.Forms.RadioButton admIssueRbBoth;
        private System.Windows.Forms.RadioButton admIssueRbAuthor;
        private System.Windows.Forms.RadioButton admIssueRbTitle;
        private System.Windows.Forms.Label admBookSearchLblSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button admIssueBooksBtnLogout;
        private System.Windows.Forms.Button admIssueBooksBtnBack;
    }
}
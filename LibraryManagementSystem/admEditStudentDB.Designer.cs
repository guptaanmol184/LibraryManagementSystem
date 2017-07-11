namespace LibraryManagementSystem
{
    partial class admEditStudentDB
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.editStudentDBBtnDelete = new System.Windows.Forms.Button();
            this.editStudentDBBtnSave = new System.Windows.Forms.Button();
            this.editStudentDBBtnSearch = new System.Windows.Forms.Button();
            this.editStudentDBTbxSearch = new System.Windows.Forms.TextBox();
            this.userBookSearchLblSearch = new System.Windows.Forms.Label();
            this.editStudentDBDgvTable = new System.Windows.Forms.DataGridView();
            this.editStudentDBTbxEmail = new System.Windows.Forms.TextBox();
            this.admStudentDBTbxName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.admStudentDBCbAdmin = new System.Windows.Forms.CheckBox();
            this.admEditStudentDBBtnClear = new System.Windows.Forms.Button();
            this.editStudentDBBtnAddToDB = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.editStudentDBTbxAddress = new System.Windows.Forms.TextBox();
            this.editStudentDBTbxPassword = new System.Windows.Forms.TextBox();
            this.editStudentDBTbxUserID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.editStudentDBBtnLogout = new System.Windows.Forms.Button();
            this.editStudentDBBtnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.editStudentDBDgvTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // editStudentDBBtnDelete
            // 
            this.editStudentDBBtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.editStudentDBBtnDelete.Location = new System.Drawing.Point(745, 654);
            this.editStudentDBBtnDelete.Name = "editStudentDBBtnDelete";
            this.editStudentDBBtnDelete.Size = new System.Drawing.Size(125, 54);
            this.editStudentDBBtnDelete.TabIndex = 65;
            this.editStudentDBBtnDelete.Text = "Delete";
            this.editStudentDBBtnDelete.UseVisualStyleBackColor = true;
            this.editStudentDBBtnDelete.Click += new System.EventHandler(this.editStudentDBBtnDelete_Click);
            // 
            // editStudentDBBtnSave
            // 
            this.editStudentDBBtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editStudentDBBtnSave.Location = new System.Drawing.Point(485, 654);
            this.editStudentDBBtnSave.Name = "editStudentDBBtnSave";
            this.editStudentDBBtnSave.Size = new System.Drawing.Size(142, 54);
            this.editStudentDBBtnSave.TabIndex = 64;
            this.editStudentDBBtnSave.Text = "Save Edit";
            this.editStudentDBBtnSave.UseVisualStyleBackColor = true;
            this.editStudentDBBtnSave.Click += new System.EventHandler(this.editStudentDBBtnSave_Click);
            // 
            // editStudentDBBtnSearch
            // 
            this.editStudentDBBtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editStudentDBBtnSearch.Location = new System.Drawing.Point(689, 148);
            this.editStudentDBBtnSearch.Name = "editStudentDBBtnSearch";
            this.editStudentDBBtnSearch.Size = new System.Drawing.Size(88, 33);
            this.editStudentDBBtnSearch.TabIndex = 63;
            this.editStudentDBBtnSearch.Text = "Search";
            this.editStudentDBBtnSearch.UseVisualStyleBackColor = true;
            this.editStudentDBBtnSearch.Click += new System.EventHandler(this.editStudentDBBtnSearch_Click);
            // 
            // editStudentDBTbxSearch
            // 
            this.editStudentDBTbxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editStudentDBTbxSearch.Location = new System.Drawing.Point(261, 119);
            this.editStudentDBTbxSearch.Name = "editStudentDBTbxSearch";
            this.editStudentDBTbxSearch.Size = new System.Drawing.Size(516, 23);
            this.editStudentDBTbxSearch.TabIndex = 62;
            // 
            // userBookSearchLblSearch
            // 
            this.userBookSearchLblSearch.AutoSize = true;
            this.userBookSearchLblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBookSearchLblSearch.Location = new System.Drawing.Point(99, 122);
            this.userBookSearchLblSearch.Name = "userBookSearchLblSearch";
            this.userBookSearchLblSearch.Size = new System.Drawing.Size(156, 20);
            this.userBookSearchLblSearch.TabIndex = 58;
            this.userBookSearchLblSearch.Text = "Search (name or id) :";
            // 
            // editStudentDBDgvTable
            // 
            this.editStudentDBDgvTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.editStudentDBDgvTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.editStudentDBDgvTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.editStudentDBDgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.editStudentDBDgvTable.Location = new System.Drawing.Point(102, 206);
            this.editStudentDBDgvTable.Name = "editStudentDBDgvTable";
            this.editStudentDBDgvTable.Size = new System.Drawing.Size(969, 169);
            this.editStudentDBDgvTable.TabIndex = 57;
            this.editStudentDBDgvTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.editStudentDBDgvTable_CellClick);
            // 
            // editStudentDBTbxEmail
            // 
            this.editStudentDBTbxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.editStudentDBTbxEmail.Location = new System.Drawing.Point(427, 573);
            this.editStudentDBTbxEmail.Name = "editStudentDBTbxEmail";
            this.editStudentDBTbxEmail.Size = new System.Drawing.Size(479, 23);
            this.editStudentDBTbxEmail.TabIndex = 55;
            // 
            // admStudentDBTbxName
            // 
            this.admStudentDBTbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.admStudentDBTbxName.Location = new System.Drawing.Point(186, 492);
            this.admStudentDBTbxName.Name = "admStudentDBTbxName";
            this.admStudentDBTbxName.Size = new System.Drawing.Size(514, 23);
            this.admStudentDBTbxName.TabIndex = 54;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.admStudentDBCbAdmin);
            this.panel1.Controls.Add(this.admEditStudentDBBtnClear);
            this.panel1.Controls.Add(this.editStudentDBBtnAddToDB);
            this.panel1.Controls.Add(this.editStudentDBBtnDelete);
            this.panel1.Controls.Add(this.editStudentDBBtnSave);
            this.panel1.Controls.Add(this.editStudentDBBtnSearch);
            this.panel1.Controls.Add(this.editStudentDBTbxSearch);
            this.panel1.Controls.Add(this.userBookSearchLblSearch);
            this.panel1.Controls.Add(this.editStudentDBDgvTable);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.editStudentDBTbxEmail);
            this.panel1.Controls.Add(this.admStudentDBTbxName);
            this.panel1.Controls.Add(this.editStudentDBTbxAddress);
            this.panel1.Controls.Add(this.editStudentDBTbxPassword);
            this.panel1.Controls.Add(this.editStudentDBTbxUserID);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.editStudentDBBtnLogout);
            this.panel1.Controls.Add(this.editStudentDBBtnBack);
            this.panel1.Location = new System.Drawing.Point(39, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1181, 717);
            this.panel1.TabIndex = 1;
            // 
            // admStudentDBCbAdmin
            // 
            this.admStudentDBCbAdmin.AutoSize = true;
            this.admStudentDBCbAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.admStudentDBCbAdmin.Location = new System.Drawing.Point(799, 495);
            this.admStudentDBCbAdmin.Name = "admStudentDBCbAdmin";
            this.admStudentDBCbAdmin.Size = new System.Drawing.Size(73, 24);
            this.admStudentDBCbAdmin.TabIndex = 69;
            this.admStudentDBCbAdmin.Text = "Admin";
            this.admStudentDBCbAdmin.UseVisualStyleBackColor = true;
            // 
            // admEditStudentDBBtnClear
            // 
            this.admEditStudentDBBtnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admEditStudentDBBtnClear.Location = new System.Drawing.Point(940, 586);
            this.admEditStudentDBBtnClear.Name = "admEditStudentDBBtnClear";
            this.admEditStudentDBBtnClear.Size = new System.Drawing.Size(131, 39);
            this.admEditStudentDBBtnClear.TabIndex = 68;
            this.admEditStudentDBBtnClear.Text = "Clear Values";
            this.admEditStudentDBBtnClear.UseVisualStyleBackColor = true;
            this.admEditStudentDBBtnClear.Click += new System.EventHandler(this.admEditStudentDBBtnClear_Click);
            // 
            // editStudentDBBtnAddToDB
            // 
            this.editStudentDBBtnAddToDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editStudentDBBtnAddToDB.Location = new System.Drawing.Point(251, 654);
            this.editStudentDBBtnAddToDB.Name = "editStudentDBBtnAddToDB";
            this.editStudentDBBtnAddToDB.Size = new System.Drawing.Size(149, 54);
            this.editStudentDBBtnAddToDB.TabIndex = 67;
            this.editStudentDBBtnAddToDB.Text = "Add to DB";
            this.editStudentDBBtnAddToDB.UseVisualStyleBackColor = true;
            this.editStudentDBBtnAddToDB.Click += new System.EventHandler(this.editStudentDBBtnAddToDB_Click);
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(102, 416);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(969, 2);
            this.label7.TabIndex = 56;
            // 
            // editStudentDBTbxAddress
            // 
            this.editStudentDBTbxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.editStudentDBTbxAddress.Location = new System.Drawing.Point(186, 530);
            this.editStudentDBTbxAddress.Name = "editStudentDBTbxAddress";
            this.editStudentDBTbxAddress.Size = new System.Drawing.Size(514, 23);
            this.editStudentDBTbxAddress.TabIndex = 52;
            // 
            // editStudentDBTbxPassword
            // 
            this.editStudentDBTbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.editStudentDBTbxPassword.Location = new System.Drawing.Point(880, 533);
            this.editStudentDBTbxPassword.Name = "editStudentDBTbxPassword";
            this.editStudentDBTbxPassword.Size = new System.Drawing.Size(191, 23);
            this.editStudentDBTbxPassword.TabIndex = 51;
            // 
            // editStudentDBTbxUserID
            // 
            this.editStudentDBTbxUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.editStudentDBTbxUserID.Location = new System.Drawing.Point(186, 458);
            this.editStudentDBTbxUserID.Name = "editStudentDBTbxUserID";
            this.editStudentDBTbxUserID.Size = new System.Drawing.Size(79, 23);
            this.editStudentDBTbxUserID.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(98, 530);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 49;
            this.label6.Text = "Address :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(99, 458);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 48;
            this.label5.Text = "User ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(361, 573);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 47;
            this.label4.Text = "E mail :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(795, 533);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Password :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(99, 495);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Name :";
            // 
            // editStudentDBBtnLogout
            // 
            this.editStudentDBBtnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.editStudentDBBtnLogout.Location = new System.Drawing.Point(996, 80);
            this.editStudentDBBtnLogout.Name = "editStudentDBBtnLogout";
            this.editStudentDBBtnLogout.Size = new System.Drawing.Size(75, 35);
            this.editStudentDBBtnLogout.TabIndex = 43;
            this.editStudentDBBtnLogout.Text = "Logout";
            this.editStudentDBBtnLogout.UseVisualStyleBackColor = true;
            this.editStudentDBBtnLogout.Click += new System.EventHandler(this.editStudentDBBtnLogout_Click);
            // 
            // editStudentDBBtnBack
            // 
            this.editStudentDBBtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.editStudentDBBtnBack.Location = new System.Drawing.Point(99, 63);
            this.editStudentDBBtnBack.Name = "editStudentDBBtnBack";
            this.editStudentDBBtnBack.Size = new System.Drawing.Size(82, 35);
            this.editStudentDBBtnBack.TabIndex = 42;
            this.editStudentDBBtnBack.Text = "Back";
            this.editStudentDBBtnBack.UseVisualStyleBackColor = true;
            this.editStudentDBBtnBack.Click += new System.EventHandler(this.editStudentDBBtnBack_Click);
            // 
            // admEditStudentDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 845);
            this.Controls.Add(this.panel1);
            this.Name = "admEditStudentDB";
            this.Text = "Edit User DB";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.admEditStudentDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.editStudentDBDgvTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button editStudentDBBtnDelete;
        private System.Windows.Forms.Button editStudentDBBtnSave;
        private System.Windows.Forms.Button editStudentDBBtnSearch;
        private System.Windows.Forms.TextBox editStudentDBTbxSearch;
        private System.Windows.Forms.Label userBookSearchLblSearch;
        private System.Windows.Forms.DataGridView editStudentDBDgvTable;
        private System.Windows.Forms.TextBox editStudentDBTbxEmail;
        private System.Windows.Forms.TextBox admStudentDBTbxName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox editStudentDBTbxAddress;
        private System.Windows.Forms.TextBox editStudentDBTbxPassword;
        private System.Windows.Forms.TextBox editStudentDBTbxUserID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button editStudentDBBtnLogout;
        private System.Windows.Forms.Button editStudentDBBtnBack;
        private System.Windows.Forms.Button editStudentDBBtnAddToDB;
        private System.Windows.Forms.Button admEditStudentDBBtnClear;
        private System.Windows.Forms.CheckBox admStudentDBCbAdmin;
    }
}
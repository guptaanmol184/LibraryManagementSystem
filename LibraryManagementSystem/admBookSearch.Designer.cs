namespace LibraryManagementSystem
{
    partial class admBookSearch
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
            this.admBookSearchBtnBack = new System.Windows.Forms.Button();
            this.admBookSearchBtnLogout = new System.Windows.Forms.Button();
            this.admBookSearchBtnSearch = new System.Windows.Forms.Button();
            this.admBookSearchTbxQuery = new System.Windows.Forms.TextBox();
            this.admBookSearchRbBoth = new System.Windows.Forms.RadioButton();
            this.admBookSearchRbAuthor = new System.Windows.Forms.RadioButton();
            this.admBookSearchRbTitle = new System.Windows.Forms.RadioButton();
            this.admBookSearchLblSearch = new System.Windows.Forms.Label();
            this.admBookSearchDgv = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admBookSearchDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.admBookSearchBtnBack);
            this.panel1.Controls.Add(this.admBookSearchBtnLogout);
            this.panel1.Controls.Add(this.admBookSearchBtnSearch);
            this.panel1.Controls.Add(this.admBookSearchTbxQuery);
            this.panel1.Controls.Add(this.admBookSearchRbBoth);
            this.panel1.Controls.Add(this.admBookSearchRbAuthor);
            this.panel1.Controls.Add(this.admBookSearchRbTitle);
            this.panel1.Controls.Add(this.admBookSearchLblSearch);
            this.panel1.Controls.Add(this.admBookSearchDgv);
            this.panel1.Location = new System.Drawing.Point(89, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1314, 703);
            this.panel1.TabIndex = 0;
            // 
            // admBookSearchBtnBack
            // 
            this.admBookSearchBtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.admBookSearchBtnBack.Location = new System.Drawing.Point(18, 22);
            this.admBookSearchBtnBack.Name = "admBookSearchBtnBack";
            this.admBookSearchBtnBack.Size = new System.Drawing.Size(75, 35);
            this.admBookSearchBtnBack.TabIndex = 33;
            this.admBookSearchBtnBack.Text = "Back";
            this.admBookSearchBtnBack.UseVisualStyleBackColor = true;
            this.admBookSearchBtnBack.Click += new System.EventHandler(this.admBookSearchBtnBack_Click);
            // 
            // admBookSearchBtnLogout
            // 
            this.admBookSearchBtnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.admBookSearchBtnLogout.Location = new System.Drawing.Point(1219, 22);
            this.admBookSearchBtnLogout.Name = "admBookSearchBtnLogout";
            this.admBookSearchBtnLogout.Size = new System.Drawing.Size(75, 35);
            this.admBookSearchBtnLogout.TabIndex = 32;
            this.admBookSearchBtnLogout.Text = "Logout";
            this.admBookSearchBtnLogout.UseVisualStyleBackColor = true;
            this.admBookSearchBtnLogout.Click += new System.EventHandler(this.admBookSearchBtnLogout_Click);
            // 
            // admBookSearchBtnSearch
            // 
            this.admBookSearchBtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admBookSearchBtnSearch.Location = new System.Drawing.Point(423, 97);
            this.admBookSearchBtnSearch.Name = "admBookSearchBtnSearch";
            this.admBookSearchBtnSearch.Size = new System.Drawing.Size(88, 33);
            this.admBookSearchBtnSearch.TabIndex = 30;
            this.admBookSearchBtnSearch.Text = "Search";
            this.admBookSearchBtnSearch.UseVisualStyleBackColor = true;
            this.admBookSearchBtnSearch.Click += new System.EventHandler(this.admBookSearchBtnSearch_Click);
            // 
            // admBookSearchTbxQuery
            // 
            this.admBookSearchTbxQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admBookSearchTbxQuery.Location = new System.Drawing.Point(133, 72);
            this.admBookSearchTbxQuery.Name = "admBookSearchTbxQuery";
            this.admBookSearchTbxQuery.Size = new System.Drawing.Size(378, 23);
            this.admBookSearchTbxQuery.TabIndex = 29;
            // 
            // admBookSearchRbBoth
            // 
            this.admBookSearchRbBoth.AutoSize = true;
            this.admBookSearchRbBoth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admBookSearchRbBoth.Location = new System.Drawing.Point(276, 101);
            this.admBookSearchRbBoth.Name = "admBookSearchRbBoth";
            this.admBookSearchRbBoth.Size = new System.Drawing.Size(61, 24);
            this.admBookSearchRbBoth.TabIndex = 28;
            this.admBookSearchRbBoth.TabStop = true;
            this.admBookSearchRbBoth.Text = "Both";
            this.admBookSearchRbBoth.UseVisualStyleBackColor = true;
            // 
            // admBookSearchRbAuthor
            // 
            this.admBookSearchRbAuthor.AutoSize = true;
            this.admBookSearchRbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admBookSearchRbAuthor.Location = new System.Drawing.Point(195, 101);
            this.admBookSearchRbAuthor.Name = "admBookSearchRbAuthor";
            this.admBookSearchRbAuthor.Size = new System.Drawing.Size(75, 24);
            this.admBookSearchRbAuthor.TabIndex = 27;
            this.admBookSearchRbAuthor.TabStop = true;
            this.admBookSearchRbAuthor.Text = "Author";
            this.admBookSearchRbAuthor.UseVisualStyleBackColor = true;
            // 
            // admBookSearchRbTitle
            // 
            this.admBookSearchRbTitle.AutoSize = true;
            this.admBookSearchRbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admBookSearchRbTitle.Location = new System.Drawing.Point(133, 101);
            this.admBookSearchRbTitle.Name = "admBookSearchRbTitle";
            this.admBookSearchRbTitle.Size = new System.Drawing.Size(56, 24);
            this.admBookSearchRbTitle.TabIndex = 26;
            this.admBookSearchRbTitle.TabStop = true;
            this.admBookSearchRbTitle.Text = "Title";
            this.admBookSearchRbTitle.UseVisualStyleBackColor = true;
            // 
            // admBookSearchLblSearch
            // 
            this.admBookSearchLblSearch.AutoSize = true;
            this.admBookSearchLblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admBookSearchLblSearch.Location = new System.Drawing.Point(14, 75);
            this.admBookSearchLblSearch.Name = "admBookSearchLblSearch";
            this.admBookSearchLblSearch.Size = new System.Drawing.Size(113, 20);
            this.admBookSearchLblSearch.TabIndex = 25;
            this.admBookSearchLblSearch.Text = "Search Books:";
            // 
            // admBookSearchDgv
            // 
            this.admBookSearchDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.admBookSearchDgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.admBookSearchDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.admBookSearchDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.admBookSearchDgv.Location = new System.Drawing.Point(20, 187);
            this.admBookSearchDgv.Name = "admBookSearchDgv";
            this.admBookSearchDgv.Size = new System.Drawing.Size(1274, 484);
            this.admBookSearchDgv.TabIndex = 23;
            // 
            // admBookSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 815);
            this.Controls.Add(this.panel1);
            this.Name = "admBookSearch";
            this.Text = "Admin Book Search";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.admBookSearch_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admBookSearchDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button admBookSearchBtnLogout;
        private System.Windows.Forms.Button admBookSearchBtnSearch;
        private System.Windows.Forms.TextBox admBookSearchTbxQuery;
        private System.Windows.Forms.RadioButton admBookSearchRbBoth;
        private System.Windows.Forms.RadioButton admBookSearchRbAuthor;
        private System.Windows.Forms.RadioButton admBookSearchRbTitle;
        private System.Windows.Forms.Label admBookSearchLblSearch;
        private System.Windows.Forms.DataGridView admBookSearchDgv;
        private System.Windows.Forms.Button admBookSearchBtnBack;
    }
}
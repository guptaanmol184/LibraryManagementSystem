namespace LibraryManagementSystem
{
    partial class login
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
            this.loginLblQuote = new System.Windows.Forms.Label();
            this.LoginBtnSubmit = new System.Windows.Forms.Button();
            this.loginTbxPassword = new System.Windows.Forms.TextBox();
            this.loginTbxUserId = new System.Windows.Forms.TextBox();
            this.loginLblPassword = new System.Windows.Forms.Label();
            this.loginLblUserId = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.LoginBtnSubmit);
            this.panel1.Controls.Add(this.loginTbxPassword);
            this.panel1.Controls.Add(this.loginTbxUserId);
            this.panel1.Controls.Add(this.loginLblPassword);
            this.panel1.Controls.Add(this.loginLblUserId);
            this.panel1.Controls.Add(this.loginLblQuote);
            this.panel1.Location = new System.Drawing.Point(67, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 559);
            this.panel1.TabIndex = 0;
            // 
            // loginLblQuote
            // 
            this.loginLblQuote.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.loginLblQuote.AutoSize = true;
            this.loginLblQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLblQuote.Location = new System.Drawing.Point(158, 124);
            this.loginLblQuote.Name = "loginLblQuote";
            this.loginLblQuote.Size = new System.Drawing.Size(585, 37);
            this.loginLblQuote.TabIndex = 3;
            this.loginLblQuote.Text = "A book is a gift you can open again and again...";
            this.loginLblQuote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginLblQuote.UseCompatibleTextRendering = true;
            // 
            // LoginBtnSubmit
            // 
            this.LoginBtnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginBtnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtnSubmit.Location = new System.Drawing.Point(456, 305);
            this.LoginBtnSubmit.Name = "LoginBtnSubmit";
            this.LoginBtnSubmit.Size = new System.Drawing.Size(74, 32);
            this.LoginBtnSubmit.TabIndex = 9;
            this.LoginBtnSubmit.Text = "Submit";
            this.LoginBtnSubmit.UseVisualStyleBackColor = true;
            this.LoginBtnSubmit.Click += new System.EventHandler(this.LoginBtnSubmit_Click);
            // 
            // loginTbxPassword
            // 
            this.loginTbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTbxPassword.Location = new System.Drawing.Point(354, 256);
            this.loginTbxPassword.Name = "loginTbxPassword";
            this.loginTbxPassword.PasswordChar = '*';
            this.loginTbxPassword.Size = new System.Drawing.Size(294, 27);
            this.loginTbxPassword.TabIndex = 8;
            // 
            // loginTbxUserId
            // 
            this.loginTbxUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTbxUserId.Location = new System.Drawing.Point(354, 211);
            this.loginTbxUserId.Name = "loginTbxUserId";
            this.loginTbxUserId.Size = new System.Drawing.Size(294, 27);
            this.loginTbxUserId.TabIndex = 7;
            // 
            // loginLblPassword
            // 
            this.loginLblPassword.AutoSize = true;
            this.loginLblPassword.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLblPassword.Location = new System.Drawing.Point(224, 261);
            this.loginLblPassword.Name = "loginLblPassword";
            this.loginLblPassword.Size = new System.Drawing.Size(110, 22);
            this.loginLblPassword.TabIndex = 6;
            this.loginLblPassword.Text = "Password :";
            // 
            // loginLblUserId
            // 
            this.loginLblUserId.AutoSize = true;
            this.loginLblUserId.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLblUserId.Location = new System.Drawing.Point(224, 216);
            this.loginLblUserId.Name = "loginLblUserId";
            this.loginLblUserId.Size = new System.Drawing.Size(100, 22);
            this.loginLblUserId.TabIndex = 5;
            this.loginLblUserId.Text = "User ID :";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 638);
            this.Controls.Add(this.panel1);
            this.Name = "login";
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label loginLblQuote;
        private System.Windows.Forms.Button LoginBtnSubmit;
        private System.Windows.Forms.TextBox loginTbxPassword;
        private System.Windows.Forms.TextBox loginTbxUserId;
        private System.Windows.Forms.Label loginLblPassword;
        private System.Windows.Forms.Label loginLblUserId;
    }
}


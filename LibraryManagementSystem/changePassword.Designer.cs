namespace LibraryManagementSystem
{
    partial class changePassword
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
            this.chnagePassbtnSubmit = new System.Windows.Forms.Button();
            this.chnagePassTbxConfirmPass = new System.Windows.Forms.TextBox();
            this.chnagePassTbxNewPass = new System.Windows.Forms.TextBox();
            this.chnagePassTbxCurPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.changePassBtnCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.changePassBtnCancel);
            this.panel1.Controls.Add(this.chnagePassbtnSubmit);
            this.panel1.Controls.Add(this.chnagePassTbxConfirmPass);
            this.panel1.Controls.Add(this.chnagePassTbxNewPass);
            this.panel1.Controls.Add(this.chnagePassTbxCurPass);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(260, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(616, 346);
            this.panel1.TabIndex = 0;
            // 
            // chnagePassbtnSubmit
            // 
            this.chnagePassbtnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chnagePassbtnSubmit.Location = new System.Drawing.Point(312, 246);
            this.chnagePassbtnSubmit.Name = "chnagePassbtnSubmit";
            this.chnagePassbtnSubmit.Size = new System.Drawing.Size(167, 45);
            this.chnagePassbtnSubmit.TabIndex = 6;
            this.chnagePassbtnSubmit.Text = "Submit";
            this.chnagePassbtnSubmit.UseVisualStyleBackColor = true;
            this.chnagePassbtnSubmit.Click += new System.EventHandler(this.chnagePassbtnSubmit_Click);
            // 
            // chnagePassTbxConfirmPass
            // 
            this.chnagePassTbxConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chnagePassTbxConfirmPass.Location = new System.Drawing.Point(297, 172);
            this.chnagePassTbxConfirmPass.Name = "chnagePassTbxConfirmPass";
            this.chnagePassTbxConfirmPass.PasswordChar = '*';
            this.chnagePassTbxConfirmPass.Size = new System.Drawing.Size(198, 27);
            this.chnagePassTbxConfirmPass.TabIndex = 5;
            // 
            // chnagePassTbxNewPass
            // 
            this.chnagePassTbxNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chnagePassTbxNewPass.Location = new System.Drawing.Point(297, 127);
            this.chnagePassTbxNewPass.Name = "chnagePassTbxNewPass";
            this.chnagePassTbxNewPass.PasswordChar = '*';
            this.chnagePassTbxNewPass.Size = new System.Drawing.Size(198, 27);
            this.chnagePassTbxNewPass.TabIndex = 4;
            // 
            // chnagePassTbxCurPass
            // 
            this.chnagePassTbxCurPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chnagePassTbxCurPass.Location = new System.Drawing.Point(297, 85);
            this.chnagePassTbxCurPass.Name = "chnagePassTbxCurPass";
            this.chnagePassTbxCurPass.PasswordChar = '*';
            this.chnagePassTbxCurPass.Size = new System.Drawing.Size(198, 27);
            this.chnagePassTbxCurPass.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Conform New Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Password :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Password :";
            // 
            // changePassBtnCancel
            // 
            this.changePassBtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.changePassBtnCancel.Location = new System.Drawing.Point(124, 248);
            this.changePassBtnCancel.Name = "changePassBtnCancel";
            this.changePassBtnCancel.Size = new System.Drawing.Size(75, 45);
            this.changePassBtnCancel.TabIndex = 14;
            this.changePassBtnCancel.Text = "Cancel";
            this.changePassBtnCancel.UseVisualStyleBackColor = true;
            this.changePassBtnCancel.Click += new System.EventHandler(this.changePassBtnCancel_Click);
            // 
            // changePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 709);
            this.Controls.Add(this.panel1);
            this.Name = "changePassword";
            this.Text = "Chnage Password";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.changePassword_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox chnagePassTbxConfirmPass;
        private System.Windows.Forms.TextBox chnagePassTbxNewPass;
        private System.Windows.Forms.TextBox chnagePassTbxCurPass;
        private System.Windows.Forms.Button chnagePassbtnSubmit;
        private System.Windows.Forms.Button changePassBtnCancel;
    }
}
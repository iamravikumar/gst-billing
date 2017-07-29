﻿namespace GST_Billing
{
    partial class Login
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
            this.splContLogin = new System.Windows.Forms.SplitContainer();
            this.lbCompanyName = new System.Windows.Forms.Label();
            this.lbCompanyAddress = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbContact = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCompanyContact = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splContLogin)).BeginInit();
            this.splContLogin.Panel1.SuspendLayout();
            this.splContLogin.Panel2.SuspendLayout();
            this.splContLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // splContLogin
            // 
            this.splContLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splContLogin.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splContLogin.Location = new System.Drawing.Point(0, 0);
            this.splContLogin.Name = "splContLogin";
            this.splContLogin.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splContLogin.Panel1
            // 
            this.splContLogin.Panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.splContLogin.Panel1.Controls.Add(this.lbCompanyContact);
            this.splContLogin.Panel1.Controls.Add(this.label1);
            this.splContLogin.Panel1.Controls.Add(this.lbContact);
            this.splContLogin.Panel1.Controls.Add(this.lbEmail);
            this.splContLogin.Panel1.Controls.Add(this.lbCompanyAddress);
            this.splContLogin.Panel1.Controls.Add(this.lbCompanyName);
            // 
            // splContLogin.Panel2
            // 
            this.splContLogin.Panel2.BackColor = System.Drawing.Color.LavenderBlush;
            this.splContLogin.Panel2.Controls.Add(this.btnCancel);
            this.splContLogin.Panel2.Controls.Add(this.btnOK);
            this.splContLogin.Panel2.Controls.Add(this.tbPassword);
            this.splContLogin.Panel2.Controls.Add(this.tbUserName);
            this.splContLogin.Panel2.Controls.Add(this.lbPassword);
            this.splContLogin.Panel2.Controls.Add(this.lbUserName);
            this.splContLogin.Size = new System.Drawing.Size(452, 280);
            this.splContLogin.SplitterDistance = 117;
            this.splContLogin.TabIndex = 0;
            // 
            // lbCompanyName
            // 
            this.lbCompanyName.AutoSize = true;
            this.lbCompanyName.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCompanyName.Location = new System.Drawing.Point(12, 9);
            this.lbCompanyName.Name = "lbCompanyName";
            this.lbCompanyName.Size = new System.Drawing.Size(129, 21);
            this.lbCompanyName.TabIndex = 0;
            this.lbCompanyName.Text = "Company Name";
            // 
            // lbCompanyAddress
            // 
            this.lbCompanyAddress.AutoSize = true;
            this.lbCompanyAddress.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCompanyAddress.Location = new System.Drawing.Point(12, 46);
            this.lbCompanyAddress.Name = "lbCompanyAddress";
            this.lbCompanyAddress.Size = new System.Drawing.Size(122, 17);
            this.lbCompanyAddress.TabIndex = 1;
            this.lbCompanyAddress.Text = "Company Address";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(12, 79);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(54, 16);
            this.lbEmail.TabIndex = 2;
            this.lbEmail.Text = "Email : ";
            // 
            // lbContact
            // 
            this.lbContact.AutoSize = true;
            this.lbContact.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContact.Location = new System.Drawing.Point(12, 96);
            this.lbContact.Name = "lbContact";
            this.lbContact.Size = new System.Drawing.Size(67, 16);
            this.lbContact.TabIndex = 3;
            this.lbContact.Text = "Contact : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "companyemail@abc.com";
            // 
            // lbCompanyContact
            // 
            this.lbCompanyContact.AutoSize = true;
            this.lbCompanyContact.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCompanyContact.Location = new System.Drawing.Point(88, 96);
            this.lbCompanyContact.Name = "lbCompanyContact";
            this.lbCompanyContact.Size = new System.Drawing.Size(112, 16);
            this.lbCompanyContact.TabIndex = 5;
            this.lbCompanyContact.Text = "+919876543210";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.Location = new System.Drawing.Point(72, 27);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(79, 17);
            this.lbUserName.TabIndex = 0;
            this.lbUserName.Text = "User Name : ";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(72, 67);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(70, 17);
            this.lbPassword.TabIndex = 1;
            this.lbPassword.Text = "Password : ";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(158, 26);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(169, 20);
            this.tbUserName.TabIndex = 2;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(158, 66);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(169, 20);
            this.tbPassword.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.Crimson;
            this.btnOK.Location = new System.Drawing.Point(158, 112);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 35);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Crimson;
            this.btnCancel.Location = new System.Drawing.Point(252, 112);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 35);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 280);
            this.Controls.Add(this.splContLogin);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(468, 318);
            this.Name = "Login";
            this.Text = "Login";
            this.splContLogin.Panel1.ResumeLayout(false);
            this.splContLogin.Panel1.PerformLayout();
            this.splContLogin.Panel2.ResumeLayout(false);
            this.splContLogin.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splContLogin)).EndInit();
            this.splContLogin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splContLogin;
        private System.Windows.Forms.Label lbCompanyName;
        private System.Windows.Forms.Label lbCompanyContact;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbContact;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbCompanyAddress;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}
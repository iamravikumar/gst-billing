﻿namespace GST_Billing
{
    partial class CompanyDetails
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
            this.lbName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbContact = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.tbGstin = new System.Windows.Forms.TextBox();
            this.lbGstin = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.blState = new System.Windows.Forms.Label();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.lbCode = new System.Windows.Forms.Label();
            this.cbState = new System.Windows.Forms.ComboBox();
            this.tbLandmark = new System.Windows.Forms.TextBox();
            this.lbLandmark = new System.Windows.Forms.Label();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.lbCity = new System.Windows.Forms.Label();
            this.tbBankName = new System.Windows.Forms.TextBox();
            this.lbBankName = new System.Windows.Forms.Label();
            this.tbPanNo = new System.Windows.Forms.TextBox();
            this.lbPanNumber = new System.Windows.Forms.Label();
            this.tbBranch = new System.Windows.Forms.TextBox();
            this.lbBranch = new System.Windows.Forms.Label();
            this.tbIfscCode = new System.Windows.Forms.TextBox();
            this.lbIfscCode = new System.Windows.Forms.Label();
            this.tbAccountNo = new System.Windows.Forms.TextBox();
            this.lbAccountNo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbContact = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(42, 18);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(47, 16);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(95, 15);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(656, 23);
            this.tbName.TabIndex = 0;
            this.tbName.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddress.Location = new System.Drawing.Point(95, 47);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(656, 23);
            this.tbAddress.TabIndex = 1;
            this.tbAddress.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.Location = new System.Drawing.Point(23, 50);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(66, 16);
            this.lbAddress.TabIndex = 6;
            this.lbAddress.Text = "Address";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(514, 105);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(237, 23);
            this.tbEmail.TabIndex = 2;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(458, 108);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(50, 16);
            this.lbEmail.TabIndex = 8;
            this.lbEmail.Text = "E-mail";
            // 
            // tbContact
            // 
            this.tbContact.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContact.Location = new System.Drawing.Point(514, 134);
            this.tbContact.Name = "tbContact";
            this.tbContact.Size = new System.Drawing.Size(237, 23);
            this.tbContact.TabIndex = 3;
            this.tbContact.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.tbContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbContact_KeyPress);
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.Location = new System.Drawing.Point(432, 138);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(76, 16);
            this.lbPhone.TabIndex = 10;
            this.lbPhone.Text = "Phone No";
            // 
            // tbGstin
            // 
            this.tbGstin.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGstin.Location = new System.Drawing.Point(95, 164);
            this.tbGstin.Name = "tbGstin";
            this.tbGstin.Size = new System.Drawing.Size(237, 23);
            this.tbGstin.TabIndex = 4;
            this.tbGstin.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // lbGstin
            // 
            this.lbGstin.AutoSize = true;
            this.lbGstin.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGstin.Location = new System.Drawing.Point(39, 167);
            this.lbGstin.Name = "lbGstin";
            this.lbGstin.Size = new System.Drawing.Size(50, 16);
            this.lbGstin.TabIndex = 12;
            this.lbGstin.Text = "GSTIN";
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(0, 293);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(755, 29);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // blState
            // 
            this.blState.AutoSize = true;
            this.blState.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blState.Location = new System.Drawing.Point(45, 108);
            this.blState.Name = "blState";
            this.blState.Size = new System.Drawing.Size(44, 16);
            this.blState.TabIndex = 15;
            this.blState.Text = "State";
            // 
            // tbCode
            // 
            this.tbCode.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCode.Location = new System.Drawing.Point(95, 135);
            this.tbCode.MaxLength = 2;
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(237, 23);
            this.tbCode.TabIndex = 6;
            this.tbCode.Click += new System.EventHandler(this.tbCode_Click);
            this.tbCode.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.tbCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbContact_KeyPress);
            this.tbCode.Leave += new System.EventHandler(this.tbCode_LeaveFocus);
            // 
            // lbCode
            // 
            this.lbCode.AutoSize = true;
            this.lbCode.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCode.Location = new System.Drawing.Point(44, 138);
            this.lbCode.Name = "lbCode";
            this.lbCode.Size = new System.Drawing.Size(45, 16);
            this.lbCode.TabIndex = 17;
            this.lbCode.Text = "Code";
            // 
            // cbState
            // 
            this.cbState.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbState.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbState.DropDownHeight = 100;
            this.cbState.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbState.FormattingEnabled = true;
            this.cbState.IntegralHeight = false;
            this.cbState.Items.AddRange(new object[] {
            "Andaman And Nicobar Islands",
            "Andhra Pradesh",
            "Arunachal Pradesh",
            "Assam",
            "Bihar",
            "Chandigarh",
            "Chattisgarh",
            "Dadra And Nagar Haveli",
            "Daman And Diu",
            "Delhi",
            "Goa",
            "Gujarat",
            "Haryana",
            "Himachal Pradesh",
            "Jammu And Kashmir",
            "Jharkhand",
            "Karnataka",
            "Kerala",
            "Lakshadweep Islands",
            "Madhya Pradesh",
            "Maharashtra",
            "Manipur",
            "Meghalaya",
            "Mizoram",
            "Nagaland",
            "Odisha",
            "Pondicherry",
            "Punjab",
            "Rajasthan",
            "Sikkim",
            "Tamil Nadu",
            "Telangana",
            "Tripura",
            "Uttar Pradesh",
            "Uttarakhand",
            "West Bengal"});
            this.cbState.Location = new System.Drawing.Point(95, 105);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(237, 24);
            this.cbState.TabIndex = 5;
            this.cbState.SelectedIndexChanged += new System.EventHandler(this.cbState_SelectedIndexChanged);
            this.cbState.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // tbLandmark
            // 
            this.tbLandmark.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLandmark.Location = new System.Drawing.Point(95, 76);
            this.tbLandmark.Name = "tbLandmark";
            this.tbLandmark.Size = new System.Drawing.Size(237, 23);
            this.tbLandmark.TabIndex = 18;
            // 
            // lbLandmark
            // 
            this.lbLandmark.AutoSize = true;
            this.lbLandmark.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLandmark.Location = new System.Drawing.Point(13, 79);
            this.lbLandmark.Name = "lbLandmark";
            this.lbLandmark.Size = new System.Drawing.Size(76, 16);
            this.lbLandmark.TabIndex = 19;
            this.lbLandmark.Text = "Landmark";
            // 
            // tbCity
            // 
            this.tbCity.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCity.Location = new System.Drawing.Point(514, 76);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(237, 23);
            this.tbCity.TabIndex = 20;
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCity.Location = new System.Drawing.Point(474, 79);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(34, 16);
            this.lbCity.TabIndex = 21;
            this.lbCity.Text = "City";
            // 
            // tbBankName
            // 
            this.tbBankName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBankName.Location = new System.Drawing.Point(514, 192);
            this.tbBankName.Name = "tbBankName";
            this.tbBankName.Size = new System.Drawing.Size(237, 23);
            this.tbBankName.TabIndex = 34;
            // 
            // lbBankName
            // 
            this.lbBankName.AutoSize = true;
            this.lbBankName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBankName.Location = new System.Drawing.Point(422, 195);
            this.lbBankName.Name = "lbBankName";
            this.lbBankName.Size = new System.Drawing.Size(86, 16);
            this.lbBankName.TabIndex = 35;
            this.lbBankName.Text = "Bank Name";
            // 
            // tbPanNo
            // 
            this.tbPanNo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPanNo.Location = new System.Drawing.Point(514, 163);
            this.tbPanNo.Name = "tbPanNo";
            this.tbPanNo.Size = new System.Drawing.Size(237, 23);
            this.tbPanNo.TabIndex = 33;
            // 
            // lbPanNumber
            // 
            this.lbPanNumber.AutoSize = true;
            this.lbPanNumber.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPanNumber.Location = new System.Drawing.Point(450, 166);
            this.lbPanNumber.Name = "lbPanNumber";
            this.lbPanNumber.Size = new System.Drawing.Size(58, 16);
            this.lbPanNumber.TabIndex = 36;
            this.lbPanNumber.Text = "PAN No";
            // 
            // tbBranch
            // 
            this.tbBranch.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBranch.Location = new System.Drawing.Point(514, 221);
            this.tbBranch.Name = "tbBranch";
            this.tbBranch.Size = new System.Drawing.Size(237, 23);
            this.tbBranch.TabIndex = 37;
            // 
            // lbBranch
            // 
            this.lbBranch.AutoSize = true;
            this.lbBranch.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBranch.Location = new System.Drawing.Point(407, 224);
            this.lbBranch.Name = "lbBranch";
            this.lbBranch.Size = new System.Drawing.Size(101, 16);
            this.lbBranch.TabIndex = 38;
            this.lbBranch.Text = "Branch Name";
            // 
            // tbIfscCode
            // 
            this.tbIfscCode.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIfscCode.Location = new System.Drawing.Point(95, 222);
            this.tbIfscCode.Name = "tbIfscCode";
            this.tbIfscCode.Size = new System.Drawing.Size(237, 23);
            this.tbIfscCode.TabIndex = 41;
            // 
            // lbIfscCode
            // 
            this.lbIfscCode.AutoSize = true;
            this.lbIfscCode.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIfscCode.Location = new System.Drawing.Point(8, 225);
            this.lbIfscCode.Name = "lbIfscCode";
            this.lbIfscCode.Size = new System.Drawing.Size(81, 16);
            this.lbIfscCode.TabIndex = 42;
            this.lbIfscCode.Text = "IFSC Code";
            // 
            // tbAccountNo
            // 
            this.tbAccountNo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAccountNo.Location = new System.Drawing.Point(95, 193);
            this.tbAccountNo.Name = "tbAccountNo";
            this.tbAccountNo.Size = new System.Drawing.Size(237, 23);
            this.tbAccountNo.TabIndex = 39;
            // 
            // lbAccountNo
            // 
            this.lbAccountNo.AutoSize = true;
            this.lbAccountNo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccountNo.Location = new System.Drawing.Point(1, 196);
            this.lbAccountNo.Name = "lbAccountNo";
            this.lbAccountNo.Size = new System.Drawing.Size(88, 16);
            this.lbAccountNo.TabIndex = 40;
            this.lbAccountNo.Text = "Account No";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(95, 251);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 23);
            this.textBox1.TabIndex = 43;
            // 
            // lbContact
            // 
            this.lbContact.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContact.Location = new System.Drawing.Point(8, 251);
            this.lbContact.Name = "lbContact";
            this.lbContact.Size = new System.Drawing.Size(81, 40);
            this.lbContact.TabIndex = 44;
            this.lbContact.Text = "Contact Person";
            // 
            // CompanyDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(755, 322);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbContact);
            this.Controls.Add(this.tbIfscCode);
            this.Controls.Add(this.lbIfscCode);
            this.Controls.Add(this.tbAccountNo);
            this.Controls.Add(this.lbAccountNo);
            this.Controls.Add(this.tbBranch);
            this.Controls.Add(this.lbBranch);
            this.Controls.Add(this.lbPanNumber);
            this.Controls.Add(this.tbBankName);
            this.Controls.Add(this.lbBankName);
            this.Controls.Add(this.tbPanNo);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.tbLandmark);
            this.Controls.Add(this.lbLandmark);
            this.Controls.Add(this.cbState);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.lbCode);
            this.Controls.Add(this.blState);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbGstin);
            this.Controls.Add(this.lbGstin);
            this.Controls.Add(this.tbContact);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbName);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(371, 299);
            this.Name = "CompanyDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompanyDetails";
            this.Load += new System.EventHandler(this.CompanyDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tbContact;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.TextBox tbGstin;
        private System.Windows.Forms.Label lbGstin;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label blState;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.Label lbCode;
        private System.Windows.Forms.ComboBox cbState;
        private System.Windows.Forms.TextBox tbLandmark;
        private System.Windows.Forms.Label lbLandmark;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.TextBox tbBankName;
        private System.Windows.Forms.Label lbBankName;
        private System.Windows.Forms.TextBox tbPanNo;
        private System.Windows.Forms.Label lbPanNumber;
        private System.Windows.Forms.TextBox tbBranch;
        private System.Windows.Forms.Label lbBranch;
        private System.Windows.Forms.TextBox tbIfscCode;
        private System.Windows.Forms.Label lbIfscCode;
        private System.Windows.Forms.TextBox tbAccountNo;
        private System.Windows.Forms.Label lbAccountNo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbContact;
    }
}
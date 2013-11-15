namespace IdRegistrationForm
{
    partial class BasicForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BasicForm));
            this.lblRegForm = new System.Windows.Forms.Label();
            this.cmbRegistration = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblBirthPlace = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtCountryOfBirth = new System.Windows.Forms.TextBox();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.btnGenerateID = new System.Windows.Forms.Button();
            this.txtGenerateID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWorkNumber = new System.Windows.Forms.Label();
            this.lblTelNumber = new System.Windows.Forms.Label();
            this.txtWorkNumber = new System.Windows.Forms.TextBox();
            this.txtTelNumber = new System.Windows.Forms.TextBox();
            this.txtDateOfBirth = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblRegForm
            // 
            this.lblRegForm.AutoSize = true;
            this.lblRegForm.Location = new System.Drawing.Point(11, 293);
            this.lblRegForm.Name = "lblRegForm";
            this.lblRegForm.Size = new System.Drawing.Size(86, 13);
            this.lblRegForm.TabIndex = 0;
            this.lblRegForm.Text = "Registraion form:";
            // 
            // cmbRegistration
            // 
            this.cmbRegistration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRegistration.FormattingEnabled = true;
            this.cmbRegistration.Items.AddRange(new object[] {
            "Birth certificate",
            "Death certificate",
            "Passport"});
            this.cmbRegistration.Location = new System.Drawing.Point(183, 290);
            this.cmbRegistration.Name = "cmbRegistration";
            this.cmbRegistration.Size = new System.Drawing.Size(149, 21);
            this.cmbRegistration.Sorted = true;
            this.cmbRegistration.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(11, 96);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(11, 122);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(52, 13);
            this.lblSurname.TabIndex = 3;
            this.lblSurname.Text = "Surname:";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(11, 148);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(133, 13);
            this.lblBirthDate.TabIndex = 4;
            this.lblBirthDate.Text = "Date of Birth   YY/MM/DD";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(11, 176);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(28, 13);
            this.lblSex.TabIndex = 5;
            this.lblSex.Text = "Sex:";
            // 
            // lblBirthPlace
            // 
            this.lblBirthPlace.AutoSize = true;
            this.lblBirthPlace.Location = new System.Drawing.Point(11, 199);
            this.lblBirthPlace.Name = "lblBirthPlace";
            this.lblBirthPlace.Size = new System.Drawing.Size(81, 13);
            this.lblBirthPlace.TabIndex = 6;
            this.lblBirthPlace.Text = "Country of birth:";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(215, 395);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 22);
            this.btnAccept.TabIndex = 7;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(186, 93);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 20);
            this.txtName.TabIndex = 8;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(186, 119);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(149, 20);
            this.txtSurname.TabIndex = 9;
            // 
            // txtCountryOfBirth
            // 
            this.txtCountryOfBirth.Location = new System.Drawing.Point(186, 196);
            this.txtCountryOfBirth.Name = "txtCountryOfBirth";
            this.txtCountryOfBirth.Size = new System.Drawing.Size(149, 20);
            this.txtCountryOfBirth.TabIndex = 11;
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Location = new System.Drawing.Point(186, 174);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(48, 17);
            this.rdbMale.TabIndex = 12;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Male";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Location = new System.Drawing.Point(276, 174);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(59, 17);
            this.rdbFemale.TabIndex = 13;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "Female";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // btnGenerateID
            // 
            this.btnGenerateID.Location = new System.Drawing.Point(14, 345);
            this.btnGenerateID.Name = "btnGenerateID";
            this.btnGenerateID.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateID.TabIndex = 15;
            this.btnGenerateID.Text = "Generate ID";
            this.btnGenerateID.UseVisualStyleBackColor = true;
            // 
            // txtGenerateID
            // 
            this.txtGenerateID.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtGenerateID.Location = new System.Drawing.Point(186, 347);
            this.txtGenerateID.Name = "txtGenerateID";
            this.txtGenerateID.ReadOnly = true;
            this.txtGenerateID.Size = new System.Drawing.Size(149, 20);
            this.txtGenerateID.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 32);
            this.label1.TabIndex = 17;
            this.label1.Text = "Please note that all fields entered here are \r\nbased on the person concerned in t" +
                "he document";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblWorkNumber
            // 
            this.lblWorkNumber.AutoSize = true;
            this.lblWorkNumber.Location = new System.Drawing.Point(10, 250);
            this.lblWorkNumber.Name = "lblWorkNumber";
            this.lblWorkNumber.Size = new System.Drawing.Size(73, 13);
            this.lblWorkNumber.TabIndex = 27;
            this.lblWorkNumber.Text = "Work Number";
            // 
            // lblTelNumber
            // 
            this.lblTelNumber.AutoSize = true;
            this.lblTelNumber.Location = new System.Drawing.Point(10, 226);
            this.lblTelNumber.Name = "lblTelNumber";
            this.lblTelNumber.Size = new System.Drawing.Size(62, 13);
            this.lblTelNumber.TabIndex = 26;
            this.lblTelNumber.Text = "Tel Number";
            // 
            // txtWorkNumber
            // 
            this.txtWorkNumber.Location = new System.Drawing.Point(185, 247);
            this.txtWorkNumber.Name = "txtWorkNumber";
            this.txtWorkNumber.Size = new System.Drawing.Size(150, 20);
            this.txtWorkNumber.TabIndex = 25;
            // 
            // txtTelNumber
            // 
            this.txtTelNumber.Location = new System.Drawing.Point(185, 221);
            this.txtTelNumber.Name = "txtTelNumber";
            this.txtTelNumber.Size = new System.Drawing.Size(150, 20);
            this.txtTelNumber.TabIndex = 24;
            // 
            // txtDateOfBirth
            // 
            this.txtDateOfBirth.Location = new System.Drawing.Point(186, 145);
            this.txtDateOfBirth.Mask = "00/00/00";
            this.txtDateOfBirth.Name = "txtDateOfBirth";
            this.txtDateOfBirth.Size = new System.Drawing.Size(149, 20);
            this.txtDateOfBirth.TabIndex = 28;
            this.txtDateOfBirth.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // BasicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(344, 448);
            this.Controls.Add(this.txtDateOfBirth);
            this.Controls.Add(this.lblWorkNumber);
            this.Controls.Add(this.lblTelNumber);
            this.Controls.Add(this.txtWorkNumber);
            this.Controls.Add(this.txtTelNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGenerateID);
            this.Controls.Add(this.btnGenerateID);
            this.Controls.Add(this.rdbFemale);
            this.Controls.Add(this.rdbMale);
            this.Controls.Add(this.txtCountryOfBirth);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.lblBirthPlace);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cmbRegistration);
            this.Controls.Add(this.lblRegForm);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BasicForm";
            this.Text = "South African Home Affairs";
            this.Load += new System.EventHandler(this.BasicForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegForm;
        private System.Windows.Forms.ComboBox cmbRegistration;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblBirthPlace;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtCountryOfBirth;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.Button btnGenerateID;
        private System.Windows.Forms.TextBox txtGenerateID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWorkNumber;
        private System.Windows.Forms.Label lblTelNumber;
        private System.Windows.Forms.TextBox txtWorkNumber;
        private System.Windows.Forms.TextBox txtTelNumber;
        private System.Windows.Forms.MaskedTextBox txtDateOfBirth;
    }
}


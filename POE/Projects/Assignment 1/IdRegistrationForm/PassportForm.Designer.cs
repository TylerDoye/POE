namespace IdRegistrationForm
{
    partial class PassportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassportForm));
            this.lblPreviousSurname = new System.Windows.Forms.Label();
            this.lblMaritalStatus = new System.Windows.Forms.Label();
            this.lblPlaceOFBirth = new System.Windows.Forms.Label();
            this.txtPreviousSurname = new System.Windows.Forms.TextBox();
            this.txtPlaceOfBirth = new System.Windows.Forms.TextBox();
            this.rdbUnmarried = new System.Windows.Forms.RadioButton();
            this.rdbMarried = new System.Windows.Forms.RadioButton();
            this.rdbWidower = new System.Windows.Forms.RadioButton();
            this.rdbWidow = new System.Windows.Forms.RadioButton();
            this.rdbDevorced = new System.Windows.Forms.RadioButton();
            this.grpMaritalStatus = new System.Windows.Forms.GroupBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.grpMaritalStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPreviousSurname
            // 
            this.lblPreviousSurname.AutoSize = true;
            this.lblPreviousSurname.Location = new System.Drawing.Point(12, 32);
            this.lblPreviousSurname.Name = "lblPreviousSurname";
            this.lblPreviousSurname.Size = new System.Drawing.Size(93, 13);
            this.lblPreviousSurname.TabIndex = 0;
            this.lblPreviousSurname.Text = "Previous Surname";
            // 
            // lblMaritalStatus
            // 
            this.lblMaritalStatus.AutoSize = true;
            this.lblMaritalStatus.Location = new System.Drawing.Point(12, 21);
            this.lblMaritalStatus.Name = "lblMaritalStatus";
            this.lblMaritalStatus.Size = new System.Drawing.Size(69, 13);
            this.lblMaritalStatus.TabIndex = 1;
            this.lblMaritalStatus.Text = "Marital status";
            // 
            // lblPlaceOFBirth
            // 
            this.lblPlaceOFBirth.AutoSize = true;
            this.lblPlaceOFBirth.Location = new System.Drawing.Point(15, 179);
            this.lblPlaceOFBirth.Name = "lblPlaceOFBirth";
            this.lblPlaceOFBirth.Size = new System.Drawing.Size(69, 13);
            this.lblPlaceOFBirth.TabIndex = 2;
            this.lblPlaceOFBirth.Text = "Place of birth";
            // 
            // txtPreviousSurname
            // 
            this.txtPreviousSurname.Location = new System.Drawing.Point(116, 29);
            this.txtPreviousSurname.Name = "txtPreviousSurname";
            this.txtPreviousSurname.Size = new System.Drawing.Size(174, 20);
            this.txtPreviousSurname.TabIndex = 3;
            // 
            // txtPlaceOfBirth
            // 
            this.txtPlaceOfBirth.Location = new System.Drawing.Point(116, 176);
            this.txtPlaceOfBirth.Name = "txtPlaceOfBirth";
            this.txtPlaceOfBirth.Size = new System.Drawing.Size(174, 20);
            this.txtPlaceOfBirth.TabIndex = 5;
            // 
            // rdbUnmarried
            // 
            this.rdbUnmarried.AutoSize = true;
            this.rdbUnmarried.Location = new System.Drawing.Point(91, 19);
            this.rdbUnmarried.Name = "rdbUnmarried";
            this.rdbUnmarried.Size = new System.Drawing.Size(73, 17);
            this.rdbUnmarried.TabIndex = 6;
            this.rdbUnmarried.TabStop = true;
            this.rdbUnmarried.Text = "Unmarried";
            this.rdbUnmarried.UseVisualStyleBackColor = true;
            // 
            // rdbMarried
            // 
            this.rdbMarried.AutoSize = true;
            this.rdbMarried.Location = new System.Drawing.Point(170, 19);
            this.rdbMarried.Name = "rdbMarried";
            this.rdbMarried.Size = new System.Drawing.Size(60, 17);
            this.rdbMarried.TabIndex = 7;
            this.rdbMarried.TabStop = true;
            this.rdbMarried.Text = "Married";
            this.rdbMarried.UseVisualStyleBackColor = true;
            // 
            // rdbWidower
            // 
            this.rdbWidower.AutoSize = true;
            this.rdbWidower.Location = new System.Drawing.Point(232, 19);
            this.rdbWidower.Name = "rdbWidower";
            this.rdbWidower.Size = new System.Drawing.Size(67, 17);
            this.rdbWidower.TabIndex = 8;
            this.rdbWidower.TabStop = true;
            this.rdbWidower.Text = "Widower";
            this.rdbWidower.UseVisualStyleBackColor = true;
            // 
            // rdbWidow
            // 
            this.rdbWidow.AutoSize = true;
            this.rdbWidow.Location = new System.Drawing.Point(131, 42);
            this.rdbWidow.Name = "rdbWidow";
            this.rdbWidow.Size = new System.Drawing.Size(58, 17);
            this.rdbWidow.TabIndex = 9;
            this.rdbWidow.TabStop = true;
            this.rdbWidow.Text = "Widow";
            this.rdbWidow.UseVisualStyleBackColor = true;
            // 
            // rdbDevorced
            // 
            this.rdbDevorced.AutoSize = true;
            this.rdbDevorced.Location = new System.Drawing.Point(195, 42);
            this.rdbDevorced.Name = "rdbDevorced";
            this.rdbDevorced.Size = new System.Drawing.Size(68, 17);
            this.rdbDevorced.TabIndex = 10;
            this.rdbDevorced.TabStop = true;
            this.rdbDevorced.Text = "Divorced";
            this.rdbDevorced.UseVisualStyleBackColor = true;
            // 
            // grpMaritalStatus
            // 
            this.grpMaritalStatus.Controls.Add(this.lblMaritalStatus);
            this.grpMaritalStatus.Controls.Add(this.rdbDevorced);
            this.grpMaritalStatus.Controls.Add(this.rdbUnmarried);
            this.grpMaritalStatus.Controls.Add(this.rdbWidow);
            this.grpMaritalStatus.Controls.Add(this.rdbMarried);
            this.grpMaritalStatus.Controls.Add(this.rdbWidower);
            this.grpMaritalStatus.Location = new System.Drawing.Point(12, 70);
            this.grpMaritalStatus.Name = "grpMaritalStatus";
            this.grpMaritalStatus.Size = new System.Drawing.Size(305, 100);
            this.grpMaritalStatus.TabIndex = 11;
            this.grpMaritalStatus.TabStop = false;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(215, 227);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 12;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // PassportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(329, 262);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.grpMaritalStatus);
            this.Controls.Add(this.txtPlaceOfBirth);
            this.Controls.Add(this.txtPreviousSurname);
            this.Controls.Add(this.lblPlaceOFBirth);
            this.Controls.Add(this.lblPreviousSurname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PassportForm";
            this.Text = "Passport registraion form";
            this.grpMaritalStatus.ResumeLayout(false);
            this.grpMaritalStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPreviousSurname;
        private System.Windows.Forms.Label lblMaritalStatus;
        private System.Windows.Forms.Label lblPlaceOFBirth;
        private System.Windows.Forms.TextBox txtPreviousSurname;
        private System.Windows.Forms.TextBox txtPlaceOfBirth;
        private System.Windows.Forms.RadioButton rdbUnmarried;
        private System.Windows.Forms.RadioButton rdbMarried;
        private System.Windows.Forms.RadioButton rdbWidower;
        private System.Windows.Forms.RadioButton rdbWidow;
        private System.Windows.Forms.RadioButton rdbDevorced;
        private System.Windows.Forms.GroupBox grpMaritalStatus;
        private System.Windows.Forms.Button btnAccept;
    }
}
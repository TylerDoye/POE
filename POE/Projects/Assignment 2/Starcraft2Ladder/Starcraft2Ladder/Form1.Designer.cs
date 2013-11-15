namespace Starcraft2Ladder
{
    partial class frmStarcraftData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStarcraftData));
            this.lblFirstName = new System.Windows.Forms.Label();
            this.rdbSilver = new System.Windows.Forms.RadioButton();
            this.rdbBronze = new System.Windows.Forms.RadioButton();
            this.rdbGold = new System.Windows.Forms.RadioButton();
            this.rdbPlatinum = new System.Windows.Forms.RadioButton();
            this.rdbDiamond = new System.Windows.Forms.RadioButton();
            this.rdbMasters = new System.Windows.Forms.RadioButton();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblAlias = new System.Windows.Forms.Label();
            this.lblWins = new System.Windows.Forms.Label();
            this.lblLosses = new System.Windows.Forms.Label();
            this.lblAvgApm = new System.Windows.Forms.Label();
            this.lblLeagueStanding = new System.Windows.Forms.Label();
            this.grpLadderLeague = new System.Windows.Forms.GroupBox();
            this.cmbReportType = new System.Windows.Forms.ComboBox();
            this.lblReportType = new System.Windows.Forms.Label();
            this.grpPlayerInfo = new System.Windows.Forms.GroupBox();
            this.grpPlayerStats = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtPlayerData = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.MaskedTextBox();
            this.txtSurname = new System.Windows.Forms.MaskedTextBox();
            this.txtAlias = new System.Windows.Forms.MaskedTextBox();
            this.txtWins = new System.Windows.Forms.MaskedTextBox();
            this.txtLosses = new System.Windows.Forms.MaskedTextBox();
            this.txtApmAverage = new System.Windows.Forms.MaskedTextBox();
            this.txtLeagueStanding = new System.Windows.Forms.MaskedTextBox();
            this.grpLadderLeague.SuspendLayout();
            this.grpPlayerInfo.SuspendLayout();
            this.grpPlayerStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstName.Location = new System.Drawing.Point(6, 25);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // rdbSilver
            // 
            this.rdbSilver.AutoSize = true;
            this.rdbSilver.BackColor = System.Drawing.Color.Transparent;
            this.rdbSilver.Location = new System.Drawing.Point(97, 19);
            this.rdbSilver.Name = "rdbSilver";
            this.rdbSilver.Size = new System.Drawing.Size(51, 17);
            this.rdbSilver.TabIndex = 1;
            this.rdbSilver.TabStop = true;
            this.rdbSilver.Text = "Silver";
            this.rdbSilver.UseVisualStyleBackColor = false;
            // 
            // rdbBronze
            // 
            this.rdbBronze.AutoSize = true;
            this.rdbBronze.BackColor = System.Drawing.Color.Transparent;
            this.rdbBronze.Location = new System.Drawing.Point(6, 19);
            this.rdbBronze.Name = "rdbBronze";
            this.rdbBronze.Size = new System.Drawing.Size(58, 17);
            this.rdbBronze.TabIndex = 2;
            this.rdbBronze.TabStop = true;
            this.rdbBronze.Text = "Bronze";
            this.rdbBronze.UseVisualStyleBackColor = false;
            // 
            // rdbGold
            // 
            this.rdbGold.AutoSize = true;
            this.rdbGold.BackColor = System.Drawing.Color.Transparent;
            this.rdbGold.Location = new System.Drawing.Point(188, 19);
            this.rdbGold.Name = "rdbGold";
            this.rdbGold.Size = new System.Drawing.Size(47, 17);
            this.rdbGold.TabIndex = 3;
            this.rdbGold.TabStop = true;
            this.rdbGold.Text = "Gold";
            this.rdbGold.UseVisualStyleBackColor = false;
            // 
            // rdbPlatinum
            // 
            this.rdbPlatinum.AutoSize = true;
            this.rdbPlatinum.BackColor = System.Drawing.Color.Transparent;
            this.rdbPlatinum.Location = new System.Drawing.Point(6, 44);
            this.rdbPlatinum.Name = "rdbPlatinum";
            this.rdbPlatinum.Size = new System.Drawing.Size(65, 17);
            this.rdbPlatinum.TabIndex = 4;
            this.rdbPlatinum.TabStop = true;
            this.rdbPlatinum.Text = "Platinum";
            this.rdbPlatinum.UseVisualStyleBackColor = false;
            // 
            // rdbDiamond
            // 
            this.rdbDiamond.AutoSize = true;
            this.rdbDiamond.BackColor = System.Drawing.Color.Transparent;
            this.rdbDiamond.Location = new System.Drawing.Point(97, 44);
            this.rdbDiamond.Name = "rdbDiamond";
            this.rdbDiamond.Size = new System.Drawing.Size(67, 17);
            this.rdbDiamond.TabIndex = 5;
            this.rdbDiamond.TabStop = true;
            this.rdbDiamond.Text = "Diamond";
            this.rdbDiamond.UseVisualStyleBackColor = false;
            // 
            // rdbMasters
            // 
            this.rdbMasters.AutoSize = true;
            this.rdbMasters.BackColor = System.Drawing.Color.Transparent;
            this.rdbMasters.Location = new System.Drawing.Point(189, 44);
            this.rdbMasters.Name = "rdbMasters";
            this.rdbMasters.Size = new System.Drawing.Size(62, 17);
            this.rdbMasters.TabIndex = 6;
            this.rdbMasters.TabStop = true;
            this.rdbMasters.Text = "Masters";
            this.rdbMasters.UseVisualStyleBackColor = false;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.BackColor = System.Drawing.Color.Transparent;
            this.lblSurname.Location = new System.Drawing.Point(6, 51);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 7;
            this.lblSurname.Text = "Surname";
            // 
            // lblAlias
            // 
            this.lblAlias.AutoSize = true;
            this.lblAlias.BackColor = System.Drawing.Color.Transparent;
            this.lblAlias.Location = new System.Drawing.Point(6, 77);
            this.lblAlias.Name = "lblAlias";
            this.lblAlias.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAlias.Size = new System.Drawing.Size(29, 13);
            this.lblAlias.TabIndex = 8;
            this.lblAlias.Text = "Alias";
            // 
            // lblWins
            // 
            this.lblWins.AutoSize = true;
            this.lblWins.BackColor = System.Drawing.Color.Transparent;
            this.lblWins.Location = new System.Drawing.Point(3, 21);
            this.lblWins.Name = "lblWins";
            this.lblWins.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblWins.Size = new System.Drawing.Size(31, 13);
            this.lblWins.TabIndex = 9;
            this.lblWins.Text = "Wins";
            // 
            // lblLosses
            // 
            this.lblLosses.AutoSize = true;
            this.lblLosses.BackColor = System.Drawing.Color.Transparent;
            this.lblLosses.Location = new System.Drawing.Point(3, 46);
            this.lblLosses.Name = "lblLosses";
            this.lblLosses.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLosses.Size = new System.Drawing.Size(40, 13);
            this.lblLosses.TabIndex = 10;
            this.lblLosses.Text = "Losses";
            // 
            // lblAvgApm
            // 
            this.lblAvgApm.AutoSize = true;
            this.lblAvgApm.BackColor = System.Drawing.Color.Transparent;
            this.lblAvgApm.Location = new System.Drawing.Point(3, 72);
            this.lblAvgApm.Name = "lblAvgApm";
            this.lblAvgApm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAvgApm.Size = new System.Drawing.Size(73, 13);
            this.lblAvgApm.TabIndex = 11;
            this.lblAvgApm.Text = "APM Average";
            // 
            // lblLeagueStanding
            // 
            this.lblLeagueStanding.AutoSize = true;
            this.lblLeagueStanding.BackColor = System.Drawing.Color.Transparent;
            this.lblLeagueStanding.Location = new System.Drawing.Point(3, 98);
            this.lblLeagueStanding.Name = "lblLeagueStanding";
            this.lblLeagueStanding.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLeagueStanding.Size = new System.Drawing.Size(88, 13);
            this.lblLeagueStanding.TabIndex = 12;
            this.lblLeagueStanding.Text = "League Standing";
            // 
            // grpLadderLeague
            // 
            this.grpLadderLeague.BackColor = System.Drawing.Color.Transparent;
            this.grpLadderLeague.Controls.Add(this.rdbPlatinum);
            this.grpLadderLeague.Controls.Add(this.rdbSilver);
            this.grpLadderLeague.Controls.Add(this.rdbBronze);
            this.grpLadderLeague.Controls.Add(this.rdbGold);
            this.grpLadderLeague.Controls.Add(this.rdbDiamond);
            this.grpLadderLeague.Controls.Add(this.rdbMasters);
            this.grpLadderLeague.Location = new System.Drawing.Point(35, 34);
            this.grpLadderLeague.Name = "grpLadderLeague";
            this.grpLadderLeague.Size = new System.Drawing.Size(282, 69);
            this.grpLadderLeague.TabIndex = 20;
            this.grpLadderLeague.TabStop = false;
            this.grpLadderLeague.Text = "Ladder League";
            // 
            // cmbReportType
            // 
            this.cmbReportType.FormattingEnabled = true;
            this.cmbReportType.Items.AddRange(new object[] {
            "more than 100 wins",
            "By Favorouble w/l",
            "If in top 8"});
            this.cmbReportType.Location = new System.Drawing.Point(133, 359);
            this.cmbReportType.Name = "cmbReportType";
            this.cmbReportType.Size = new System.Drawing.Size(137, 21);
            this.cmbReportType.TabIndex = 21;
            // 
            // lblReportType
            // 
            this.lblReportType.AutoSize = true;
            this.lblReportType.BackColor = System.Drawing.Color.Transparent;
            this.lblReportType.Location = new System.Drawing.Point(64, 359);
            this.lblReportType.Name = "lblReportType";
            this.lblReportType.Size = new System.Drawing.Size(62, 13);
            this.lblReportType.TabIndex = 22;
            this.lblReportType.Text = "Report type";
            // 
            // grpPlayerInfo
            // 
            this.grpPlayerInfo.BackColor = System.Drawing.Color.Transparent;
            this.grpPlayerInfo.Controls.Add(this.txtAlias);
            this.grpPlayerInfo.Controls.Add(this.txtSurname);
            this.grpPlayerInfo.Controls.Add(this.txtFirstName);
            this.grpPlayerInfo.Controls.Add(this.lblFirstName);
            this.grpPlayerInfo.Controls.Add(this.lblSurname);
            this.grpPlayerInfo.Controls.Add(this.lblAlias);
            this.grpPlayerInfo.Location = new System.Drawing.Point(35, 109);
            this.grpPlayerInfo.Name = "grpPlayerInfo";
            this.grpPlayerInfo.Size = new System.Drawing.Size(282, 100);
            this.grpPlayerInfo.TabIndex = 23;
            this.grpPlayerInfo.TabStop = false;
            this.grpPlayerInfo.Text = "Player Info";
            // 
            // grpPlayerStats
            // 
            this.grpPlayerStats.BackColor = System.Drawing.Color.Transparent;
            this.grpPlayerStats.Controls.Add(this.txtApmAverage);
            this.grpPlayerStats.Controls.Add(this.txtLeagueStanding);
            this.grpPlayerStats.Controls.Add(this.txtLosses);
            this.grpPlayerStats.Controls.Add(this.txtWins);
            this.grpPlayerStats.Controls.Add(this.lblWins);
            this.grpPlayerStats.Controls.Add(this.lblLosses);
            this.grpPlayerStats.Controls.Add(this.lblAvgApm);
            this.grpPlayerStats.Controls.Add(this.lblLeagueStanding);
            this.grpPlayerStats.Location = new System.Drawing.Point(35, 215);
            this.grpPlayerStats.Name = "grpPlayerStats";
            this.grpPlayerStats.Size = new System.Drawing.Size(282, 125);
            this.grpPlayerStats.TabIndex = 24;
            this.grpPlayerStats.TabStop = false;
            this.grpPlayerStats.Text = "Player Stats";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.Location = new System.Drawing.Point(214, 400);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 24);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Location = new System.Drawing.Point(133, 400);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 24);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Add Player";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Transparent;
            this.btnLoad.Location = new System.Drawing.Point(51, 400);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 24);
            this.btnLoad.TabIndex = 27;
            this.btnLoad.Text = "Load Report";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtPlayerData
            // 
            this.txtPlayerData.Location = new System.Drawing.Point(13, 28);
            this.txtPlayerData.Multiline = true;
            this.txtPlayerData.Name = "txtPlayerData";
            this.txtPlayerData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPlayerData.Size = new System.Drawing.Size(323, 396);
            this.txtPlayerData.TabIndex = 29;
            this.txtPlayerData.Visible = false;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(97, 22);
            this.txtFirstName.Mask = "???????????????";
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(112, 20);
            this.txtFirstName.TabIndex = 16;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(97, 48);
            this.txtSurname.Mask = "???????????????";
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(112, 20);
            this.txtSurname.TabIndex = 17;
            // 
            // txtAlias
            // 
            this.txtAlias.Location = new System.Drawing.Point(97, 74);
            this.txtAlias.Mask = "???????????????";
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Size = new System.Drawing.Size(112, 20);
            this.txtAlias.TabIndex = 18;
            // 
            // txtWins
            // 
            this.txtWins.Location = new System.Drawing.Point(97, 18);
            this.txtWins.Mask = "9999";
            this.txtWins.Name = "txtWins";
            this.txtWins.Size = new System.Drawing.Size(100, 20);
            this.txtWins.TabIndex = 20;
            // 
            // txtLosses
            // 
            this.txtLosses.Location = new System.Drawing.Point(97, 43);
            this.txtLosses.Mask = "9999";
            this.txtLosses.Name = "txtLosses";
            this.txtLosses.Size = new System.Drawing.Size(100, 20);
            this.txtLosses.TabIndex = 21;
            // 
            // txtApmAverage
            // 
            this.txtApmAverage.Location = new System.Drawing.Point(97, 69);
            this.txtApmAverage.Mask = "9999";
            this.txtApmAverage.Name = "txtApmAverage";
            this.txtApmAverage.Size = new System.Drawing.Size(100, 20);
            this.txtApmAverage.TabIndex = 30;
            // 
            // txtLeagueStanding
            // 
            this.txtLeagueStanding.Location = new System.Drawing.Point(97, 95);
            this.txtLeagueStanding.Mask = "9999";
            this.txtLeagueStanding.Name = "txtLeagueStanding";
            this.txtLeagueStanding.Size = new System.Drawing.Size(100, 20);
            this.txtLeagueStanding.TabIndex = 31;
            // 
            // frmStarcraftData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(348, 436);
            this.Controls.Add(this.txtPlayerData);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.grpPlayerStats);
            this.Controls.Add(this.grpPlayerInfo);
            this.Controls.Add(this.lblReportType);
            this.Controls.Add(this.cmbReportType);
            this.Controls.Add(this.grpLadderLeague);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStarcraftData";
            this.Text = "Starcraft II Player Data";
            this.grpLadderLeague.ResumeLayout(false);
            this.grpLadderLeague.PerformLayout();
            this.grpPlayerInfo.ResumeLayout(false);
            this.grpPlayerInfo.PerformLayout();
            this.grpPlayerStats.ResumeLayout(false);
            this.grpPlayerStats.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.RadioButton rdbSilver;
        private System.Windows.Forms.RadioButton rdbBronze;
        private System.Windows.Forms.RadioButton rdbGold;
        private System.Windows.Forms.RadioButton rdbPlatinum;
        private System.Windows.Forms.RadioButton rdbDiamond;
        private System.Windows.Forms.RadioButton rdbMasters;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblAlias;
        private System.Windows.Forms.Label lblWins;
        private System.Windows.Forms.Label lblLosses;
        private System.Windows.Forms.Label lblAvgApm;
        private System.Windows.Forms.Label lblLeagueStanding;
        private System.Windows.Forms.GroupBox grpLadderLeague;
        private System.Windows.Forms.ComboBox cmbReportType;
        private System.Windows.Forms.Label lblReportType;
        private System.Windows.Forms.GroupBox grpPlayerInfo;
        private System.Windows.Forms.GroupBox grpPlayerStats;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtPlayerData;
        private System.Windows.Forms.MaskedTextBox txtFirstName;
        private System.Windows.Forms.MaskedTextBox txtAlias;
        private System.Windows.Forms.MaskedTextBox txtSurname;
        private System.Windows.Forms.MaskedTextBox txtApmAverage;
        private System.Windows.Forms.MaskedTextBox txtLeagueStanding;
        private System.Windows.Forms.MaskedTextBox txtLosses;
        private System.Windows.Forms.MaskedTextBox txtWins;
    }
}


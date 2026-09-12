namespace SteamTradeCardDropper
{
    partial class frmSettings
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
            this.components = new System.ComponentModel.Container();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.pnlDivider = new System.Windows.Forms.Panel();
            this.grpGeneral = new System.Windows.Forms.GroupBox();
            this.chkIdleOnlyPlayed = new System.Windows.Forms.CheckBox();
            this.chkShutdown = new System.Windows.Forms.CheckBox();
            this.chkPreventSleep = new System.Windows.Forms.CheckBox();
            this.chkShowUsername = new System.Windows.Forms.CheckBox();
            this.chkIgnoreClientStatus = new System.Windows.Forms.CheckBox();
            this.chkMinToTray = new System.Windows.Forms.CheckBox();
            this.grpIdlingQuantity = new System.Windows.Forms.GroupBox();
            this.radWhitelistMode = new System.Windows.Forms.RadioButton();
            this.radFastMode = new System.Windows.Forms.RadioButton();
            this.radOneThenMany = new System.Windows.Forms.RadioButton();
            this.radManyThenOne = new System.Windows.Forms.RadioButton();
            this.radOneGameOnly = new System.Windows.Forms.RadioButton();
            this.grpPriority = new System.Windows.Forms.GroupBox();
            this.radIdleLeastDrops = new System.Windows.Forms.RadioButton();
            this.radIdleMostDrops = new System.Windows.Forms.RadioButton();
            this.radIdleDefault = new System.Windows.Forms.RadioButton();
            this.linkLabelAppData = new System.Windows.Forms.LinkLabel();
            this.lnkGitHubWiki = new System.Windows.Forms.LinkLabel();
            this.btnAdvanced = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.ttHints = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.grpGeneral.SuspendLayout();
            this.grpIdlingQuantity.SuspendLayout();
            this.grpPriority.SuspendLayout();
            this.SuspendLayout();
            // 
            // picIcon
            // 
            this.picIcon.Location = new System.Drawing.Point(20, 16);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(36, 36);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picIcon.TabIndex = 0;
            this.picIcon.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(68, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(72, 21);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Settings";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.Location = new System.Drawing.Point(70, 38);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(326, 15);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "Customize idling behavior, queue priority, and automation.";
            // 
            // pnlDivider
            // 
            this.pnlDivider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDivider.Location = new System.Drawing.Point(20, 64);
            this.pnlDivider.Name = "pnlDivider";
            this.pnlDivider.Size = new System.Drawing.Size(500, 1);
            this.pnlDivider.TabIndex = 3;
            // 
            // grpGeneral
            // 
            this.grpGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpGeneral.Controls.Add(this.chkIdleOnlyPlayed);
            this.grpGeneral.Controls.Add(this.chkShutdown);
            this.grpGeneral.Controls.Add(this.chkPreventSleep);
            this.grpGeneral.Controls.Add(this.chkShowUsername);
            this.grpGeneral.Controls.Add(this.chkIgnoreClientStatus);
            this.grpGeneral.Controls.Add(this.chkMinToTray);
            this.grpGeneral.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGeneral.Location = new System.Drawing.Point(20, 74);
            this.grpGeneral.Name = "grpGeneral";
            this.grpGeneral.Size = new System.Drawing.Size(500, 128);
            this.grpGeneral.TabIndex = 4;
            this.grpGeneral.TabStop = false;
            this.grpGeneral.Text = "General Options";
            // 
            // chkIdleOnlyPlayed
            // 
            this.chkIdleOnlyPlayed.AutoSize = true;
            this.chkIdleOnlyPlayed.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIdleOnlyPlayed.Location = new System.Drawing.Point(16, 96);
            this.chkIdleOnlyPlayed.Name = "chkIdleOnlyPlayed";
            this.chkIdleOnlyPlayed.Size = new System.Drawing.Size(148, 19);
            this.chkIdleOnlyPlayed.TabIndex = 5;
            this.chkIdleOnlyPlayed.Text = "Idle only played games";
            this.chkIdleOnlyPlayed.UseVisualStyleBackColor = true;
            // 
            // chkShutdown
            // 
            this.chkShutdown.AutoSize = true;
            this.chkShutdown.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShutdown.Location = new System.Drawing.Point(265, 48);
            this.chkShutdown.Name = "chkShutdown";
            this.chkShutdown.Size = new System.Drawing.Size(193, 19);
            this.chkShutdown.TabIndex = 4;
            this.chkShutdown.Text = "Shutdown Windows when done";
            this.chkShutdown.UseVisualStyleBackColor = true;
            this.chkShutdown.CheckedChanged += new System.EventHandler(this.chkShutdown_CheckedChanged);
            // 
            // chkPreventSleep
            // 
            this.chkPreventSleep.AutoSize = true;
            this.chkPreventSleep.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPreventSleep.Location = new System.Drawing.Point(265, 24);
            this.chkPreventSleep.Name = "chkPreventSleep";
            this.chkPreventSleep.Size = new System.Drawing.Size(178, 19);
            this.chkPreventSleep.TabIndex = 3;
            this.chkPreventSleep.Text = "Prevent Windows from Sleep";
            this.chkPreventSleep.UseVisualStyleBackColor = true;
            // 
            // chkShowUsername
            // 
            this.chkShowUsername.AutoSize = true;
            this.chkShowUsername.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowUsername.Location = new System.Drawing.Point(16, 48);
            this.chkShowUsername.Name = "chkShowUsername";
            this.chkShowUsername.Size = new System.Drawing.Size(248, 19);
            this.chkShowUsername.TabIndex = 2;
            this.chkShowUsername.Text = "Show Steam username of signed on user";
            this.chkShowUsername.UseVisualStyleBackColor = true;
            // 
            // chkIgnoreClientStatus
            // 
            this.chkIgnoreClientStatus.AutoSize = true;
            this.chkIgnoreClientStatus.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIgnoreClientStatus.Location = new System.Drawing.Point(16, 24);
            this.chkIgnoreClientStatus.Name = "chkIgnoreClientStatus";
            this.chkIgnoreClientStatus.Size = new System.Drawing.Size(168, 19);
            this.chkIgnoreClientStatus.TabIndex = 1;
            this.chkIgnoreClientStatus.Text = "Ignore Steam client status";
            this.chkIgnoreClientStatus.UseVisualStyleBackColor = true;
            // 
            // chkMinToTray
            // 
            this.chkMinToTray.AutoSize = true;
            this.chkMinToTray.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMinToTray.Location = new System.Drawing.Point(16, 72);
            this.chkMinToTray.Name = "chkMinToTray";
            this.chkMinToTray.Size = new System.Drawing.Size(155, 19);
            this.chkMinToTray.TabIndex = 0;
            this.chkMinToTray.Text = "Minimize to system tray";
            this.chkMinToTray.UseVisualStyleBackColor = true;
            // 
            // grpIdlingQuantity
            // 
            this.grpIdlingQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpIdlingQuantity.Controls.Add(this.radWhitelistMode);
            this.grpIdlingQuantity.Controls.Add(this.radFastMode);
            this.grpIdlingQuantity.Controls.Add(this.radOneThenMany);
            this.grpIdlingQuantity.Controls.Add(this.radManyThenOne);
            this.grpIdlingQuantity.Controls.Add(this.radOneGameOnly);
            this.grpIdlingQuantity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpIdlingQuantity.Location = new System.Drawing.Point(20, 210);
            this.grpIdlingQuantity.Name = "grpIdlingQuantity";
            this.grpIdlingQuantity.Size = new System.Drawing.Size(500, 142);
            this.grpIdlingQuantity.TabIndex = 5;
            this.grpIdlingQuantity.TabStop = false;
            this.grpIdlingQuantity.Text = "Idling Behavior";
            // 
            // radWhitelistMode
            // 
            this.radWhitelistMode.AutoSize = true;
            this.radWhitelistMode.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radWhitelistMode.Location = new System.Drawing.Point(16, 45);
            this.radWhitelistMode.Name = "radWhitelistMode";
            this.radWhitelistMode.Size = new System.Drawing.Size(205, 19);
            this.radWhitelistMode.TabIndex = 1;
            this.radWhitelistMode.Text = "Whitelist mode (File > Whitelist)";
            this.radWhitelistMode.UseVisualStyleBackColor = true;
            // 
            // radFastMode
            // 
            this.radFastMode.AutoSize = true;
            this.radFastMode.Checked = true;
            this.radFastMode.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFastMode.Location = new System.Drawing.Point(16, 22);
            this.radFastMode.Name = "radFastMode";
            this.radFastMode.Size = new System.Drawing.Size(167, 19);
            this.radFastMode.TabIndex = 0;
            this.radFastMode.TabStop = true;
            this.radFastMode.Text = "Fast mode (Recommended)";
            this.radFastMode.UseVisualStyleBackColor = true;
            // 
            // radOneThenMany
            // 
            this.radOneThenMany.AutoSize = true;
            this.radOneThenMany.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radOneThenMany.Location = new System.Drawing.Point(16, 114);
            this.radOneThenMany.Name = "radOneThenMany";
            this.radOneThenMany.Size = new System.Drawing.Size(381, 19);
            this.radOneThenMany.TabIndex = 4;
            this.radOneThenMany.Text = "Idle games with more than 2 hours individually, then simultaneously";
            this.radOneThenMany.UseVisualStyleBackColor = true;
            // 
            // radManyThenOne
            // 
            this.radManyThenOne.AutoSize = true;
            this.radManyThenOne.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radManyThenOne.Location = new System.Drawing.Point(16, 91);
            this.radManyThenOne.Name = "radManyThenOne";
            this.radManyThenOne.Size = new System.Drawing.Size(350, 19);
            this.radManyThenOne.TabIndex = 3;
            this.radManyThenOne.Text = "Idle games simultaneously up to 2 hours, then individually";
            this.radManyThenOne.UseVisualStyleBackColor = true;
            // 
            // radOneGameOnly
            // 
            this.radOneGameOnly.AutoSize = true;
            this.radOneGameOnly.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radOneGameOnly.Location = new System.Drawing.Point(16, 68);
            this.radOneGameOnly.Name = "radOneGameOnly";
            this.radOneGameOnly.Size = new System.Drawing.Size(217, 19);
            this.radOneGameOnly.TabIndex = 2;
            this.radOneGameOnly.Text = "Idle each game individually (Slow)";
            this.radOneGameOnly.UseVisualStyleBackColor = true;
            // 
            // grpPriority
            // 
            this.grpPriority.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPriority.Controls.Add(this.radIdleLeastDrops);
            this.grpPriority.Controls.Add(this.radIdleMostDrops);
            this.grpPriority.Controls.Add(this.radIdleDefault);
            this.grpPriority.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPriority.Location = new System.Drawing.Point(20, 360);
            this.grpPriority.Name = "grpPriority";
            this.grpPriority.Size = new System.Drawing.Size(500, 96);
            this.grpPriority.TabIndex = 6;
            this.grpPriority.TabStop = false;
            this.grpPriority.Text = "Idling Order";
            // 
            // radIdleLeastDrops
            // 
            this.radIdleLeastDrops.AutoSize = true;
            this.radIdleLeastDrops.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radIdleLeastDrops.Location = new System.Drawing.Point(16, 68);
            this.radIdleLeastDrops.Name = "radIdleLeastDrops";
            this.radIdleLeastDrops.Size = new System.Drawing.Size(342, 19);
            this.radIdleLeastDrops.TabIndex = 2;
            this.radIdleLeastDrops.Text = "Prioritize games with the lowest number of available drops";
            this.radIdleLeastDrops.UseVisualStyleBackColor = true;
            // 
            // radIdleMostDrops
            // 
            this.radIdleMostDrops.AutoSize = true;
            this.radIdleMostDrops.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radIdleMostDrops.Location = new System.Drawing.Point(16, 45);
            this.radIdleMostDrops.Name = "radIdleMostDrops";
            this.radIdleMostDrops.Size = new System.Drawing.Size(346, 19);
            this.radIdleMostDrops.TabIndex = 1;
            this.radIdleMostDrops.Text = "Prioritize games with the highest number of available drops";
            this.radIdleMostDrops.UseVisualStyleBackColor = true;
            // 
            // radIdleDefault
            // 
            this.radIdleDefault.AutoSize = true;
            this.radIdleDefault.Checked = true;
            this.radIdleDefault.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radIdleDefault.Location = new System.Drawing.Point(16, 22);
            this.radIdleDefault.Name = "radIdleDefault";
            this.radIdleDefault.Size = new System.Drawing.Size(175, 19);
            this.radIdleDefault.TabIndex = 0;
            this.radIdleDefault.TabStop = true;
            this.radIdleDefault.Text = "Default (Alphabetical Order)";
            this.radIdleDefault.UseVisualStyleBackColor = true;
            // 
            // linkLabelAppData
            // 
            this.linkLabelAppData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabelAppData.AutoSize = true;
            this.linkLabelAppData.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelAppData.Location = new System.Drawing.Point(20, 474);
            this.linkLabelAppData.Name = "linkLabelAppData";
            this.linkLabelAppData.Size = new System.Drawing.Size(127, 15);
            this.linkLabelAppData.TabIndex = 7;
            this.linkLabelAppData.TabStop = true;
            this.linkLabelAppData.Text = "Browse AppData Folder";
            this.linkLabelAppData.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSettings_LinkClicked);
            // 
            // lnkGitHubWiki
            // 
            this.lnkGitHubWiki.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lnkGitHubWiki.AutoSize = true;
            this.lnkGitHubWiki.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkGitHubWiki.Location = new System.Drawing.Point(20, 496);
            this.lnkGitHubWiki.Name = "lnkGitHubWiki";
            this.lnkGitHubWiki.Size = new System.Drawing.Size(117, 15);
            this.lnkGitHubWiki.TabIndex = 8;
            this.lnkGitHubWiki.TabStop = true;
            this.lnkGitHubWiki.Text = "Online Setup Guide";
            this.lnkGitHubWiki.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGitHubWiki_LinkClicked);
            // 
            // btnAdvanced
            // 
            this.btnAdvanced.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdvanced.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdvanced.Location = new System.Drawing.Point(220, 478);
            this.btnAdvanced.Name = "btnAdvanced";
            this.btnAdvanced.Size = new System.Drawing.Size(140, 34);
            this.btnAdvanced.TabIndex = 9;
            this.btnAdvanced.Text = "  Authentication";
            this.ttHints.SetToolTip(this.btnAdvanced, "Display Steam session authentication cookie settings");
            this.btnAdvanced.UseVisualStyleBackColor = true;
            this.btnAdvanced.Click += new System.EventHandler(this.btnAdvanced_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(370, 478);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 34);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(450, 478);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(70, 34);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "&Save";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmSettings
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(540, 526);
            this.Controls.Add(this.btnAdvanced);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lnkGitHubWiki);
            this.Controls.Add(this.linkLabelAppData);
            this.Controls.Add(this.grpPriority);
            this.Controls.Add(this.grpIdlingQuantity);
            this.Controls.Add(this.grpGeneral);
            this.Controls.Add(this.pnlDivider);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picIcon);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings — Steam Trade Card Dropper";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.grpGeneral.ResumeLayout(false);
            this.grpGeneral.PerformLayout();
            this.grpIdlingQuantity.ResumeLayout(false);
            this.grpIdlingQuantity.PerformLayout();
            this.grpPriority.ResumeLayout(false);
            this.grpPriority.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlDivider;
        private System.Windows.Forms.GroupBox grpGeneral;
        private System.Windows.Forms.CheckBox chkMinToTray;
        private System.Windows.Forms.CheckBox chkIgnoreClientStatus;
        private System.Windows.Forms.CheckBox chkShowUsername;
        private System.Windows.Forms.CheckBox chkPreventSleep;
        private System.Windows.Forms.CheckBox chkShutdown;
        private System.Windows.Forms.CheckBox chkIdleOnlyPlayed;
        private System.Windows.Forms.GroupBox grpIdlingQuantity;
        private System.Windows.Forms.RadioButton radFastMode;
        private System.Windows.Forms.RadioButton radWhitelistMode;
        private System.Windows.Forms.RadioButton radOneGameOnly;
        private System.Windows.Forms.RadioButton radManyThenOne;
        private System.Windows.Forms.RadioButton radOneThenMany;
        private System.Windows.Forms.GroupBox grpPriority;
        private System.Windows.Forms.RadioButton radIdleDefault;
        private System.Windows.Forms.RadioButton radIdleMostDrops;
        private System.Windows.Forms.RadioButton radIdleLeastDrops;
        private System.Windows.Forms.LinkLabel linkLabelAppData;
        private System.Windows.Forms.LinkLabel lnkGitHubWiki;
        private System.Windows.Forms.Button btnAdvanced;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ToolTip ttHints;
    }
}
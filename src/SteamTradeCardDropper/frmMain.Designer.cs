using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SteamTradeCardDropper
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblCookieStatus = new System.Windows.Forms.Label();
            this.tmrCheckCookieData = new System.Windows.Forms.Timer(this.components);
            this.lblSteamStatus = new System.Windows.Forms.Label();
            this.tmrCheckSteam = new System.Windows.Forms.Timer(this.components);
            this.lnkResetCookies = new System.Windows.Forms.LinkLabel();
            this.lnkSignIn = new System.Windows.Forms.LinkLabel();
            this.lblDrops = new System.Windows.Forms.Label();
            this.lblIdle = new System.Windows.Forms.Label();
            this.lblCurrentStatus = new System.Windows.Forms.LinkLabel();
            this.lblCurrentRemaining = new System.Windows.Forms.Label();
            this.lblGameName = new System.Windows.Forms.LinkLabel();
            this.mnuTop = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blacklistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whitelistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseIdlingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumeIdlingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skipGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.blacklistCurrentGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wikiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changelogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrReadyToGo = new System.Windows.Forms.Timer(this.components);
            this.tmrCardDropCheck = new System.Windows.Forms.Timer(this.components);
            this.ssFooter = new System.Windows.Forms.StatusStrip();
            this.pbIdle = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTimer = new System.Windows.Forms.ToolStripStatusLabel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.picReadingPage = new System.Windows.Forms.PictureBox();
            this.btnSkip = new System.Windows.Forms.Button();
            this.picIdleStatus = new System.Windows.Forms.PictureBox();
            this.picCookieStatus = new System.Windows.Forms.PictureBox();
            this.picSteamStatus = new System.Windows.Forms.PictureBox();
            this.picApp = new System.Windows.Forms.PictureBox();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.tmrStartNext = new System.Windows.Forms.Timer(this.components);
            this.tmrBadgeReload = new System.Windows.Forms.Timer(this.components);
            this.lblSignedOnAs = new System.Windows.Forms.Label();
            this.GamesState = new System.Windows.Forms.ListView();
            this.GameName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hours = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblHoursPlayed = new System.Windows.Forms.Label();
            this.tmrStatistics = new System.Windows.Forms.Timer(this.components);
            this.lnkLatestRelease = new System.Windows.Forms.LinkLabel();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.picSidebarLogo = new System.Windows.Forms.PictureBox();
            this.lblSidebarBrand = new System.Windows.Forms.Label();
            this.lblSidebarVersion = new System.Windows.Forms.Label();
            this.pnlNavDivider = new System.Windows.Forms.Panel();
            this.btnNavDashboard = new System.Windows.Forms.Button();
            this.btnNavSettings = new System.Windows.Forms.Button();
            this.btnNavWhitelist = new System.Windows.Forms.Button();
            this.btnNavBlacklist = new System.Windows.Forms.Button();
            this.btnNavStatistics = new System.Windows.Forms.Button();
            this.btnNavEula = new System.Windows.Forms.Button();
            this.btnNavAbout = new System.Windows.Forms.Button();
            this.btnNavExit = new System.Windows.Forms.Button();
            this.pnlStatusCard = new System.Windows.Forms.Panel();
            this.pnlSessionCard = new System.Windows.Forms.Panel();
            this.pnlEmptyState = new System.Windows.Forms.Panel();
            this.picEmptyIcon = new System.Windows.Forms.PictureBox();
            this.lblEmptyTitle = new System.Windows.Forms.Label();
            this.lblEmptySubtitle = new System.Windows.Forms.Label();
            this.mnuTop.SuspendLayout();
            this.ssFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReadingPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIdleStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCookieStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSteamStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picApp)).BeginInit();
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSidebarLogo)).BeginInit();
            this.pnlStatusCard.SuspendLayout();
            this.pnlSessionCard.SuspendLayout();
            this.pnlEmptyState.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEmptyIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnlSidebar.Controls.Add(this.picSidebarLogo);
            this.pnlSidebar.Controls.Add(this.lblSidebarBrand);
            this.pnlSidebar.Controls.Add(this.lblSidebarVersion);
            this.pnlSidebar.Controls.Add(this.pnlNavDivider);
            this.pnlSidebar.Controls.Add(this.btnNavDashboard);
            this.pnlSidebar.Controls.Add(this.btnNavSettings);
            this.pnlSidebar.Controls.Add(this.btnNavWhitelist);
            this.pnlSidebar.Controls.Add(this.btnNavBlacklist);
            this.pnlSidebar.Controls.Add(this.btnNavStatistics);
            this.pnlSidebar.Controls.Add(this.btnNavEula);
            this.pnlSidebar.Controls.Add(this.btnNavAbout);
            this.pnlSidebar.Controls.Add(this.btnNavExit);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(160, 385);
            this.pnlSidebar.TabIndex = 31;
            // 
            // picSidebarLogo
            // 
            this.picSidebarLogo.Location = new System.Drawing.Point(14, 12);
            this.picSidebarLogo.Name = "picSidebarLogo";
            this.picSidebarLogo.Size = new System.Drawing.Size(32, 32);
            this.picSidebarLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSidebarLogo.TabIndex = 0;
            this.picSidebarLogo.TabStop = false;
            this.picSidebarLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.picSidebarLogo_Paint);
            // 
            // lblSidebarBrand
            // 
            this.lblSidebarBrand.AutoSize = true;
            this.lblSidebarBrand.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSidebarBrand.Location = new System.Drawing.Point(50, 10);
            this.lblSidebarBrand.Name = "lblSidebarBrand";
            this.lblSidebarBrand.Size = new System.Drawing.Size(100, 19);
            this.lblSidebarBrand.TabIndex = 1;
            this.lblSidebarBrand.Text = "Card Dropper";
            // 
            // lblSidebarVersion
            // 
            this.lblSidebarVersion.AutoSize = true;
            this.lblSidebarVersion.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSidebarVersion.ForeColor = System.Drawing.Color.DimGray;
            this.lblSidebarVersion.Location = new System.Drawing.Point(52, 28);
            this.lblSidebarVersion.Name = "lblSidebarVersion";
            this.lblSidebarVersion.Size = new System.Drawing.Size(37, 12);
            this.lblSidebarVersion.TabIndex = 2;
            this.lblSidebarVersion.Text = "v2.0.0";
            // 
            // pnlNavDivider
            // 
            this.pnlNavDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.pnlNavDivider.Location = new System.Drawing.Point(12, 50);
            this.pnlNavDivider.Name = "pnlNavDivider";
            this.pnlNavDivider.Size = new System.Drawing.Size(136, 1);
            this.pnlNavDivider.TabIndex = 3;
            // 
            // btnNavDashboard
            // 
            this.btnNavDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavDashboard.FlatAppearance.BorderSize = 0;
            this.btnNavDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavDashboard.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavDashboard.Location = new System.Drawing.Point(7, 58);
            this.btnNavDashboard.Name = "btnNavDashboard";
            this.btnNavDashboard.Size = new System.Drawing.Size(146, 28);
            this.btnNavDashboard.TabIndex = 4;
            this.btnNavDashboard.Text = "  Dashboard";
            this.btnNavDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNavDashboard.UseVisualStyleBackColor = true;
            this.btnNavDashboard.Click += new System.EventHandler(this.btnNavDashboard_Click);
            // 
            // btnNavSettings
            // 
            this.btnNavSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavSettings.FlatAppearance.BorderSize = 0;
            this.btnNavSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavSettings.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavSettings.Location = new System.Drawing.Point(7, 88);
            this.btnNavSettings.Name = "btnNavSettings";
            this.btnNavSettings.Size = new System.Drawing.Size(146, 28);
            this.btnNavSettings.TabIndex = 5;
            this.btnNavSettings.Text = "  Settings";
            this.btnNavSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNavSettings.UseVisualStyleBackColor = true;
            this.btnNavSettings.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // btnNavWhitelist
            // 
            this.btnNavWhitelist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavWhitelist.FlatAppearance.BorderSize = 0;
            this.btnNavWhitelist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavWhitelist.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavWhitelist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavWhitelist.Location = new System.Drawing.Point(7, 118);
            this.btnNavWhitelist.Name = "btnNavWhitelist";
            this.btnNavWhitelist.Size = new System.Drawing.Size(146, 28);
            this.btnNavWhitelist.TabIndex = 6;
            this.btnNavWhitelist.Text = "  Whitelist";
            this.btnNavWhitelist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavWhitelist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNavWhitelist.UseVisualStyleBackColor = true;
            this.btnNavWhitelist.Click += new System.EventHandler(this.whitelistToolStripMenuItem_Click);
            // 
            // btnNavBlacklist
            // 
            this.btnNavBlacklist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavBlacklist.FlatAppearance.BorderSize = 0;
            this.btnNavBlacklist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavBlacklist.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavBlacklist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavBlacklist.Location = new System.Drawing.Point(7, 148);
            this.btnNavBlacklist.Name = "btnNavBlacklist";
            this.btnNavBlacklist.Size = new System.Drawing.Size(146, 28);
            this.btnNavBlacklist.TabIndex = 7;
            this.btnNavBlacklist.Text = "  Blacklist";
            this.btnNavBlacklist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavBlacklist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNavBlacklist.UseVisualStyleBackColor = true;
            this.btnNavBlacklist.Click += new System.EventHandler(this.blacklistToolStripMenuItem_Click);
            // 
            // btnNavStatistics
            // 
            this.btnNavStatistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavStatistics.FlatAppearance.BorderSize = 0;
            this.btnNavStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavStatistics.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavStatistics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavStatistics.Location = new System.Drawing.Point(7, 178);
            this.btnNavStatistics.Name = "btnNavStatistics";
            this.btnNavStatistics.Size = new System.Drawing.Size(146, 28);
            this.btnNavStatistics.TabIndex = 8;
            this.btnNavStatistics.Text = "  Statistics";
            this.btnNavStatistics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavStatistics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNavStatistics.UseVisualStyleBackColor = true;
            this.btnNavStatistics.Click += new System.EventHandler(this.statisticsToolStripMenuItem_Click);
            // 
            // btnNavEula
            // 
            this.btnNavEula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavEula.FlatAppearance.BorderSize = 0;
            this.btnNavEula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavEula.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavEula.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavEula.Location = new System.Drawing.Point(7, 208);
            this.btnNavEula.Name = "btnNavEula";
            this.btnNavEula.Size = new System.Drawing.Size(146, 28);
            this.btnNavEula.TabIndex = 9;
            this.btnNavEula.Text = "  Terms / EULA";
            this.btnNavEula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavEula.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNavEula.UseVisualStyleBackColor = true;
            this.btnNavEula.Click += new System.EventHandler(this.btnNavEula_Click);
            // 
            // btnNavAbout
            // 
            this.btnNavAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavAbout.FlatAppearance.BorderSize = 0;
            this.btnNavAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavAbout.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavAbout.Location = new System.Drawing.Point(7, 238);
            this.btnNavAbout.Name = "btnNavAbout";
            this.btnNavAbout.Size = new System.Drawing.Size(146, 28);
            this.btnNavAbout.TabIndex = 10;
            this.btnNavAbout.Text = "  About";
            this.btnNavAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNavAbout.UseVisualStyleBackColor = true;
            this.btnNavAbout.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // btnNavExit
            // 
            this.btnNavExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavExit.FlatAppearance.BorderSize = 0;
            this.btnNavExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavExit.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavExit.Location = new System.Drawing.Point(7, 276);
            this.btnNavExit.Name = "btnNavExit";
            this.btnNavExit.Size = new System.Drawing.Size(146, 28);
            this.btnNavExit.TabIndex = 11;
            this.btnNavExit.Text = "  Exit";
            this.btnNavExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNavExit.UseVisualStyleBackColor = true;
            this.btnNavExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tmrCheckCookieData
            // 
            this.tmrCheckCookieData.Enabled = true;
            this.tmrCheckCookieData.Tick += new System.EventHandler(this.tmrCheckCookieData_Tick);
            // 
            // tmrCheckSteam
            // 
            this.tmrCheckSteam.Enabled = true;
            this.tmrCheckSteam.Interval = 500;
            this.tmrCheckSteam.Tick += new System.EventHandler(this.tmrCheckSteam_Tick);
            // 
            // mnuTop
            // 
            this.mnuTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.gameToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mnuTop.Location = new System.Drawing.Point(0, 0);
            this.mnuTop.Name = "mnuTop";
            this.mnuTop.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mnuTop.Size = new System.Drawing.Size(450, 24);
            this.mnuTop.TabIndex = 19;
            this.mnuTop.Text = "menuStrip1";
            this.mnuTop.Visible = false;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.blacklistToolStripMenuItem,
            this.whitelistToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Image = global::SteamTradeCardDropper.Properties.Resources.imgSettings;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.settingsToolStripMenuItem.Text = "&Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // blacklistToolStripMenuItem
            // 
            this.blacklistToolStripMenuItem.Image = global::SteamTradeCardDropper.Properties.Resources.imgBlacklist;
            this.blacklistToolStripMenuItem.Name = "blacklistToolStripMenuItem";
            this.blacklistToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.blacklistToolStripMenuItem.Text = "&Blacklist";
            this.blacklistToolStripMenuItem.Click += new System.EventHandler(this.blacklistToolStripMenuItem_Click);
            // 
            // whitelistToolStripMenuItem
            // 
            this.whitelistToolStripMenuItem.Image = global::SteamTradeCardDropper.Properties.Resources.imgTrue;
            this.whitelistToolStripMenuItem.Name = "whitelistToolStripMenuItem";
            this.whitelistToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.whitelistToolStripMenuItem.Text = "Whitelist";
            this.whitelistToolStripMenuItem.Click += new System.EventHandler(this.whitelistToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(117, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::SteamTradeCardDropper.Properties.Resources.imgExit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pauseIdlingToolStripMenuItem,
            this.resumeIdlingToolStripMenuItem,
            this.skipGameToolStripMenuItem,
            this.toolStripMenuItem2,
            this.blacklistCurrentGameToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "&Game";
            // 
            // pauseIdlingToolStripMenuItem
            // 
            this.pauseIdlingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pauseIdlingToolStripMenuItem.Image")));
            this.pauseIdlingToolStripMenuItem.Name = "pauseIdlingToolStripMenuItem";
            this.pauseIdlingToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.pauseIdlingToolStripMenuItem.Text = "&Pause Idling";
            this.pauseIdlingToolStripMenuItem.Click += new System.EventHandler(this.pauseIdlingToolStripMenuItem_Click);
            // 
            // resumeIdlingToolStripMenuItem
            // 
            this.resumeIdlingToolStripMenuItem.Enabled = false;
            this.resumeIdlingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("resumeIdlingToolStripMenuItem.Image")));
            this.resumeIdlingToolStripMenuItem.Name = "resumeIdlingToolStripMenuItem";
            this.resumeIdlingToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.resumeIdlingToolStripMenuItem.Text = "Resume Idling";
            this.resumeIdlingToolStripMenuItem.Click += new System.EventHandler(this.resumeIdlingToolStripMenuItem_Click);
            // 
            // skipGameToolStripMenuItem
            // 
            this.skipGameToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("skipGameToolStripMenuItem.Image")));
            this.skipGameToolStripMenuItem.Name = "skipGameToolStripMenuItem";
            this.skipGameToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.skipGameToolStripMenuItem.Text = "&Skip Current Game";
            this.skipGameToolStripMenuItem.Click += new System.EventHandler(this.skipGameToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(191, 6);
            // 
            // blacklistCurrentGameToolStripMenuItem
            // 
            this.blacklistCurrentGameToolStripMenuItem.Image = global::SteamTradeCardDropper.Properties.Resources.imgBlacklist;
            this.blacklistCurrentGameToolStripMenuItem.Name = "blacklistCurrentGameToolStripMenuItem";
            this.blacklistCurrentGameToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.blacklistCurrentGameToolStripMenuItem.Text = "&Blacklist Current Game";
            this.blacklistCurrentGameToolStripMenuItem.Click += new System.EventHandler(this.blacklistCurrentGameToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wikiToolStripMenuItem,
            this.changelogToolStripMenuItem,
            this.statisticsToolStripMenuItem,
            this.toolStripMenuItem3,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // wikiToolStripMenuItem
            // 
            this.wikiToolStripMenuItem.Image = global::SteamTradeCardDropper.Properties.Resources.imgInfo;
            this.wikiToolStripMenuItem.Name = "wikiToolStripMenuItem";
            this.wikiToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.wikiToolStripMenuItem.Text = "&Wiki Page";
            this.wikiToolStripMenuItem.Click += new System.EventHandler(this.wikiToolStripMenuItem_Click);
            // 
            // changelogToolStripMenuItem
            // 
            this.changelogToolStripMenuItem.Image = global::SteamTradeCardDropper.Properties.Resources.imgDocument;
            this.changelogToolStripMenuItem.Name = "changelogToolStripMenuItem";
            this.changelogToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.changelogToolStripMenuItem.Text = "&Release Notes";
            this.changelogToolStripMenuItem.Click += new System.EventHandler(this.changelogToolStripMenuItem_Click);
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.Image = global::SteamTradeCardDropper.Properties.Resources.imgStatistics;
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.statisticsToolStripMenuItem.Text = "&Statistics";
            this.statisticsToolStripMenuItem.Click += new System.EventHandler(this.statisticsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(145, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tmrReadyToGo
            // 
            this.tmrReadyToGo.Enabled = true;
            this.tmrReadyToGo.Tick += new System.EventHandler(this.tmrReadyToGo_Tick);
            // 
            // tmrCardDropCheck
            // 
            this.tmrCardDropCheck.Interval = 1000;
            this.tmrCardDropCheck.Tick += new System.EventHandler(this.tmrCardDropCheck_Tick);
            // 
            // ssFooter
            // 
            this.ssFooter.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssFooter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pbIdle,
            this.toolStripStatusLabel1,
            this.lblTimer});
            this.ssFooter.Location = new System.Drawing.Point(148, 313);
            this.ssFooter.Name = "ssFooter";
            this.ssFooter.ShowItemToolTips = true;
            this.ssFooter.Size = new System.Drawing.Size(302, 22);
            this.ssFooter.SizingGrip = false;
            this.ssFooter.TabIndex = 20;
            this.ssFooter.Text = "statusStrip1";
            this.ssFooter.Visible = false;
            // 
            // pbIdle
            // 
            this.pbIdle.Maximum = 1;
            this.pbIdle.Name = "pbIdle";
            this.pbIdle.Size = new System.Drawing.Size(120, 16);
            this.pbIdle.Step = 1;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(100, 17);
            this.toolStripStatusLabel1.Text = "Next check";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTimer
            // 
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(34, 17);
            this.lblTimer.Text = "15:00";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = global::SteamTradeCardDropper.Properties.Resources.appIcon;
            this.notifyIcon1.Text = "Steam Trade Card Dropper";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // pnlStatusCard
            // 
            this.pnlStatusCard.BackColor = System.Drawing.Color.White;
            this.pnlStatusCard.Controls.Add(this.lnkLatestRelease);
            this.pnlStatusCard.Controls.Add(this.picSteamStatus);
            this.pnlStatusCard.Controls.Add(this.lblSteamStatus);
            this.pnlStatusCard.Controls.Add(this.lnkSignIn);
            this.pnlStatusCard.Controls.Add(this.lnkResetCookies);
            this.pnlStatusCard.Controls.Add(this.picCookieStatus);
            this.pnlStatusCard.Controls.Add(this.lblCookieStatus);
            this.pnlStatusCard.Controls.Add(this.lblSignedOnAs);
            this.pnlStatusCard.Location = new System.Drawing.Point(176, 14);
            this.pnlStatusCard.Name = "pnlStatusCard";
            this.pnlStatusCard.Size = new System.Drawing.Size(388, 76);
            this.pnlStatusCard.TabIndex = 32;
            this.pnlStatusCard.Paint += new System.Windows.Forms.PaintEventHandler(this.Card_Paint);
            // 
            // picSteamStatus
            // 
            this.picSteamStatus.Location = new System.Drawing.Point(14, 14);
            this.picSteamStatus.Name = "picSteamStatus";
            this.picSteamStatus.Size = new System.Drawing.Size(16, 16);
            this.picSteamStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSteamStatus.TabIndex = 7;
            this.picSteamStatus.TabStop = false;
            // 
            // lblSteamStatus
            // 
            this.lblSteamStatus.AutoSize = true;
            this.lblSteamStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSteamStatus.Location = new System.Drawing.Point(36, 14);
            this.lblSteamStatus.Name = "lblSteamStatus";
            this.lblSteamStatus.Size = new System.Drawing.Size(117, 15);
            this.lblSteamStatus.TabIndex = 3;
            this.lblSteamStatus.Text = "Steam is not running";
            // 
            // lnkLatestRelease
            // 
            this.lnkLatestRelease.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkLatestRelease.AutoSize = true;
            this.lnkLatestRelease.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkLatestRelease.Location = new System.Drawing.Point(292, 14);
            this.lnkLatestRelease.Name = "lnkLatestRelease";
            this.lnkLatestRelease.Size = new System.Drawing.Size(84, 13);
            this.lnkLatestRelease.TabIndex = 30;
            this.lnkLatestRelease.TabStop = true;
            this.lnkLatestRelease.Text = "(Latest release)";
            this.lnkLatestRelease.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLatestRelease_LinkClicked);
            // 
            // picCookieStatus
            // 
            this.picCookieStatus.Location = new System.Drawing.Point(14, 44);
            this.picCookieStatus.Name = "picCookieStatus";
            this.picCookieStatus.Size = new System.Drawing.Size(16, 16);
            this.picCookieStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCookieStatus.TabIndex = 8;
            this.picCookieStatus.TabStop = false;
            // 
            // lblCookieStatus
            // 
            this.lblCookieStatus.AutoSize = true;
            this.lblCookieStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCookieStatus.Location = new System.Drawing.Point(36, 44);
            this.lblCookieStatus.Name = "lblCookieStatus";
            this.lblCookieStatus.Size = new System.Drawing.Size(262, 15);
            this.lblCookieStatus.TabIndex = 0;
            this.lblCookieStatus.Text = "Steam Trade Card Dropper is not connected to Steam";
            // 
            // lblSignedOnAs
            // 
            this.lblSignedOnAs.AutoSize = true;
            this.lblSignedOnAs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignedOnAs.Location = new System.Drawing.Point(36, 44);
            this.lblSignedOnAs.Name = "lblSignedOnAs";
            this.lblSignedOnAs.Size = new System.Drawing.Size(71, 15);
            this.lblSignedOnAs.TabIndex = 27;
            this.lblSignedOnAs.Text = "Signed in as";
            this.lblSignedOnAs.Visible = false;
            // 
            // lnkSignIn
            // 
            this.lnkSignIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkSignIn.AutoSize = true;
            this.lnkSignIn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkSignIn.Location = new System.Drawing.Point(330, 44);
            this.lnkSignIn.Name = "lnkSignIn";
            this.lnkSignIn.Size = new System.Drawing.Size(46, 13);
            this.lnkSignIn.TabIndex = 5;
            this.lnkSignIn.TabStop = true;
            this.lnkSignIn.Text = "(Sign in)";
            this.lnkSignIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSignIn_LinkClicked);
            // 
            // lnkResetCookies
            // 
            this.lnkResetCookies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkResetCookies.AutoSize = true;
            this.lnkResetCookies.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkResetCookies.Location = new System.Drawing.Point(322, 44);
            this.lnkResetCookies.Name = "lnkResetCookies";
            this.lnkResetCookies.Size = new System.Drawing.Size(54, 13);
            this.lnkResetCookies.TabIndex = 4;
            this.lnkResetCookies.TabStop = true;
            this.lnkResetCookies.Text = "(Sign out)";
            this.lnkResetCookies.Visible = false;
            this.lnkResetCookies.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkResetCookies_LinkClicked);
            // 
            // pnlSessionCard
            // 
            this.pnlSessionCard.BackColor = System.Drawing.Color.White;
            this.pnlSessionCard.Controls.Add(this.pnlEmptyState);
            this.pnlSessionCard.Controls.Add(this.lblCurrentStatus);
            this.pnlSessionCard.Controls.Add(this.btnPause);
            this.pnlSessionCard.Controls.Add(this.btnResume);
            this.pnlSessionCard.Controls.Add(this.btnSkip);
            this.pnlSessionCard.Controls.Add(this.lblGameName);
            this.pnlSessionCard.Controls.Add(this.picApp);
            this.pnlSessionCard.Controls.Add(this.GamesState);
            this.pnlSessionCard.Controls.Add(this.lblHoursPlayed);
            this.pnlSessionCard.Controls.Add(this.lblCurrentRemaining);
            this.pnlSessionCard.Location = new System.Drawing.Point(176, 100);
            this.pnlSessionCard.Name = "pnlSessionCard";
            this.pnlSessionCard.Size = new System.Drawing.Size(388, 258);
            this.pnlSessionCard.TabIndex = 33;
            this.pnlSessionCard.Paint += new System.Windows.Forms.PaintEventHandler(this.Card_Paint);
            // 
            // pnlEmptyState
            // 
            this.pnlEmptyState.BackColor = System.Drawing.Color.White;
            this.pnlEmptyState.Controls.Add(this.picEmptyIcon);
            this.pnlEmptyState.Controls.Add(this.lblEmptyTitle);
            this.pnlEmptyState.Controls.Add(this.lblEmptySubtitle);
            this.pnlEmptyState.Controls.Add(this.picReadingPage);
            this.pnlEmptyState.Controls.Add(this.lblDrops);
            this.pnlEmptyState.Controls.Add(this.lblIdle);
            this.pnlEmptyState.Location = new System.Drawing.Point(1, 1);
            this.pnlEmptyState.Name = "pnlEmptyState";
            this.pnlEmptyState.Size = new System.Drawing.Size(386, 256);
            this.pnlEmptyState.TabIndex = 34;
            // 
            // picEmptyIcon
            // 
            this.picEmptyIcon.Location = new System.Drawing.Point(170, 20);
            this.picEmptyIcon.Name = "picEmptyIcon";
            this.picEmptyIcon.Size = new System.Drawing.Size(46, 46);
            this.picEmptyIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEmptyIcon.TabIndex = 0;
            this.picEmptyIcon.TabStop = false;
            this.picEmptyIcon.Paint += new System.Windows.Forms.PaintEventHandler(this.picEmptyIcon_Paint);
            // 
            // lblEmptyTitle
            // 
            this.lblEmptyTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmptyTitle.Location = new System.Drawing.Point(14, 74);
            this.lblEmptyTitle.Name = "lblEmptyTitle";
            this.lblEmptyTitle.Size = new System.Drawing.Size(358, 44);
            this.lblEmptyTitle.TabIndex = 1;
            this.lblEmptyTitle.Text = "Steam Trade Card Dropper";
            this.lblEmptyTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmptySubtitle
            // 
            this.lblEmptySubtitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmptySubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblEmptySubtitle.Location = new System.Drawing.Point(14, 120);
            this.lblEmptySubtitle.Name = "lblEmptySubtitle";
            this.lblEmptySubtitle.Size = new System.Drawing.Size(358, 36);
            this.lblEmptySubtitle.TabIndex = 2;
            this.lblEmptySubtitle.Text = "Please launch Steam or sign in to start gathering card drops.";
            this.lblEmptySubtitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picReadingPage
            // 
            this.picReadingPage.Image = global::SteamTradeCardDropper.Properties.Resources.imgSpin;
            this.picReadingPage.Location = new System.Drawing.Point(185, 156);
            this.picReadingPage.Name = "picReadingPage";
            this.picReadingPage.Size = new System.Drawing.Size(16, 16);
            this.picReadingPage.TabIndex = 26;
            this.picReadingPage.TabStop = false;
            this.picReadingPage.Visible = false;
            // 
            // lblDrops
            // 
            this.lblDrops.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrops.Location = new System.Drawing.Point(14, 180);
            this.lblDrops.Name = "lblDrops";
            this.lblDrops.Size = new System.Drawing.Size(358, 20);
            this.lblDrops.TabIndex = 9;
            this.lblDrops.Text = "card drops remaining";
            this.lblDrops.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDrops.Visible = false;
            // 
            // lblIdle
            // 
            this.lblIdle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdle.Location = new System.Drawing.Point(14, 204);
            this.lblIdle.Name = "lblIdle";
            this.lblIdle.Size = new System.Drawing.Size(358, 20);
            this.lblIdle.TabIndex = 10;
            this.lblIdle.Text = "games left to idle";
            this.lblIdle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblIdle.Visible = false;
            // 
            // lblCurrentStatus
            // 
            this.lblCurrentStatus.AutoSize = true;
            this.lblCurrentStatus.DisabledLinkColor = System.Drawing.SystemColors.Control;
            this.lblCurrentStatus.Enabled = false;
            this.lblCurrentStatus.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentStatus.Location = new System.Drawing.Point(14, 12);
            this.lblCurrentStatus.Name = "lblCurrentStatus";
            this.lblCurrentStatus.Size = new System.Drawing.Size(99, 13);
            this.lblCurrentStatus.TabIndex = 11;
            this.lblCurrentStatus.TabStop = true;
            this.lblCurrentStatus.Text = "Currently in-game";
            this.lblCurrentStatus.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCurrentStatus_LinkClicked);
            // 
            // btnPause
            // 
            this.btnPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPause.FlatAppearance.BorderSize = 0;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Image = global::SteamTradeCardDropper.Properties.Resources.imgPauseSmall;
            this.btnPause.Location = new System.Drawing.Point(336, 9);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(20, 20);
            this.btnPause.TabIndex = 22;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnResume
            // 
            this.btnResume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResume.FlatAppearance.BorderSize = 0;
            this.btnResume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResume.Image = global::SteamTradeCardDropper.Properties.Resources.imgPlaySmall;
            this.btnResume.Location = new System.Drawing.Point(336, 9);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(20, 20);
            this.btnResume.TabIndex = 24;
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Visible = false;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // btnSkip
            // 
            this.btnSkip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSkip.FlatAppearance.BorderSize = 0;
            this.btnSkip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkip.Image = global::SteamTradeCardDropper.Properties.Resources.imgSkipSmall;
            this.btnSkip.Location = new System.Drawing.Point(360, 9);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(20, 20);
            this.btnSkip.TabIndex = 23;
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // lblGameName
            // 
            this.lblGameName.AutoEllipsis = true;
            this.lblGameName.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblGameName.Location = new System.Drawing.Point(14, 32);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(360, 20);
            this.lblGameName.TabIndex = 16;
            this.lblGameName.TabStop = true;
            this.lblGameName.Text = "Game Name";
            this.lblGameName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblGameName_LinkClicked);
            // 
            // picApp
            // 
            this.picApp.Location = new System.Drawing.Point(14, 56);
            this.picApp.Name = "picApp";
            this.picApp.Size = new System.Drawing.Size(360, 158);
            this.picApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picApp.TabIndex = 6;
            this.picApp.TabStop = false;
            this.picApp.Visible = false;
            // 
            // GamesState
            // 
            this.GamesState.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.GameName,
            this.Hours});
            this.GamesState.HideSelection = false;
            this.GamesState.Location = new System.Drawing.Point(14, 56);
            this.GamesState.Margin = new System.Windows.Forms.Padding(2);
            this.GamesState.Name = "GamesState";
            this.GamesState.Size = new System.Drawing.Size(360, 158);
            this.GamesState.TabIndex = 28;
            this.GamesState.UseCompatibleStateImageBehavior = false;
            this.GamesState.View = System.Windows.Forms.View.Details;
            this.GamesState.Visible = false;
            // 
            // GameName
            // 
            this.GameName.Tag = "";
            this.GameName.Text = "Name";
            this.GameName.Width = 200;
            // 
            // Hours
            // 
            this.Hours.Text = "Hours";
            this.Hours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Hours.Width = 45;
            // 
            // lblHoursPlayed
            // 
            this.lblHoursPlayed.AutoSize = true;
            this.lblHoursPlayed.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursPlayed.Location = new System.Drawing.Point(14, 226);
            this.lblHoursPlayed.Name = "lblHoursPlayed";
            this.lblHoursPlayed.Size = new System.Drawing.Size(0, 13);
            this.lblHoursPlayed.TabIndex = 29;
            this.lblHoursPlayed.Visible = false;
            // 
            // lblCurrentRemaining
            // 
            this.lblCurrentRemaining.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentRemaining.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCurrentRemaining.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentRemaining.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblCurrentRemaining.Location = new System.Drawing.Point(164, 224);
            this.lblCurrentRemaining.Name = "lblCurrentRemaining";
            this.lblCurrentRemaining.Size = new System.Drawing.Size(210, 20);
            this.lblCurrentRemaining.TabIndex = 12;
            this.lblCurrentRemaining.Text = "3 card drops remaining";
            this.lblCurrentRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCurrentRemaining.Click += new System.EventHandler(this.lblCurrentRemaining_Click);
            // 
            // picIdleStatus
            // 
            this.picIdleStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picIdleStatus.Location = new System.Drawing.Point(556, 364);
            this.picIdleStatus.Name = "picIdleStatus";
            this.picIdleStatus.Size = new System.Drawing.Size(15, 16);
            this.picIdleStatus.TabIndex = 15;
            this.picIdleStatus.TabStop = false;
            this.picIdleStatus.Visible = false;
            // 
            // tmrStartNext
            // 
            this.tmrStartNext.Tick += new System.EventHandler(this.tmrStartNext_Tick);
            // 
            // tmrBadgeReload
            // 
            this.tmrBadgeReload.Interval = 1000;
            this.tmrBadgeReload.Tick += new System.EventHandler(this.tmrBadgeReload_Tick);
            // 
            // tmrStatistics
            // 
            this.tmrStatistics.Interval = 60000;
            this.tmrStatistics.Tick += new System.EventHandler(this.tmrStatistics_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(580, 385);
            this.Controls.Add(this.pnlSessionCard);
            this.Controls.Add(this.pnlStatusCard);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.picIdleStatus);
            this.Controls.Add(this.mnuTop);
            this.Controls.Add(this.ssFooter);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::SteamTradeCardDropper.Properties.Resources.appIcon;
            this.MainMenuStrip = this.mnuTop;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Steam Trade Card Dropper";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClose);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.mnuTop.ResumeLayout(false);
            this.mnuTop.PerformLayout();
            this.ssFooter.ResumeLayout(false);
            this.ssFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReadingPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIdleStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCookieStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSteamStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picApp)).EndInit();
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSidebarLogo)).EndInit();
            this.pnlStatusCard.ResumeLayout(false);
            this.pnlStatusCard.PerformLayout();
            this.pnlSessionCard.ResumeLayout(false);
            this.pnlSessionCard.PerformLayout();
            this.pnlEmptyState.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picEmptyIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label lblCookieStatus;
        private Timer tmrCheckCookieData;
        private Label lblSteamStatus;
        private Timer tmrCheckSteam;
        private LinkLabel lnkResetCookies;
        private LinkLabel lnkSignIn;
        private PictureBox picApp;
        private PictureBox picSteamStatus;
        private PictureBox picCookieStatus;
        private Label lblDrops;
        private Label lblIdle;
        private LinkLabel lblCurrentStatus;
        private Label lblCurrentRemaining;
        private PictureBox picIdleStatus;
        private LinkLabel lblGameName;
        private MenuStrip mnuTop;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Timer tmrReadyToGo;
        private Timer tmrCardDropCheck;
        private StatusStrip ssFooter;
        private ToolStripProgressBar pbIdle;
        private ToolStripStatusLabel lblTimer;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Button btnPause;
        private Button btnSkip;
        private Button btnResume;
        private ToolStripMenuItem gameToolStripMenuItem;
        private ToolStripMenuItem pauseIdlingToolStripMenuItem;
        private ToolStripMenuItem resumeIdlingToolStripMenuItem;
        private ToolStripMenuItem skipGameToolStripMenuItem;
        private NotifyIcon notifyIcon1;
        private PictureBox picReadingPage;
        private ToolStripMenuItem blacklistToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem blacklistCurrentGameToolStripMenuItem;
        private Timer tmrStartNext;
        private ToolStripMenuItem changelogToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private Timer tmrBadgeReload;
        private Label lblSignedOnAs;
        private ListView GamesState;
        private ColumnHeader GameName;
        private ColumnHeader Hours;
        private Label lblHoursPlayed;
        private Timer tmrStatistics;
        private ToolStripMenuItem statisticsToolStripMenuItem;
        private LinkLabel lnkLatestRelease;
        private ToolStripMenuItem whitelistToolStripMenuItem;
        private ToolStripMenuItem wikiToolStripMenuItem;
        private Panel pnlSidebar;
        private PictureBox picSidebarLogo;
        private Label lblSidebarBrand;
        private Label lblSidebarVersion;
        private Panel pnlNavDivider;
        private Button btnNavDashboard;
        private Button btnNavSettings;
        private Button btnNavWhitelist;
        private Button btnNavBlacklist;
        private Button btnNavStatistics;
        private Button btnNavEula;
        private Button btnNavAbout;
        private Button btnNavExit;
        private Panel pnlStatusCard;
        private Panel pnlSessionCard;
        private Panel pnlEmptyState;
        private PictureBox picEmptyIcon;
        private Label lblEmptyTitle;
        private Label lblEmptySubtitle;
    }
}

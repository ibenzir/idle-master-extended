namespace SteamTradeCardDropper
{
    partial class frmSettingsAdvanced
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
            this.lblSessionID = new System.Windows.Forms.Label();
            this.txtSessionID = new System.Windows.Forms.TextBox();
            this.lblSteamLoginSecure = new System.Windows.Forms.Label();
            this.txtSteamLoginSecure = new System.Windows.Forms.TextBox();
            this.lblSteamParental = new System.Windows.Forms.Label();
            this.txtSteamParental = new System.Windows.Forms.TextBox();
            this.btnView = new System.Windows.Forms.Button();
            this.linkLabelWhatIsThis = new System.Windows.Forms.LinkLabel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.ttHelp = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
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
            this.lblTitle.Size = new System.Drawing.Size(215, 21);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Steam Authentication Data";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.Location = new System.Drawing.Point(70, 38);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(342, 15);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "Provide your personal Steam session cookies to synchronize badges.";
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
            // lblSessionID
            // 
            this.lblSessionID.AutoSize = true;
            this.lblSessionID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSessionID.Location = new System.Drawing.Point(20, 78);
            this.lblSessionID.Name = "lblSessionID";
            this.lblSessionID.Size = new System.Drawing.Size(126, 15);
            this.lblSessionID.TabIndex = 4;
            this.lblSessionID.Text = "Session ID (sessionid):";
            // 
            // txtSessionID
            // 
            this.txtSessionID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSessionID.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSessionID.Location = new System.Drawing.Point(20, 98);
            this.txtSessionID.Name = "txtSessionID";
            this.txtSessionID.PasswordChar = '*';
            this.txtSessionID.Size = new System.Drawing.Size(500, 24);
            this.txtSessionID.TabIndex = 5;
            this.txtSessionID.TextChanged += new System.EventHandler(this.txtSessionID_TextChanged);
            // 
            // lblSteamLoginSecure
            // 
            this.lblSteamLoginSecure.AutoSize = true;
            this.lblSteamLoginSecure.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSteamLoginSecure.Location = new System.Drawing.Point(20, 134);
            this.lblSteamLoginSecure.Name = "lblSteamLoginSecure";
            this.lblSteamLoginSecure.Size = new System.Drawing.Size(201, 15);
            this.lblSteamLoginSecure.TabIndex = 6;
            this.lblSteamLoginSecure.Text = "Steam Login Secure (steamLoginSecure):";
            // 
            // txtSteamLoginSecure
            // 
            this.txtSteamLoginSecure.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSteamLoginSecure.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSteamLoginSecure.Location = new System.Drawing.Point(20, 154);
            this.txtSteamLoginSecure.Name = "txtSteamLoginSecure";
            this.txtSteamLoginSecure.PasswordChar = '*';
            this.txtSteamLoginSecure.Size = new System.Drawing.Size(500, 24);
            this.txtSteamLoginSecure.TabIndex = 7;
            this.txtSteamLoginSecure.TextChanged += new System.EventHandler(this.txtSteamLogin_TextChanged);
            // 
            // lblSteamParental
            // 
            this.lblSteamParental.AutoSize = true;
            this.lblSteamParental.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSteamParental.Location = new System.Drawing.Point(20, 190);
            this.lblSteamParental.Name = "lblSteamParental";
            this.lblSteamParental.Size = new System.Drawing.Size(273, 15);
            this.lblSteamParental.TabIndex = 8;
            this.lblSteamParental.Text = "Steam Parental / Machine Auth (steamparental):";
            // 
            // txtSteamParental
            // 
            this.txtSteamParental.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSteamParental.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSteamParental.Location = new System.Drawing.Point(20, 210);
            this.txtSteamParental.Name = "txtSteamParental";
            this.txtSteamParental.PasswordChar = '*';
            this.txtSteamParental.Size = new System.Drawing.Size(500, 24);
            this.txtSteamParental.TabIndex = 9;
            this.txtSteamParental.TextChanged += new System.EventHandler(this.txtSteamParental_TextChanged);
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(20, 248);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(120, 28);
            this.btnView.TabIndex = 10;
            this.btnView.Text = "Show Cookies";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // linkLabelWhatIsThis
            // 
            this.linkLabelWhatIsThis.AutoSize = true;
            this.linkLabelWhatIsThis.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelWhatIsThis.Location = new System.Drawing.Point(150, 255);
            this.linkLabelWhatIsThis.Name = "linkLabelWhatIsThis";
            this.linkLabelWhatIsThis.Size = new System.Drawing.Size(157, 15);
            this.linkLabelWhatIsThis.TabIndex = 11;
            this.linkLabelWhatIsThis.TabStop = true;
            this.linkLabelWhatIsThis.Text = "How to find session cookies?";
            this.linkLabelWhatIsThis.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelWhatIsThis_LinkClicked);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(280, 304);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 32);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(390, 304);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(130, 32);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "&Save && Validate";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // ttHelp
            // 
            this.ttHelp.AutoPopDelay = 9000;
            this.ttHelp.InitialDelay = 500;
            this.ttHelp.ReshowDelay = 100;
            // 
            // frmSettingsAdvanced
            // 
            this.AcceptButton = this.btnUpdate;
            this.CancelButton = this.btnCancel;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 354);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.linkLabelWhatIsThis);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.txtSteamParental);
            this.Controls.Add(this.lblSteamParental);
            this.Controls.Add(this.txtSteamLoginSecure);
            this.Controls.Add(this.lblSteamLoginSecure);
            this.Controls.Add(this.txtSessionID);
            this.Controls.Add(this.lblSessionID);
            this.Controls.Add(this.pnlDivider);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picIcon);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettingsAdvanced";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Authentication Data";
            this.Load += new System.EventHandler(this.frmSettingsAdvanced_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlDivider;
        private System.Windows.Forms.Label lblSessionID;
        private System.Windows.Forms.TextBox txtSessionID;
        private System.Windows.Forms.Label lblSteamLoginSecure;
        private System.Windows.Forms.TextBox txtSteamLoginSecure;
        private System.Windows.Forms.Label lblSteamParental;
        private System.Windows.Forms.TextBox txtSteamParental;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.LinkLabel linkLabelWhatIsThis;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ToolTip ttHelp;
    }
}
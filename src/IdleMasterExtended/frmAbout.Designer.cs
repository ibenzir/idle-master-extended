using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace IdleMasterExtended
{
    partial class frmAbout
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
            this.picAppIcon = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.linkLabelVersion = new System.Windows.Forms.LinkLabel();
            this.pnlDivider = new System.Windows.Forms.Panel();
            this.lblMaintainer = new System.Windows.Forms.Label();
            this.lnkWebsite = new System.Windows.Forms.LinkLabel();
            this.lblLicense = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picAppIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // picAppIcon
            // 
            this.picAppIcon.Location = new System.Drawing.Point(18, 16);
            this.picAppIcon.Name = "picAppIcon";
            this.picAppIcon.Size = new System.Drawing.Size(42, 42);
            this.picAppIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAppIcon.TabIndex = 0;
            this.picAppIcon.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(68, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(182, 21);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Idle Master Extended";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblSubtitle.Location = new System.Drawing.Point(70, 37);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(206, 13);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "Automated Steam Trading Card Idler";
            // 
            // linkLabelVersion
            // 
            this.linkLabelVersion.AutoSize = true;
            this.linkLabelVersion.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelVersion.Location = new System.Drawing.Point(70, 53);
            this.linkLabelVersion.Name = "linkLabelVersion";
            this.linkLabelVersion.Size = new System.Drawing.Size(46, 13);
            this.linkLabelVersion.TabIndex = 3;
            this.linkLabelVersion.TabStop = true;
            this.linkLabelVersion.Text = "v1.11.0";
            this.linkLabelVersion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelVersion_LinkClicked);
            // 
            // pnlDivider
            // 
            this.pnlDivider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlDivider.Location = new System.Drawing.Point(18, 76);
            this.pnlDivider.Name = "pnlDivider";
            this.pnlDivider.Size = new System.Drawing.Size(304, 1);
            this.pnlDivider.TabIndex = 4;
            // 
            // lblMaintainer
            // 
            this.lblMaintainer.AutoSize = true;
            this.lblMaintainer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaintainer.Location = new System.Drawing.Point(18, 90);
            this.lblMaintainer.Name = "lblMaintainer";
            this.lblMaintainer.Size = new System.Drawing.Size(196, 15);
            this.lblMaintainer.TabIndex = 5;
            this.lblMaintainer.Text = "Maintained by BENZIR";
            // 
            // lnkWebsite
            // 
            this.lnkWebsite.AutoSize = true;
            this.lnkWebsite.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkWebsite.Location = new System.Drawing.Point(18, 110);
            this.lnkWebsite.Name = "lnkWebsite";
            this.lnkWebsite.Size = new System.Drawing.Size(107, 15);
            this.lnkWebsite.TabIndex = 6;
            this.lnkWebsite.TabStop = true;
            this.lnkWebsite.Text = "https://ibenzir.me";
            this.lnkWebsite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkWebsite_LinkClicked);
            // 
            // lblLicense
            // 
            this.lblLicense.AutoSize = true;
            this.lblLicense.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicense.ForeColor = System.Drawing.Color.Gray;
            this.lblLicense.Location = new System.Drawing.Point(18, 132);
            this.lblLicense.Name = "lblLicense";
            this.lblLicense.Size = new System.Drawing.Size(206, 13);
            this.lblLicense.TabIndex = 7;
            this.lblLicense.Text = "Licensed under GNU GPL v2.0 (Open Source)";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(247, 158);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 25);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "&Close";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmAbout
            // 
            this.AcceptButton = this.btnOK;
            this.CancelButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 196);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblLicense);
            this.Controls.Add(this.lnkWebsite);
            this.Controls.Add(this.lblMaintainer);
            this.Controls.Add(this.pnlDivider);
            this.Controls.Add(this.linkLabelVersion);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picAppIcon);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About Idle Master Extended";
            this.Load += new System.EventHandler(this.frmAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAppIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picAppIcon;
        private Label lblTitle;
        private Label lblSubtitle;
        private LinkLabel linkLabelVersion;
        private Panel pnlDivider;
        private Label lblMaintainer;
        private LinkLabel lnkWebsite;
        private Label lblLicense;
        private Button btnOK;
    }
}
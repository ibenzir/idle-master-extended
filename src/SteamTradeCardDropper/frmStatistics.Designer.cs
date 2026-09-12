namespace SteamTradeCardDropper
{
    partial class frmStatistics
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
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.pnlDivider = new System.Windows.Forms.Panel();
            this.pnlSessionCard = new System.Windows.Forms.Panel();
            this.lblSessionHeader = new System.Windows.Forms.Label();
            this.lblSessionCards = new System.Windows.Forms.Label();
            this.lblSessionTime = new System.Windows.Forms.Label();
            this.pnlTotalCard = new System.Windows.Forms.Panel();
            this.lblTotalHeader = new System.Windows.Forms.Label();
            this.lblTotalCards = new System.Windows.Forms.Label();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.pnlSessionCard.SuspendLayout();
            this.pnlTotalCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // picIcon
            // 
            this.picIcon.Location = new System.Drawing.Point(20, 16);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(42, 42);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 0;
            this.picIcon.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(72, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(127, 21);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Idling Statistics";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.Location = new System.Drawing.Point(74, 38);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(263, 15);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "Overview of session and lifetime trading card progress";
            // 
            // pnlDivider
            // 
            this.pnlDivider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDivider.Location = new System.Drawing.Point(20, 68);
            this.pnlDivider.Name = "pnlDivider";
            this.pnlDivider.Size = new System.Drawing.Size(380, 1);
            this.pnlDivider.TabIndex = 3;
            // 
            // pnlSessionCard
            // 
            this.pnlSessionCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSessionCard.Controls.Add(this.lblSessionHeader);
            this.pnlSessionCard.Controls.Add(this.lblSessionCards);
            this.pnlSessionCard.Controls.Add(this.lblSessionTime);
            this.pnlSessionCard.Location = new System.Drawing.Point(20, 80);
            this.pnlSessionCard.Name = "pnlSessionCard";
            this.pnlSessionCard.Size = new System.Drawing.Size(380, 82);
            this.pnlSessionCard.TabIndex = 4;
            // 
            // lblSessionHeader
            // 
            this.lblSessionHeader.AutoSize = true;
            this.lblSessionHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSessionHeader.Location = new System.Drawing.Point(14, 10);
            this.lblSessionHeader.Name = "lblSessionHeader";
            this.lblSessionHeader.Size = new System.Drawing.Size(109, 19);
            this.lblSessionHeader.TabIndex = 0;
            this.lblSessionHeader.Text = "Current Session";
            // 
            // lblSessionCards
            // 
            this.lblSessionCards.AutoSize = true;
            this.lblSessionCards.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSessionCards.Location = new System.Drawing.Point(14, 34);
            this.lblSessionCards.Name = "lblSessionCards";
            this.lblSessionCards.Size = new System.Drawing.Size(86, 17);
            this.lblSessionCards.TabIndex = 1;
            this.lblSessionCards.Text = "sessionCards";
            // 
            // lblSessionTime
            // 
            this.lblSessionTime.AutoSize = true;
            this.lblSessionTime.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSessionTime.Location = new System.Drawing.Point(14, 56);
            this.lblSessionTime.Name = "lblSessionTime";
            this.lblSessionTime.Size = new System.Drawing.Size(73, 15);
            this.lblSessionTime.TabIndex = 2;
            this.lblSessionTime.Text = "sessionTime";
            // 
            // pnlTotalCard
            // 
            this.pnlTotalCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTotalCard.Controls.Add(this.lblTotalHeader);
            this.pnlTotalCard.Controls.Add(this.lblTotalCards);
            this.pnlTotalCard.Controls.Add(this.lblTotalTime);
            this.pnlTotalCard.Location = new System.Drawing.Point(20, 172);
            this.pnlTotalCard.Name = "pnlTotalCard";
            this.pnlTotalCard.Size = new System.Drawing.Size(380, 82);
            this.pnlTotalCard.TabIndex = 5;
            // 
            // lblTotalHeader
            // 
            this.lblTotalHeader.AutoSize = true;
            this.lblTotalHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalHeader.Location = new System.Drawing.Point(14, 10);
            this.lblTotalHeader.Name = "lblTotalHeader";
            this.lblTotalHeader.Size = new System.Drawing.Size(100, 19);
            this.lblTotalHeader.TabIndex = 0;
            this.lblTotalHeader.Text = "Lifetime Total";
            // 
            // lblTotalCards
            // 
            this.lblTotalCards.AutoSize = true;
            this.lblTotalCards.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCards.Location = new System.Drawing.Point(14, 34);
            this.lblTotalCards.Name = "lblTotalCards";
            this.lblTotalCards.Size = new System.Drawing.Size(68, 17);
            this.lblTotalCards.TabIndex = 1;
            this.lblTotalCards.Text = "totalCards";
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.AutoSize = true;
            this.lblTotalTime.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTime.Location = new System.Drawing.Point(14, 56);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(57, 15);
            this.lblTotalTime.TabIndex = 2;
            this.lblTotalTime.Text = "totalTime";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(310, 266);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(90, 32);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "&Close";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmStatistics
            // 
            this.AcceptButton = this.btnOK;
            this.CancelButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 312);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.pnlTotalCard);
            this.Controls.Add(this.pnlSessionCard);
            this.Controls.Add(this.pnlDivider);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picIcon);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStatistics";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.frmStatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.pnlSessionCard.ResumeLayout(false);
            this.pnlSessionCard.PerformLayout();
            this.pnlTotalCard.ResumeLayout(false);
            this.pnlTotalCard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlDivider;
        private System.Windows.Forms.Panel pnlSessionCard;
        private System.Windows.Forms.Panel pnlTotalCard;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblSessionTime;
        private System.Windows.Forms.Label lblSessionCards;
        private System.Windows.Forms.Label lblTotalCards;
        private System.Windows.Forms.Label lblTotalTime;
        private System.Windows.Forms.Label lblSessionHeader;
        private System.Windows.Forms.Label lblTotalHeader;
    }
}
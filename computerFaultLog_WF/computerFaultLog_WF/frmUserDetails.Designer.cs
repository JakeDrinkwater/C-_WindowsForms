namespace computerFaultLog_WF
{
    partial class frmUserDetails
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblUserDetails = new System.Windows.Forms.Label();
            this.lblFaultReport = new System.Windows.Forms.Label();
            this.btnReportFault = new System.Windows.Forms.Button();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(3, 394);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(194, 42);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(3, 330);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(194, 42);
            this.btnLogOut.TabIndex = 16;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlMenu.Controls.Add(this.lblUserDetails);
            this.pnlMenu.Controls.Add(this.lblFaultReport);
            this.pnlMenu.Controls.Add(this.btnReportFault);
            this.pnlMenu.Controls.Add(this.btnLogOut);
            this.pnlMenu.Controls.Add(this.btnExit);
            this.pnlMenu.Location = new System.Drawing.Point(1, 2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 446);
            this.pnlMenu.TabIndex = 17;
            // 
            // lblUserDetails
            // 
            this.lblUserDetails.AutoSize = true;
            this.lblUserDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserDetails.Location = new System.Drawing.Point(72, 28);
            this.lblUserDetails.Name = "lblUserDetails";
            this.lblUserDetails.Size = new System.Drawing.Size(125, 24);
            this.lblUserDetails.TabIndex = 19;
            this.lblUserDetails.Text = "User details:";
            // 
            // lblFaultReport
            // 
            this.lblFaultReport.AutoSize = true;
            this.lblFaultReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaultReport.Location = new System.Drawing.Point(12, 4);
            this.lblFaultReport.Name = "lblFaultReport";
            this.lblFaultReport.Size = new System.Drawing.Size(122, 24);
            this.lblFaultReport.TabIndex = 18;
            this.lblFaultReport.Text = "Report fault:";
            // 
            // btnReportFault
            // 
            this.btnReportFault.FlatAppearance.BorderSize = 0;
            this.btnReportFault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportFault.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportFault.Location = new System.Drawing.Point(3, 165);
            this.btnReportFault.Name = "btnReportFault";
            this.btnReportFault.Size = new System.Drawing.Size(194, 42);
            this.btnReportFault.TabIndex = 17;
            this.btnReportFault.Text = "Report fault";
            this.btnReportFault.UseVisualStyleBackColor = true;
            this.btnReportFault.Click += new System.EventHandler(this.BtnReportFault_Click);
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(675, 6);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(55, 13);
            this.lblDateTime.TabIndex = 21;
            this.lblDateTime.Text = "Date time:";
            this.lblDateTime.Click += new System.EventHandler(this.LblDateTime_Click);
            // 
            // frmUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.pnlMenu);
            this.Name = "frmUserDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMainMenu";
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblUserDetails;
        private System.Windows.Forms.Label lblFaultReport;
        private System.Windows.Forms.Button btnReportFault;
        private System.Windows.Forms.Label lblDateTime;
    }
}
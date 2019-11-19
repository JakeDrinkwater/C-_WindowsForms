namespace computerFaultLog_WF
{
    partial class frmReportFault
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
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlReportMenu = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblSName = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtSName = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cboTitle = new System.Windows.Forms.ComboBox();
            this.pnlReportMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.FlatAppearance.BorderSize = 0;
            this.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.Location = new System.Drawing.Point(3, 3);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(68, 50);
            this.btnMainMenu.TabIndex = 18;
            this.btnMainMenu.Text = "Back";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(3, 400);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(194, 42);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // pnlReportMenu
            // 
            this.pnlReportMenu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlReportMenu.Controls.Add(this.btnLogOut);
            this.pnlReportMenu.Controls.Add(this.btnMainMenu);
            this.pnlReportMenu.Controls.Add(this.btnExit);
            this.pnlReportMenu.Location = new System.Drawing.Point(1, 1);
            this.pnlReportMenu.Name = "pnlReportMenu";
            this.pnlReportMenu.Size = new System.Drawing.Size(200, 448);
            this.pnlReportMenu.TabIndex = 19;
            // 
            // btnLogOut
            // 
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(6, 344);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(191, 50);
            this.btnLogOut.TabIndex = 19;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click_1);
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(675, 9);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(55, 13);
            this.lblDateTime.TabIndex = 20;
            this.lblDateTime.Text = "Date time:";
            this.lblDateTime.Click += new System.EventHandler(this.LblDateTime_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(263, 106);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(56, 24);
            this.lblTitle.TabIndex = 21;
            this.lblTitle.Text = "Title:";
            this.lblTitle.Click += new System.EventHandler(this.LblTitle_Click);
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFName.Location = new System.Drawing.Point(263, 171);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(112, 24);
            this.lblFName.TabIndex = 22;
            this.lblFName.Text = "Forename:";
            this.lblFName.Click += new System.EventHandler(this.LblFName_Click);
            // 
            // lblSName
            // 
            this.lblSName.AutoSize = true;
            this.lblSName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSName.Location = new System.Drawing.Point(263, 231);
            this.lblSName.Name = "lblSName";
            this.lblSName.Size = new System.Drawing.Size(100, 24);
            this.lblSName.TabIndex = 23;
            this.lblSName.Text = "Surname:";
            this.lblSName.Click += new System.EventHandler(this.LblSName_Click);
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(263, 291);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(123, 24);
            this.lblDepartment.TabIndex = 24;
            this.lblDepartment.Text = "Department:";
            this.lblDepartment.Click += new System.EventHandler(this.LblDepartment_Click);
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(401, 171);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(139, 20);
            this.txtFName.TabIndex = 26;
            this.txtFName.Text = "Jake";
            // 
            // txtSName
            // 
            this.txtSName.Location = new System.Drawing.Point(401, 231);
            this.txtSName.Name = "txtSName";
            this.txtSName.Size = new System.Drawing.Size(139, 20);
            this.txtSName.TabIndex = 27;
            this.txtSName.Text = "Drinkwater";
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(401, 291);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(139, 20);
            this.txtDepartment.TabIndex = 28;
            this.txtDepartment.Text = "Student";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(267, 335);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(119, 41);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(401, 335);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(119, 41);
            this.btnSubmit.TabIndex = 30;
            this.btnSubmit.Text = "Submit:";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // cboTitle
            // 
            this.cboTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTitle.FormattingEnabled = true;
            this.cboTitle.Items.AddRange(new object[] {
            "Mr.",
            "Mrs.",
            "Ms.",
            "Dr.",
            "Rev."});
            this.cboTitle.Location = new System.Drawing.Point(401, 106);
            this.cboTitle.Name = "cboTitle";
            this.cboTitle.Size = new System.Drawing.Size(121, 21);
            this.cboTitle.TabIndex = 31;
            // 
            // frmReportFault
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboTitle);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.txtSName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblSName);
            this.Controls.Add(this.lblFName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.pnlReportMenu);
            this.Name = "frmReportFault";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReportFault";
            this.pnlReportMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlReportMenu;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblSName;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtSName;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cboTitle;
    }
}
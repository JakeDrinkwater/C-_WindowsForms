namespace QuizAppFixed_WF
{
    partial class frmQuiz
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.grpLeftSide = new System.Windows.Forms.GroupBox();
            this.lblHelp2 = new System.Windows.Forms.Label();
            this.lblHelp = new System.Windows.Forms.Label();
            this.btnResults = new System.Windows.Forms.Button();
            this.btnStudy = new System.Windows.Forms.Button();
            this.btnQuiz = new System.Windows.Forms.Button();
            this.lnkHelpDoc = new System.Windows.Forms.LinkLabel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnQuiz1 = new System.Windows.Forms.Button();
            this.btnQuiz2 = new System.Windows.Forms.Button();
            this.lblDesript = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grpLeftSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Aquamarine;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemToolStripMenuItem,
            this.userToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(937, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExitButton});
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.systemToolStripMenuItem.Text = "System";
            // 
            // mnuExitButton
            // 
            this.mnuExitButton.Name = "mnuExitButton";
            this.mnuExitButton.Size = new System.Drawing.Size(95, 22);
            this.mnuExitButton.Text = "Exit";
            this.mnuExitButton.Click += new System.EventHandler(this.mnuExitButton_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLogout});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.userToolStripMenuItem.Text = "User";
            // 
            // mnuLogout
            // 
            this.mnuLogout.Name = "mnuLogout";
            this.mnuLogout.Size = new System.Drawing.Size(116, 22);
            this.mnuLogout.Text = "Log out";
            this.mnuLogout.Click += new System.EventHandler(this.mnuLogout_Click);
            // 
            // grpLeftSide
            // 
            this.grpLeftSide.BackColor = System.Drawing.Color.Aquamarine;
            this.grpLeftSide.Controls.Add(this.lblHelp2);
            this.grpLeftSide.Controls.Add(this.lblHelp);
            this.grpLeftSide.Controls.Add(this.btnResults);
            this.grpLeftSide.Controls.Add(this.btnStudy);
            this.grpLeftSide.Controls.Add(this.btnQuiz);
            this.grpLeftSide.Controls.Add(this.lnkHelpDoc);
            this.grpLeftSide.Controls.Add(this.lblTitle);
            this.grpLeftSide.Location = new System.Drawing.Point(-2, -82);
            this.grpLeftSide.Name = "grpLeftSide";
            this.grpLeftSide.Size = new System.Drawing.Size(321, 615);
            this.grpLeftSide.TabIndex = 11;
            this.grpLeftSide.TabStop = false;
            // 
            // lblHelp2
            // 
            this.lblHelp2.AutoSize = true;
            this.lblHelp2.BackColor = System.Drawing.Color.Aquamarine;
            this.lblHelp2.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelp2.Location = new System.Drawing.Point(64, 112);
            this.lblHelp2.Name = "lblHelp2";
            this.lblHelp2.Size = new System.Drawing.Size(175, 32);
            this.lblHelp2.TabIndex = 9;
            this.lblHelp2.Text = "^ If you want to log out or exit, \r\nclick on these!";
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelp.Location = new System.Drawing.Point(18, 501);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(239, 38);
            this.lblHelp.TabIndex = 6;
            this.lblHelp.Text = "If you\'re confused about what to do, \r\nclick on the blue link below!";
            // 
            // btnResults
            // 
            this.btnResults.BackColor = System.Drawing.Color.Aquamarine;
            this.btnResults.FlatAppearance.BorderSize = 0;
            this.btnResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResults.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResults.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnResults.Location = new System.Drawing.Point(16, 386);
            this.btnResults.Name = "btnResults";
            this.btnResults.Size = new System.Drawing.Size(294, 70);
            this.btnResults.TabIndex = 5;
            this.btnResults.Text = "Results";
            this.btnResults.UseVisualStyleBackColor = false;
            this.btnResults.Click += new System.EventHandler(this.BtnResults_Click);
            // 
            // btnStudy
            // 
            this.btnStudy.BackColor = System.Drawing.Color.Aquamarine;
            this.btnStudy.FlatAppearance.BorderSize = 0;
            this.btnStudy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudy.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudy.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnStudy.Location = new System.Drawing.Point(16, 310);
            this.btnStudy.Name = "btnStudy";
            this.btnStudy.Size = new System.Drawing.Size(294, 70);
            this.btnStudy.TabIndex = 3;
            this.btnStudy.Text = "Study";
            this.btnStudy.UseVisualStyleBackColor = false;
            this.btnStudy.Click += new System.EventHandler(this.BtnStudy_Click);
            // 
            // btnQuiz
            // 
            this.btnQuiz.BackColor = System.Drawing.Color.Aquamarine;
            this.btnQuiz.FlatAppearance.BorderSize = 0;
            this.btnQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuiz.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuiz.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnQuiz.Location = new System.Drawing.Point(16, 234);
            this.btnQuiz.Name = "btnQuiz";
            this.btnQuiz.Size = new System.Drawing.Size(294, 70);
            this.btnQuiz.TabIndex = 2;
            this.btnQuiz.Text = "Quiz";
            this.btnQuiz.UseVisualStyleBackColor = false;
            // 
            // lnkHelpDoc
            // 
            this.lnkHelpDoc.AutoSize = true;
            this.lnkHelpDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkHelpDoc.Location = new System.Drawing.Point(31, 555);
            this.lnkHelpDoc.Name = "lnkHelpDoc";
            this.lnkHelpDoc.Size = new System.Drawing.Size(130, 25);
            this.lnkHelpDoc.TabIndex = 1;
            this.lnkHelpDoc.TabStop = true;
            this.lnkHelpDoc.Text = "User Guide";
            this.lnkHelpDoc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkHelpDoc_LinkClicked);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTitle.Location = new System.Drawing.Point(75, 175);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(182, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Quiz App";
            this.lblTitle.Click += new System.EventHandler(this.LblTitle_Click);
            // 
            // btnQuiz1
            // 
            this.btnQuiz1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnQuiz1.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuiz1.Location = new System.Drawing.Point(343, 27);
            this.btnQuiz1.Name = "btnQuiz1";
            this.btnQuiz1.Size = new System.Drawing.Size(582, 126);
            this.btnQuiz1.TabIndex = 13;
            this.btnQuiz1.Text = "Level 1 (ICT)";
            this.btnQuiz1.UseVisualStyleBackColor = false;
            this.btnQuiz1.Click += new System.EventHandler(this.btnQuiz1_Click);
            // 
            // btnQuiz2
            // 
            this.btnQuiz2.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuiz2.Location = new System.Drawing.Point(343, 358);
            this.btnQuiz2.Name = "btnQuiz2";
            this.btnQuiz2.Size = new System.Drawing.Size(582, 126);
            this.btnQuiz2.TabIndex = 14;
            this.btnQuiz2.Text = "Level 2 (Art)";
            this.btnQuiz2.UseVisualStyleBackColor = true;
            this.btnQuiz2.Click += new System.EventHandler(this.btnQuiz2_Click);
            // 
            // lblDesript
            // 
            this.lblDesript.AutoSize = true;
            this.lblDesript.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesript.Location = new System.Drawing.Point(531, 172);
            this.lblDesript.Name = "lblDesript";
            this.lblDesript.Size = new System.Drawing.Size(232, 168);
            this.lblDesript.TabIndex = 15;
            this.lblDesript.Text = "               /\\\r\n                |\r\nTo begin pick which \r\nquiz you want to do!\r" +
    "\n                |\r\n               \\/\r\n";
            // 
            // frmQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(937, 518);
            this.Controls.Add(this.lblDesript);
            this.Controls.Add(this.btnQuiz2);
            this.Controls.Add(this.btnQuiz1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.grpLeftSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQuiz";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpLeftSide.ResumeLayout(false);
            this.grpLeftSide.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuExitButton;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuLogout;
        private System.Windows.Forms.GroupBox grpLeftSide;
        private System.Windows.Forms.Label lblHelp2;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Button btnResults;
        private System.Windows.Forms.Button btnStudy;
        private System.Windows.Forms.Button btnQuiz;
        private System.Windows.Forms.LinkLabel lnkHelpDoc;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnQuiz1;
        private System.Windows.Forms.Button btnQuiz2;
        private System.Windows.Forms.Label lblDesript;
    }
}
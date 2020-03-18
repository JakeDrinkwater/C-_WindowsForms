namespace QuizAppFixed_WF
{
    partial class frmLevel1
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
            this.pnlIncorrect = new System.Windows.Forms.Panel();
            this.lblIncorrectCount = new System.Windows.Forms.Label();
            this.lblIncorrect = new System.Windows.Forms.Label();
            this.pnlCorrect = new System.Windows.Forms.Panel();
            this.lblCorrectCount = new System.Windows.Forms.Label();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.lblFan = new System.Windows.Forms.Label();
            this.lblCPU = new System.Windows.Forms.Label();
            this.lblUSB = new System.Windows.Forms.Label();
            this.lblHDD = new System.Windows.Forms.Label();
            this.lblFloppy = new System.Windows.Forms.Label();
            this.lblRAM = new System.Windows.Forms.Label();
            this.lblSpacer = new System.Windows.Forms.Label();
            this.pnlSide = new System.Windows.Forms.Panel();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.lblHelp2 = new System.Windows.Forms.Label();
            this.lblHelp = new System.Windows.Forms.Label();
            this.btnQuiz = new System.Windows.Forms.Button();
            this.lnkHelpDoc = new System.Windows.Forms.LinkLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUSB_Drop = new System.Windows.Forms.Label();
            this.lblRAM_Drop = new System.Windows.Forms.Label();
            this.lblHDD_Drop = new System.Windows.Forms.Label();
            this.lblFloppy_Drop = new System.Windows.Forms.Label();
            this.lblFan_Drop = new System.Windows.Forms.Label();
            this.lblCPU_Drop = new System.Windows.Forms.Label();
            this.pnlIncorrect.SuspendLayout();
            this.pnlCorrect.SuspendLayout();
            this.pnlSide.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlIncorrect
            // 
            this.pnlIncorrect.BackColor = System.Drawing.Color.Aquamarine;
            this.pnlIncorrect.Controls.Add(this.lblIncorrectCount);
            this.pnlIncorrect.Controls.Add(this.lblIncorrect);
            this.pnlIncorrect.Location = new System.Drawing.Point(868, 516);
            this.pnlIncorrect.Name = "pnlIncorrect";
            this.pnlIncorrect.Size = new System.Drawing.Size(166, 126);
            this.pnlIncorrect.TabIndex = 31;
            // 
            // lblIncorrectCount
            // 
            this.lblIncorrectCount.AutoSize = true;
            this.lblIncorrectCount.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncorrectCount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblIncorrectCount.Location = new System.Drawing.Point(58, 51);
            this.lblIncorrectCount.Name = "lblIncorrectCount";
            this.lblIncorrectCount.Size = new System.Drawing.Size(42, 46);
            this.lblIncorrectCount.TabIndex = 2;
            this.lblIncorrectCount.Text = "0";
            // 
            // lblIncorrect
            // 
            this.lblIncorrect.AutoSize = true;
            this.lblIncorrect.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncorrect.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblIncorrect.Location = new System.Drawing.Point(3, 2);
            this.lblIncorrect.Name = "lblIncorrect";
            this.lblIncorrect.Size = new System.Drawing.Size(97, 26);
            this.lblIncorrect.TabIndex = 1;
            this.lblIncorrect.Text = "Incorrect";
            // 
            // pnlCorrect
            // 
            this.pnlCorrect.BackColor = System.Drawing.Color.Aquamarine;
            this.pnlCorrect.Controls.Add(this.lblCorrectCount);
            this.pnlCorrect.Controls.Add(this.lblCorrect);
            this.pnlCorrect.Location = new System.Drawing.Point(691, 516);
            this.pnlCorrect.Name = "pnlCorrect";
            this.pnlCorrect.Size = new System.Drawing.Size(166, 126);
            this.pnlCorrect.TabIndex = 30;
            // 
            // lblCorrectCount
            // 
            this.lblCorrectCount.AutoSize = true;
            this.lblCorrectCount.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrectCount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCorrectCount.Location = new System.Drawing.Point(64, 51);
            this.lblCorrectCount.Name = "lblCorrectCount";
            this.lblCorrectCount.Size = new System.Drawing.Size(42, 46);
            this.lblCorrectCount.TabIndex = 1;
            this.lblCorrectCount.Text = "0";
            this.lblCorrectCount.Click += new System.EventHandler(this.lblCorrectCount_Click_1);
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrect.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCorrect.Location = new System.Drawing.Point(4, 2);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(82, 26);
            this.lblCorrect.TabIndex = 0;
            this.lblCorrect.Text = "Correct";
            // 
            // lblFan
            // 
            this.lblFan.AutoSize = true;
            this.lblFan.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFan.Location = new System.Drawing.Point(564, 498);
            this.lblFan.Name = "lblFan";
            this.lblFan.Size = new System.Drawing.Size(83, 46);
            this.lblFan.TabIndex = 29;
            this.lblFan.Text = "Fan";
            this.lblFan.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblFan_MouseDown);
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPU.Location = new System.Drawing.Point(420, 587);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(94, 46);
            this.lblCPU.TabIndex = 28;
            this.lblCPU.Text = "CPU";
            this.lblCPU.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblCPU_MouseDown);
            // 
            // lblUSB
            // 
            this.lblUSB.AutoSize = true;
            this.lblUSB.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUSB.Location = new System.Drawing.Point(564, 587);
            this.lblUSB.Name = "lblUSB";
            this.lblUSB.Size = new System.Drawing.Size(92, 46);
            this.lblUSB.TabIndex = 27;
            this.lblUSB.Text = "USB";
            this.lblUSB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblUSB_MouseDown);
            // 
            // lblHDD
            // 
            this.lblHDD.AutoSize = true;
            this.lblHDD.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHDD.Location = new System.Drawing.Point(300, 587);
            this.lblHDD.Name = "lblHDD";
            this.lblHDD.Size = new System.Drawing.Size(105, 46);
            this.lblHDD.TabIndex = 26;
            this.lblHDD.Text = "HDD";
            this.lblHDD.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblHDD_MouseDown);
            // 
            // lblFloppy
            // 
            this.lblFloppy.AutoSize = true;
            this.lblFloppy.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFloppy.Location = new System.Drawing.Point(420, 498);
            this.lblFloppy.Name = "lblFloppy";
            this.lblFloppy.Size = new System.Drawing.Size(139, 46);
            this.lblFloppy.TabIndex = 25;
            this.lblFloppy.Text = "Floppy";
            this.lblFloppy.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblFloppy_MouseDown);
            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRAM.Location = new System.Drawing.Point(300, 498);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(106, 46);
            this.lblRAM.TabIndex = 24;
            this.lblRAM.Text = "RAM";
            this.lblRAM.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblRAM_MouseDown_1);
            // 
            // lblSpacer
            // 
            this.lblSpacer.AutoSize = true;
            this.lblSpacer.Location = new System.Drawing.Point(271, 454);
            this.lblSpacer.Name = "lblSpacer";
            this.lblSpacer.Size = new System.Drawing.Size(721, 39);
            this.lblSpacer.TabIndex = 23;
            this.lblSpacer.Text = "_________________________________________________________________________________" +
    "______________________________________\r\n\r\n\r\n";
            // 
            // pnlSide
            // 
            this.pnlSide.BackColor = System.Drawing.Color.Aquamarine;
            this.pnlSide.Controls.Add(this.btnMainMenu);
            this.pnlSide.Controls.Add(this.lblHelp2);
            this.pnlSide.Controls.Add(this.lblHelp);
            this.pnlSide.Controls.Add(this.btnQuiz);
            this.pnlSide.Controls.Add(this.lnkHelpDoc);
            this.pnlSide.Location = new System.Drawing.Point(0, 12);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(265, 662);
            this.pnlSide.TabIndex = 16;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.Color.Aquamarine;
            this.btnMainMenu.FlatAppearance.BorderSize = 0;
            this.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainMenu.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMainMenu.Location = new System.Drawing.Point(3, 47);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(259, 70);
            this.btnMainMenu.TabIndex = 17;
            this.btnMainMenu.Text = "Quiz App";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click_1);
            // 
            // lblHelp2
            // 
            this.lblHelp2.AutoSize = true;
            this.lblHelp2.BackColor = System.Drawing.Color.Aquamarine;
            this.lblHelp2.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelp2.Location = new System.Drawing.Point(12, 12);
            this.lblHelp2.Name = "lblHelp2";
            this.lblHelp2.Size = new System.Drawing.Size(175, 32);
            this.lblHelp2.TabIndex = 16;
            this.lblHelp2.Text = "^ If you want to log out or exit, \r\nclick on these!";
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHelp.Location = new System.Drawing.Point(12, 560);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(239, 38);
            this.lblHelp.TabIndex = 15;
            this.lblHelp.Text = "If you\'re confused about what to do, \r\nclick on the blue link below!";
            // 
            // btnQuiz
            // 
            this.btnQuiz.BackColor = System.Drawing.Color.Aquamarine;
            this.btnQuiz.FlatAppearance.BorderSize = 0;
            this.btnQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuiz.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuiz.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnQuiz.Location = new System.Drawing.Point(3, 135);
            this.btnQuiz.Name = "btnQuiz";
            this.btnQuiz.Size = new System.Drawing.Size(259, 70);
            this.btnQuiz.TabIndex = 12;
            this.btnQuiz.Text = "Quiz";
            this.btnQuiz.UseVisualStyleBackColor = false;
            this.btnQuiz.Click += new System.EventHandler(this.btnQuiz_Click);
            // 
            // lnkHelpDoc
            // 
            this.lnkHelpDoc.AutoSize = true;
            this.lnkHelpDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkHelpDoc.Location = new System.Drawing.Point(25, 614);
            this.lnkHelpDoc.Name = "lnkHelpDoc";
            this.lnkHelpDoc.Size = new System.Drawing.Size(130, 25);
            this.lnkHelpDoc.TabIndex = 11;
            this.lnkHelpDoc.TabStop = true;
            this.lnkHelpDoc.Text = "User Guide";
            this.lnkHelpDoc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkHelpDoc_LinkClicked);
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
            this.menuStrip1.Size = new System.Drawing.Size(1069, 24);
            this.menuStrip1.TabIndex = 32;
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
            // lblUSB_Drop
            // 
            this.lblUSB_Drop.AllowDrop = true;
            this.lblUSB_Drop.Image = global::QuizAppFixed_WF.Properties.Resources.USB;
            this.lblUSB_Drop.Location = new System.Drawing.Point(437, 244);
            this.lblUSB_Drop.Name = "lblUSB_Drop";
            this.lblUSB_Drop.Size = new System.Drawing.Size(158, 195);
            this.lblUSB_Drop.TabIndex = 22;
            this.lblUSB_Drop.Click += new System.EventHandler(this.lblUSB_Drop_Click_1);
            this.lblUSB_Drop.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblUSB_Drop_DragDrop);
            this.lblUSB_Drop.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblUSB_Drop_DragEnter);
            this.lblUSB_Drop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblUSB_Drop_MouseDown);
            // 
            // lblRAM_Drop
            // 
            this.lblRAM_Drop.AllowDrop = true;
            this.lblRAM_Drop.Image = global::QuizAppFixed_WF.Properties.Resources.RAM;
            this.lblRAM_Drop.Location = new System.Drawing.Point(271, 244);
            this.lblRAM_Drop.Name = "lblRAM_Drop";
            this.lblRAM_Drop.Size = new System.Drawing.Size(160, 195);
            this.lblRAM_Drop.TabIndex = 21;
            this.lblRAM_Drop.Click += new System.EventHandler(this.lblRAM_Drop_Click);
            this.lblRAM_Drop.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblRAM_Drop_DragDrop);
            this.lblRAM_Drop.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblRAM_Drop_DragEnter);
            this.lblRAM_Drop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblRAM_Drop_MouseDown);
            // 
            // lblHDD_Drop
            // 
            this.lblHDD_Drop.AllowDrop = true;
            this.lblHDD_Drop.Image = global::QuizAppFixed_WF.Properties.Resources.HDD;
            this.lblHDD_Drop.Location = new System.Drawing.Point(601, 244);
            this.lblHDD_Drop.Name = "lblHDD_Drop";
            this.lblHDD_Drop.Size = new System.Drawing.Size(162, 195);
            this.lblHDD_Drop.TabIndex = 20;
            this.lblHDD_Drop.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblHDD_Drop_DragDrop);
            this.lblHDD_Drop.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblHDD_Drop_DragEnter);
            this.lblHDD_Drop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblHDD_Drop_MouseDown);
            // 
            // lblFloppy_Drop
            // 
            this.lblFloppy_Drop.AllowDrop = true;
            this.lblFloppy_Drop.Image = global::QuizAppFixed_WF.Properties.Resources.Floppy;
            this.lblFloppy_Drop.Location = new System.Drawing.Point(603, 12);
            this.lblFloppy_Drop.Name = "lblFloppy_Drop";
            this.lblFloppy_Drop.Size = new System.Drawing.Size(160, 195);
            this.lblFloppy_Drop.TabIndex = 19;
            this.lblFloppy_Drop.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblFloppy_Drop_DragDrop);
            this.lblFloppy_Drop.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblFloppy_Drop_DragEnter);
            this.lblFloppy_Drop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblFloppy_Drop_MouseDown);
            // 
            // lblFan_Drop
            // 
            this.lblFan_Drop.AllowDrop = true;
            this.lblFan_Drop.Image = global::QuizAppFixed_WF.Properties.Resources.Fan;
            this.lblFan_Drop.Location = new System.Drawing.Point(437, 12);
            this.lblFan_Drop.Name = "lblFan_Drop";
            this.lblFan_Drop.Size = new System.Drawing.Size(160, 195);
            this.lblFan_Drop.TabIndex = 18;
            this.lblFan_Drop.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblFan_Drop_DragDrop);
            this.lblFan_Drop.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblFan_Drop_DragEnter);
            this.lblFan_Drop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblFan_Drop_MouseDown);
            // 
            // lblCPU_Drop
            // 
            this.lblCPU_Drop.AllowDrop = true;
            this.lblCPU_Drop.Image = global::QuizAppFixed_WF.Properties.Resources.CPU;
            this.lblCPU_Drop.Location = new System.Drawing.Point(271, 28);
            this.lblCPU_Drop.Name = "lblCPU_Drop";
            this.lblCPU_Drop.Size = new System.Drawing.Size(160, 195);
            this.lblCPU_Drop.TabIndex = 17;
            this.lblCPU_Drop.Click += new System.EventHandler(this.lblCPU_Drop_Click_1);
            this.lblCPU_Drop.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblCPU_Drop_DragDrop);
            this.lblCPU_Drop.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblCPU_Drop_DragEnter);
            this.lblCPU_Drop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblCPU_Drop_MouseDown);
            // 
            // frmLevel1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1069, 673);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlIncorrect);
            this.Controls.Add(this.pnlCorrect);
            this.Controls.Add(this.lblFan);
            this.Controls.Add(this.lblCPU);
            this.Controls.Add(this.lblUSB);
            this.Controls.Add(this.lblHDD);
            this.Controls.Add(this.lblFloppy);
            this.Controls.Add(this.lblRAM);
            this.Controls.Add(this.lblSpacer);
            this.Controls.Add(this.lblUSB_Drop);
            this.Controls.Add(this.lblRAM_Drop);
            this.Controls.Add(this.lblHDD_Drop);
            this.Controls.Add(this.lblFloppy_Drop);
            this.Controls.Add(this.lblFan_Drop);
            this.Controls.Add(this.pnlSide);
            this.Controls.Add(this.lblCPU_Drop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLevel1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlIncorrect.ResumeLayout(false);
            this.pnlIncorrect.PerformLayout();
            this.pnlCorrect.ResumeLayout(false);
            this.pnlCorrect.PerformLayout();
            this.pnlSide.ResumeLayout(false);
            this.pnlSide.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlIncorrect;
        private System.Windows.Forms.Label lblIncorrectCount;
        private System.Windows.Forms.Label lblIncorrect;
        private System.Windows.Forms.Panel pnlCorrect;
        private System.Windows.Forms.Label lblCorrectCount;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Label lblFan;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.Label lblUSB;
        private System.Windows.Forms.Label lblHDD;
        private System.Windows.Forms.Label lblFloppy;
        private System.Windows.Forms.Label lblRAM;
        private System.Windows.Forms.Label lblSpacer;
        private System.Windows.Forms.Label lblUSB_Drop;
        private System.Windows.Forms.Label lblRAM_Drop;
        private System.Windows.Forms.Label lblHDD_Drop;
        private System.Windows.Forms.Label lblFloppy_Drop;
        private System.Windows.Forms.Label lblFan_Drop;
        private System.Windows.Forms.Panel pnlSide;
        private System.Windows.Forms.Label lblCPU_Drop;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuExitButton;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuLogout;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Label lblHelp2;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Button btnQuiz;
        private System.Windows.Forms.LinkLabel lnkHelpDoc;
    }
}
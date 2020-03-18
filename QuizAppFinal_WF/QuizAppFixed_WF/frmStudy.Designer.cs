namespace QuizAppFixed_WF
{
    partial class frmStudy
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
            this.tabStudy = new System.Windows.Forms.TabControl();
            this.ICT = new System.Windows.Forms.TabPage();
            this.lblUSB = new System.Windows.Forms.Label();
            this.lblRAM = new System.Windows.Forms.Label();
            this.lblHDD = new System.Windows.Forms.Label();
            this.lblFloppy = new System.Windows.Forms.Label();
            this.lblFan = new System.Windows.Forms.Label();
            this.lblCPU = new System.Windows.Forms.Label();
            this.ptcUSB = new System.Windows.Forms.PictureBox();
            this.ptcRAM = new System.Windows.Forms.PictureBox();
            this.ptcHDD = new System.Windows.Forms.PictureBox();
            this.ptcFloppy = new System.Windows.Forms.PictureBox();
            this.ptcFan = new System.Windows.Forms.PictureBox();
            this.ptcCPU = new System.Windows.Forms.PictureBox();
            this.Art = new System.Windows.Forms.TabPage();
            this.lblPicasso = new System.Windows.Forms.Label();
            this.lblDali = new System.Windows.Forms.Label();
            this.lblAndyW = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ptcsssss = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.grpLeftSide.SuspendLayout();
            this.tabStudy.SuspendLayout();
            this.ICT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcUSB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcHDD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcFloppy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcFan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcCPU)).BeginInit();
            this.Art.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcsssss)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(936, 24);
            this.menuStrip1.TabIndex = 10;
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
            this.mnuExitButton.Click += new System.EventHandler(this.MnuExitButton_Click);
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
            this.mnuLogout.Click += new System.EventHandler(this.MnuLogout_Click);
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
            this.grpLeftSide.Location = new System.Drawing.Point(-5, -82);
            this.grpLeftSide.Name = "grpLeftSide";
            this.grpLeftSide.Size = new System.Drawing.Size(321, 615);
            this.grpLeftSide.TabIndex = 9;
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
            this.lblHelp.Location = new System.Drawing.Point(18, 534);
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
            this.btnQuiz.Click += new System.EventHandler(this.btnQuiz_Click);
            // 
            // lnkHelpDoc
            // 
            this.lnkHelpDoc.AutoSize = true;
            this.lnkHelpDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkHelpDoc.Location = new System.Drawing.Point(31, 588);
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
            // tabStudy
            // 
            this.tabStudy.Controls.Add(this.ICT);
            this.tabStudy.Controls.Add(this.Art);
            this.tabStudy.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabStudy.Location = new System.Drawing.Point(322, 30);
            this.tabStudy.Name = "tabStudy";
            this.tabStudy.SelectedIndex = 0;
            this.tabStudy.Size = new System.Drawing.Size(614, 538);
            this.tabStudy.TabIndex = 11;
            // 
            // ICT
            // 
            this.ICT.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ICT.Controls.Add(this.lblUSB);
            this.ICT.Controls.Add(this.lblRAM);
            this.ICT.Controls.Add(this.lblHDD);
            this.ICT.Controls.Add(this.lblFloppy);
            this.ICT.Controls.Add(this.lblFan);
            this.ICT.Controls.Add(this.lblCPU);
            this.ICT.Controls.Add(this.ptcUSB);
            this.ICT.Controls.Add(this.ptcRAM);
            this.ICT.Controls.Add(this.ptcHDD);
            this.ICT.Controls.Add(this.ptcFloppy);
            this.ICT.Controls.Add(this.ptcFan);
            this.ICT.Controls.Add(this.ptcCPU);
            this.ICT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ICT.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ICT.Location = new System.Drawing.Point(4, 37);
            this.ICT.Name = "ICT";
            this.ICT.Padding = new System.Windows.Forms.Padding(3);
            this.ICT.Size = new System.Drawing.Size(606, 497);
            this.ICT.TabIndex = 0;
            this.ICT.Text = "ICT";
            this.ICT.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // lblUSB
            // 
            this.lblUSB.AutoSize = true;
            this.lblUSB.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUSB.Location = new System.Drawing.Point(326, 369);
            this.lblUSB.Name = "lblUSB";
            this.lblUSB.Size = new System.Drawing.Size(108, 39);
            this.lblUSB.TabIndex = 11;
            this.lblUSB.Text = "USB =";
            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRAM.Location = new System.Drawing.Point(13, 369);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(120, 39);
            this.lblRAM.TabIndex = 10;
            this.lblRAM.Text = "RAM =";
            // 
            // lblHDD
            // 
            this.lblHDD.AutoSize = true;
            this.lblHDD.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHDD.Location = new System.Drawing.Point(326, 206);
            this.lblHDD.Name = "lblHDD";
            this.lblHDD.Size = new System.Drawing.Size(118, 39);
            this.lblHDD.TabIndex = 9;
            this.lblHDD.Text = "HDD =";
            // 
            // lblFloppy
            // 
            this.lblFloppy.AutoSize = true;
            this.lblFloppy.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFloppy.Location = new System.Drawing.Point(3, 206);
            this.lblFloppy.Name = "lblFloppy";
            this.lblFloppy.Size = new System.Drawing.Size(147, 39);
            this.lblFloppy.TabIndex = 8;
            this.lblFloppy.Text = "Floppy =";
            // 
            // lblFan
            // 
            this.lblFan.AutoSize = true;
            this.lblFan.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFan.Location = new System.Drawing.Point(326, 56);
            this.lblFan.Name = "lblFan";
            this.lblFan.Size = new System.Drawing.Size(100, 39);
            this.lblFan.TabIndex = 7;
            this.lblFan.Text = "Fan =";
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPU.Location = new System.Drawing.Point(13, 56);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(110, 39);
            this.lblCPU.TabIndex = 6;
            this.lblCPU.Text = "CPU =";
            // 
            // ptcUSB
            // 
            this.ptcUSB.Image = global::QuizAppFixed_WF.Properties.Resources.USB;
            this.ptcUSB.Location = new System.Drawing.Point(457, 302);
            this.ptcUSB.Name = "ptcUSB";
            this.ptcUSB.Size = new System.Drawing.Size(142, 164);
            this.ptcUSB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptcUSB.TabIndex = 5;
            this.ptcUSB.TabStop = false;
            // 
            // ptcRAM
            // 
            this.ptcRAM.Image = global::QuizAppFixed_WF.Properties.Resources.RAM;
            this.ptcRAM.Location = new System.Drawing.Point(156, 302);
            this.ptcRAM.Name = "ptcRAM";
            this.ptcRAM.Size = new System.Drawing.Size(142, 164);
            this.ptcRAM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptcRAM.TabIndex = 4;
            this.ptcRAM.TabStop = false;
            // 
            // ptcHDD
            // 
            this.ptcHDD.Image = global::QuizAppFixed_WF.Properties.Resources.HDD;
            this.ptcHDD.Location = new System.Drawing.Point(457, 155);
            this.ptcHDD.Name = "ptcHDD";
            this.ptcHDD.Size = new System.Drawing.Size(149, 149);
            this.ptcHDD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptcHDD.TabIndex = 3;
            this.ptcHDD.TabStop = false;
            // 
            // ptcFloppy
            // 
            this.ptcFloppy.Image = global::QuizAppFixed_WF.Properties.Resources.Floppy;
            this.ptcFloppy.Location = new System.Drawing.Point(156, 155);
            this.ptcFloppy.Name = "ptcFloppy";
            this.ptcFloppy.Size = new System.Drawing.Size(142, 149);
            this.ptcFloppy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptcFloppy.TabIndex = 2;
            this.ptcFloppy.TabStop = false;
            this.ptcFloppy.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // ptcFan
            // 
            this.ptcFan.Image = global::QuizAppFixed_WF.Properties.Resources.Fan;
            this.ptcFan.Location = new System.Drawing.Point(457, 6);
            this.ptcFan.Name = "ptcFan";
            this.ptcFan.Size = new System.Drawing.Size(149, 149);
            this.ptcFan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptcFan.TabIndex = 1;
            this.ptcFan.TabStop = false;
            // 
            // ptcCPU
            // 
            this.ptcCPU.Image = global::QuizAppFixed_WF.Properties.Resources.CPU;
            this.ptcCPU.Location = new System.Drawing.Point(156, 6);
            this.ptcCPU.Name = "ptcCPU";
            this.ptcCPU.Size = new System.Drawing.Size(142, 149);
            this.ptcCPU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptcCPU.TabIndex = 0;
            this.ptcCPU.TabStop = false;
            // 
            // Art
            // 
            this.Art.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Art.Controls.Add(this.lblPicasso);
            this.Art.Controls.Add(this.lblDali);
            this.Art.Controls.Add(this.lblAndyW);
            this.Art.Controls.Add(this.pictureBox5);
            this.Art.Controls.Add(this.pictureBox4);
            this.Art.Controls.Add(this.pictureBox3);
            this.Art.Controls.Add(this.pictureBox2);
            this.Art.Controls.Add(this.pictureBox1);
            this.Art.Controls.Add(this.ptcsssss);
            this.Art.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Art.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Art.Location = new System.Drawing.Point(4, 37);
            this.Art.Name = "Art";
            this.Art.Padding = new System.Windows.Forms.Padding(3);
            this.Art.Size = new System.Drawing.Size(606, 497);
            this.Art.TabIndex = 1;
            this.Art.Text = "Art";
            // 
            // lblPicasso
            // 
            this.lblPicasso.AutoSize = true;
            this.lblPicasso.Location = new System.Drawing.Point(89, 377);
            this.lblPicasso.Name = "lblPicasso";
            this.lblPicasso.Size = new System.Drawing.Size(95, 28);
            this.lblPicasso.TabIndex = 8;
            this.lblPicasso.Text = "Picasso:";
            // 
            // lblDali
            // 
            this.lblDali.AutoSize = true;
            this.lblDali.Location = new System.Drawing.Point(27, 237);
            this.lblDali.Name = "lblDali";
            this.lblDali.Size = new System.Drawing.Size(157, 28);
            this.lblDali.TabIndex = 7;
            this.lblDali.Text = "Salvador Dalí:";
            // 
            // lblAndyW
            // 
            this.lblAndyW.AutoSize = true;
            this.lblAndyW.Location = new System.Drawing.Point(26, 85);
            this.lblAndyW.Name = "lblAndyW";
            this.lblAndyW.Size = new System.Drawing.Size(158, 28);
            this.lblAndyW.TabIndex = 6;
            this.lblAndyW.Text = "Andy Warhol:";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::QuizAppFixed_WF.Properties.Resources.picasso2;
            this.pictureBox5.Location = new System.Drawing.Point(383, 332);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(148, 134);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::QuizAppFixed_WF.Properties.Resources.picasso1;
            this.pictureBox4.Location = new System.Drawing.Point(211, 332);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(148, 134);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::QuizAppFixed_WF.Properties.Resources.dali2;
            this.pictureBox3.Location = new System.Drawing.Point(383, 173);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(148, 134);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QuizAppFixed_WF.Properties.Resources.dali1;
            this.pictureBox2.Location = new System.Drawing.Point(211, 173);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(148, 134);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuizAppFixed_WF.Properties.Resources.AndyWothol2;
            this.pictureBox1.Location = new System.Drawing.Point(383, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ptcsssss
            // 
            this.ptcsssss.Image = global::QuizAppFixed_WF.Properties.Resources.AndyWothol1;
            this.ptcsssss.Location = new System.Drawing.Point(211, 21);
            this.ptcsssss.Name = "ptcsssss";
            this.ptcsssss.Size = new System.Drawing.Size(148, 134);
            this.ptcsssss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptcsssss.TabIndex = 0;
            this.ptcsssss.TabStop = false;
            // 
            // frmStudy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(936, 534);
            this.Controls.Add(this.tabStudy);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.grpLeftSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStudy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStudy";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpLeftSide.ResumeLayout(false);
            this.grpLeftSide.PerformLayout();
            this.tabStudy.ResumeLayout(false);
            this.ICT.ResumeLayout(false);
            this.ICT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcUSB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcHDD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcFloppy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcFan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcCPU)).EndInit();
            this.Art.ResumeLayout(false);
            this.Art.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcsssss)).EndInit();
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
        private System.Windows.Forms.TabControl tabStudy;
        private System.Windows.Forms.TabPage ICT;
        private System.Windows.Forms.TabPage Art;
        private System.Windows.Forms.PictureBox ptcUSB;
        private System.Windows.Forms.PictureBox ptcRAM;
        private System.Windows.Forms.PictureBox ptcHDD;
        private System.Windows.Forms.PictureBox ptcFloppy;
        private System.Windows.Forms.PictureBox ptcFan;
        private System.Windows.Forms.PictureBox ptcCPU;
        private System.Windows.Forms.Label lblUSB;
        private System.Windows.Forms.Label lblRAM;
        private System.Windows.Forms.Label lblHDD;
        private System.Windows.Forms.Label lblFloppy;
        private System.Windows.Forms.Label lblFan;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.Label lblPicasso;
        private System.Windows.Forms.Label lblDali;
        private System.Windows.Forms.Label lblAndyW;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ptcsssss;
    }
}
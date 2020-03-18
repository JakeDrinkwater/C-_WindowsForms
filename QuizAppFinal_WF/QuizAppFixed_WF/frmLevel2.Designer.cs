namespace QuizAppFixed_WF
{
    partial class frmLevel2
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
            this.lblSpacer = new System.Windows.Forms.Label();
            this.pnlIncorrect = new System.Windows.Forms.Panel();
            this.lblIncorrectCount = new System.Windows.Forms.Label();
            this.lblIncorrect = new System.Windows.Forms.Label();
            this.pnlCorrect = new System.Windows.Forms.Panel();
            this.lblCorrectCount = new System.Windows.Forms.Label();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.lblPicasso = new System.Windows.Forms.Label();
            this.lblSalvador = new System.Windows.Forms.Label();
            this.lblWorhol = new System.Windows.Forms.Label();
            this.lblPic2 = new System.Windows.Forms.Label();
            this.lblDali2_Drop = new System.Windows.Forms.Label();
            this.lblDali1_Drop = new System.Windows.Forms.Label();
            this.lblAndy2_Drop = new System.Windows.Forms.Label();
            this.lblPic1_Drop = new System.Windows.Forms.Label();
            this.lblWorhol1_Drop = new System.Windows.Forms.Label();
            this.pnlSide.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnlIncorrect.SuspendLayout();
            this.pnlCorrect.SuspendLayout();
            this.SuspendLayout();
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
            this.pnlSide.Size = new System.Drawing.Size(265, 661);
            this.pnlSide.TabIndex = 17;
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
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // lblHelp2
            // 
            this.lblHelp2.AutoSize = true;
            this.lblHelp2.BackColor = System.Drawing.Color.Aquamarine;
            this.lblHelp2.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelp2.Location = new System.Drawing.Point(12, 16);
            this.lblHelp2.Name = "lblHelp2";
            this.lblHelp2.Size = new System.Drawing.Size(175, 32);
            this.lblHelp2.TabIndex = 16;
            this.lblHelp2.Text = "^ If you want to log out or exit, \r\nclick on these!";
            this.lblHelp2.Click += new System.EventHandler(this.lblHelp2_Click);
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelp.Location = new System.Drawing.Point(11, 562);
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
            this.lnkHelpDoc.Location = new System.Drawing.Point(3, 616);
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
            this.menuStrip1.TabIndex = 33;
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
            this.mnuExitButton.Click += new System.EventHandler(this.mnuExitButton_Click_1);
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
            this.mnuLogout.Click += new System.EventHandler(this.mnuLogout_Click_1);
            // 
            // lblSpacer
            // 
            this.lblSpacer.AutoSize = true;
            this.lblSpacer.Location = new System.Drawing.Point(271, 473);
            this.lblSpacer.Name = "lblSpacer";
            this.lblSpacer.Size = new System.Drawing.Size(721, 39);
            this.lblSpacer.TabIndex = 34;
            this.lblSpacer.Text = "_________________________________________________________________________________" +
    "______________________________________\r\n\r\n\r\n";
            // 
            // pnlIncorrect
            // 
            this.pnlIncorrect.BackColor = System.Drawing.Color.Aquamarine;
            this.pnlIncorrect.Controls.Add(this.lblIncorrectCount);
            this.pnlIncorrect.Controls.Add(this.lblIncorrect);
            this.pnlIncorrect.Location = new System.Drawing.Point(854, 530);
            this.pnlIncorrect.Name = "pnlIncorrect";
            this.pnlIncorrect.Size = new System.Drawing.Size(166, 126);
            this.pnlIncorrect.TabIndex = 42;
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
            this.pnlCorrect.Location = new System.Drawing.Point(677, 530);
            this.pnlCorrect.Name = "pnlCorrect";
            this.pnlCorrect.Size = new System.Drawing.Size(166, 126);
            this.pnlCorrect.TabIndex = 41;
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
            // lblPicasso
            // 
            this.lblPicasso.AutoSize = true;
            this.lblPicasso.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPicasso.Location = new System.Drawing.Point(286, 558);
            this.lblPicasso.Name = "lblPicasso";
            this.lblPicasso.Size = new System.Drawing.Size(148, 46);
            this.lblPicasso.TabIndex = 36;
            this.lblPicasso.Text = "Picasso";
            this.lblPicasso.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblPicasso_MouseDown);
            // 
            // lblSalvador
            // 
            this.lblSalvador.AutoSize = true;
            this.lblSalvador.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalvador.Location = new System.Drawing.Point(286, 512);
            this.lblSalvador.Name = "lblSalvador";
            this.lblSalvador.Size = new System.Drawing.Size(250, 46);
            this.lblSalvador.TabIndex = 35;
            this.lblSalvador.Text = "Salvador Dalí";
            this.lblSalvador.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblSalvador_MouseDown);
            // 
            // lblWorhol
            // 
            this.lblWorhol.AutoSize = true;
            this.lblWorhol.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorhol.Location = new System.Drawing.Point(285, 604);
            this.lblWorhol.Name = "lblWorhol";
            this.lblWorhol.Size = new System.Drawing.Size(251, 46);
            this.lblWorhol.TabIndex = 43;
            this.lblWorhol.Text = "Andy Warhol";
            this.lblWorhol.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblWorhol_MouseDown);
            // 
            // lblPic2
            // 
            this.lblPic2.AllowDrop = true;
            this.lblPic2.Image = global::QuizAppFixed_WF.Properties.Resources.picasso2;
            this.lblPic2.Location = new System.Drawing.Point(683, 238);
            this.lblPic2.Name = "lblPic2";
            this.lblPic2.Size = new System.Drawing.Size(195, 196);
            this.lblPic2.TabIndex = 49;
            this.lblPic2.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblPic2_DragDrop);
            this.lblPic2.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblPic2_DragEnter);
            // 
            // lblDali2_Drop
            // 
            this.lblDali2_Drop.AllowDrop = true;
            this.lblDali2_Drop.Image = global::QuizAppFixed_WF.Properties.Resources.dali2;
            this.lblDali2_Drop.Location = new System.Drawing.Point(482, 238);
            this.lblDali2_Drop.Name = "lblDali2_Drop";
            this.lblDali2_Drop.Size = new System.Drawing.Size(195, 196);
            this.lblDali2_Drop.TabIndex = 48;
            this.lblDali2_Drop.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblDali2_Drop_DragDrop);
            this.lblDali2_Drop.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblDali2_Drop_DragEnter);
            // 
            // lblDali1_Drop
            // 
            this.lblDali1_Drop.AllowDrop = true;
            this.lblDali1_Drop.Image = global::QuizAppFixed_WF.Properties.Resources.dali1;
            this.lblDali1_Drop.Location = new System.Drawing.Point(281, 238);
            this.lblDali1_Drop.Name = "lblDali1_Drop";
            this.lblDali1_Drop.Size = new System.Drawing.Size(195, 196);
            this.lblDali1_Drop.TabIndex = 47;
            this.lblDali1_Drop.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblDali1_Drop_DragDrop);
            this.lblDali1_Drop.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblDali1_Drop_DragEnter);
            // 
            // lblAndy2_Drop
            // 
            this.lblAndy2_Drop.AllowDrop = true;
            this.lblAndy2_Drop.Image = global::QuizAppFixed_WF.Properties.Resources.AndyWothol2;
            this.lblAndy2_Drop.Location = new System.Drawing.Point(683, 28);
            this.lblAndy2_Drop.Name = "lblAndy2_Drop";
            this.lblAndy2_Drop.Size = new System.Drawing.Size(195, 196);
            this.lblAndy2_Drop.TabIndex = 46;
            this.lblAndy2_Drop.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblAndy2_Drop_DragDrop);
            this.lblAndy2_Drop.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblAndy2_Drop_DragEnter);
            // 
            // lblPic1_Drop
            // 
            this.lblPic1_Drop.AllowDrop = true;
            this.lblPic1_Drop.Image = global::QuizAppFixed_WF.Properties.Resources.picasso1;
            this.lblPic1_Drop.Location = new System.Drawing.Point(482, 28);
            this.lblPic1_Drop.Name = "lblPic1_Drop";
            this.lblPic1_Drop.Size = new System.Drawing.Size(195, 196);
            this.lblPic1_Drop.TabIndex = 45;
            this.lblPic1_Drop.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblPic1_Drop_DragDrop);
            this.lblPic1_Drop.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblPic1_Drop_DragEnter);
            // 
            // lblWorhol1_Drop
            // 
            this.lblWorhol1_Drop.AllowDrop = true;
            this.lblWorhol1_Drop.Image = global::QuizAppFixed_WF.Properties.Resources.AndyWothol1;
            this.lblWorhol1_Drop.Location = new System.Drawing.Point(281, 27);
            this.lblWorhol1_Drop.Name = "lblWorhol1_Drop";
            this.lblWorhol1_Drop.Size = new System.Drawing.Size(195, 196);
            this.lblWorhol1_Drop.TabIndex = 44;
            this.lblWorhol1_Drop.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblWorhol1_Drop_DragDrop);
            this.lblWorhol1_Drop.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblWorhol1_Drop_DragEnter);
            // 
            // frmLevel2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1069, 673);
            this.Controls.Add(this.lblPic2);
            this.Controls.Add(this.lblDali2_Drop);
            this.Controls.Add(this.lblDali1_Drop);
            this.Controls.Add(this.lblAndy2_Drop);
            this.Controls.Add(this.lblPic1_Drop);
            this.Controls.Add(this.lblWorhol1_Drop);
            this.Controls.Add(this.lblWorhol);
            this.Controls.Add(this.pnlIncorrect);
            this.Controls.Add(this.pnlCorrect);
            this.Controls.Add(this.lblPicasso);
            this.Controls.Add(this.lblSalvador);
            this.Controls.Add(this.lblSpacer);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLevel2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLevel2";
            this.pnlSide.ResumeLayout(false);
            this.pnlSide.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlIncorrect.ResumeLayout(false);
            this.pnlIncorrect.PerformLayout();
            this.pnlCorrect.ResumeLayout(false);
            this.pnlCorrect.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSide;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Label lblHelp2;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Button btnQuiz;
        private System.Windows.Forms.LinkLabel lnkHelpDoc;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuExitButton;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuLogout;
        private System.Windows.Forms.Label lblSpacer;
        private System.Windows.Forms.Panel pnlIncorrect;
        private System.Windows.Forms.Label lblIncorrectCount;
        private System.Windows.Forms.Label lblIncorrect;
        private System.Windows.Forms.Panel pnlCorrect;
        private System.Windows.Forms.Label lblCorrectCount;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Label lblPicasso;
        private System.Windows.Forms.Label lblSalvador;
        private System.Windows.Forms.Label lblWorhol;
        private System.Windows.Forms.Label lblWorhol1_Drop;
        private System.Windows.Forms.Label lblPic1_Drop;
        private System.Windows.Forms.Label lblAndy2_Drop;
        private System.Windows.Forms.Label lblDali1_Drop;
        private System.Windows.Forms.Label lblDali2_Drop;
        private System.Windows.Forms.Label lblPic2;
    }
}
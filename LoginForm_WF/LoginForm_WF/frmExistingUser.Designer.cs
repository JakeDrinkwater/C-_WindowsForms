﻿namespace LoginForm_WF
{
    partial class frmExistingUser
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
            this.grpBanner = new System.Windows.Forms.GroupBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.grpBanner.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 380);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(229, 58);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpBanner
            // 
            this.grpBanner.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grpBanner.Controls.Add(this.lblTitle);
            this.grpBanner.Location = new System.Drawing.Point(-6, -4);
            this.grpBanner.Name = "grpBanner";
            this.grpBanner.Size = new System.Drawing.Size(819, 104);
            this.grpBanner.TabIndex = 6;
            this.grpBanner.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(286, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(247, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Existing User";
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(559, 380);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(229, 58);
            this.btnHome.TabIndex = 7;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(283, 267);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(229, 58);
            this.btnEnter.TabIndex = 15;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(228, 204);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(344, 20);
            this.txtSurname.TabIndex = 14;
            this.txtSurname.Text = "Surname";
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(228, 126);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(344, 20);
            this.txtForename.TabIndex = 13;
            this.txtForename.Text = "Forename";
            // 
            // txtTest
            // 
            this.txtTest.Location = new System.Drawing.Point(46, 204);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(100, 20);
            this.txtTest.TabIndex = 16;
            // 
            // frmExistingUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtForename);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.grpBanner);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmExistingUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmExistingUser";
            this.grpBanner.ResumeLayout(false);
            this.grpBanner.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpBanner;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.TextBox txtTest;
    }
}
namespace MessagSpammer_WF
{
    partial class frmMessageSpammer
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
            this.lblUname = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUEnter = new System.Windows.Forms.TextBox();
            this.txtPWEnter = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.ptcUserProfile = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcUserProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUname
            // 
            this.lblUname.AutoSize = true;
            this.lblUname.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblUname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUname.Location = new System.Drawing.Point(152, 228);
            this.lblUname.Name = "lblUname";
            this.lblUname.Size = new System.Drawing.Size(125, 25);
            this.lblUname.TabIndex = 0;
            this.lblUname.Text = "Username:";
            this.lblUname.Click += new System.EventHandler(this.LblUname_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(156, 304);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(121, 25);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password:";
            this.lblPassword.Click += new System.EventHandler(this.LblPassword_Click);
            // 
            // txtUEnter
            // 
            this.txtUEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUEnter.Location = new System.Drawing.Point(318, 225);
            this.txtUEnter.Name = "txtUEnter";
            this.txtUEnter.Size = new System.Drawing.Size(257, 31);
            this.txtUEnter.TabIndex = 2;
            this.txtUEnter.Text = "p";
            this.txtUEnter.TextChanged += new System.EventHandler(this.TxtUEnter_TextChanged);
            // 
            // txtPWEnter
            // 
            this.txtPWEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPWEnter.Location = new System.Drawing.Point(318, 301);
            this.txtPWEnter.Name = "txtPWEnter";
            this.txtPWEnter.PasswordChar = '*';
            this.txtPWEnter.Size = new System.Drawing.Size(257, 31);
            this.txtPWEnter.TabIndex = 3;
            this.txtPWEnter.Text = "p";
            this.txtPWEnter.TextChanged += new System.EventHandler(this.TxtPWEnter_TextChanged);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(318, 368);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(96, 43);
            this.btnEnter.TabIndex = 5;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(479, 368);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 43);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // ptcUserProfile
            // 
            this.ptcUserProfile.Image = global::MessagSpammer_WF.Properties.Resources.profilePicture;
            this.ptcUserProfile.Location = new System.Drawing.Point(337, 12);
            this.ptcUserProfile.Name = "ptcUserProfile";
            this.ptcUserProfile.Size = new System.Drawing.Size(224, 186);
            this.ptcUserProfile.TabIndex = 4;
            this.ptcUserProfile.TabStop = false;
            this.ptcUserProfile.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // frmMessageSpammer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.ptcUserProfile);
            this.Controls.Add(this.txtPWEnter);
            this.Controls.Add(this.txtUEnter);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUname);
            this.Name = "frmMessageSpammer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMessageSpammer";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcUserProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUname;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUEnter;
        private System.Windows.Forms.TextBox txtPWEnter;
        private System.Windows.Forms.PictureBox ptcUserProfile;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnClose;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}


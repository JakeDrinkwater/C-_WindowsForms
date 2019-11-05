namespace LibrarySystem_WF
{
    partial class frmTemplate
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
            this.pnlBig = new System.Windows.Forms.Panel();
            this.pnlSmall = new System.Windows.Forms.Panel();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnAddBooks = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlBig.SuspendLayout();
            this.pnlSmall.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBig
            // 
            this.pnlBig.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlBig.Controls.Add(this.btnExit);
            this.pnlBig.Controls.Add(this.btnAddBooks);
            this.pnlBig.Controls.Add(this.btnMainMenu);
            this.pnlBig.Location = new System.Drawing.Point(12, 12);
            this.pnlBig.Name = "pnlBig";
            this.pnlBig.Size = new System.Drawing.Size(200, 426);
            this.pnlBig.TabIndex = 0;
            // 
            // pnlSmall
            // 
            this.pnlSmall.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlSmall.Controls.Add(this.lblLogo);
            this.pnlSmall.Location = new System.Drawing.Point(12, 12);
            this.pnlSmall.Name = "pnlSmall";
            this.pnlSmall.Size = new System.Drawing.Size(200, 100);
            this.pnlSmall.TabIndex = 0;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.FlatAppearance.BorderSize = 0;
            this.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMainMenu.Location = new System.Drawing.Point(3, 106);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(194, 44);
            this.btnMainMenu.TabIndex = 0;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.BtnMainMenu_Click);
            // 
            // btnAddBooks
            // 
            this.btnAddBooks.FlatAppearance.BorderSize = 0;
            this.btnAddBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBooks.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddBooks.Location = new System.Drawing.Point(6, 188);
            this.btnAddBooks.Name = "btnAddBooks";
            this.btnAddBooks.Size = new System.Drawing.Size(194, 44);
            this.btnAddBooks.TabIndex = 1;
            this.btnAddBooks.Text = "Add books";
            this.btnAddBooks.UseVisualStyleBackColor = true;
            this.btnAddBooks.Click += new System.EventHandler(this.BtnAddBooks_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExit.Location = new System.Drawing.Point(3, 267);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(194, 44);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLogo.Location = new System.Drawing.Point(50, 47);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(102, 18);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "SERC Library";
            // 
            // frmTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlSmall);
            this.Controls.Add(this.pnlBig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTemplate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTemplate";
            this.pnlBig.ResumeLayout(false);
            this.pnlSmall.ResumeLayout(false);
            this.pnlSmall.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBig;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddBooks;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Panel pnlSmall;
        private System.Windows.Forms.Label lblLogo;
    }
}


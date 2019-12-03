namespace pizzaOrders_WF
{
    partial class frmMainMenu
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
            this.pnlOne = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.pnlTwo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ptcLogo = new System.Windows.Forms.PictureBox();
            this.rchAddress = new System.Windows.Forms.RichTextBox();
            this.pnlOne.SuspendLayout();
            this.pnlTwo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlOne
            // 
            this.pnlOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlOne.Controls.Add(this.btnExit);
            this.pnlOne.Controls.Add(this.btnMainMenu);
            this.pnlOne.Controls.Add(this.btnOrderPizza);
            this.pnlOne.Controls.Add(this.pnlTwo);
            this.pnlOne.Location = new System.Drawing.Point(0, 0);
            this.pnlOne.Name = "pnlOne";
            this.pnlOne.Size = new System.Drawing.Size(211, 505);
            this.pnlOne.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(3, 440);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(205, 37);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.FlatAppearance.BorderSize = 0;
            this.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainMenu.Location = new System.Drawing.Point(3, 165);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(205, 55);
            this.btnMainMenu.TabIndex = 1;
            this.btnMainMenu.Text = "MainMenu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.BtnMainMenu_Click);
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.FlatAppearance.BorderSize = 0;
            this.btnOrderPizza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderPizza.Location = new System.Drawing.Point(3, 247);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(205, 55);
            this.btnOrderPizza.TabIndex = 2;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = true;
            this.btnOrderPizza.Click += new System.EventHandler(this.BtnOrderPizza_Click);
            // 
            // pnlTwo
            // 
            this.pnlTwo.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.pnlTwo.Controls.Add(this.label1);
            this.pnlTwo.Location = new System.Drawing.Point(-1, 0);
            this.pnlTwo.Name = "pnlTwo";
            this.pnlTwo.Size = new System.Drawing.Size(212, 103);
            this.pnlTwo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "LoGo";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // ptcLogo
            // 
            this.ptcLogo.Image = global::pizzaOrders_WF.Properties.Resources.Fast_Pizza_Logo_01;
            this.ptcLogo.Location = new System.Drawing.Point(217, 37);
            this.ptcLogo.Name = "ptcLogo";
            this.ptcLogo.Size = new System.Drawing.Size(430, 428);
            this.ptcLogo.TabIndex = 1;
            this.ptcLogo.TabStop = false;
            this.ptcLogo.Click += new System.EventHandler(this.PtcLogo_Click);
            // 
            // rchAddress
            // 
            this.rchAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rchAddress.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchAddress.Location = new System.Drawing.Point(677, 152);
            this.rchAddress.Name = "rchAddress";
            this.rchAddress.ReadOnly = true;
            this.rchAddress.Size = new System.Drawing.Size(372, 313);
            this.rchAddress.TabIndex = 2;
            this.rchAddress.Text = "Address: 53 High St, Bangor BT20 5BE\n\nHours: 9AM - 5PM \n\nPhone: 028 9185 9780\n\nOr" +
    "der: just-eat.co.uk";
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 501);
            this.Controls.Add(this.rchAddress);
            this.Controls.Add(this.ptcLogo);
            this.Controls.Add(this.pnlOne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTemplate";
            this.pnlOne.ResumeLayout(false);
            this.pnlTwo.ResumeLayout(false);
            this.pnlTwo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOne;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Panel pnlTwo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptcLogo;
        private System.Windows.Forms.RichTextBox rchAddress;
    }
}


namespace Hello_WF
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
            this.components = new System.ComponentModel.Container();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClickMe = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnClose.Location = new System.Drawing.Point(414, 163);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 22);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnClickMe
            // 
            this.btnClickMe.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnClickMe.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Italic);
            this.btnClickMe.Location = new System.Drawing.Point(165, 88);
            this.btnClickMe.Name = "btnClickMe";
            this.btnClickMe.Size = new System.Drawing.Size(144, 60);
            this.btnClickMe.TabIndex = 4;
            this.btnClickMe.Text = "Click me ;)";
            this.btnClickMe.UseVisualStyleBackColor = false;
            this.btnClickMe.Click += new System.EventHandler(this.BtnClickMe_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Italic);
            this.lblTitle.Location = new System.Drawing.Point(37, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(411, 38);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Hello World ~ Jake Drinkwater";
            this.lblTitle.Click += new System.EventHandler(this.LblTitle_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 184);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClickMe);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClickMe;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}


namespace MessagSpammer_WF
{
    partial class frmSpammer
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
            this.grpEnterDetails = new System.Windows.Forms.GroupBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lblRun = new System.Windows.Forms.Label();
            this.txtRun = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lstMessage = new System.Windows.Forms.ListBox();
            this.grpEnterDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpEnterDetails
            // 
            this.grpEnterDetails.Controls.Add(this.txtRun);
            this.grpEnterDetails.Controls.Add(this.lblRun);
            this.grpEnterDetails.Controls.Add(this.txtMessage);
            this.grpEnterDetails.Controls.Add(this.lblMessage);
            this.grpEnterDetails.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEnterDetails.Location = new System.Drawing.Point(12, 12);
            this.grpEnterDetails.Name = "grpEnterDetails";
            this.grpEnterDetails.Size = new System.Drawing.Size(373, 237);
            this.grpEnterDetails.TabIndex = 0;
            this.grpEnterDetails.TabStop = false;
            this.grpEnterDetails.Text = "dAnGeR zOnE";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(6, 34);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(121, 21);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Enter message:";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(10, 57);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(233, 28);
            this.txtMessage.TabIndex = 1;
            // 
            // lblRun
            // 
            this.lblRun.AutoSize = true;
            this.lblRun.Location = new System.Drawing.Point(6, 126);
            this.lblRun.Name = "lblRun";
            this.lblRun.Size = new System.Drawing.Size(156, 21);
            this.lblRun.TabIndex = 2;
            this.lblRun.Text = "How many times? ;)";
            this.lblRun.Click += new System.EventHandler(this.LblRun_Click);
            // 
            // txtRun
            // 
            this.txtRun.Location = new System.Drawing.Point(10, 150);
            this.txtRun.Name = "txtRun";
            this.txtRun.Size = new System.Drawing.Size(233, 28);
            this.txtRun.TabIndex = 3;
            this.txtRun.TextChanged += new System.EventHandler(this.TxtRun_TextChanged);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(12, 255);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(185, 46);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(203, 255);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(182, 46);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(12, 307);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(373, 46);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.Button3_Click);
            // 
            // lstMessage
            // 
            this.lstMessage.FormattingEnabled = true;
            this.lstMessage.Location = new System.Drawing.Point(432, 23);
            this.lstMessage.Name = "lstMessage";
            this.lstMessage.Size = new System.Drawing.Size(243, 225);
            this.lstMessage.TabIndex = 7;
            // 
            // frmSpammer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 365);
            this.Controls.Add(this.lstMessage);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.grpEnterDetails);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRun);
            this.Name = "frmSpammer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSpammer";
            this.grpEnterDetails.ResumeLayout(false);
            this.grpEnterDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEnterDetails;
        private System.Windows.Forms.TextBox txtRun;
        private System.Windows.Forms.Label lblRun;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.ListBox lstMessage;
    }
}
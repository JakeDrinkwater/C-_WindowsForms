namespace LibrarySystem_WF
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
            this.rtbSERCDetails = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbSERCDetails
            // 
            this.rtbSERCDetails.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbSERCDetails.Location = new System.Drawing.Point(279, 324);
            this.rtbSERCDetails.Name = "rtbSERCDetails";
            this.rtbSERCDetails.Size = new System.Drawing.Size(373, 114);
            this.rtbSERCDetails.TabIndex = 4;
            this.rtbSERCDetails.Text = "Name: SERC Bangor Campus\n\nAddress: Castle Park Rd, Bangor BT20 4TD\n\nPhone number:" +
    " +44 345 600 7555\n\nE-mail:  info@serc.ac.uk \n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(279, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(373, 282);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rtbSERCDetails);
            this.Name = "frmMainMenu";
            this.Text = "frmMainMenu";
            this.Controls.SetChildIndex(this.rtbSERCDetails, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbSERCDetails;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
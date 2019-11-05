namespace LibrarySystem_WF
{
    partial class frmAddBooks
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
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lstBooks = new System.Windows.Forms.ListBox();
            this.btnBookView = new System.Windows.Forms.Button();
            this.grpEnterDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpEnterDetails
            // 
            this.grpEnterDetails.Controls.Add(this.txtPrice);
            this.grpEnterDetails.Controls.Add(this.lblPrice);
            this.grpEnterDetails.Controls.Add(this.txtISBN);
            this.grpEnterDetails.Controls.Add(this.lblISBN);
            this.grpEnterDetails.Controls.Add(this.txtTitle);
            this.grpEnterDetails.Controls.Add(this.lblTitle);
            this.grpEnterDetails.Controls.Add(this.txtAuthor);
            this.grpEnterDetails.Controls.Add(this.lblAuthor);
            this.grpEnterDetails.Location = new System.Drawing.Point(249, 13);
            this.grpEnterDetails.Name = "grpEnterDetails";
            this.grpEnterDetails.Size = new System.Drawing.Size(237, 277);
            this.grpEnterDetails.TabIndex = 1;
            this.grpEnterDetails.TabStop = false;
            this.grpEnterDetails.Text = "Enter details";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(6, 46);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(41, 13);
            this.lblAuthor.TabIndex = 0;
            this.lblAuthor.Text = "Author:";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(9, 63);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(100, 20);
            this.txtAuthor.TabIndex = 1;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(9, 122);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(6, 105);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title:";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(9, 177);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(100, 20);
            this.txtISBN.TabIndex = 5;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(6, 161);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(35, 13);
            this.lblISBN.TabIndex = 4;
            this.lblISBN.Text = "ISBN:";
            this.lblISBN.Click += new System.EventHandler(this.Label1_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(9, 235);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 7;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(6, 218);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Price:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(249, 296);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 35);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(373, 296);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(113, 35);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // lstBooks
            // 
            this.lstBooks.FormattingEnabled = true;
            this.lstBooks.Location = new System.Drawing.Point(529, 13);
            this.lstBooks.Name = "lstBooks";
            this.lstBooks.Size = new System.Drawing.Size(246, 277);
            this.lstBooks.TabIndex = 4;
            this.lstBooks.SelectedIndexChanged += new System.EventHandler(this.LstBooks_SelectedIndexChanged);
            // 
            // btnBookView
            // 
            this.btnBookView.Location = new System.Drawing.Point(529, 296);
            this.btnBookView.Name = "btnBookView";
            this.btnBookView.Size = new System.Drawing.Size(246, 35);
            this.btnBookView.TabIndex = 5;
            this.btnBookView.Text = "View Books";
            this.btnBookView.UseVisualStyleBackColor = true;
            this.btnBookView.Click += new System.EventHandler(this.BtnBookView_Click);
            // 
            // frmAddBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBookView);
            this.Controls.Add(this.lstBooks);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpEnterDetails);
            this.Name = "frmAddBooks";
            this.Text = "frmAddBooks";
            this.Controls.SetChildIndex(this.grpEnterDetails, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnClear, 0);
            this.Controls.SetChildIndex(this.lstBooks, 0);
            this.Controls.SetChildIndex(this.btnBookView, 0);
            this.grpEnterDetails.ResumeLayout(false);
            this.grpEnterDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEnterDetails;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox lstBooks;
        private System.Windows.Forms.Button btnBookView;
    }
}
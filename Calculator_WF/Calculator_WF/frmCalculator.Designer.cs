namespace Calculator_WF
{
    partial class frmCalculator
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
            this.lblCalculatorTitle = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubt = new System.Windows.Forms.Button();
            this.btnMultip = new System.Windows.Forms.Button();
            this.btnDivid = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblno2 = new System.Windows.Forms.Label();
            this.lblNo1 = new System.Windows.Forms.Label();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAnswerBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCalculatorTitle
            // 
            this.lblCalculatorTitle.AutoSize = true;
            this.lblCalculatorTitle.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblCalculatorTitle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblCalculatorTitle.Location = new System.Drawing.Point(54, 9);
            this.lblCalculatorTitle.Name = "lblCalculatorTitle";
            this.lblCalculatorTitle.Size = new System.Drawing.Size(218, 16);
            this.lblCalculatorTitle.TabIndex = 0;
            this.lblCalculatorTitle.Text = "Calculator - Jake Drinkwater";
            this.lblCalculatorTitle.Click += new System.EventHandler(this.LblCalculatorTitle_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 253);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(51, 47);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnSubt
            // 
            this.btnSubt.Location = new System.Drawing.Point(84, 253);
            this.btnSubt.Name = "btnSubt";
            this.btnSubt.Size = new System.Drawing.Size(54, 47);
            this.btnSubt.TabIndex = 4;
            this.btnSubt.Text = "-";
            this.btnSubt.UseVisualStyleBackColor = true;
            this.btnSubt.Click += new System.EventHandler(this.BtnSubt_Click);
            // 
            // btnMultip
            // 
            this.btnMultip.Location = new System.Drawing.Point(82, 316);
            this.btnMultip.Name = "btnMultip";
            this.btnMultip.Size = new System.Drawing.Size(56, 46);
            this.btnMultip.TabIndex = 5;
            this.btnMultip.Text = "x";
            this.btnMultip.UseVisualStyleBackColor = true;
            this.btnMultip.Click += new System.EventHandler(this.BtnMultip_Click);
            // 
            // btnDivid
            // 
            this.btnDivid.Location = new System.Drawing.Point(12, 316);
            this.btnDivid.Name = "btnDivid";
            this.btnDivid.Size = new System.Drawing.Size(51, 46);
            this.btnDivid.TabIndex = 6;
            this.btnDivid.Text = "/";
            this.btnDivid.UseVisualStyleBackColor = true;
            this.btnDivid.Click += new System.EventHandler(this.BtnDivid_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(223, 316);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 46);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(223, 253);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(99, 47);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // lblno2
            // 
            this.lblno2.AutoSize = true;
            this.lblno2.Location = new System.Drawing.Point(9, 144);
            this.lblno2.Name = "lblno2";
            this.lblno2.Size = new System.Drawing.Size(96, 16);
            this.lblno2.TabIndex = 2;
            this.lblno2.Text = "Number two:";
            this.lblno2.Click += new System.EventHandler(this.Lblno2_Click);
            // 
            // lblNo1
            // 
            this.lblNo1.AutoSize = true;
            this.lblNo1.Location = new System.Drawing.Point(9, 75);
            this.lblNo1.Name = "lblNo1";
            this.lblNo1.Size = new System.Drawing.Size(94, 16);
            this.lblNo1.TabIndex = 1;
            this.lblNo1.Text = "Number One:";
            this.lblNo1.Click += new System.EventHandler(this.LblNo1_Click);
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(109, 72);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(100, 23);
            this.txtNumber1.TabIndex = 9;
            this.txtNumber1.TextChanged += new System.EventHandler(this.TxtNumber1_TextChanged);
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(109, 141);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(100, 23);
            this.txtNumber2.TabIndex = 10;
            this.txtNumber2.TextChanged += new System.EventHandler(this.TxtNumber2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Answer:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // txtAnswerBox
            // 
            this.txtAnswerBox.BackColor = System.Drawing.SystemColors.Window;
            this.txtAnswerBox.Location = new System.Drawing.Point(109, 207);
            this.txtAnswerBox.Name = "txtAnswerBox";
            this.txtAnswerBox.ReadOnly = true;
            this.txtAnswerBox.Size = new System.Drawing.Size(100, 23);
            this.txtAnswerBox.TabIndex = 12;
            this.txtAnswerBox.TextChanged += new System.EventHandler(this.TxtAnswerBox_TextChanged);
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 374);
            this.Controls.Add(this.txtAnswerBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDivid);
            this.Controls.Add(this.btnMultip);
            this.Controls.Add(this.btnSubt);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblno2);
            this.Controls.Add(this.lblNo1);
            this.Controls.Add(this.lblCalculatorTitle);
            this.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.FrmCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCalculatorTitle;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubt;
        private System.Windows.Forms.Button btnMultip;
        private System.Windows.Forms.Button btnDivid;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblno2;
        private System.Windows.Forms.Label lblNo1;
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAnswerBox;
    }
}


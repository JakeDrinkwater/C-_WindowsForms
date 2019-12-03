namespace pizzaOrders_WF
{
    partial class frmOrderPizza
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
            this.pnlTwo = new System.Windows.Forms.Panel();
            this.lblOne = new System.Windows.Forms.Label();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.grpSize = new System.Windows.Forms.GroupBox();
            this.lblLrgPrice = new System.Windows.Forms.Label();
            this.lblMdmPrice = new System.Windows.Forms.Label();
            this.lblSmlPrice = new System.Windows.Forms.Label();
            this.rdbLarge = new System.Windows.Forms.RadioButton();
            this.rdbMedia = new System.Windows.Forms.RadioButton();
            this.rdbSmall = new System.Windows.Forms.RadioButton();
            this.grpCrust = new System.Windows.Forms.GroupBox();
            this.lblStuffedPrce = new System.Windows.Forms.Label();
            this.lblThiccPrce = new System.Windows.Forms.Label();
            this.lblThinPrce = new System.Windows.Forms.Label();
            this.rdbStuffed = new System.Windows.Forms.RadioButton();
            this.rdbThicc = new System.Windows.Forms.RadioButton();
            this.rdbThin = new System.Windows.Forms.RadioButton();
            this.grpToppings = new System.Windows.Forms.GroupBox();
            this.chkMushroom = new System.Windows.Forms.CheckBox();
            this.chkHam = new System.Windows.Forms.CheckBox();
            this.chkPineapple = new System.Windows.Forms.CheckBox();
            this.chkPepperoni = new System.Windows.Forms.CheckBox();
            this.chkCheese = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rdbMedium = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.lblPCheese = new System.Windows.Forms.Label();
            this.lblPPepp = new System.Windows.Forms.Label();
            this.lblPPineap = new System.Windows.Forms.Label();
            this.lblPHam = new System.Windows.Forms.Label();
            this.lblPMushroom = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lstOrder = new System.Windows.Forms.ListBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtLabel = new System.Windows.Forms.TextBox();
            this.pnlOne.SuspendLayout();
            this.pnlTwo.SuspendLayout();
            this.grpSize.SuspendLayout();
            this.grpCrust.SuspendLayout();
            this.grpToppings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOne
            // 
            this.pnlOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlOne.Controls.Add(this.btnExit);
            this.pnlOne.Controls.Add(this.pnlTwo);
            this.pnlOne.Controls.Add(this.btnMainMenu);
            this.pnlOne.Controls.Add(this.btnOrderPizza);
            this.pnlOne.Location = new System.Drawing.Point(0, 1);
            this.pnlOne.Name = "pnlOne";
            this.pnlOne.Size = new System.Drawing.Size(211, 505);
            this.pnlOne.TabIndex = 1;
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
            // pnlTwo
            // 
            this.pnlTwo.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.pnlTwo.Controls.Add(this.lblOne);
            this.pnlTwo.Location = new System.Drawing.Point(0, 0);
            this.pnlTwo.Name = "pnlTwo";
            this.pnlTwo.Size = new System.Drawing.Size(212, 103);
            this.pnlTwo.TabIndex = 0;
            // 
            // lblOne
            // 
            this.lblOne.AutoSize = true;
            this.lblOne.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOne.Location = new System.Drawing.Point(68, 30);
            this.lblOne.Name = "lblOne";
            this.lblOne.Size = new System.Drawing.Size(78, 38);
            this.lblOne.TabIndex = 0;
            this.lblOne.Text = "LoGo";
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
            // grpSize
            // 
            this.grpSize.Controls.Add(this.lblLrgPrice);
            this.grpSize.Controls.Add(this.lblMdmPrice);
            this.grpSize.Controls.Add(this.lblSmlPrice);
            this.grpSize.Controls.Add(this.rdbLarge);
            this.grpSize.Controls.Add(this.rdbMedia);
            this.grpSize.Controls.Add(this.rdbSmall);
            this.grpSize.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSize.Location = new System.Drawing.Point(252, 31);
            this.grpSize.Name = "grpSize";
            this.grpSize.Size = new System.Drawing.Size(449, 73);
            this.grpSize.TabIndex = 2;
            this.grpSize.TabStop = false;
            this.grpSize.Text = "Size:";
            // 
            // lblLrgPrice
            // 
            this.lblLrgPrice.AutoSize = true;
            this.lblLrgPrice.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLrgPrice.Location = new System.Drawing.Point(356, 53);
            this.lblLrgPrice.Name = "lblLrgPrice";
            this.lblLrgPrice.Size = new System.Drawing.Size(50, 17);
            this.lblLrgPrice.TabIndex = 5;
            this.lblLrgPrice.Text = "£.16.99";
            // 
            // lblMdmPrice
            // 
            this.lblMdmPrice.AutoSize = true;
            this.lblMdmPrice.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMdmPrice.Location = new System.Drawing.Point(192, 53);
            this.lblMdmPrice.Name = "lblMdmPrice";
            this.lblMdmPrice.Size = new System.Drawing.Size(45, 17);
            this.lblMdmPrice.TabIndex = 4;
            this.lblMdmPrice.Text = "£11.99";
            this.lblMdmPrice.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lblSmlPrice
            // 
            this.lblSmlPrice.AutoSize = true;
            this.lblSmlPrice.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSmlPrice.Location = new System.Drawing.Point(21, 53);
            this.lblSmlPrice.Name = "lblSmlPrice";
            this.lblSmlPrice.Size = new System.Drawing.Size(42, 17);
            this.lblSmlPrice.TabIndex = 3;
            this.lblSmlPrice.Text = "£6.99";
            // 
            // rdbLarge
            // 
            this.rdbLarge.AutoSize = true;
            this.rdbLarge.Location = new System.Drawing.Point(359, 30);
            this.rdbLarge.Name = "rdbLarge";
            this.rdbLarge.Size = new System.Drawing.Size(72, 27);
            this.rdbLarge.TabIndex = 2;
            this.rdbLarge.TabStop = true;
            this.rdbLarge.Text = "Large";
            this.rdbLarge.UseVisualStyleBackColor = true;
            // 
            // rdbMedia
            // 
            this.rdbMedia.AutoSize = true;
            this.rdbMedia.Location = new System.Drawing.Point(195, 29);
            this.rdbMedia.Name = "rdbMedia";
            this.rdbMedia.Size = new System.Drawing.Size(84, 27);
            this.rdbMedia.TabIndex = 1;
            this.rdbMedia.TabStop = true;
            this.rdbMedia.Text = "Medium";
            this.rdbMedia.UseVisualStyleBackColor = true;
            this.rdbMedia.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // rdbSmall
            // 
            this.rdbSmall.AutoSize = true;
            this.rdbSmall.Location = new System.Drawing.Point(24, 29);
            this.rdbSmall.Name = "rdbSmall";
            this.rdbSmall.Size = new System.Drawing.Size(68, 27);
            this.rdbSmall.TabIndex = 0;
            this.rdbSmall.TabStop = true;
            this.rdbSmall.Text = "Small";
            this.rdbSmall.UseVisualStyleBackColor = true;
            this.rdbSmall.CheckedChanged += new System.EventHandler(this.RdbSmall_CheckedChanged);
            // 
            // grpCrust
            // 
            this.grpCrust.Controls.Add(this.lblStuffedPrce);
            this.grpCrust.Controls.Add(this.lblThiccPrce);
            this.grpCrust.Controls.Add(this.lblThinPrce);
            this.grpCrust.Controls.Add(this.rdbStuffed);
            this.grpCrust.Controls.Add(this.rdbThicc);
            this.grpCrust.Controls.Add(this.rdbThin);
            this.grpCrust.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCrust.Location = new System.Drawing.Point(252, 148);
            this.grpCrust.Name = "grpCrust";
            this.grpCrust.Size = new System.Drawing.Size(449, 73);
            this.grpCrust.TabIndex = 3;
            this.grpCrust.TabStop = false;
            this.grpCrust.Text = "Crust:";
            // 
            // lblStuffedPrce
            // 
            this.lblStuffedPrce.AutoSize = true;
            this.lblStuffedPrce.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStuffedPrce.Location = new System.Drawing.Point(356, 53);
            this.lblStuffedPrce.Name = "lblStuffedPrce";
            this.lblStuffedPrce.Size = new System.Drawing.Size(46, 17);
            this.lblStuffedPrce.TabIndex = 11;
            this.lblStuffedPrce.Text = "+£1.50";
            // 
            // lblThiccPrce
            // 
            this.lblThiccPrce.AutoSize = true;
            this.lblThiccPrce.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThiccPrce.Location = new System.Drawing.Point(192, 53);
            this.lblThiccPrce.Name = "lblThiccPrce";
            this.lblThiccPrce.Size = new System.Drawing.Size(48, 17);
            this.lblThiccPrce.TabIndex = 10;
            this.lblThiccPrce.Text = "+£0.50";
            // 
            // lblThinPrce
            // 
            this.lblThinPrce.AutoSize = true;
            this.lblThinPrce.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThinPrce.Location = new System.Drawing.Point(21, 53);
            this.lblThinPrce.Name = "lblThinPrce";
            this.lblThinPrce.Size = new System.Drawing.Size(48, 17);
            this.lblThinPrce.TabIndex = 9;
            this.lblThinPrce.Text = "+£0.00";
            // 
            // rdbStuffed
            // 
            this.rdbStuffed.AutoSize = true;
            this.rdbStuffed.Location = new System.Drawing.Point(359, 30);
            this.rdbStuffed.Name = "rdbStuffed";
            this.rdbStuffed.Size = new System.Drawing.Size(89, 27);
            this.rdbStuffed.TabIndex = 8;
            this.rdbStuffed.TabStop = true;
            this.rdbStuffed.Text = "Stuffed";
            this.rdbStuffed.UseVisualStyleBackColor = true;
            // 
            // rdbThicc
            // 
            this.rdbThicc.AutoSize = true;
            this.rdbThicc.Location = new System.Drawing.Point(195, 29);
            this.rdbThicc.Name = "rdbThicc";
            this.rdbThicc.Size = new System.Drawing.Size(68, 27);
            this.rdbThicc.TabIndex = 7;
            this.rdbThicc.TabStop = true;
            this.rdbThicc.Text = "Thicc";
            this.rdbThicc.UseVisualStyleBackColor = true;
            // 
            // rdbThin
            // 
            this.rdbThin.AutoSize = true;
            this.rdbThin.Location = new System.Drawing.Point(24, 29);
            this.rdbThin.Name = "rdbThin";
            this.rdbThin.Size = new System.Drawing.Size(60, 27);
            this.rdbThin.TabIndex = 6;
            this.rdbThin.TabStop = true;
            this.rdbThin.Text = "Thin";
            this.rdbThin.UseVisualStyleBackColor = true;
            // 
            // grpToppings
            // 
            this.grpToppings.Controls.Add(this.lblPMushroom);
            this.grpToppings.Controls.Add(this.lblPHam);
            this.grpToppings.Controls.Add(this.lblPPineap);
            this.grpToppings.Controls.Add(this.lblPPepp);
            this.grpToppings.Controls.Add(this.lblPCheese);
            this.grpToppings.Controls.Add(this.chkMushroom);
            this.grpToppings.Controls.Add(this.chkHam);
            this.grpToppings.Controls.Add(this.chkPineapple);
            this.grpToppings.Controls.Add(this.chkPepperoni);
            this.grpToppings.Controls.Add(this.chkCheese);
            this.grpToppings.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpToppings.Location = new System.Drawing.Point(252, 262);
            this.grpToppings.Name = "grpToppings";
            this.grpToppings.Size = new System.Drawing.Size(449, 161);
            this.grpToppings.TabIndex = 4;
            this.grpToppings.TabStop = false;
            this.grpToppings.Text = "Toppings:";
            // 
            // chkMushroom
            // 
            this.chkMushroom.AutoSize = true;
            this.chkMushroom.Location = new System.Drawing.Point(7, 117);
            this.chkMushroom.Name = "chkMushroom";
            this.chkMushroom.Size = new System.Drawing.Size(114, 27);
            this.chkMushroom.TabIndex = 4;
            this.chkMushroom.Text = "+Mushroom";
            this.chkMushroom.UseVisualStyleBackColor = true;
            // 
            // chkHam
            // 
            this.chkHam.AutoSize = true;
            this.chkHam.Location = new System.Drawing.Point(150, 74);
            this.chkHam.Name = "chkHam";
            this.chkHam.Size = new System.Drawing.Size(72, 27);
            this.chkHam.TabIndex = 3;
            this.chkHam.Text = "+Ham";
            this.chkHam.UseVisualStyleBackColor = true;
            this.chkHam.CheckedChanged += new System.EventHandler(this.CheckBox4_CheckedChanged);
            // 
            // chkPineapple
            // 
            this.chkPineapple.AutoSize = true;
            this.chkPineapple.Location = new System.Drawing.Point(7, 74);
            this.chkPineapple.Name = "chkPineapple";
            this.chkPineapple.Size = new System.Drawing.Size(109, 27);
            this.chkPineapple.TabIndex = 2;
            this.chkPineapple.Text = "+Pineapple";
            this.chkPineapple.UseVisualStyleBackColor = true;
            this.chkPineapple.CheckedChanged += new System.EventHandler(this.CheckBox3_CheckedChanged);
            // 
            // chkPepperoni
            // 
            this.chkPepperoni.AutoSize = true;
            this.chkPepperoni.Location = new System.Drawing.Point(150, 30);
            this.chkPepperoni.Name = "chkPepperoni";
            this.chkPepperoni.Size = new System.Drawing.Size(112, 27);
            this.chkPepperoni.TabIndex = 1;
            this.chkPepperoni.Text = "+Pepperoni";
            this.chkPepperoni.UseVisualStyleBackColor = true;
            this.chkPepperoni.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // chkCheese
            // 
            this.chkCheese.AutoSize = true;
            this.chkCheese.Location = new System.Drawing.Point(7, 30);
            this.chkCheese.Name = "chkCheese";
            this.chkCheese.Size = new System.Drawing.Size(144, 27);
            this.chkCheese.TabIndex = 0;
            this.chkCheese.Text = "+Extra Cheese";
            this.chkCheese.UseVisualStyleBackColor = true;
            this.chkCheese.CheckedChanged += new System.EventHandler(this.ChkCheese_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.rdbMedium);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(252, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 73);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Size:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(356, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "£16.99";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(192, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "£11.99";
            this.label2.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "£6.99";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(359, 30);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(72, 27);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Large";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // rdbMedium
            // 
            this.rdbMedium.AutoSize = true;
            this.rdbMedium.Location = new System.Drawing.Point(195, 29);
            this.rdbMedium.Name = "rdbMedium";
            this.rdbMedium.Size = new System.Drawing.Size(84, 27);
            this.rdbMedium.TabIndex = 1;
            this.rdbMedium.TabStop = true;
            this.rdbMedium.Text = "Medium";
            this.rdbMedium.UseVisualStyleBackColor = true;
            this.rdbMedium.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(24, 29);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(68, 27);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Small";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.RdbSmall_CheckedChanged);
            // 
            // lblPCheese
            // 
            this.lblPCheese.AutoSize = true;
            this.lblPCheese.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPCheese.Location = new System.Drawing.Point(36, 54);
            this.lblPCheese.Name = "lblPCheese";
            this.lblPCheese.Size = new System.Drawing.Size(48, 17);
            this.lblPCheese.TabIndex = 11;
            this.lblPCheese.Text = "+£0.50";
            // 
            // lblPPepp
            // 
            this.lblPPepp.AutoSize = true;
            this.lblPPepp.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPPepp.Location = new System.Drawing.Point(174, 54);
            this.lblPPepp.Name = "lblPPepp";
            this.lblPPepp.Size = new System.Drawing.Size(48, 17);
            this.lblPPepp.TabIndex = 12;
            this.lblPPepp.Text = "+£0.50";
            // 
            // lblPPineap
            // 
            this.lblPPineap.AutoSize = true;
            this.lblPPineap.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPPineap.Location = new System.Drawing.Point(36, 97);
            this.lblPPineap.Name = "lblPPineap";
            this.lblPPineap.Size = new System.Drawing.Size(48, 17);
            this.lblPPineap.TabIndex = 13;
            this.lblPPineap.Text = "+£0.50";
            // 
            // lblPHam
            // 
            this.lblPHam.AutoSize = true;
            this.lblPHam.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPHam.Location = new System.Drawing.Point(174, 97);
            this.lblPHam.Name = "lblPHam";
            this.lblPHam.Size = new System.Drawing.Size(48, 17);
            this.lblPHam.TabIndex = 14;
            this.lblPHam.Text = "+£0.50";
            // 
            // lblPMushroom
            // 
            this.lblPMushroom.AutoSize = true;
            this.lblPMushroom.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPMushroom.Location = new System.Drawing.Point(36, 138);
            this.lblPMushroom.Name = "lblPMushroom";
            this.lblPMushroom.Size = new System.Drawing.Size(48, 17);
            this.lblPMushroom.TabIndex = 15;
            this.lblPMushroom.Text = "+£0.50";
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(252, 429);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(448, 60);
            this.btnOrder.TabIndex = 5;
            this.btnOrder.Text = "Place Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lstOrder
            // 
            this.lstOrder.FormattingEnabled = true;
            this.lstOrder.Location = new System.Drawing.Point(742, 31);
            this.lstOrder.Name = "lstOrder";
            this.lstOrder.Size = new System.Drawing.Size(318, 394);
            this.lstOrder.TabIndex = 6;
            this.lstOrder.SelectedIndexChanged += new System.EventHandler(this.LstOrder_SelectedIndexChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(737, 429);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(72, 25);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total:";
            // 
            // txtLabel
            // 
            this.txtLabel.Location = new System.Drawing.Point(816, 432);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.ReadOnly = true;
            this.txtLabel.Size = new System.Drawing.Size(100, 20);
            this.txtLabel.TabIndex = 8;
            this.txtLabel.Text = "£";
            // 
            // frmOrderPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 501);
            this.Controls.Add(this.txtLabel);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lstOrder);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.grpToppings);
            this.Controls.Add(this.grpCrust);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpSize);
            this.Controls.Add(this.pnlOne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOrderPizza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOrderPizza";
            this.pnlOne.ResumeLayout(false);
            this.pnlTwo.ResumeLayout(false);
            this.pnlTwo.PerformLayout();
            this.grpSize.ResumeLayout(false);
            this.grpSize.PerformLayout();
            this.grpCrust.ResumeLayout(false);
            this.grpCrust.PerformLayout();
            this.grpToppings.ResumeLayout(false);
            this.grpToppings.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlOne;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Panel pnlTwo;
        private System.Windows.Forms.Label lblOne;
        private System.Windows.Forms.GroupBox grpSize;
        private System.Windows.Forms.GroupBox grpCrust;
        private System.Windows.Forms.GroupBox grpToppings;
        private System.Windows.Forms.RadioButton rdbLarge;
        private System.Windows.Forms.RadioButton rdbMedia;
        private System.Windows.Forms.RadioButton rdbSmall;
        private System.Windows.Forms.Label lblLrgPrice;
        private System.Windows.Forms.Label lblMdmPrice;
        private System.Windows.Forms.Label lblSmlPrice;
        private System.Windows.Forms.Label lblStuffedPrce;
        private System.Windows.Forms.Label lblThiccPrce;
        private System.Windows.Forms.Label lblThinPrce;
        private System.Windows.Forms.RadioButton rdbStuffed;
        private System.Windows.Forms.RadioButton rdbThicc;
        private System.Windows.Forms.RadioButton rdbThin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rdbMedium;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.CheckBox chkMushroom;
        private System.Windows.Forms.CheckBox chkHam;
        private System.Windows.Forms.CheckBox chkPineapple;
        private System.Windows.Forms.CheckBox chkPepperoni;
        private System.Windows.Forms.CheckBox chkCheese;
        private System.Windows.Forms.Label lblPMushroom;
        private System.Windows.Forms.Label lblPHam;
        private System.Windows.Forms.Label lblPPineap;
        private System.Windows.Forms.Label lblPPepp;
        private System.Windows.Forms.Label lblPCheese;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.ListBox lstOrder;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtLabel;
    }
}
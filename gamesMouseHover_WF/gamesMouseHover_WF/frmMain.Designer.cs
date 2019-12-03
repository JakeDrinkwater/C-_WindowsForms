namespace gamesMouseHover_WF
{
    partial class frmMain
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
            this.pnlLeftSide = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpGames = new System.Windows.Forms.GroupBox();
            this.picVietnam = new System.Windows.Forms.PictureBox();
            this.picBorder2 = new System.Windows.Forms.PictureBox();
            this.picSkyrim = new System.Windows.Forms.PictureBox();
            this.picDoom = new System.Windows.Forms.PictureBox();
            this.picPayday = new System.Windows.Forms.PictureBox();
            this.picNewVegas = new System.Windows.Forms.PictureBox();
            this.ptcSteamLogo = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtPlatforms = new System.Windows.Forms.TextBox();
            this.lblPlatforms = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.pnlLeftSide.SuspendLayout();
            this.grpGames.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVietnam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBorder2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSkyrim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPayday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNewVegas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcSteamLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeftSide
            // 
            this.pnlLeftSide.BackColor = System.Drawing.Color.White;
            this.pnlLeftSide.Controls.Add(this.btnExit);
            this.pnlLeftSide.Controls.Add(this.ptcSteamLogo);
            this.pnlLeftSide.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftSide.Name = "pnlLeftSide";
            this.pnlLeftSide.Size = new System.Drawing.Size(200, 450);
            this.pnlLeftSide.TabIndex = 0;
            this.pnlLeftSide.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlLeftSide_Paint);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(0, 410);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(197, 37);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // grpGames
            // 
            this.grpGames.Controls.Add(this.picVietnam);
            this.grpGames.Controls.Add(this.picBorder2);
            this.grpGames.Controls.Add(this.picSkyrim);
            this.grpGames.Controls.Add(this.picDoom);
            this.grpGames.Controls.Add(this.picPayday);
            this.grpGames.Controls.Add(this.picNewVegas);
            this.grpGames.Location = new System.Drawing.Point(207, 3);
            this.grpGames.Name = "grpGames";
            this.grpGames.Size = new System.Drawing.Size(313, 435);
            this.grpGames.TabIndex = 1;
            this.grpGames.TabStop = false;
            this.grpGames.Text = "Games";
            // 
            // picVietnam
            // 
            this.picVietnam.Image = global::gamesMouseHover_WF.Properties.Resources._220px_Rising_Storm_2_Vietnam_Official_Poster;
            this.picVietnam.Location = new System.Drawing.Point(162, 299);
            this.picVietnam.Name = "picVietnam";
            this.picVietnam.Size = new System.Drawing.Size(145, 131);
            this.picVietnam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picVietnam.TabIndex = 5;
            this.picVietnam.TabStop = false;
            this.picVietnam.MouseLeave += new System.EventHandler(this.PicVietnam_MouseLeave);
            this.picVietnam.MouseHover += new System.EventHandler(this.PicVietnam_MouseHover);
            // 
            // picBorder2
            // 
            this.picBorder2.Image = global::gamesMouseHover_WF.Properties.Resources.borderlands2;
            this.picBorder2.Location = new System.Drawing.Point(7, 299);
            this.picBorder2.Name = "picBorder2";
            this.picBorder2.Size = new System.Drawing.Size(149, 130);
            this.picBorder2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBorder2.TabIndex = 4;
            this.picBorder2.TabStop = false;
            this.picBorder2.MouseLeave += new System.EventHandler(this.PicBorder2_MouseLeave);
            this.picBorder2.MouseHover += new System.EventHandler(this.PicBorder2_MouseHover);
            // 
            // picSkyrim
            // 
            this.picSkyrim.Image = global::gamesMouseHover_WF.Properties.Resources._220px_The_Elder_Scrolls_V_Skyrim_cover;
            this.picSkyrim.Location = new System.Drawing.Point(162, 166);
            this.picSkyrim.Name = "picSkyrim";
            this.picSkyrim.Size = new System.Drawing.Size(145, 127);
            this.picSkyrim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSkyrim.TabIndex = 3;
            this.picSkyrim.TabStop = false;
            this.picSkyrim.MouseLeave += new System.EventHandler(this.PicSkyrim_MouseLeave);
            this.picSkyrim.MouseHover += new System.EventHandler(this.PicSkyrim_MouseHover);
            // 
            // picDoom
            // 
            this.picDoom.Image = global::gamesMouseHover_WF.Properties.Resources.doom_mobile_hero;
            this.picDoom.Location = new System.Drawing.Point(7, 166);
            this.picDoom.Name = "picDoom";
            this.picDoom.Size = new System.Drawing.Size(149, 127);
            this.picDoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDoom.TabIndex = 2;
            this.picDoom.TabStop = false;
            this.picDoom.MouseLeave += new System.EventHandler(this.PicDoom_MouseLeave);
            this.picDoom.MouseHover += new System.EventHandler(this.PicDoom_MouseHover);
            // 
            // picPayday
            // 
            this.picPayday.Image = global::gamesMouseHover_WF.Properties.Resources.pd2;
            this.picPayday.Location = new System.Drawing.Point(162, 20);
            this.picPayday.Name = "picPayday";
            this.picPayday.Size = new System.Drawing.Size(145, 140);
            this.picPayday.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPayday.TabIndex = 1;
            this.picPayday.TabStop = false;
            this.picPayday.MouseLeave += new System.EventHandler(this.PicPayday_MouseLeave);
            this.picPayday.MouseHover += new System.EventHandler(this.PicPayday_MouseHover);
            // 
            // picNewVegas
            // 
            this.picNewVegas.Image = global::gamesMouseHover_WF.Properties.Resources.fallout_new_vegas_ultimate_edition_cover;
            this.picNewVegas.Location = new System.Drawing.Point(7, 20);
            this.picNewVegas.Name = "picNewVegas";
            this.picNewVegas.Size = new System.Drawing.Size(149, 140);
            this.picNewVegas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picNewVegas.TabIndex = 0;
            this.picNewVegas.TabStop = false;
            this.picNewVegas.MouseLeave += new System.EventHandler(this.PicNewVegas_MouseLeave);
            this.picNewVegas.MouseHover += new System.EventHandler(this.PicNewVegas_MouseHover);
            // 
            // ptcSteamLogo
            // 
            this.ptcSteamLogo.BackColor = System.Drawing.Color.White;
            this.ptcSteamLogo.Image = global::gamesMouseHover_WF.Properties.Resources.steamLogo;
            this.ptcSteamLogo.Location = new System.Drawing.Point(3, 3);
            this.ptcSteamLogo.Name = "ptcSteamLogo";
            this.ptcSteamLogo.Size = new System.Drawing.Size(80, 79);
            this.ptcSteamLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptcSteamLogo.TabIndex = 0;
            this.ptcSteamLogo.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(539, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(56, 24);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(543, 36);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(217, 20);
            this.txtTitle.TabIndex = 3;
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(543, 86);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.ReadOnly = true;
            this.txtGenre.Size = new System.Drawing.Size(217, 20);
            this.txtGenre.TabIndex = 5;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(539, 59);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(74, 24);
            this.lblGenre.TabIndex = 4;
            this.lblGenre.Text = "Genre:";
            this.lblGenre.Click += new System.EventHandler(this.Label1_Click);
            // 
            // txtPlatforms
            // 
            this.txtPlatforms.Location = new System.Drawing.Point(543, 136);
            this.txtPlatforms.Name = "txtPlatforms";
            this.txtPlatforms.ReadOnly = true;
            this.txtPlatforms.Size = new System.Drawing.Size(217, 20);
            this.txtPlatforms.TabIndex = 7;
            // 
            // lblPlatforms
            // 
            this.lblPlatforms.AutoSize = true;
            this.lblPlatforms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlatforms.Location = new System.Drawing.Point(539, 109);
            this.lblPlatforms.Name = "lblPlatforms";
            this.lblPlatforms.Size = new System.Drawing.Size(101, 24);
            this.lblPlatforms.TabIndex = 6;
            this.lblPlatforms.Text = "Platforms:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(543, 186);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(217, 20);
            this.txtPrice.TabIndex = 9;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(539, 159);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(64, 24);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "Price:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(539, 218);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(121, 24);
            this.lblDescription.TabIndex = 10;
            this.lblDescription.Text = "Description:";
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(543, 246);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.ReadOnly = true;
            this.rtbDescription.Size = new System.Drawing.Size(217, 187);
            this.rtbDescription.TabIndex = 11;
            this.rtbDescription.Text = "";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPlatforms);
            this.Controls.Add(this.lblPlatforms);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpGames);
            this.Controls.Add(this.pnlLeftSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.pnlLeftSide.ResumeLayout(false);
            this.grpGames.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picVietnam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBorder2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSkyrim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPayday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNewVegas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcSteamLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeftSide;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox ptcSteamLogo;
        private System.Windows.Forms.GroupBox grpGames;
        private System.Windows.Forms.PictureBox picVietnam;
        private System.Windows.Forms.PictureBox picBorder2;
        private System.Windows.Forms.PictureBox picSkyrim;
        private System.Windows.Forms.PictureBox picDoom;
        private System.Windows.Forms.PictureBox picPayday;
        private System.Windows.Forms.PictureBox picNewVegas;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox txtPlatforms;
        private System.Windows.Forms.Label lblPlatforms;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RichTextBox rtbDescription;
    }
}


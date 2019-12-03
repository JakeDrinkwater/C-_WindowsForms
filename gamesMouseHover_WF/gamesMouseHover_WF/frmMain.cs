using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gamesMouseHover_WF
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void PnlLeftSide_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult exitConfirm = new DialogResult();

            exitConfirm = MessageBox.Show("Are you sure you wish to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (exitConfirm == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Label1_Click(object sender, EventArgs e) //genre
        {

        }

        private void clear()
        {
            txtGenre.Clear();
            txtPlatforms.Clear();
            txtPrice.Clear();
            txtTitle.Clear();
            rtbDescription.Clear();
        }

        #region FNV
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void PicNewVegas_MouseHover(object sender, EventArgs e)
        {
            txtTitle.Text = "Fallout: New Vegas";
            txtGenre.Text = "RPG";
            txtPlatforms.Text = "PC, XBOX 360/1, PS3/4 ";
            txtPrice.Text = "14.99 (ultimate edition) ";
            rtbDescription.Text = "Fallout: New Vegas is a post-apocalyptic action role-playing video game. It is a spin-off of the Fallout series and was developed by Obsidian Entertainment and published by Bethesda Softworks. \nIt was announced in April 2009 and released for Microsoft Windows, PlayStation 3 and Xbox 360 on October 19, 2010 ";
        }

        private void PicNewVegas_MouseLeave(object sender, EventArgs e)
        {
            clear();
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #endregion


        #region PD2
        private void PicPayday_MouseHover(object sender, EventArgs e)
        {
            txtTitle.Text = "Payday 2";
            txtGenre.Text = "FPS";
            txtPlatforms.Text = "PC, XBOX 60/1, PS3/4";
            txtPrice.Text = "7.49 (base edition)";
            rtbDescription.Text = "PAYDAY 2 is an action-packed, four-player co-op shooter that once again lets gamers don the masks of the original PAYDAY crew - Dallas, Hoxton, Wolf and Chains - as they descend on Washington DC for an epic crime spree. ";
        }

        private void PicPayday_MouseLeave(object sender, EventArgs e)
        {
            clear();
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #endregion


        #region DOOM
        private void PicDoom_MouseHover(object sender, EventArgs e)
        {
            txtTitle.Text = "DOOM 2016 ";
            txtGenre.Text = "FPS";
            txtPlatforms.Text = "PC, XBOX 1, PS4 ";
            txtPrice.Text = "14.99";
            rtbDescription.Text = "Doom is a first-person shooter video game developed by id Software and published by Bethesda Softworks. It was released worldwide on Microsoft Windows, PlayStation 4, and Xbox One in May 2016 and is powered by id Tech 6. ... Mick Gordon composed the music for the game, with additional music contributed by Ben F. ";
        }

        private void PicDoom_MouseLeave(object sender, EventArgs e)
        {
            clear();
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #endregion


        #region Skyrim
        private void PicSkyrim_MouseHover(object sender, EventArgs e)
        {
            txtTitle.Text = "Elder Scrolls V: Skyrim ";
            txtGenre.Text = "RPG";
            txtPlatforms.Text = "PC, XBOX 60/1, PS3/4 ";
            txtPrice.Text = "29.99 (special “rip-off” edition) ";
            rtbDescription.Text = "The Elder Scrolls V: Skyrim is an action role-playing game, playable from either a first or third-person perspective. The player may freely roam over the land of Skyrim which is an open world environment consisting of wilderness expanses, dungeons, cities, towns, fortresses, and villages ";
        }

        private void PicSkyrim_MouseLeave(object sender, EventArgs e)
        {
            clear();
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #endregion


        #region BL2
        private void PicBorder2_MouseHover(object sender, EventArgs e)
        {
            txtTitle.Text = "Borderlands 2 ";
            txtGenre.Text = "FPS ";
            txtPlatforms.Text = "PC, XBOX 306/1, PS3/4 ";
            txtPrice.Text = "19.99 ";
            rtbDescription.Text = "Borderlands 2 is an action role-playing game played from a first-person perspective. The gameplay revolves around the completion of missions and the collection of randomly generated loot (such as weapons, shields, skins, and other items) with various rarities, statistics, and elemental effects. ";
        }

        private void PicBorder2_MouseLeave(object sender, EventArgs e)
        {
            clear();
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #endregion



        #region RS2
        private void PicVietnam_MouseHover(object sender, EventArgs e)
        {
            txtTitle.Text = "Rising storm 2: Vietnam ";
            txtGenre.Text = "FPS ";
            txtPlatforms.Text = "PC ";
            txtPrice.Text = "18.99 ";
            rtbDescription.Text = "Like its predecessors in the series, Rising Storm 2: Vietnam is a tactical first-person shooter that emphasizes large-scale teamwork with realistic mechanics and combat. The game is set in the period of the Vietnam War conflict and many of the locations are based on historic battles. ";
        }

        private void PicVietnam_MouseLeave(object sender, EventArgs e)
        {
            clear();
        }
        #endregion
    }
}

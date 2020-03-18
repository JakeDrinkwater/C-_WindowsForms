﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizAppFixed_WF
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)//when form loads, sets the label as the global fore and surname
        {
            string strFullname = GlobalVars.strForname + " " + GlobalVars.strSurname;

            lblName.Text = strFullname;
        } //sets global fullname variable as the label text

        private void mnuExitButton_Click(object sender, EventArgs e)//exit button and promt
        {
            DialogResult exitConfirm = new DialogResult();

            exitConfirm = MessageBox.Show("Are you sure you wish to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (exitConfirm == DialogResult.Yes)
            {
                Application.Exit();
            }
        } //opens YesNo dialogue and exits is yes is chosen

        private void mnuLogout_Click(object sender, EventArgs e)//log out button and prompt
        {
            DialogResult logoutConfirm = new DialogResult();

            logoutConfirm = MessageBox.Show("Are you sure you wish to Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (logoutConfirm == DialogResult.Yes)
            {
                frmLogin Login = new frmLogin();

                this.Hide();
                Login.Show();
            } //once log out button is pressed, asks the user to confirm, loads frmLogin if yes
        }

        private void lnkHelpDoc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //"user guide" label, opens up the help document once clicked
            {
            try
            {
                /*
                starts up notepad application and opens help document
                change file path for individual systems
                */
                Process.Start("notepad.exe", @"C:\Users\Jake\Desktop\C-_WindowsForms-master (1)\C-_WindowsForms-master\QuizAppFixed_WF\QuizAppFixed_WF\Resources\Help.txt"); //change file path for individual systems 
            }
            catch
            {
                MessageBox.Show("Error", "Could not read file!");
            }
        }
        private void lblName_Click(object sender, EventArgs e)//redundant
        {

        }

        private void btnStudy_Click(object sender, EventArgs e)//opens study form
        {
            frmStudy stud = new frmStudy(); //opens the study form when clicked
            this.Hide();
            stud.Show();
        }


        private void btnQuiz_Click(object sender, EventArgs e)//opens quiz form
        {
            frmQuiz lvl1 = new frmQuiz(); //opens the quiz from 
            this.Hide();
            lvl1.Show();
        }

        private void btnResults_Click(object sender, EventArgs e)//redundant
        {

        }

        private void BtnResults_Click_1(object sender, EventArgs e) //use this for results button
        {
            frmResults res = new frmResults();
            this.Hide();
            res.Show();
        }

        private void ToolStripTextBox1_Click(object sender, EventArgs e)//redundant
        {

        }
    }
}

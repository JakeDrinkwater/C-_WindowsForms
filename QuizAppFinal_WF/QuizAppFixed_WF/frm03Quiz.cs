using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace QuizAppFixed_WF
{
    public partial class frm03Quiz : Form
    {
        public frm03Quiz()
        {
            InitializeComponent();
        }

        private void mnuExitButton_Click(object sender, EventArgs e)//exit button and prompt
        {
            DialogResult exitConfirm = new DialogResult();

            exitConfirm = MessageBox.Show("Are you sure you wish to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (exitConfirm == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void mnuLogout_Click(object sender, EventArgs e)//log out button and prompt
        {
            DialogResult logoutConfirm = new DialogResult();

            logoutConfirm = MessageBox.Show("Are you sure you wish to Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (logoutConfirm == DialogResult.Yes)
            {
                frm01Login Login = new frm01Login();

                this.Hide();
                Login.Show();
            } //once log out button is pressed, asks the user to confirm, loads frmLogin if yes
        }

        private void LblTitle_Click(object sender, EventArgs e)//loads main menu when clicked
        {
            frm02MainMenu main = new frm02MainMenu();
            this.Hide();
            main.Show();
        }

        private void BtnStudy_Click(object sender, EventArgs e)//opens study form
        {
            frm07Study stud = new frm07Study();
            this.Hide(); 
            stud.Show();
        }

        private void BtnResults_Click(object sender, EventArgs e)//opens results form
        {
            frm06Results res = new frm06Results();
            this.Hide();
            res.Show();
        }

        private void btnQuiz1_Click(object sender, EventArgs e)//opens first quiz
        {
            frm04Level1 lvl = new frm04Level1();
            this.Hide();
            lvl.Show();
        }

        private void btnQuiz2_Click(object sender, EventArgs e)//opens second quiz
        {
            frm05Level2 lvl2 = new frm05Level2();
            this.Hide();
            lvl2.Show();
        }

        private void lnkHelpDoc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                /*
                starts up notepad application and opens help document
                change file path for individual systems
                */
                Process.Start("notepad.exe", @"C:\Users\Jake\Desktop\C-_WindowsForms-master (1)\C-_WindowsForms-master\QuizAppFinal_WF\QuizAppFixed_WF\Resources\Help.txt");
                //change file path for individual systems 
            }
            catch
            {
                MessageBox.Show("Error", "Could not read file!");//error message
            }
        }
    }
}

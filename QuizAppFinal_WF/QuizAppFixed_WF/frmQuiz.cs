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
    public partial class frmQuiz : Form
    {
        public frmQuiz()
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
                frmLogin Login = new frmLogin();

                this.Hide();
                Login.Show();
            } //once log out button is pressed, asks the user to confirm, loads frmLogin if yes
        }

        private void LblTitle_Click(object sender, EventArgs e)//loads main menu when clicked
        {
            frmMainMenu main = new frmMainMenu();
            this.Hide();
            main.Show();
        }

        private void BtnStudy_Click(object sender, EventArgs e)//opens study form
        {
            frmStudy stud = new frmStudy();
            this.Hide(); 
            stud.Show();
        }

        private void BtnResults_Click(object sender, EventArgs e)//opens results form
        {
            frmResults res = new frmResults();
            this.Hide();
            res.Show();
        }

        private void btnQuiz1_Click(object sender, EventArgs e)//opens first quiz
        {
            frmLevel1 lvl = new frmLevel1();
            this.Hide();
            lvl.Show();
        }

        private void btnQuiz2_Click(object sender, EventArgs e)//opens second quiz
        {
            frmLevel2 lvl2 = new frmLevel2();
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
                Process.Start("notepad.exe", @"C:\Users\Jake\Desktop\C-_WindowsForms-master (1)\C-_WindowsForms-master\QuizAppFixed_WF\QuizAppFixed_WF\Resources\Help.txt"); //change file path for individual systems 
            }
            catch
            {
                MessageBox.Show("Error", "Could not read file!");//error message
            }
        }
    }
}

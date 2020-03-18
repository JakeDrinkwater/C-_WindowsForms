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
    public partial class frmResults : Form
    {
        public frmResults()
        {
            InitializeComponent();
        }

        private void grpLeftSide_Enter(object sender, EventArgs e)//redundant
        {

        }

        private void BtnQuiz_Click(object sender, EventArgs e)//opens quiz form
        {
            frmQuiz quiz = new frmQuiz();
            this.Hide();
            quiz.Show();
        }

        private void BtnStudy_Click(object sender, EventArgs e)//opens study form
        {
            frmStudy stud = new frmStudy();
            this.Hide();
            stud.Show();
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

        private void mnuLogout_Click(object sender, EventArgs e)//logout button and promt
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

        private void lblLvl1Incorrect_Click(object sender, EventArgs e)//redundant
        {

        }

        private void frmResults_Load(object sender, EventArgs e)//when form loads, sets score labels with global variables
        {
            //variables//
            double correctAnswers = GlobalVars.intCorrectAnswers;
            double total = GlobalVars.intTotal;
            double percentage;
            /////////////

            percentage = (correctAnswers / total) * 100;

            if (GlobalVars.intTotal >= 1)//allows the message to only appear once at least 1 question has been answered
            {
                if (percentage >= 50)//if percentage is over 50 prints "well done" to OverallScore label
                {
                    lblWellDone.Text = "Well Done!";
                }
                else
                {
                    lblWellDone.Text = "Better luck next time!";
                }
            }
            else
            {
                lblWellDone.Text = " "; //blank text
            }

            lblCorrect1.Text = "Correct Score: " + GlobalVars.intCorrectAnswers;      //total correct answers
            lblIncorrect1.Text = "Incorrect Score: " + GlobalVars.intIncorrectAnswers;//total incorrect answers
            lblTotalQs.Text = "Total Questions answered: " + GlobalVars.intTotal;     //total questions answered
            lblOverallScore.Text = "Overall total: " + GlobalVars.intCorrectAnswers + "/" + GlobalVars.intTotal + " " + percentage + "%";
            //displays the total correct answers out of 12 and percentage

        }

        private void lblLevel1_Click(object sender, EventArgs e)//redundant
        {

        }

        private void lblCorrect1_Click(object sender, EventArgs e)//redundant
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)//brings user back to main menu
        {
            frmMainMenu ma = new frmMainMenu();
            this.Hide();
            ma.Show();
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

        private void lblOverallScore_Click(object sender, EventArgs e)//label for overall score out of 12 and percentage
        {

        }

        private void lblIncorrect1_Click(object sender, EventArgs e)//redundant
        {

        }
    }
}

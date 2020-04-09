using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuizAppFixed_WF
{
    public partial class frm07Study : Form
    {
        public frm07Study()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)//ICT tab
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnQuiz_Click(object sender, EventArgs e)//returns to quiz form
        {
            frm03Quiz quiz = new frm03Quiz();
            this.Hide();
            quiz.Show();
        }

        private void MnuExitButton_Click(object sender, EventArgs e)//exit button and prompt
        {
            DialogResult exitConfirm = new DialogResult();

            exitConfirm = MessageBox.Show("Are you sure you wish to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (exitConfirm == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void MnuLogout_Click(object sender, EventArgs e)//logout button and prompt
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

        private void LblTitle_Click(object sender, EventArgs e)//brings back to main menu
        {
            frm02MainMenu main = new frm02MainMenu();
            this.Hide();
            main.Show();
        }

        private void BtnResults_Click(object sender, EventArgs e)//opens results form
        {
            frm06Results res = new frm06Results();
            this.Hide();
            res.Show();
        }

        private void lnkHelpDoc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                /*
                starts up notepad application and opens help document
                change file path for individual systems
                */
                Process.Start("notepad.exe", @"C:\Users\Jake\Desktop\C-_WindowsForms-master (1)\C-_WindowsForms-master\QuizAppFinal_WF\QuizAppFixed_WF\Resources\Help.txt"); //change file path for individual systems 
            }
            catch
            {
                MessageBox.Show("Error", "Could not read file!");//error message
            }
        }
    }
}

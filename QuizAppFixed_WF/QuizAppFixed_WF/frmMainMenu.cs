using System;
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

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            string strFullname = GlobalVars.strForname + " " + GlobalVars.strSurname;

            lblName.Text = strFullname;
        } //sets global fullname variable as the label text

        private void mnuExitButton_Click(object sender, EventArgs e)
        {
            DialogResult exitConfirm = new DialogResult();

            exitConfirm = MessageBox.Show("Are you sure you wish to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (exitConfirm == DialogResult.Yes)
            {
                Application.Exit();
            }
        } //opens YesNo dialogue and exits is yes is chosen

        private void mnuLogout_Click(object sender, EventArgs e)
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

        private void lnkHelpDoc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /*
           string FilePath; //code opens the help file whenever the "User Guide" button is pressed
           ​
           FilePath = System.IO.Path.GetFullPath(Application.StartupPath + @"\..\..\Resources\Help\");​
           Process.Start(FilePath + "Help.pdf");
           */
        }
        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void btnStudy_Click(object sender, EventArgs e)
        {

        }


        private void btnQuiz_Click(object sender, EventArgs e)
        {

        }

        private void btnResults_Click(object sender, EventArgs e)
        {

        }

        private void BtnResults_Click_1(object sender, EventArgs e) //use this for results button
        {

        }

        private void ToolStripTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

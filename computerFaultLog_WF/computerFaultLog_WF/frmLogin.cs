using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace computerFaultLog_WF
{
    public partial class frmLogIn : Form
    {
        //
        string UserName = "";
        string EnteredUserName;

        string Password = "";
        string EnteredPassword;

        int attempts = 0;
        //
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            EnteredUserName = txtUserField.Text;
            EnteredPassword = txtPasswordField.Text;

            if ((EnteredUserName == UserName) && (EnteredPassword == Password))
            {
                frmUserDetails MainMenu = new frmUserDetails();
                this.Hide();
                MainMenu.Show();
            }
            else
            {
                MessageBox.Show("Detailed incorrect");
                attempts = attempts + 1;
            }

            if(attempts > 3)
            {
                Application.Exit();
            }
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

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtUserField.Clear();
            txtPasswordField.Clear();
        }

        private void LblDateTime_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            lblDateTime.Text = Convert.ToString(date);
        }
    }
}

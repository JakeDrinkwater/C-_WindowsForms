using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessagSpammer_WF
{
    public partial class frmMessageSpammer : Form
    {
        //Variables //
        string Password = "p";
        string EntPassword;

        string Username = "p";
        string EnteredUsername;
        // // // // //
        public frmMessageSpammer()
        {
            InitializeComponent();
        }

        private void LblUname_Click(object sender, EventArgs e)
        {

        }

        private void TxtPWEnter_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblPassword_Click(object sender, EventArgs e)
        {

        }

        private void TxtUEnter_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            EnteredUsername = txtUEnter.Text;
            EntPassword = txtPWEnter.Text;

            if ((EnteredUsername == Username) && (EntPassword == Password))
            {
                frmMainMenu frmMainMenu = new frmMainMenu();
                frmMainMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Detailed incorrect");
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsLogin_WF
{
    public partial class frmUserLogin : Form
    {
        //
        string UserName = "admin";
        string EnteredUserName;

        string Password = "Password";
        string EnteredPassword;
        //
        public frmUserLogin()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LblUserName_Click(object sender, EventArgs e)
        {

        }

        private void LblPassword_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtUserField.Clear();
            txtPasswordField.Clear();
        }

        private void TxtUserField_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            EnteredUserName = txtUserField.Text;
            EnteredPassword = txtPasswordField.Text;

            if ((EnteredUserName == UserName) && (EnteredPassword == Password))
            {
                MessageBox.Show("Details correct");
            }
            else
            {
                MessageBox.Show("Detailed incorrect");
            }
        }
        private void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"M:\Downloads\Unit 4 Programming\startup.wav");
            simpleSound.Play();
        }
    }
}

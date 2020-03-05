using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace LoginForm_WF
{
    public partial class frmNewUser : Form
    {
        string winDir = System.Environment.GetEnvironmentVariable("windir");

        public frmNewUser()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult exitConfirm = new DialogResult();

            exitConfirm = MessageBox.Show("Are you sure you wish to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (exitConfirm == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmMainMenu main = new frmMainMenu();

            this.Hide();
            main.Show();
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            string UserName= GlobalVars.strForename + "\n" + GlobalVars.strSurname;

            StreamWriter writer = new StreamWriter("C:/Users/dri40079303/Desktop/Unit 4 Programming/C-_WindowsForms-master/LoginForm_WF/LoginForm_WF/Users.txt");
            writer.WriteLine(UserName);
            writer.Close();

            MessageBox.Show("New user created", "Success");

            frmMainMenu main = new frmMainMenu();
            this.Hide();
            main.Show();

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void txtForename_TextChanged(object sender, EventArgs e)
        {
            GlobalVars.strForename = txtForename.Text;         
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            GlobalVars.strSurname = txtSurname.Text;
        }


    }
}

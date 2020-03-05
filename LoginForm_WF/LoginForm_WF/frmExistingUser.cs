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
    public partial class frmExistingUser : Form
    {
        string winDir = System.Environment.GetEnvironmentVariable("windir");

        public frmExistingUser()
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
            frmNewUser Main = new frmNewUser();

            this.Hide();
            Main.Show();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            bool forename = false;
            bool surname = false;


            // Read a text file line by line.  
            string[] lines = File.ReadAllLines("C:/Users/dri40079303/Desktop/Unit 4 Programming/C-_WindowsForms-master/LoginForm_WF/LoginForm_WF/Users.txt");

            try
            {
                for (int a = 0; a <= 99; a++)
                {
                    if (txtForename.Text == lines[a])
                    {
                        forename = true;
                    }

                    if (txtSurname.Text == lines[a])
                    {
                        surname = true;
                    }
                }

                if ((surname = true) && (forename = true))
                {
                    frmMainMenu main = new frmMainMenu();
                    this.Hide();
                    main.Show();
                }
            }
            catch
            {
                MessageBox.Show("login not recognised", "error");
            }
            /*
            foreach (string line in lines) //debug function
                txtTest.Text = line;
           */
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizAppFixed_WF
{
    public partial class frm01Login : Form
    {

        //Variables//
        int attempts = 0;
        // // // // //

        public frm01Login()
        {
            InitializeComponent();
        }

        private void lblTitle_Click(object sender, EventArgs e)//redundant
        {

        }

        private void lblForname_Click(object sender, EventArgs e)//redundant
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtForname.Text == "" || txtSurname.Text == "") //checks if the user has input both a forename and a surname
            {
                MessageBox.Show("Enter Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                attempts++;
                //if either/both details are not entered, displays error and increments "attampts" variable by one
            }
            else
            { //if user inputs correct data, global variables are assigned and the user can log in
                GlobalVars.strForname = txtForname.Text;
                GlobalVars.strSurname = txtSurname.Text;

                frm02MainMenu mainMenu = new frm02MainMenu();
                this.Hide();
                mainMenu.Show();
            }

            if (attempts > 3) //if attempts variables increments over 3 the application closes
            {
                Application.Exit();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)//clears text boxes when prompt is accepted
        {
            DialogResult clearConfirm = new DialogResult();

            clearConfirm = MessageBox.Show("Are you sure you wish to clear?", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (clearConfirm == DialogResult.Yes)
            {
                txtForname.Clear();
                txtSurname.Clear();
            }
        }//Confirms the user wishes to clear text, and clears if yes is pressed
        

        private void btnExit_Click(object sender, EventArgs e)//exits application once prompt accepted 
        {
            DialogResult exitConfirm = new DialogResult();

            exitConfirm = MessageBox.Show("Are you sure you wish to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (exitConfirm == DialogResult.Yes)
            {
                Application.Exit();
            }
        } //Once exit button is pressed, dialogue box shows with yes/no options, exits if yes
    }
}

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
    public partial class frmLevel2 : Form
    {
        public frmLevel2()
        {
            InitializeComponent();
        }


        #region MouseDown
        //Code to handle a mouse click and drag for each of the bottom labels
        private void lblSalvador_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(lblSalvador.Text, DragDropEffects.Copy);
        }

        private void lblPicasso_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(lblPicasso.Text, DragDropEffects.Copy);
        }

        private void lblWorhol_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(lblWorhol.Text, DragDropEffects.Copy);
        }
        #endregion

        #region DragEnter 
        //events for whenever the label enters the image
        private void lblWorhol1_Drop_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text)) e.Effect = DragDropEffects.Copy;
        }

        private void lblPic1_Drop_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text)) e.Effect = DragDropEffects.Copy;
        }

        private void lblAndy2_Drop_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text)) e.Effect = DragDropEffects.Copy;
        }

        private void lblDali1_Drop_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text)) e.Effect = DragDropEffects.Copy;
        }

        private void lblDali2_Drop_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text)) e.Effect = DragDropEffects.Copy;
        }

        private void lblPic2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text)) e.Effect = DragDropEffects.Copy;
        }
        #endregion

        #region DragDrop
        //events for whenever the name label is dropped onto the image and calls either the correct() or incorrect() procedures
        private void lblWorhol1_Drop_DragDrop(object sender, DragEventArgs e)
        {
            if (Convert.ToString(e.Data.GetData(DataFormats.Text)) == "Andy Warhol")
            {
                Trace.WriteLine(Convert.ToString(e.Data.GetData(DataFormats.Text)));
                Correct();
                lblWorhol.Visible = false;
            }
            else
            {
                Trace.WriteLine(Convert.ToString(e.Data.GetData(DataFormats.Text)));
                Incorrect();
            }
        }

        private void lblPic1_Drop_DragDrop(object sender, DragEventArgs e)
        {
            if (Convert.ToString(e.Data.GetData(DataFormats.Text)) == "Picasso")
            {
                Trace.WriteLine(Convert.ToString(e.Data.GetData(DataFormats.Text)));
                Correct();
                lblPicasso.Visible = false;
            }
            else
            {
                Trace.WriteLine(Convert.ToString(e.Data.GetData(DataFormats.Text)));
                Incorrect();
            }
        }

        private void lblAndy2_Drop_DragDrop(object sender, DragEventArgs e)
        {
            if (Convert.ToString(e.Data.GetData(DataFormats.Text)) == "Worhol")
            {
                Trace.WriteLine(Convert.ToString(e.Data.GetData(DataFormats.Text)));
                Correct();
                lblWorhol.Visible = false;
            }
            else
            {
                Trace.WriteLine(Convert.ToString(e.Data.GetData(DataFormats.Text)));
                Incorrect();
            }
        }

        private void lblDali1_Drop_DragDrop(object sender, DragEventArgs e)
        {
            if (Convert.ToString(e.Data.GetData(DataFormats.Text)) == "Salvador Dalí")
            {
                Trace.WriteLine(Convert.ToString(e.Data.GetData(DataFormats.Text)));
                Correct();
                lblSalvador.Visible = false;
            }
            else
            {
                Trace.WriteLine(Convert.ToString(e.Data.GetData(DataFormats.Text)));
                Incorrect();
            }
        }

        private void lblDali2_Drop_DragDrop(object sender, DragEventArgs e)
        {
            if (Convert.ToString(e.Data.GetData(DataFormats.Text)) == "Salvador Dalí")
            {
                Trace.WriteLine(Convert.ToString(e.Data.GetData(DataFormats.Text)));
                Correct();
                lblSalvador.Visible = false;
            }
            else
            {
                Trace.WriteLine(Convert.ToString(e.Data.GetData(DataFormats.Text)));
                Incorrect();
            }
        }

        private void lblPic2_DragDrop(object sender, DragEventArgs e)
        {
            if (Convert.ToString(e.Data.GetData(DataFormats.Text)) == "Picasso")
            {
                Trace.WriteLine(Convert.ToString(e.Data.GetData(DataFormats.Text)));
                Correct();
                lblPicasso.Visible = false;
            }
            else
            {
                Trace.WriteLine(Convert.ToString(e.Data.GetData(DataFormats.Text)));
                Incorrect();
            }
        }
        #endregion

        #region buttons
        //code for each of the buttons on the form
        private void btnMainMenu_Click(object sender, EventArgs e) //Main menu button
        {
            DialogResult exitConfirm = new DialogResult();

            exitConfirm = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (exitConfirm == DialogResult.Yes)
            {
                frmMainMenu main = new frmMainMenu();
                this.Hide();
                main.Show();
            }
            //confirmation dialogue
        }

        private void btnQuiz_Click(object sender, EventArgs e) //brings user back to quiz form
        {
            frmQuiz qu = new frmQuiz();
            this.Hide();
            qu.Show();
        }

        private void mnuExitButton_Click(object sender, EventArgs e)//redundant
        {
           
        }

        private void mnuLogout_Click(object sender, EventArgs e) //menu strip log out button
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

        private void mnuExitButton_Click_1(object sender, EventArgs e) //exit button
        {
            DialogResult exitConfirm = new DialogResult();

            exitConfirm = MessageBox.Show("Are you sure you wish to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (exitConfirm == DialogResult.Yes)
            {
                Application.Exit();
            }//confirmation dialogue
        }

        private void lblHelp2_Click(object sender, EventArgs e)//redundant
        {

        }

        private void mnuLogout_Click_1(object sender, EventArgs e) //log out button
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
        #endregion


        public void Correct() //procedure for whenever questions are answered correctly
        {
            MessageBox.Show("Answer Correct!", "Correct");
            GlobalVars.intComponentsCorrect2++;//increments global correct score variable
            lblCorrectCount.Text = Convert.ToString(GlobalVars.intComponentsCorrect2); //displays correct score on label
            GlobalVars.intTotal++;
            GlobalVars.intCorrectAnswers++; //increments total answers and total correct answers

        }

        public void Incorrect() //procedure for whenever questions are answered incorrectly
        {
            MessageBox.Show("Answer Incorrect!", "Incorrect");
            GlobalVars.intComponentsIncorrect2++;//increments global incorrect score variable
            lblIncorrectCount.Text = Convert.ToString(GlobalVars.intComponentsIncorrect2); //displays incorrect score on label
            GlobalVars.intTotal++;
            GlobalVars.intIncorrectAnswers++; //increments total answers and total incorrect answers
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
                MessageBox.Show("Error", "Could not read file!"); //error message
            }
        }
    }
}

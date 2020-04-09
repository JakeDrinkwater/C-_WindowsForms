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
    public partial class frm04Level1 : Form
    {
        public frm04Level1()
        {
            InitializeComponent();
        }

        #region Misc
        //region for miscellaneous or unecessary event handling 
        private void btnExit_Click(object sender, EventArgs e) //once exit button is pressed, exits with confirmation dialogue
        {

        }
        private void lblFloppy_Drop_Click(object sender, EventArgs e)
        {

        }

        private void lblCPU_Drop_Click(object sender, EventArgs e)
        {

        }

        private void lblHDD_Drop_Click(object sender, EventArgs e)
        {

        }

        private void lblUSB_Drop_Click(object sender, EventArgs e)
        {

        }

        private void lblCPU_Click(object sender, EventArgs e)
        {

        }

        private void lblHDD_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e) //pnlIncorrect
        {

        }
        private void pnlCorrect_Paint(object sender, PaintEventArgs e)
        {

        }
        private void lblCorrectCount_Click(object sender, EventArgs e)
        {

        }

        private void lblIncorrectCount_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region MouseDownEvents
        //Code to handle a mouse click and drag for each of the bottom labels
        private void lblRAM_MouseDown_1(object sender, MouseEventArgs e)
        {     
            DoDragDrop(lblRAM.Text, DragDropEffects.Copy);

        }
        private void lblFloppy_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(lblFloppy.Text, DragDropEffects.Copy);

        }

        private void lblFan_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(lblFan.Text, DragDropEffects.Copy);

        }

        private void lblHDD_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(lblHDD.Text, DragDropEffects.Copy);
        }

        private void lblCPU_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(lblCPU.Text, DragDropEffects.Copy);

        }

        private void lblUSB_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(lblUSB.Text, DragDropEffects.Copy);

        }
        #endregion

        #region DragEnter
        //events for whenever the label enters the image
        private void lblCPU_Drop_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text)) e.Effect = DragDropEffects.Copy;
        }

        private void lblFan_Drop_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text)) e.Effect = DragDropEffects.Copy;
        }

        private void lblFloppy_Drop_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text)) e.Effect = DragDropEffects.Copy;
        }

        private void lblRAM_Drop_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text)) e.Effect = DragDropEffects.Copy;
        }

        private void lblUSB_Drop_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text)) e.Effect = DragDropEffects.Copy;
        }

        private void lblHDD_Drop_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text)) e.Effect = DragDropEffects.Copy;
        }
        #endregion

        #region DragDrop
        //events for whenever the name label is dropped onto the image and calls either the correct() or incorrect() procedures
        private void lblCPU_Drop_DragDrop(object sender, DragEventArgs e)
        {

            if (Convert.ToString(e.Data.GetData(DataFormats.Text)) == "CPU")
            {
                Trace.WriteLine(Convert.ToString(e.Data.GetData(DataFormats.Text)));
                Correct();
                lblCPU.Visible = false;
            }
            else
            {
                Trace.WriteLine(Convert.ToString(e.Data.GetData(DataFormats.Text)));
                Incorrect();
            }
        }

        private void lblFan_Drop_DragDrop(object sender, DragEventArgs e)
        {
            if (Convert.ToString(e.Data.GetData(DataFormats.Text)) == "Fan")
            {
                Trace.WriteLine(Convert.ToString(e.Data.GetData(DataFormats.Text)));
                Correct();
                lblFan.Visible = false;
            }
            else
            {
                Trace.WriteLine(Convert.ToString(e.Data.GetData(DataFormats.Text)));
                Incorrect();
            }

        }

        private void lblFloppy_Drop_DragDrop(object sender, DragEventArgs e)
        {
            if (Convert.ToString(e.Data.GetData(DataFormats.Text)) == "Floppy")
            {
                Trace.WriteLine(Convert.ToString(e.Data.GetData(DataFormats.Text)));
                Correct();
                lblFloppy.Visible = false;
            }
            else
            {
                Trace.WriteLine(Convert.ToString(e.Data.GetData(DataFormats.Text)));
                Incorrect();
            }
        }

        private void lblRAM_Drop_DragDrop(object sender, DragEventArgs e)
        {
            if (Convert.ToString(e.Data.GetData(DataFormats.Text)) == "RAM")
            {
                Trace.WriteLine(Convert.ToString(e.Data.GetData(DataFormats.Text)));
                Correct();
                lblRAM.Visible = false;
            }
            else
            {
                Trace.WriteLine(Convert.ToString(e.Data.GetData(DataFormats.Text)));
                Incorrect();
            }
        }

        private void lblUSB_Drop_DragDrop(object sender, DragEventArgs e)
        {
            if (Convert.ToString(e.Data.GetData(DataFormats.Text)) == "USB")
            {
                Trace.WriteLine(Convert.ToString(e.Data.GetData(DataFormats.Text)));
                Correct();
                lblUSB.Visible = false;
            }
            else
            {
                Trace.WriteLine(Convert.ToString(e.Data.GetData(DataFormats.Text)));
                Incorrect();
            }
        }

        private void lblHDD_Drop_DragDrop(object sender, DragEventArgs e)
        {
            if (Convert.ToString(e.Data.GetData(DataFormats.Text)) == "HDD")
            {
                Trace.WriteLine(Convert.ToString(e.Data.GetData(DataFormats.Text)));
                Correct();
                lblHDD.Visible = false;
            }
            else
            {
                Trace.WriteLine(Convert.ToString(e.Data.GetData(DataFormats.Text)));
                Incorrect();
            }
        }

        #endregion

        #region Buttons
        //code for each of the buttons on the form
        private void mnuExitButton_Click(object sender, EventArgs e) //menu strip exit button
         {
            DialogResult exitConfirm = new DialogResult();

            exitConfirm = MessageBox.Show("Are you sure you wish to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (exitConfirm == DialogResult.Yes)
            {
                Application.Exit();
            }
         }//opens YesNo dialogue and exits is yes is chosen

         private void mnuLogout_Click(object sender, EventArgs e) //menu strip exit button
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
        private void btnMainMenu_Click(object sender, EventArgs e) //Main menu button
        {
            DialogResult mainConfirm = new DialogResult();
            mainConfirm = MessageBox.Show("Are you sure you want to go to main menu?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (mainConfirm == DialogResult.Yes)
            {
                frm02MainMenu main = new frm02MainMenu();
                this.Hide();
                main.Show();
            }//confirmation dialogue
        }

        private void btnMainMenu_Click_1(object sender, EventArgs e) //when clicked, shows confirmation prompt and (if yes) brings user back to the main menu
        {
            DialogResult exitConfirm = new DialogResult();

            exitConfirm = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (exitConfirm == DialogResult.Yes)
            {
                frm02MainMenu main = new frm02MainMenu();
                this.Hide();
                main.Show();
            }

        }

        private void BtnStudy_Click(object sender, EventArgs e) //brings user to the study form (removed from final version)
        {
            frm07Study stud = new frm07Study();
            this.Hide();
            stud.Show();
        }

        private void BtnResults_Click(object sender, EventArgs e) //brings user to results form (removed from final version)
        {
            frm06Results res = new frm06Results();
            this.Hide();
            res.Show();
        }

        private void btnQuiz_Click(object sender, EventArgs e) //brings user to quiz form
        {
            DialogResult exitConfirm = new DialogResult();

            exitConfirm = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (exitConfirm == DialogResult.Yes)
            {
                frm03Quiz ma = new frm03Quiz();
                this.Hide();
                ma.Show();
            }

        }
        #endregion

        public void Correct() //procedure for whenever questions are answered correctly
        {
            MessageBox.Show("Answer Correct!", "Correct");
            GlobalVars.intComponentsCorrect1++;//increments global correct score variable
            lblCorrectCount.Text = Convert.ToString(GlobalVars.intComponentsCorrect1); //displays correct score on label
            GlobalVars.intTotal++;
            GlobalVars.intCorrectAnswers++; //increments total answers and total correct answers

        }

        public void Incorrect() //procedure for whenever questions are answered incorrectly
        {
            MessageBox.Show("Answer Incorrect!", "Incorrect");
            GlobalVars.intComponentsIncorrect1++;//increments global incorrect score variable
            lblIncorrectCount.Text = Convert.ToString(GlobalVars.intComponentsIncorrect1); //displays incorrect score on label
            GlobalVars.intTotal++;
            GlobalVars.intIncorrectAnswers++; //increments total answers and total incorrect answers
        }



#region shhhhhhhh
        private void lblUSB_Drop_Click_1(object sender, EventArgs e)
        {

        }

        private void lblCPU_Drop_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void lblFan_Drop_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void lblFloppy_Drop_MouseDown(object sender, MouseEventArgs e)
        {
          
        }

        private void lblRAM_Drop_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void lblUSB_Drop_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void lblHDD_Drop_MouseDown(object sender, MouseEventArgs e)
        {
          
        }

        private void lblCorrectCount_Click_1(object sender, EventArgs e)
        {

        }  
        
        private void lblCPU_Drop_Click_1(object sender, EventArgs e)
        {

        }

        private void lblRAM_Drop_Click(object sender, EventArgs e)
        {

        }
        #endregion //why are you looking! 
//we dont talk about this 

        private void lnkHelpDoc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //"user guide" label, opens up the help document once clicked
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

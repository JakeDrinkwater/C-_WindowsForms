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
    public partial class frmLevel1 : Form
    {
        public frmLevel1()
        {
            InitializeComponent();
        }

        #region Misc
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
        //Code to handle a mouse drag and drop for each of the bottom labels
        private void lblRAM_MouseDown_1(object sender, MouseEventArgs e)
        {
            //allows drag and drop
            DoDragDrop(lblRAM.Text, DragDropEffects.Copy);
        }
        private void lblFloppy_MouseDown(object sender, MouseEventArgs e)
        {
            //allows drag and drop
            DoDragDrop(lblFloppy.Text, DragDropEffects.Copy);

        }

        private void lblFan_MouseDown(object sender, MouseEventArgs e)
        {
            //allows drag and drop
            DoDragDrop(lblFan.Text, DragDropEffects.Copy);

        }

        private void lblHDD_MouseDown(object sender, MouseEventArgs e)
        {
            //allows drag and drop
            DoDragDrop(lblHDD.Text, DragDropEffects.Copy);

        }

        private void lblCPU_MouseDown(object sender, MouseEventArgs e)
        {
            //allows drag and drop
            DoDragDrop(lblCPU.Text, DragDropEffects.Copy);

        }

        private void lblUSB_MouseDown(object sender, MouseEventArgs e)
        {
            //allows drag and drop
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
        //events for whenever the label is dropped
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
        private void mnuExitButton_Click(object sender, EventArgs e)
         {
            DialogResult exitConfirm = new DialogResult();

            exitConfirm = MessageBox.Show("Are you sure you wish to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (exitConfirm == DialogResult.Yes)
            {
                Application.Exit();
            }
         }//opens YesNo dialogue and exits is yes is chosen

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
        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            DialogResult mainConfirm = new DialogResult();
            mainConfirm = MessageBox.Show("Are you sure you want to go to main menu?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (mainConfirm == DialogResult.Yes)
            {
                frmMainMenu main = new frmMainMenu();
                this.Hide();
                main.Show();
            }
        }   

        #endregion

        public void Correct()
        {
            MessageBox.Show("Answer Correct!", "Correct");
            GlobalVars.intComponentsCorrect++;//increments global correct score variable
            lblCorrectCount.Text = Convert.ToString(GlobalVars.intComponentsCorrect); //displays correct score on label
        }

        public void Incorrect()
        {
            MessageBox.Show("Answer Incorrect!", "Incorrect");
            GlobalVars.intComponentsIncorrect++;//increments global incorrect score variable
            lblIncorrectCount.Text = Convert.ToString(GlobalVars.intComponentsIncorrect); //displays incorrect score on label
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


        #endregion

        private void btnMainMenu_Click_1(object sender, EventArgs e)
        {
            DialogResult exitConfirm = new DialogResult();

            exitConfirm = MessageBox.Show("Are you sure?", "Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if (exitConfirm == DialogResult.Yes)
            {
                frmMainMenu main = new frmMainMenu();
                this.Hide();
                main.Show();
            }
           
        }
    }
}

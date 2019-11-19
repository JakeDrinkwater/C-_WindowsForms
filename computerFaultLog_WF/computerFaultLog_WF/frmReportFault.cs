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
    public partial class frmReportFault : Form
    {
        public frmReportFault()
        {
            InitializeComponent();
        }

        private void BtnLogOut_Click(object sender, EventArgs e) //Main menu Button
        {
            frmUserDetails MainMenu = new frmUserDetails();
            this.Hide();
            MainMenu.Show();
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

        private void BtnLogOut_Click_1(object sender, EventArgs e)
        {
            DialogResult exitConfirm = new DialogResult();

            exitConfirm = MessageBox.Show("Are you sure you wish to log out?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (exitConfirm == DialogResult.Yes)
            {
                frmLogIn LogIn = new frmLogIn();
                this.Hide();
                LogIn.Show();
            }
        }

        private void LblDateTime_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            lblDateTime.Text = Convert.ToString(date);
        }

        private void LblDepartment_Click(object sender, EventArgs e)
        {

        }

        private void LblFName_Click(object sender, EventArgs e)
        {

        }

        private void LblTitle_Click(object sender, EventArgs e)
        {

        }

        private void LblSName_Click(object sender, EventArgs e)
        {

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtDepartment.Clear();
            txtFName.Clear();
            txtSName.Clear();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            globalVars.Title = cboTitle.Text;
            globalVars.Forname = txtFName.Text;
            globalVars.SureName = txtSName.Text;
            globalVars.Department = txtDepartment.Text;

            MessageBox.Show("Record Saved","Saved");

            cboTitle.Enabled = false;
            txtDepartment.Enabled = false;
            txtFName.Enabled = false;
            txtSName.Enabled = false;
            btnSubmit.Enabled = false;
            btnClear.Enabled = false;
        }
    }
}

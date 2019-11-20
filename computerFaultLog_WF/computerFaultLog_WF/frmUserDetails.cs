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
    public partial class frmUserDetails : Form
    {
        public frmUserDetails()
        {
            InitializeComponent();
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

        private void BtnLogin_Click(object sender, EventArgs e)
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

        private void BtnReportFault_Click(object sender, EventArgs e)
        {
            frmReportFault ReportFault = new frmReportFault();
            this.Hide();
            ReportFault.Show();
        }

        private void LblDateTime_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            lblDateTime.Text = Convert.ToString(date);
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDepartment.Clear();
            txtFName.Clear();
            txtSName.Clear();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            globalVars.Title = cboTitle.Text;
            globalVars.Forname = txtFName.Text;
            globalVars.Surname = txtSName.Text;
            globalVars.Department = txtDepartment.Text;

            MessageBox.Show("Record Saved", "Saved");

            cboTitle.Enabled = false;
            txtDepartment.Enabled = false;
            txtFName.Enabled = false;
            txtSName.Enabled = false;
            btnSubmit.Enabled = false;
            btnClear.Enabled = false;

            lstDetails.Items.Add(globalVars.Title);
            lstDetails.Items.Add(globalVars.Forname);
            lstDetails.Items.Add(globalVars.Surname);
            lstDetails.Items.Add(globalVars.Department);
        }

        private void lstDetails_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            cboTitle.Enabled = true;
            txtDepartment.Enabled = true;
            txtFName.Enabled = true;
            txtSName.Enabled = true;
            btnSubmit.Enabled = true;
            btnClear.Enabled = true;

            txtDepartment.Clear();
            txtFName.Clear();
            txtSName.Clear();

            lstDetails.Items.Add("\n");
        }
    }
}

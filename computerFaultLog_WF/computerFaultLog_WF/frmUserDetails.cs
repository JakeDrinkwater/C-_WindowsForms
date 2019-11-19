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
    }
}

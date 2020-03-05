using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm_WF
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void grpBanner_Enter(object sender, EventArgs e)
        {

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

        private void btnExisting_Click(object sender, EventArgs e)
        {
            frmExistingUser Main = new frmExistingUser();

            this.Hide();
            Main.Show();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmNewUser Main = new frmNewUser();

            this.Hide();
            Main.Show();
        }
    }
}

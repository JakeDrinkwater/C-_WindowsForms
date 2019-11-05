using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem_WF
{
    public partial class frmTemplate : Form
    {
        public frmTemplate()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult exitConfirm = new DialogResult();

            exitConfirm = MessageBox.Show("Are you sure you wish to exit?","Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if (exitConfirm == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnMainMenu_Click(object sender, EventArgs e)
        {
            frmMainMenu MainMenu = new frmMainMenu();

            MainMenu.Show();
            this.Hide();
        }

        private void BtnAddBooks_Click(object sender, EventArgs e)
        {
            frmAddBooks AddBooks = new frmAddBooks();

            AddBooks.Show();
            this.Hide();
        }
    }
}

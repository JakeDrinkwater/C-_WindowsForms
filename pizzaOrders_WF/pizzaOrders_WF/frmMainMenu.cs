using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizzaOrders_WF
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e) //exit button
        {
            DialogResult exitConfirm = new DialogResult();

            exitConfirm = MessageBox.Show("Are you sure you wish to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (exitConfirm == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnMainMenu_Click(object sender, EventArgs e) //main menu button
        {
            frmMainMenu MainMenu = new frmMainMenu();

            MainMenu.Show();
            this.Hide();
        }

        private void BtnOrderPizza_Click(object sender, EventArgs e) //order pizza button
        {
            frmOrderPizza OrderPizza = new frmOrderPizza();

            OrderPizza.Show();
            this.Hide();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void PtcLogo_Click(object sender, EventArgs e)
        {

        }
    }
}

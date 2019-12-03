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
    public partial class frmOrderPizza : Form

    {
        //Variables //
        double total;

        // // // // //
        public frmOrderPizza()
        {
            InitializeComponent();
        }

        private void BtnMainMenu_Click(object sender, EventArgs e)
        {
            frmMainMenu MainMenu = new frmMainMenu();

            MainMenu.Show();
            this.Hide();
        }

        private void BtnOrderPizza_Click(object sender, EventArgs e)
        {

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

        private void RadioButton2_CheckedChanged(object sender, EventArgs e) //rdb medium
        {

        }

        private void RdbSmall_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e) //pineapple checkbox
        {

        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e) //pepperoni check box
        {

        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e) //ham check box
        {

        }

        private void ChkCheese_CheckedChanged(object sender, EventArgs e) //Cheese Check Box
        {

        }

        private void Button1_Click(object sender, EventArgs e) //place order button
        {
            #region pizzaSize
            lstOrder.Items.Clear();
            total = 0;

            if (radioButton3.Checked == true)
            {
                total = total + 6.99;
                lstOrder.Items.Add("Small Pizza");
            }
            else if (rdbMedium.Checked == true)
            {
                total = total + 11.99;
                lstOrder.Items.Add("Medium Pizza");
            }
            else if(radioButton1.Checked == true)
            {
                total = total + 16.99;
                lstOrder.Items.Add("Large Pizza");
            }
            #endregion

            txtLabel.Text = Convert.ToString(total);
        }

        private void LstOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e) //rdb large
        {

        }
    }
}

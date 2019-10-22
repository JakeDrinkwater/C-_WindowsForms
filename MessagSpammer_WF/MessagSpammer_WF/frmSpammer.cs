using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessagSpammer_WF
{
    public partial class frmSpammer : Form
    {
        public frmSpammer()
        {
            InitializeComponent();
        }

        private void LblRun_Click(object sender, EventArgs e)
        {

        }

        private void TxtRun_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e) //btnClear
        {
            txtMessage.Clear();
            txtRun.Clear();
            lstMessage.Items.Clear();
        }

        private void Button3_Click(object sender, EventArgs e) //btnLogOut
        {
            frmMessageSpammer frmMessageSpammer = new frmMessageSpammer();
            frmMessageSpammer.Show();
            this.Hide();
        }

        private void BtnClear_Click(object sender, EventArgs e) //btnRun
        {
            string Message = txtMessage.Text;
            double RunTime = Convert.ToInt32(txtRun.Text);

            for(double a = 0; a < RunTime; a++)
            {
                lstMessage.Items.Add(Message);
            }
        }
    }
}

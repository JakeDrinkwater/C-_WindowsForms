using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_WF
{
    public partial class frmCalculator : Form
    {
        //Variables
        decimal Number1;
        decimal Number2;
        decimal Answer;
        //

        public frmCalculator()
        {
            InitializeComponent();
        }
        private void LblCalculatorTitle_Click(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Number1 = Convert.ToDecimal(txtNumber1.Text);
            Number2 = Convert.ToDecimal(txtNumber2.Text);

            Answer = Number1 + Number2;
            txtAnswerBox.Text = Answer.ToString();
        }

       private void BtnSubt_Click(object sender, EventArgs e)
        {
            Number1 = Convert.ToDecimal(txtNumber1.Text);
            Number2 = Convert.ToDecimal(txtNumber2.Text);

            Answer = Number1 - Number2;
            txtAnswerBox.Text = Answer.ToString();
        }

        private void BtnDivid_Click(object sender, EventArgs e)
        {
            Number1 = Convert.ToDecimal(txtNumber1.Text);
            Number2 = Convert.ToDecimal(txtNumber2.Text);

            Answer = Number1 / Number2;
            txtAnswerBox.Text = Answer.ToString();
        }

        private void BtnMultip_Click(object sender, EventArgs e)
        {
            Number1 = Convert.ToDecimal(txtNumber1.Text);
            Number2 = Convert.ToDecimal(txtNumber2.Text);

            Answer = Number1 * Number2;
            txtAnswerBox.Text = Answer.ToString();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtNumber1.Clear();
            txtNumber2.Clear();
            txtAnswerBox.Clear();
        }

        private void FrmCalculator_Load(object sender, EventArgs e)
        {

        }

        private void Lblno2_Click(object sender, EventArgs e)
        {

        }

        private void LblNo1_Click(object sender, EventArgs e)
        {

        }

        private void TxtNumber1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNumber2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtAnswerBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}

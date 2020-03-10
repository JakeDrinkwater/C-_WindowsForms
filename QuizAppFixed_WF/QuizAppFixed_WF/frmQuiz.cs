using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizAppFixed_WF
{
    public partial class frmQuiz : Form
    {
        public frmQuiz()
        {
            InitializeComponent();
        }

        private void mnuExitButton_Click(object sender, EventArgs e)
        {

        }

        private void mnuLogout_Click(object sender, EventArgs e)
        {

        }

        private void LblTitle_Click(object sender, EventArgs e)
        {
            frmMainMenu main = new frmMainMenu();
            this.Hide();
            main.Show();
        }

        private void BtnStudy_Click(object sender, EventArgs e)
        {
            frmStudy stud = new frmStudy();
            this.Hide(); 
            stud.Show();
        }

        private void BtnResults_Click(object sender, EventArgs e)
        {
            frmResults res = new frmResults();
            this.Hide();
            res.Show();
        }
    }
}

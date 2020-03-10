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
    public partial class frmResults : Form
    {
        public frmResults()
        {
            InitializeComponent();
        }

        private void grpLeftSide_Enter(object sender, EventArgs e)
        {

        }

        private void BtnQuiz_Click(object sender, EventArgs e)
        {
            frmQuiz quiz = new frmQuiz();
            this.Hide();
            quiz.Show();
        }

        private void BtnStudy_Click(object sender, EventArgs e)
        {
            frmStudy stud = new frmStudy();
            this.Hide();
            stud.Show();
        }
    }
}

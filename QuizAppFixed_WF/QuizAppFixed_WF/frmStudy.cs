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
    public partial class frmStudy : Form
    {
        public frmStudy()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)//ICT tab
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnQuiz_Click(object sender, EventArgs e)
        {
            frmQuiz quiz = new frmQuiz();
            this.Hide();
            quiz.Show();
        }
    }
}

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
    public partial class frmAddBooks : frmTemplate
    {
        //Variables
        string[] Author = new string[1];
        string[] Title = new string[1];
        string[] ISBN = new string[1];
        string[] Price = new string[1];

        int ArrayCounter = 0;
        //
        public frmAddBooks()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Author[ArrayCounter] = txtAuthor.Text;
                Title[ArrayCounter] = txtTitle.Text;
                ISBN[ArrayCounter] = txtISBN.Text;
                Price[ArrayCounter] = txtPrice.Text;

                ArrayCounter++;

                MessageBox.Show("Record saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clearbtn();
            }catch (Exception ex)
            {
                MessageBox.Show("Max amount of books reached", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Disable();
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Clearbtn();
        }

        private void LstBooks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnBookView_Click(object sender, EventArgs e)
        {
            lstBooks.Items.Clear();

            for(int i = 0; i < ArrayCounter; i++)
            {
                lstBooks.Items.Add(Author[i]);
                lstBooks.Items.Add(Title[i]);
                lstBooks.Items.Add(ISBN[i]);
                lstBooks.Items.Add("£" + Price[i]);
                lstBooks.Items.Add("\n");
            }
          
        }


        private void Clearbtn() {
            txtAuthor.Clear();
            txtTitle.Clear();
            txtISBN.Clear();
            txtPrice.Clear();
        }

        private void Disable()
        {
            txtAuthor.Enabled = false;
            txtTitle.Enabled = false;
            txtISBN.Enabled = false;
            txtPrice.Enabled = false;

            btnSave.Enabled = false;
        }


    }
}

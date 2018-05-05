using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryApp
{
    public partial class LibTracker_Add : Form
    {
        SqlCommand cmd;
        public LibTracker_Add()
        {
            InitializeComponent();

            btnAdd.Enabled = false;
            //set Genre list box to top entry (acts as a form of validation)
            lbAddGenre.SelectedIndex = 0;

            //initialize ToolTips for all data entry fields and buttons to give user vital information on how to 
            //fill out and use the form
            tipISBN.SetToolTip(mtbAddISBN, "This field allows you to specify the book's ISBN\n" +
                "**Field only takes numbers");
            tipTitle.SetToolTip(txtAddTitle, "This field allows you to specify the book's title\n" +
                "**Field takes a maximum of 50 characters");
            tipAuthor.SetToolTip(txtAddAuthor, "This field allows you to specify the book's author\n" +
                "**Field takes a maximum of 50 characters");
            tipGenre.SetToolTip(lbAddGenre, "This field allows you to specify the book's genre\n" +
                "**You can only select one genre at a time");
            tipCopies.SetToolTip(numAddCopies, "This field allows you to specify the number of copies of the book\n" +
                "**minimum number of copies is 1, maximum is 20");
            tipRating.SetToolTip(nudAddRating, "This field allows you to specify the rating of the book\n" +
                "**rating is on a scale of 1 to 5 (1 being least popular, 5 being most popular");
            tipSynopsis.SetToolTip(txtAddSynopsis, "This field allows you to specify the book's synopsis\n" +
                "**maximum of 300 characters is allowed");
        }

        //Click event that sends user to the Home page
        private void menuItemHome_Click(object sender, EventArgs e)
        {
            new LibTracker().Show();
            this.Hide();
        }

        //Click event that sends the user to the Search Books form
        private void menuItemSearch_Click(object sender, EventArgs e)
        {
            new LibTracker_search().Show();
            this.Hide();
        }

        //Click event that sends the user to the Delete Books form
        private void menuItemDelete_Click(object sender, EventArgs e)
        {
            new LibTracker_Delete().Show();
            this.Hide();
        }

        //Click event that sends the user to the Update Books form
        private void menuItemUpdate_Click(object sender, EventArgs e)
        {
            new LibTracker_UpdateBook().Show();
            this.Hide();
        }

        //Validation for the ISBN number field
        private void mtbAddISBN_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            
            if (!ValidEntry(mtbAddISBN.Text, out errorMsg))
            {
                
                //cancels the event to be corrected
                e.Cancel = true;
                //Cancel the event and select the text to be correct
                mtbAddISBN.Select(0, mtbAddISBN.Text.Length);
                //Set the ErrorProvider error with the text to display
                this.errISBN.SetError(mtbAddISBN, errorMsg);
            }
            if (e.Cancel == false)
                this.errISBN.Clear();
        }

        private void mtbAddISBN_Validated(object sender, EventArgs e)
        {
            errISBN.SetError(mtbAddISBN, "");
            txtAddAuthor.Focus();
        }

        //Validation for the Title field
        private void txtAddTitle_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidEntry(txtAddTitle.Text, out errorMsg))
            {
                //cancels the event to be corrected
                e.Cancel = true;
                //Cancel the event and select the text to be correct
                txtAddTitle.Select(0, txtAddTitle.Text.Length);
                //Set the ErrorProvider error with the text to display
                this.errTitle.SetError(txtAddTitle, errorMsg);
            }
            if (e.Cancel == false)
                this.errTitle.Clear();
        }

        private void txtAddTitle_Validated(object sender, EventArgs e)
        {
            errTitle.SetError(txtAddTitle, "");
            mtbAddISBN.Focus();
        }

        //Validation for the Author field
        private void txtAddAuthor_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidEntry(txtAddAuthor.Text, out errorMsg))
            {
                //cancels the event to be corrected
                e.Cancel = true;
                //Cancel the event and select the text to be correct
                txtAddAuthor.Select(0, txtAddAuthor.Text.Length);
                //Set the ErrorProvider error with the text to display
                this.errAuthor.SetError(txtAddAuthor, errorMsg);
            }
            if (e.Cancel == false)
                this.errAuthor.Clear();
        }

        private void txtAddAuthor_Validated(object sender, EventArgs e)
        {
            errAuthor.SetError(txtAddAuthor, "");
            btnAdd.Enabled = true;
        }

        //Method to check for empty fields
        public bool ValidEntry(string mtbField, out string errorMessage)
        {
            //check if field is empty
            if (mtbField.Length == 0)
            {
                errorMessage = "You must provide data in this field.";
                return false;
            }
            else
            {
                errorMessage = "";
                return true;
            }

        }

        //Click event that clears all fields on the Add Books form
        private void btnAddClear_Click(object sender, EventArgs e)
        {
            txtAddAuthor.Text = "";
            mtbAddISBN.Text = "";
            txtAddSynopsis.Text = "";
            txtAddTitle.Text = "";
            lbAddGenre.SelectedIndex = 0;
            nudAddRating.Value = 1;
            numAddCopies.Value = 1;
            btnAdd.Enabled = false;
            
        }

        //Click event for adding a new Book into the LibraryInventory table
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            //create book object with user defined values
            Book temp = new Book( Convert.ToInt64(mtbAddISBN.Text), txtAddTitle.Text, txtAddAuthor.Text, 
                lbAddGenre.Text, (int)nudAddRating.Value, (int)numAddCopies.Value, txtAddSynopsis.Text);

            //add book to database
            temp.AddBook(temp);

            //reset fields on form for more input
            txtAddAuthor.Text = "";
            mtbAddISBN.Text = "";
            txtAddSynopsis.Text = "";
            txtAddTitle.Text = "";
            lbAddGenre.SelectedIndex = 0;
            nudAddRating.Value = 1;
            numAddCopies.Value = 1;
            btnAdd.Enabled = false;
            
        }

        //Help Menu pop up with general instructions on how to use this page
        private void menuItemHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter information for all fields\nbefore clicking the 'Add' button to add a Book to inventory.\n\n" +
                "You can use the 'Clear' button to clear all fields\n" +
                "and start again. ", "Help Menu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

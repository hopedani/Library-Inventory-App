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
    public partial class LibTracker_UpdateBook : Form
    {
        //define variables used for database connection
        public SqlConnection con;
        public SqlDataAdapter da;
        public SqlCommand sqlCmd;
        DataSet ds;
        long toUpdate;
        public LibTracker_UpdateBook()
        {
            InitializeComponent();

            //Create a dataset and link it to the data grid view
            DataSet ds = Commands.CreateDataSet();
            dgvUpdate.DataSource = ds.Tables["LibraryInventory"];
            btnUpdate.Enabled = false;

            //initialize ToolTips for all data entry fields and buttons to give user vital information on how to 
            //fill out and use the form

            tipTitle.SetToolTip(txtUpdateTitle, "This field allows you to update the book's title\n" +
                "**Field takes a maximum of 50 characters");
            tipAuthor.SetToolTip(txtUpdateAuthor, "This field allows you to update the book's author\n" +
                "**Field takes a maximum of 50 characters");
            tipGenre.SetToolTip(lbUpdateGenre, "This field allows you to update the book's genre\n" +
                "**You can only select one genre at a time");
            tipCopies.SetToolTip(numUpdateCopies, "This field allows you to update the number of copies of the book\n" +
                "**minimum number of copies is zero, maximum is 20");
            tipRating.SetToolTip(nudUpdateRating, "This field allows you to update the rating of the book\n" +
                "**rating is on a scale of 1 to 5 (1 being least popular, 5 being most popular");
            tipSynopsis.SetToolTip(txtUpdateSynopsis, "This field allows you to update the book's synopsis\n" +
                "**maximum of 300 characters is allowed");
        }

        //Click event that sends user to the Search Books form
        private void menuItemSearch_Click(object sender, EventArgs e)
        {
            new LibTracker_search().Show();
            this.Hide();
        }

        //Click event that sends user to the Add Books form
        private void menuItemAdd_Click(object sender, EventArgs e)
        {
            new LibTracker_Add().Show();
            this.Hide();
        }

        //Click event that sends user to the Delete Books form
        private void menuItemDelete_Click(object sender, EventArgs e)
        {
            new LibTracker_Delete().Show();
            this.Hide();
        }

        //Click event that directs user back to the Home page
        private void menuItemHome_Click(object sender, EventArgs e)
        {
            new LibTracker().Show();
            this.Hide();
        }

        //Click event that clears all the fields in the Update Books form
        private void btnUpdateClear_Click(object sender, EventArgs e)
        {
            txtUpdateAuthor.Text = "";
            txtUpdateSynopsis.Text = "";
            txtUpdateTitle.Text = "";
            lbUpdateGenre.SelectedIndex = -1;
            nudUpdateRating.Value = 1;
            numUpdateCopies.Value = 0;
            lbUpdateGenre.SelectedIndex = 0;
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

        //Validation for Title field
        private void txtUpdateTitle_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidEntry(txtUpdateTitle.Text, out errorMsg))
            {
                //cancels the event to be corrected
                e.Cancel = true;
                //Cancel the event and select the text to be correct
                txtUpdateTitle.Select(0, txtUpdateTitle.Text.Length);
                //Set the ErrorProvider error with the text to display
                this.errTitle.SetError(txtUpdateTitle, errorMsg);
            }
            if (e.Cancel == false)
                this.errTitle.Clear();
        }

        private void txtUpdateTitle_Validated(object sender, EventArgs e)
        {
            errTitle.SetError(txtUpdateTitle, "");
        }

        //Validation for Author field
        private void txtUpdateAuthor_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidEntry(txtUpdateAuthor.Text, out errorMsg))
            {
                //cancels the event to be corrected
                e.Cancel = true;
                //Cancel the event and select the text to be correct
                txtUpdateAuthor.Select(0, txtUpdateAuthor.Text.Length);
                //Set the ErrorProvider error with the text to display
                this.errAuthor.SetError(txtUpdateAuthor, errorMsg);
            }
            if (e.Cancel == false)
                this.errAuthor.Clear();
        }

        private void txtUpdateAuthor_Validated(object sender, EventArgs e)
        {
            errAuthor.SetError(txtUpdateAuthor, "");
        }

        //Click event to Update user selected book
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //create Book object with user defined values
            Book temp = new Book(toUpdate, txtUpdateTitle.Text, txtUpdateAuthor.Text,
                lbUpdateGenre.Text, (int)nudUpdateRating.Value, (int)numUpdateCopies.Value, txtUpdateSynopsis.Text);

            //update book in database by calling the Edit method in the Book class
            temp.EditBook(temp);
            DataSet ds = Commands.CreateDataSet();
            dgvUpdate.DataSource = ds.Tables["LibraryInventory"];

            //reset fields on form for potential next update
            txtUpdateAuthor.Text = "";
            txtUpdateSynopsis.Text = "";
            txtUpdateTitle.Text = "";
            lbUpdateGenre.SelectedIndex = -1;
            nudUpdateRating.Value = 1;
            numUpdateCopies.Value = 1;
            btnUpdate.Enabled = false;
        }

        //Click event to grab Book information from dataset and populate it in their respective fields on the form, so the user
        //can choose to manipulate.
        private void dgvUpdate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvUpdate.Rows[e.RowIndex];

            toUpdate = Convert.ToInt64(row.Cells[0].Value.ToString());
            
            //Fill the input fields with the values of the row array

            txtUpdateTitle.Text = row.Cells[1].Value.ToString();
            txtUpdateAuthor.Text = row.Cells[2].Value.ToString();
            lbUpdateGenre.SelectedIndex = lbUpdateGenre.FindStringExact(row.Cells[3].Value.ToString());
            nudUpdateRating.Value = Convert.ToInt32(row.Cells[4].Value.ToString());
            numUpdateCopies.Value = Convert.ToInt32(row.Cells[5].Value.ToString());
            txtUpdateSynopsis.Text = row.Cells[6].Value.ToString();

            //Enable the update button
            btnUpdate.Enabled = true;
        }

        //Help Menu pop up with general instructions on how to use this page
        private void menuItemHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Select a Book from the Inventory list on the right.\nChange the book's information on the left.\n" +
                "Click the 'Update' button to update the information in the Library's Inventory.\n\n" +
                "Click the 'Clear' button to empty all fields at once.\n\n**NOTE: You cannot change a Book's ISBN number.\n" +
                "You must Add a 'new' Book to enter a different ISBN"
                , "Help Menu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    }


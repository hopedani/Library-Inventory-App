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
    public partial class LibTracker_search : Form
    {
        //variables used for database connection and dataset
        public SqlConnection con;
        public SqlDataAdapter da;
        public SqlCommand sqlCmd;
        DataSet ds;
        public LibTracker_search()
        {
            InitializeComponent();

            //Create dataset from LibraryInventory table in Library database and connect it to data grid view
            ds = Commands.CreateDataSet();
            dgvSearch.DataSource = ds.Tables["LibraryInventory"];
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LibraryFinal;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
           

            //initialize ToolTips for all data entry fields and buttons to give user vital information on how to 
            //fill out and use the form
            tipISBN.SetToolTip(mtbSearchISBN, "This field allows you to search for a book by it's ISBN\n" +
                "**Field only takes numbers");
            tipTitle.SetToolTip(txtSearchTitle, "This field allows you to search for a book by it's title\n" +
                "**Field takes a maximum of 50 characters");
            tipAuthor.SetToolTip(txtSearchAuthor, "This field allows you to search for a book by it's author\n" +
                "**Field takes a maximum of 50 characters");
            tipGenre.SetToolTip(lbSearchGenre, "This field allows you to search a book by it's genre\n" +
                "**You can only select one genre at a time");
        }

        //Click event that sends the user to the Home page
        private void menuItemHome_Click(object sender, EventArgs e)
        {
            new LibTracker().Show();
            this.Hide();
        }

        //Click event that sends the user to the Add Books form
        private void menuItemAdd_Click(object sender, EventArgs e)
        {
            new LibTracker_Add().Show();
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

        //Click event that clears all fields on the Search Books form
        private void btnSearchClear_Click(object sender, EventArgs e)
        {
            txtSearchAuthor.Text = "";
            mtbSearchISBN.Text = "";
            txtSearchTitle.Text = "";
            lbSearchGenre.SelectedIndex = -1;
            txtSearchTitle.Enabled = true;
            txtSearchAuthor.Enabled = true;
            mtbSearchISBN.Enabled = true;
            lbSearchGenre.Enabled = true;
            ds = Commands.CreateDataSet();
            dgvSearch.DataSource = ds.Tables["LibraryInventory"];
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

        //Validation method for Title field
        private void txtSearchTitle_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidEntry(txtSearchTitle.Text, out errorMsg))
            {
                //cancels the event to be corrected
                e.Cancel = true;
                //Cancel the event and select the text to be correct
                txtSearchTitle.Select(0, txtSearchTitle.Text.Length);
                //Set the ErrorProvider error with the text to display
                this.errTitle.SetError(txtSearchTitle, errorMsg);
            }
            if (e.Cancel == false)
                this.errTitle.Clear();
        }

        private void txtSearchTitle_Validated(object sender, EventArgs e)
        {
            errTitle.SetError(txtSearchTitle, "");
        }

        //Validation method for ISBN number field
        private void mtbSearchISBN_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidEntry(mtbSearchISBN.Text, out errorMsg))
            {
                //cancels the event to be corrected
                e.Cancel = true;
                //Cancel the event and select the text to be correct
                mtbSearchISBN.Select(0, mtbSearchISBN.Text.Length);
                //Set the ErrorProvider error with the text to display
                this.errISBN.SetError(mtbSearchISBN, errorMsg);
            }
            if (e.Cancel == false)
                this.errISBN.Clear();
        }

        private void mtbSearchISBN_Validated(object sender, EventArgs e)
        {
            errISBN.SetError(mtbSearchISBN, "");
        }

        //Validation method for Author field
        private void txtSearchAuthor_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidEntry(txtSearchAuthor.Text, out errorMsg))
            {
                //cancels the event to be corrected
                e.Cancel = true;
                //Cancel the event and select the text to be correct
                txtSearchAuthor.Select(0, txtSearchAuthor.Text.Length);
                //Set the ErrorProvider error with the text to display
                this.errAuthor.SetError(txtSearchAuthor, errorMsg);
            }
            if (e.Cancel == false)
                this.errAuthor.Clear();
        }

        private void txtSearchAuthor_Validated(object sender, EventArgs e)
        {
            errAuthor.SetError(txtSearchAuthor, "");
        }

        //Click event for searching database
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Check for which field is enabled(active) and grab the information from it to check database for value
            if (txtSearchTitle.Enabled)
            {
                sqlCmd = new SqlCommand(Commands.SearchTitle("@Title"), con);
                sqlCmd.Parameters.AddWithValue("Title", txtSearchTitle.Text);
                con.Open();
                da = new SqlDataAdapter();
                ds = new DataSet();
                da.SelectCommand = sqlCmd;
                da.Fill(ds, "LibraryInventory");
                dgvSearch.DataSource = ds.Tables["LibraryInventory"];
                con.Close();
            }
            else if (txtSearchAuthor.Enabled)
            {
                sqlCmd = new SqlCommand(Commands.SearchAuthor("@Author"), con);
                sqlCmd.Parameters.AddWithValue("Author", txtSearchAuthor.Text);
                con.Open();
                da = new SqlDataAdapter();
                ds = new DataSet();
                da.SelectCommand = sqlCmd;
                da.Fill(ds, "LibraryInventory");
                dgvSearch.DataSource = ds.Tables["LibraryInventory"];
                con.Close();
            }
            else if (mtbSearchISBN.Enabled)
            {
                sqlCmd = new SqlCommand(Commands.SearchISBN("@ISBN"), con);
                sqlCmd.Parameters.AddWithValue("ISBN", mtbSearchISBN.Text);
                con.Open();
                da = new SqlDataAdapter();
                ds = new DataSet();
                da.SelectCommand = sqlCmd;
                da.Fill(ds, "LibraryInventory");
                dgvSearch.DataSource = ds.Tables["LibraryInventory"];
                con.Close();
            }
            else if (lbSearchGenre.Enabled) {
                sqlCmd = new SqlCommand(Commands.SearchGenre("@Genre"), con);
                sqlCmd.Parameters.AddWithValue("Genre", lbSearchGenre.Text);
                con.Open();
                da = new SqlDataAdapter();
                ds = new DataSet();
                da.SelectCommand = sqlCmd;
                da.Fill(ds, "LibraryInventory");
                dgvSearch.DataSource = ds.Tables["LibraryInventory"];
                con.Close();
            }
        }
        //Click event to disable all search fields except Title
        private void txtSearchTitle_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearchAuthor.Enabled = false;
            mtbSearchISBN.Enabled = false;
            lbSearchGenre.Enabled = false;
        }

        //Click event to disable all search fields except ISBN
        private void mtbSearchISBN_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearchAuthor.Enabled = false;
            txtSearchTitle.Enabled = false;
            lbSearchGenre.Enabled = false;
        }

        //Click event to disable all search fields except Author
        private void txtSearchAuthor_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearchTitle.Enabled = false;
            mtbSearchISBN.Enabled = false;
            lbSearchGenre.Enabled = false;
        }

        //Click event to disable all search fields except Genre
        private void lbSearchGenre_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearchAuthor.Enabled = false;
            mtbSearchISBN.Enabled = false;
            txtSearchTitle.Enabled = false;
        }

        //Help Menu pop up with general instructions on how to use this page
        private void menuItemHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click on one of the 4 search fields,\n" +
                "enter information to search then click 'Search' button.\n" +
                "Click on the 'Clear' button to clear text entered and open up the other " +
                "search fields.", "Help Menu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

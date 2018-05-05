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
    public partial class LibTracker : Form
    {
        //variable to connect to database and create a dataset that will be used in the Book class
        public SqlConnection con;
        public DataSet ds;
        public SqlDataAdapter da;
        public SqlCommand sqlCmd;
        
        public LibTracker()
        {
            InitializeComponent();

            //create connection to database and fill dataset to be used in Book class
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LibraryFinal;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            con.Open();
            da = new SqlDataAdapter();
            ds = new DataSet();
            sqlCmd = new SqlCommand(Commands.SelectAll(), con);
            da.SelectCommand = sqlCmd;
            da.Fill(ds, "LibraryInventory");
            con.Close();
        }

        //Click event to open Search form, used to search LibraryInventory table
        private void menuItemSearch_Click(object sender, EventArgs e)
        {
            new LibTracker_search().Show();
            this.Hide();
        }

        //Button control to open the Search page and hide the Main page
        private void btnView_Click(object sender, EventArgs e)
        {
            
            new LibTracker_search().Show();
            this.Hide();
        }

        //Click event to open Add form (used to add Books into LibraryInventory table)
        private void menuItemAdd_Click(object sender, EventArgs e)
        {
            new LibTracker_Add().Show();
            this.Hide();
        }

        //Click event to open Delete form (used to delete Books from LibraryInventory table)
        private void menuItemDelete_Click(object sender, EventArgs e)
        {
            new LibTracker_Delete().Show();
            this.Hide();
        }

        //Click event to open Update form (used to update Books from LibraryInventory table)
        private void menuItemUpdate_Click(object sender, EventArgs e)
        {
            new LibTracker_UpdateBook().Show();
            this.Hide();
        }

        //Help Menu pop up with general instructions on how to use this page
        private void menuItemHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to the 'Help Menu'\nYou can click on the 'Help' button at the top of any page\n" +
                "to get instructions related to that page.\n\nClick on the 'Search' button below to look for a Book \n" +
                "in the Library's Inventory.\n\nClicking 'Options' at the top of the page will bring you\n" +
                "to other pages in the application, where you can:\nAdd, Delete, or Update Books in the Library's Inventory." +
                "\n\nYou can click on the 'Home' button at the top any page to bring you back here."
                , "Help Menu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

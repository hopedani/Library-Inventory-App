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
    public partial class LibTracker_Delete : Form
    {
        DialogResult result;
        public SqlConnection con;
        public SqlDataAdapter da;
        public SqlCommand sqlCmd;
        DataSet ds;
        long toDelete;

        public LibTracker_Delete()
        {
            InitializeComponent();

            btnDelete.Enabled = false;
            ds = Commands.CreateDataSet();
            dgvDelete.DataSource = ds.Tables["LibraryInventory"];
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LibraryFinal;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            da = new SqlDataAdapter();
            ds = new DataSet();

            //initialize ToolTips for all data entry fields and buttons to give user vital information on how to 
            //fill out and use the form
            dgvTip.SetToolTip(dgvDelete, "Select a Book record to delete and then click the delete button above");
            
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

        //Click event that sends the user to the Add Books form
        private void menuItemAdd_Click(object sender, EventArgs e)
        {
            new LibTracker_Add().Show();
            this.Hide();
        }

        //Click event that sends the user to the Update Books form
        private void menuItemUpdate_Click(object sender, EventArgs e)
        {
            new LibTracker_UpdateBook().Show();
            this.Hide();
        }

        //Click event for deleting a Book from database
        private void btnDelete_Click(object sender, EventArgs e)
        {
            result = MessageBox.Show("Are you sure you want to delete this book?",
                "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return;
            }

            try
            {
                //if database contains a valid MovieID to delete and user confirms deletion with MessageBox
                //continue with deleting record from database
                con.Open();
                sqlCmd = new SqlCommand (Commands.DeleteBook(toDelete), con);

                da.InsertCommand = sqlCmd;
                da.InsertCommand.ExecuteNonQuery();

                MessageBox.Show("Book deleted successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                ds = Commands.CreateDataSet();
                dgvDelete.DataSource = ds.Tables["LibraryInventory"];
                btnDelete.Enabled = false;
            }
            catch (SqlException ex)
            {

            }
            con.Close();
        }

        //Click event that will grab a the selected Book's ISBN to use in for deleting the Book from database
        private void dgvDelete_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvDelete.Rows[e.RowIndex];
            toDelete = Convert.ToInt64(row.Cells[0].Value.ToString());
            btnDelete.Enabled = true;
        }

        //Help Menu pop up with general instructions on how to use this page
        private void menuItemHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please select a Book record\nand then click the 'Delete' button\n" +
                "to remove the record from the database.", "Help Menu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

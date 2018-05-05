using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryApp
{
    static class Commands
    {
        //method that returns a formatted sql statement that selects all book info connected to a user defined book title
        public static string SearchTitle (string title){
            string result = "SELECT * FROM LibraryInventory WHERE Title = " + title + ";";
            return result;
        }

        //method that returns a formatted sql statement that selects all book info connected to a user defined book ISBN number
        public static string SearchISBN(string ISBN)
        {
            string result = "SELECT * FROM LibraryInventory WHERE ISBN = " + ISBN + ";";
            return result;
        }

        //method that returns a formatted sql statement that selects all book info connected to a user defined book genre 
        public static string SearchGenre(string genre)
        {
            string result = "SELECT * FROM LibraryInventory WHERE Genre = " + genre + ";";
            return result;
        }

        //method that returns a formatted sql statement that selects all book info connected to a user defined book author
        public static string SearchAuthor(string author)
        {
            string result = "SELECT * FROM LibraryInventory WHERE Author = " + author + ";";
            return result;
        }

        //method that returns a formatted sql statement that selects all info from LibraryInventory table
        public static string SelectAll()
        {
            string result = "SELECT * FROM LibraryInventory";
            return result;
        }

        //method that returns a formatted sql statement that deletes a user defined book
        public static string DeleteBook(long ISBN) {
            string result = "DELETE FROM LibraryInventory WHERE ISBN = " + ISBN + ";";
            return result;
        }

        //method that returns a DataSet object based on LibraryInvetory table in Library Database 
        public static DataSet CreateDataSet() {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LibraryFinal;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            SqlCommand sqlCmd = new SqlCommand(Commands.SelectAll(), con);
            da.SelectCommand = sqlCmd;
            da.Fill(ds, "LibraryInventory");
            con.Close();
            return ds;
        } 
    }
}

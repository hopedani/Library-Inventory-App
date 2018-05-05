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
    class Book:LibTracker
    {
        //variables to hold a Book object's attributes
        public string Title { get; set; }
        public long ISBN { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int Rating { get; set; }
        public int NumOfBooks { get; set; }
        public string Synopsis { get; set; }
        
        //Constructor to create a Book object with all associated information
        public Book( long isbn, string title, string author, string genre, int rating, int copies, string synopsis) {
            this.ISBN = isbn;
            this.Title = title;
            this.Author = author;
            this.Genre = genre;
            this.Rating = rating;
            this.NumOfBooks = copies;
            this.Synopsis = synopsis;
        }

      
            //Method to add a Book object
        public void AddBook(Book book) {

            //variable used to check if ISBN is not already in database
            string result = "allGood";

            try
            {
                //create sql command, open connection to database
                sqlCmd = new SqlCommand("Select * FROM LibraryInventory WHERE ISBN = (@ISBN)", con);
                con.Open();
                sqlCmd.Parameters.AddWithValue("ISBN", this.ISBN);
                SqlDataReader tempReader = sqlCmd.ExecuteReader();
                
                //check if record already exists (based on MovieID number)
                if (tempReader.HasRows)
                {
                    MessageBox.Show("The ISBN you selected is already in use!\nPlease choose a different ISBN.",
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    result = "inUse";
                    tempReader.Close();
                   
                    throw new Exception();  //throw exception and catch it to exit method
                    
                }
            }
            catch (SqlException) { }
            catch (Exception) { }
            finally {con.Close(); }

            if (result == "allGood")
            {
                try
                {
                    //create sql command to enter new book info into database
                    sqlCmd = new SqlCommand("INSERT INTO LibraryInventory VALUES(@ISBN , @Title, @Author, @Genre, @Rating, @Copies, @Synopsis);", con);
                    con.Open();

                    //prevent sql injection
                    sqlCmd.Parameters.AddWithValue("ISBN", this.ISBN);
                    sqlCmd.Parameters.AddWithValue("Title", this.Title);
                    sqlCmd.Parameters.AddWithValue("Author", this.Author);
                    sqlCmd.Parameters.AddWithValue("Genre", this.Genre);
                    sqlCmd.Parameters.AddWithValue("Rating", this.Rating);
                    sqlCmd.Parameters.AddWithValue("Copies", this.NumOfBooks);
                    sqlCmd.Parameters.AddWithValue("Synopsis", this.Synopsis);

                    //execute command to add book to database
                    da.InsertCommand = sqlCmd;
                    da.InsertCommand.ExecuteNonQuery();

                    //reload updated database into dataset
                    ds.Tables["LibraryInventory"].Clear();
                    da.Fill(ds, "LibraryInventory");
                }
                catch (SqlException ex){}
                con.Close();
                //inform user of successful addition of book to database
                MessageBox.Show("Book added successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else {
                return;
            }
        }

        //Method for editing a pre-existing Book object
        public void EditBook(Book book) {
            //sql command to edit
            try
            {
                //create sql command to enter new book info into database
                sqlCmd = new SqlCommand("UPDATE LibraryInventory SET Title = @Title, Author = @Author, Genre = @Genre, " +
                    "Rating = @Rating, Copies = @Copies, Synopsis = @Synopsis WHERE ISBN = @ISBN", con);
                con.Open();

                //prevent sql injection
                sqlCmd.Parameters.AddWithValue("ISBN", this.ISBN);
                sqlCmd.Parameters.AddWithValue("Title", this.Title);
                sqlCmd.Parameters.AddWithValue("Author", this.Author);
                sqlCmd.Parameters.AddWithValue("Genre", this.Genre);
                sqlCmd.Parameters.AddWithValue("Rating", this.Rating);
                sqlCmd.Parameters.AddWithValue("Copies", this.NumOfBooks);
                sqlCmd.Parameters.AddWithValue("Synopsis", this.Synopsis);

                //execute command to update database
                da.UpdateCommand = sqlCmd;
                da.UpdateCommand.ExecuteNonQuery();
                da.Update(ds, "LibraryInventory");
                //reload updated database into dataset
                ds.Tables["LibraryInventory"].Clear();
                da.Fill(ds, "LibraryInventory");
                
            }
            catch (SqlException ex) { }
            con.Close();

            //inform user of successful update
            MessageBox.Show("Book updated successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
            
        

        //Method for deleting a Book object
        public void DeleteBook(Book book) {
            //add sql command for deleting from db
        }
    }
}

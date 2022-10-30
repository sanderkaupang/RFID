using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFID
{
    internal class DeleteBook : ClassConnectionSQL
    {
        public void ClassDeleteBook(string bookTitle)
        {   // if the user dont enter book title show error
            if (!(bookTitle == string.Empty))
            {
                ClassConnectionSQL classConnectionSQL = new ClassConnectionSQL(); // con to database
                classConnectionSQL.ConnectionToDatabase();

                string query = "Delete from BOOK where Title= '" + bookTitle + "'"; // direct query programming without SP
                SqlCommand cmd = new SqlCommand(query, ClassConnectionSQL.myCon);
                SqlDataReader myreader;
                try
                {

                    myreader = cmd.ExecuteReader();
                    MessageBox.Show("successfully data Deleted", "user information");
                    while (myreader.Read())
                    {
                    }

                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }
            }
            else
            {
                MessageBox.Show("enter ID which you want to delete", "User information");
            }
        }
    }
}

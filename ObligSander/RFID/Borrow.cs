using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFID
{
    internal class Borrow : ClassConnectionSQL
    {
        public void BorrowBoks(string fromDate, string toDate, string rfidId, int bookId)
        {
            try
            {
                ClassConnectionSQL classConnectionSQL = new ClassConnectionSQL(); // connect to database with classConnectoToDatabase
                classConnectionSQL.ConnectionToDatabase();
            }
            catch
            {

                MessageBox.Show("Error Writing Data to Database");
            }
            if (true)
            {
                // send arguments into Query in sql 
                cmd = new SqlCommand("BorrowBook", ClassConnectionSQL.myCon);
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.Add(new SqlParameter("@fromDate", fromDate));
                cmd.Parameters.Add(new SqlParameter("@toDate", toDate));
                cmd.Parameters.Add(new SqlParameter("@rfidId", rfidId));
                cmd.Parameters.Add(new SqlParameter("@bookId", bookId));


               
                    cmd.ExecuteNonQuery();
                MessageBox.Show("Book is now borrowed ", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
            }

        }
    }
}

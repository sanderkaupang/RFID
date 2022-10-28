using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFID
{
    internal class DeleteUser : ClassConnectionSQL
    {
        public void ClassDeleteUser(string RFID, string Username)
        {
            //if (!(RFID == string.Empty))
            //{
            //    ClassConnectionSQL classConnectionSQL = new ClassConnectionSQL();
            //    classConnectionSQL.ConnectionToDatabase();

            //    string query = "Delete from RFID where rfidId= '" + RFID + "' ";

            //    SqlCommand cmd = new SqlCommand(query, ClassConnectionSQL.myCon);
            //    SqlDataReader myreader;

            //    try
            //    {

            //        myreader = cmd.ExecuteReader();

            //        MessageBox.Show("successfully data Deleted", "user information");
            //        while (myreader.Read())
            //        {
            //        }

            //    }
            //    catch (Exception ec)
            //    {
            //        MessageBox.Show(ec.Message);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("enter ID which you want to delete", "User information");
            //}
            try
            {
                ClassConnectionSQL classConnectionSQL = new ClassConnectionSQL();
                classConnectionSQL.ConnectionToDatabase();
            }
            catch
            {
                MessageBox.Show("Error Writing Data to Database");
            }

            
                if (!(RFID == string.Empty))
                {
                    cmd = new SqlCommand("select * from RFID where rfidId='" + RFID + "'", ClassConnectionSQL.myCon);

                    SqlDataReader dr = cmd.ExecuteReader();


                        dr.Close();
                        cmd = new SqlCommand("DELETEUSER", ClassConnectionSQL.myCon);
                        cmd.CommandType = CommandType.StoredProcedure;


                        cmd.Parameters.Add(new SqlParameter("@rfidId", RFID));
                        cmd.Parameters.Add(new SqlParameter("@username", Username));



                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                }
                else
                {
                    MessageBox.Show("wrong value ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }
    }
}

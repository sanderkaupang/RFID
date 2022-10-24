using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFID
{
    internal class DeleteUser : ClassConnectionSQL
    {
        public void ClassDeleteUser(string phone)
        {
            if (!(phone == string.Empty))
            {
                ClassConnectionSQL classConnectionSQL = new ClassConnectionSQL();
                classConnectionSQL.ConnectionToDatabase();

                string query = "Delete from PERSON where phone= '" + phone + "'";
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

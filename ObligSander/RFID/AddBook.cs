using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFID
{
    public class AddBook : ClassConnectionSQL
    {
        public void RegestrateNewBook(string bookTitle, int pagecount, string bookType, string autherFirstname, string autherLastname)
        {
            try
            {
                ClassConnectionSQL classConnectionSQL = new ClassConnectionSQL();
                classConnectionSQL.ConnectionToDatabase();
            }
            catch 
            {

                MessageBox.Show("Error Writing Data to Database");
            }
            if (true)
            {
                
                cmd = new SqlCommand("CreateBook", ClassConnectionSQL.myCon);
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.Add(new SqlParameter("@Title", bookTitle));
                cmd.Parameters.Add(new SqlParameter("@pagecount", pagecount));
                cmd.Parameters.Add(new SqlParameter("@TypeName", bookType));
                cmd.Parameters.Add(new SqlParameter("@AutherFirstname", autherFirstname));
                cmd.Parameters.Add(new SqlParameter("@AutherLastname", autherLastname));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Book has been added ", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error");
            }

        }

    }
}

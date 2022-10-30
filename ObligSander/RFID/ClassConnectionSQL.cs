using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFID
{
    public class ClassConnectionSQL
    {
        public static SqlConnection myCon = null;
        public SqlCommand cmd;
        public SqlCommand cmd2;

        public void ConnectionToDatabase()
        {       //connect to database with the connection string under. 
            myCon = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog =RFID_Library2;" +
                " Integrated Security = True; TrustServerCertificate=True");
            myCon.Open();
        }
    }
}

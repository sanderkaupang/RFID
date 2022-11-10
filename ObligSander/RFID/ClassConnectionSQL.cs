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


        public void ConnectionToDatabase()
        {       //connect to database with the connection string under. 
            myCon = new SqlConnection("Data Source=localhost\\SQLEXPRESS02;Initial Catalog =RFID_LibraryOblig;" +
                " Integrated Security = True; TrustServerCertificate=True");
            myCon.Open();
        }
    }
}

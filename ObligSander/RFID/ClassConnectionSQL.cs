﻿using Microsoft.Data.SqlClient;
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
        {
            myCon = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog =RFID_Library;" +
                " Integrated Security = True; TrustServerCertificate=True");
            myCon.Open();
        }
    }
}

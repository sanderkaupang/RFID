using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFID
{


    internal class Login : ClassConnectionSQL
    {
        private MenuForm MenuForm;

        public void CheckLoginDetails(string Username, string Password)
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

            string sqlQuery = @"SELECT* FROM PERSON WHERE Username= '" + Username +
                                 "' AND Password = '" + Password + "'";
            SqlDataAdapter sda = new SqlDataAdapter(sqlQuery, ClassConnectionSQL.myCon);
            DataTable dt = new DataTable();
            sda.Fill(dt);


            if (dt.Rows.Count == 1)
            {
                MenuForm = new MenuForm();
                MenuForm.Show();

            }
            else
            {
                MessageBox.Show("Incorrect Username or password");
            }


        }
    }
}

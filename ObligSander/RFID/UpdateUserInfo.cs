using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFID
{
    internal class UpdateUserInfo : ClassConnectionSQL
    {
        public void UpdatePersonlia(string fName, string lName, int Phone, string Email, string DOB, string Username, string Password, string ConfirmPassword)
        {
            try
            {
                if (true)
                {
                    ClassConnectionSQL classConnectionSQL = new ClassConnectionSQL();
                    classConnectionSQL.ConnectionToDatabase();
                    cmd = new SqlCommand("UpdateUserPersonlia", ClassConnectionSQL.myCon);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@fName", fName));
                    cmd.Parameters.Add(new SqlParameter("@lName", lName));
                    cmd.Parameters.Add(new SqlParameter("@phone", Phone));
                    cmd.Parameters.Add(new SqlParameter("@email", Email));
                    cmd.Parameters.Add(new SqlParameter("@dOB", DOB));
                    cmd.Parameters.Add(new SqlParameter("@Username", Username));
                    cmd.Parameters.Add(new SqlParameter("@Password", Password));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Personlia is Updated");
                }
                else
                {
                    MessageBox.Show("Value Error");
                }
               
            }
            catch
            {
                MessageBox.Show("Error Writing Data to Database");
            }

        }
    }
}

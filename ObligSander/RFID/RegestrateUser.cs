using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFID
{
    internal class RegestrateUser : ClassConnectionSQL
    {
        public void RegestratenewUser2(string fName, string lName, int Phone, string Email, string DOB, string Username, string Password, string ConfirmPassword)
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

            if (Password != string.Empty || ConfirmPassword != string.Empty || Username != string.Empty)
            {
                if (Password == ConfirmPassword)
                {
                    cmd = new SqlCommand("select * from Person where Username='" + Username + "'", ClassConnectionSQL.myCon);

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();
                        cmd = new SqlCommand("RegistrateUser", ClassConnectionSQL.myCon);
                        cmd.CommandType = CommandType.StoredProcedure;


                        cmd.Parameters.Add(new SqlParameter("@fName", fName));
                        cmd.Parameters.Add(new SqlParameter("@lName", lName));
                        cmd.Parameters.Add(new SqlParameter("@phone", Phone));
                        cmd.Parameters.Add(new SqlParameter("@email", Email));
                        cmd.Parameters.Add(new SqlParameter("@dOB", DOB));
                        cmd.Parameters.Add(new SqlParameter("@Username", Username));
                        cmd.Parameters.Add(new SqlParameter("@Password", Password));
                        

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {
                    MessageBox.Show("Please enter both password same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

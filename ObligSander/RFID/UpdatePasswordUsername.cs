using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFID
{
    internal class UpdatePasswordUsername : ClassConnectionSQL
    {

        public void UpdateUsernamePAssword(int Phone, string Username, string Password, string ConfirmPassword, string name)
        {
            try
            {
                ClassConnectionSQL classConnectionSQL = new ClassConnectionSQL(); // con to database
                classConnectionSQL.ConnectionToDatabase();
            }
            catch
            {
                MessageBox.Show("Error Writing Data to Database");
            }


            if (Password != string.Empty || ConfirmPassword != string.Empty || Username != string.Empty)
            {
                if (Username == name && Password == ConfirmPassword) // if statment to only change password NOT username
                {
                    {   // Select password from person in sql 
                        cmd = new SqlCommand("select * from Person where Password='" + Password + "'", ClassConnectionSQL.myCon);

                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {   // check if password is confirm correck
                            dr.Close();
                            MessageBox.Show("wrong password confirmation ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            dr.Close();
                            cmd = new SqlCommand("UpdatePasswordOnly", ClassConnectionSQL.myCon); //  SP for Updating Password Only
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add(new SqlParameter("@phone", Phone));
                            cmd.Parameters.Add(new SqlParameter("@Password", Password));


                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Your Account is Updated", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                }
                else if (Password == ConfirmPassword) // updating username and password. 
                {
                    cmd = new SqlCommand("select * from Person where Username='" + Username + "'", ClassConnectionSQL.myCon);

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        dr.Close(); // check if username exist
                        MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();
                        cmd = new SqlCommand("UpdateUsernamePAssword", ClassConnectionSQL.myCon); // update username and password SP in sql
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add(new SqlParameter("@phone", Phone));
                        cmd.Parameters.Add(new SqlParameter("@Username", Username));
                        cmd.Parameters.Add(new SqlParameter("@Password", Password));


                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your Account is Updated", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                
                else
                {
                    MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

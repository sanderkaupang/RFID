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
using System.IO;
using System.Data.SqlClient;
using System.Configuration;
using System.Security.Cryptography;


namespace RFID
{
    public partial class Registrate : Form
    {


        public Registrate()
        {
            InitializeComponent(); 

        }

        //




        //

        private void RegistrateNewUser()
        {

                string fName = textBoxFname.Text;
                string lName = textBoxLname.Text;
                int Phone = Convert.ToInt32(textBoxPhone.Text);
                string Email = textBoxEmail.Text;
                string DOB = textBoxDoB.Text;
                string Username = textBoxUsername.Text;
                string Password = textBoxPassword.Text;
                string ConfirmPassword = textBoxConfirmPassword.Text;
                string RfidTag = textBoxRfidTag.Text; 

            RegestrateUser regestrateUser = new RegestrateUser();
            regestrateUser.RegestratenewUser2(fName, lName, Phone, Email, DOB, Username, Password, ConfirmPassword,RfidTag);
        }


        private void btnRegistrate_Click(object sender, EventArgs e)
        {
            //


            //

            RegistrateNewUser();

            var m = new Form1();     // Choose form is will open after registration
            m.Show();
            this.Hide();
    
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var m = new Form1();     // Choose form is will open after registration
            m.Show();
            this.Hide();

        }
    }
}

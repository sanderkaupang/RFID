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
    public partial class Registrate : Form
    {


        public Registrate()
        {
            InitializeComponent(); 

        }

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

            RegestrateUser regestrateUser = new RegestrateUser();
            regestrateUser.RegestratenewUser2(fName, lName, Phone, Email, DOB, Username, Password, ConfirmPassword);
        }


        private void btnRegistrate_Click(object sender, EventArgs e)
        {


            RegistrateNewUser();

            var m = new Form1();     // Choose form is will open after registration
            m.Show();
            this.Hide();

        }


    }
}

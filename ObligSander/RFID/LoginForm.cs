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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RFID
{
    public partial class LoginForm : Form
    {
        private Form MenuForm;
        private Form Registrate;
        public LoginForm()
        {
            InitializeComponent();
        }


        public static string Username;
        // method to display username from loginscreen in other forms
        public static string recby
        {
            get { return Username; }
            set { Username = value; }
        }

        // login method makes object of login class
        private void LoginUser()
        {
            recby = txtBoxTag.Text;
            string UserName = txtBoxTag.Text;
            string Password = txtBoxPin.Text;


            Login login = new Login();
            login.CheckLoginDetails(UserName,Password);
        }


        private void btnLogIn_Click(object sender, EventArgs e)
        {
            LoginUser();
            this.Hide();


        }

        // shows registratin form
        private void btnRegistrate_Click(object sender, EventArgs e)
        {
            var m = new Registrate();
            m.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void txtBoxTag_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
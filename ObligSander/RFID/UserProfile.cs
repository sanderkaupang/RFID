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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace RFID
{
    public partial class UserProfile : Form
    {
        public UserProfile()
        {
            InitializeComponent();
        }


        public void DelUser()
        {
            string RFID = textBoxDeleteAccount.Text;
            string Username = textBoxUsername.Text;
            DeleteUser deleteUser = new DeleteUser();
            deleteUser.ClassDeleteUser(RFID, Username);
        }



        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            var m = new UpdatePersonlia();     // goes into UpdatePersonlia form
            m.Show();
            this.Hide();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            DelUser();

            var m = new LoginForm();     // when account is deleted. goes back to login page 
            m.Show();
            this.Hide();
        }

        private void btnUpdateUsernamePassword_Click(object sender, EventArgs e)
        {
           
            
            var m = new UpdateUsernamePassword();     // goes into update username and password form
            m.Show();
            this.Hide();
        }

        private void buttonBackToMenu_Click(object sender, EventArgs e)
        {
            var m = new MenuForm();     // Goes back to menuForm
            m.Show();
            this.Hide();
        }


        private void pbProfilePic_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            textBoxUsername.Text = LoginForm.recby;
        }
    }
}


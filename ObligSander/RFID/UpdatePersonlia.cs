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
    public partial class UpdatePersonlia : Form
    {
        public UpdatePersonlia()
        {
            InitializeComponent();
        }


        private void UpdateUserPersonlia()
        {

            string fName = textBoxFname.Text;
            string lName = textBoxLname.Text;
            int Phone = Convert.ToInt32(textBoxPhone.Text);
            string Email = textBoxEmail.Text;
            string DOB = textBoxDoB.Text;
            string Username = textBoxUsername.Text;
            string Password = textBoxPassword.Text;
            string ConfirmPassword = textBoxConfirmPassword.Text;

            UpdateUserInfo updateUserInfo = new UpdateUserInfo();
            updateUserInfo.UpdatePersonlia(fName, lName, Phone, Email, DOB, Username, Password, ConfirmPassword);
        }

        private void btnUpdatePersonlia_Click(object sender, EventArgs e)
        {
            UpdateUserPersonlia();

            var m = new UserProfile();     // Choose form is will open after registration
            m.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var m = new UserProfile();    
            m.Show();
            this.Hide();
        }
    }
}

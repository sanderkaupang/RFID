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
    public partial class UpdateUsernamePassword : Form
    {
        public UpdateUsernamePassword()
        {
            InitializeComponent();
        }

        private void UpdateUsePassword()
        {


            int Phone = Convert.ToInt32(textBoxPhone.Text);
            string Username = textBoxUsername.Text;
            string Password = textBoxPassword.Text;
            string ConfirmPassword = textBoxConfirmPassword.Text;

            UpdatePasswordUsername updatePasswordUsername = new UpdatePasswordUsername();
            updatePasswordUsername.UpdateUsernamePAssword(Phone, Username, Password, ConfirmPassword);
        }

        private void UpdateUsernamePassword_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdateUsernmanePassword_Click(object sender, EventArgs e)
        {
            UpdateUsePassword();

        }
    }
}

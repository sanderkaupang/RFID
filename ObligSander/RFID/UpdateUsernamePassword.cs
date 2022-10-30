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
        public void UpdateUsernamePassword_Load(object sender, EventArgs e)
        {
            textBoxname.Text = LoginForm.recby;
        }

        private void UpdateUsePassword()
        {
            //Method for updating User Password and not username

            int Phone = Convert.ToInt32(textBoxPhone.Text);
            string Username = textBoxUsername.Text;
            string Password = textBoxPassword.Text;
            string ConfirmPassword = textBoxConfirmPassword.Text;
            string name = textBoxname.Text;

            UpdatePasswordUsername updatePasswordUsername = new UpdatePasswordUsername();
            updatePasswordUsername.UpdateUsernamePAssword(Phone, Username, Password, ConfirmPassword, name);
        }

        private void btnUpdateUsernmanePassword_Click(object sender, EventArgs e)
        {
            UpdateUsePassword();
            var m = new LoginForm();     // when userinformation is updated. goes back to loin screen.
            m.Show();
            this.Hide();


        }

        private void btnBackToProfile_Click(object sender, EventArgs e)
        {
            var m = new UserProfile();     // goes back to userprofile
            m.Show();
            this.Hide();
        }

    }
}
